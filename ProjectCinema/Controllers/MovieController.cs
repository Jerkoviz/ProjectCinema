using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectCinema.App.Areas;
using ProjectCinema.App.Domain;
using ProjectCinema.App.Services;
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
        private readonly IRepertoireManager repertoireManager;

        public MovieController(IBaseManager<Movie> manager, IMapper mapper, IRepertoireManager repertoireManager) 
        {
            this.manager = manager;
            this.mapper = mapper;
            this.repertoireManager = repertoireManager;
        }

        // GET: MovieController
        public IActionResult Index()
        {
            return View();
        }

        // GET: MovieController/Details/5

        [HttpPost]
        public ActionResult Search(string searchTerm)
        {
            searchTerm = string.IsNullOrWhiteSpace(searchTerm) ? string.Empty : searchTerm;

            var cinemaModel = repertoireManager.GetAllRepertoire();           
            var model = new SearchMovieViewModel
            {
                CinemaRepertoires = mapper.Map<List<CinemaRepertoireViewModel>>(cinemaModel) 
            };
            
            return RedirectToAction("Index", "Home", model);
        }

        [HttpGet]
        public IActionResult GetMovie(int id)
        {
            var movie = manager.GetById(id);
            var model = mapper.Map<MovieViewModel>(movie);

            return View("Index", model);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var movies = manager.GetAll();
            var model = new MovieViewModel { Movies = mapper.Map<List<MovieViewModel>>(movies) };

            return View("Update", model);
        }

        // POST: MovieController/Create/Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(MovieViewModel model)
        {
            if (ModelState.IsValid)
            {               
                var movie = mapper.Map<Movie>(model);
                manager.Create(movie);

                return RedirectToAction("GetAll");
            }

            return RedirectToAction("Home", "Index");
            
        }

        // GET: MovieController/Edit/5
        [HttpGet]
        public IActionResult Update(int id)
        {
            var movie= manager.GetById(id);
            var model = mapper.Map<MovieViewModel>(movie);

            return View("Update", model);
        }


        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                if(id > 0)
                {
                    manager.Delete(id);
                }
                return RedirectToAction(nameof(GetAll));
            }
            catch
            {
                return View("Error");
            }            
        }
    }
}
