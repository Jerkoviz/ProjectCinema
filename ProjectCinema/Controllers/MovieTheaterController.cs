using AutoMapper;
using ProjectCinema.App.Areas.MovieTheater;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCinema.App.Areas;
using ProjectCinema.App.Domain;

namespace ProjectCinema.Controllers
{

    public class MovieTheaterController : Controller
    {
        private readonly IMapper mapper;
        private readonly IBaseManager<MovieTheater> movieTheaterManager;

        public MovieTheaterController(IMapper mapper, IBaseManager<MovieTheater> movieTheaterManager)
        {
            this.mapper = mapper;
            this.movieTheaterManager = movieTheaterManager;
        }
        // GET: CityController
        public ActionResult Index()
        {
            return View("CityCreate");
        }

        // GET: CityController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CityController/Create
        public ActionResult GetAll()
        {            
            var listOfAllMovieTheaters = movieTheaterManager.GetAll();
            var model = new SearchTheater 
            { 
                Results = mapper.Map<List<SearchResultViewModel>>(listOfAllMovieTheaters) 
            };

            return View("~/Views/MovieTheaters/MovieTheaterList.cshtml", model);
        }

        // POST: CityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieTheaterViewModel model)
        {
            try
            {
                var movieTheater = mapper.Map<ProjectCinema.App.Domain.MovieTheater>(model);
                var manager = movieTheaterManager.Create(movieTheater);

                return RedirectToAction("GetAll");
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: CityController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CityController/Edit/5
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

        // GET: CityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CityController/Delete/5
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
