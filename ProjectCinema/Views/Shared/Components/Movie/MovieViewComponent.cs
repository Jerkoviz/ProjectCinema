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
        private readonly IRepertoireManager repertoireManager;

        public MovieViewComponent(IMapper mapper, IBaseManager<App.Domain.Movie> movieManager, IRepertoireManager repertoireManager)
        {
            this.mapper = mapper;
            this.movieManager = movieManager;
            this.repertoireManager = repertoireManager;
        }
        public IViewComponentResult Invoke()
        {

            var cinemaModel = repertoireManager.GetAllRepertoire();            

            var model = new SearchMovieViewModel
            {
                CinemaRepertoires = mapper.Map<List<CinemaRepertoireViewModel>>(cinemaModel)
            };

            return View(model);

        }
    }
}
