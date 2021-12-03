using AutoMapper;
using NUnit.Framework;
using ProjectCinema.App.Areas;
using ProjectCinema.App.Areas.MovieTheater;
using ProjectCinema.App.Domain;
using ProjectCinema.Controllers;
using ProjectCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Tests.Controllers
{
    [TestFixture]
    public class MovieTheaterControllerTests
    {
        private readonly IMapper mapper;
        private readonly IBaseManager<MovieTheater> manager;
        [Test]
        public void Create_EnterModel_ReturnValidValue()
        {
            var model = new MovieTheaterViewModel();
            var controller = new MovieTheaterController(mapper, manager);

            controller.Create(model);

            Assert.IsNotNull(model);
        }
    }
}


    



