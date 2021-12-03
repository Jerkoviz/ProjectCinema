using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectCinema.App.Areas;
using ProjectCinema.App.Domain;
using ProjectCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Controllers
{
    public class CurrentlyInCinemaController : Controller
    {
        private readonly IMapper mapper;
        private readonly IBaseManager<CurrentlyInCinema> currentlyInCinemaManager;
        private readonly IBaseManager<Movie> movieManager;
        private readonly IBaseManager<ScreeningTime> screeningTimeManager;

        public CurrentlyInCinemaController(IMapper mapper, IBaseManager<CurrentlyInCinema> currentlyInCinemaManager, IBaseManager<Movie> movieManager, IBaseManager<ScreeningTime> screeningTimeManager)
        {
            this.mapper = mapper;
            this.currentlyInCinemaManager = currentlyInCinemaManager;
            this.movieManager = movieManager;
            this.screeningTimeManager = screeningTimeManager;
        }
        public IActionResult Index()
        {
            var model = new CurrentlyInCinemaViewModel();
            var movies = movieManager.GetAll();
            var screeningTime = screeningTimeManager.GetAll();

            model.Movies = movies.Select(m => new SelectListItem { Value = m.MovieId.ToString(), Text = m.MovieName}).ToList();
            model.ScreeningTimes = screeningTime.Select(s => new SelectListItem { Value = s.ScreeningTimeId.ToString(), Text = s.MovieTime.ToString() }).ToList();
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CurrentlyInCinemaViewModel currentlyInCinema)
        {
            var model = mapper.Map<CurrentlyInCinema>(currentlyInCinema);
            currentlyInCinemaManager.Create(model);

            return RedirectToAction("Index");
        }
    }
}
