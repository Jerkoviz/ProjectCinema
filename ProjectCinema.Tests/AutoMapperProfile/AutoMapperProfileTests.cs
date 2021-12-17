using AutoMapper;
using NUnit.Framework;
using ProjectCinema.App.Services.Entities;
using ProjectCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Tests.AutoMapperProfile
{
    [TestFixture]
    public class AutoMapperProfileTests
    {
        //private static readonly object[] MappingProfiles =
        //{
        //    new object[] {new Ticket(), new App.Domain.Ticket()},
        //};
               
        [Test]
       
        public void CreateMap_Ticket_ReturnTrue()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ticket, App.Domain.Ticket>());
            
            config.AssertConfigurationIsValid();
        }

        [Test]
        public void CreateMap_Image_ReturnTrue()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Image, App.Domain.Image>());

            config.AssertConfigurationIsValid();
        }

        [Test]
        public void CreateMap_ScreeningTime_ReturnTrue()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ScreeningTime, App.Domain.ScreeningTime>());

            config.AssertConfigurationIsValid();
        }

        [Test]
        public void CreateMap_CurrentlyInCinema_ReturnTrue()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CurrentlyInCinema, App.Domain.CurrentlyInCinema>());

            config.AssertConfigurationIsValid();
        }

        [Test]
        public void CreateMap_Banner_ReturnTrue()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BannerViewModel, App.Domain.Banner>());

            config.AssertConfigurationIsValid();
        }

        [Test]
        public void CreateMap_CinemaRepertoire_ReturnTrue()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CinemaRepertoireViewModel, App.Domain.CinemaRepertoire>());

            config.AssertConfigurationIsValid();
        }

        [Test]
        public void CreateMap_Movie_ReturnTrue()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Movie, App.Domain.Movie>());

            config.AssertConfigurationIsValid();
        }
    }
}
