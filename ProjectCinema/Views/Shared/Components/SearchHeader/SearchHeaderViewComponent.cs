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

namespace ProjectCinema.Views.Shared.Components.SearchHeader
{
    public class SearchHeaderViewComponent: ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IBaseManager<App.Domain.Movie> movieManager;
        private readonly IBaseManager<App.Domain.CurrentlyInCinema> datesManager;

        public SearchHeaderViewComponent(IMapper mapper, IBaseManager<App.Domain.Movie> movieManager, IBaseManager<App.Domain.CurrentlyInCinema> datesManager)
        {
            this.mapper = mapper;
            this.movieManager = movieManager;
            this.datesManager = datesManager;
        }
        public IViewComponentResult Invoke()
        {
            var movies = movieManager.GetAll();
            //var dates = datesManager.GetAll();

            var model = new HeaderViewModel();

            model.Movies = movies.Select(m => new SelectListItem { Value = m.MovieId.ToString(), Text = m.MovieName }).ToList();
            //model.Dates = dates.Select(d => new SelectListItem { Value = d.CurrentlyInCinemaId.ToString(), Text = d.MovieTime}).ToList();
            return View(model);
        }
    }
}
