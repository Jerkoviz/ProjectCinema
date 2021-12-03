using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectCinema.App.Areas;
using ProjectCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Views.Shared.Components.Movie
{
    public class MovieViewComponent : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IBaseManager<App.Domain.Movie> movieManager;

        public MovieViewComponent(IMapper mapper, IBaseManager<App.Domain.Movie> movieManager)
        {
            this.mapper = mapper;
            this.movieManager = movieManager;
        }
        public IViewComponentResult Invoke()
        {

            var movies = movieManager.GetAll();
            var model = new SearchMovieViewModel { Results = mapper.Map<List<SearchResultViewModel>>(movies) };
            return View(model);

        }
    }
}
