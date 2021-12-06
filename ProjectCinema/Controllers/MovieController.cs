using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectCinema.App.Areas;
using ProjectCinema.App.Domain;
using ProjectCinema.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Controllers
{
    public class MovieController : Controller
    {
        private readonly IBaseManager<Movie> manager;
        private readonly IMapper mapper;

        public MovieController(IBaseManager<App.Domain.Movie> manager, IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
        }

        // GET: MovieController
        public IActionResult Index()
        {
            var movies = manager.GetAll();
            var model = new MovieViewModel { Movies = mapper.Map<List<MovieViewModel>>(movies) };           

            return View(model);
        }

        // GET: MovieController/Details/5

        [HttpPost]
        public ActionResult Search(string searchTerm)
        {
            searchTerm = string.IsNullOrWhiteSpace(searchTerm) ? "" : searchTerm;

            var movieModel = manager.GetBySearch(searchTerm);
            var model = new SearchMovieViewModel { Results = mapper.Map<List<SearchResultViewModel>>(movieModel) };
            
            return RedirectToAction("Index", "Home", model);
        }

        // GET: MovieController/Create
        public IActionResult GetAll()
        {
            var movies = manager.GetAll();
            var model = new SearchMovieViewModel { Results = mapper.Map<List<SearchResultViewModel>>(movies) };

            return View(model);
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                string fileName = string.Empty;

                if (Path.GetFileName(model.Image.ImageFile.FileName) == null)
                {
                    fileName = "newMovie";
                }
                fileName = Path.GetFileName(model.Image.ImageFile.FileName);

                var movie = mapper.Map<Movie>(model);

                manager.Create(movie);

                return RedirectToAction("Index");
            }
           
             return View("Index");
            
        }

        // GET: MovieController/Edit/5
        public ActionResult Update(int id)
        {
            var getById= manager.GetById(id);

            return RedirectToAction("Index", "Home");
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
