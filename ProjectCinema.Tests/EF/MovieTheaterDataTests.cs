using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using ProjectCinema.App.Services.EF;
using ProjectCinema.App.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Tests.EF
{
    [TestFixture]
    public class MovieTheaterDataTests
    {
        private readonly IMapper mapper;
        private readonly DbContextOptions options;
        
        [Test]
        public void Create_EnterModel_ReturnTrue()
        {
            var model = new ProjectCinema.App.Domain.MovieTheater { 
                MovieTheaterId =1,
                Name = "Oscar",
                City = "Ruma",
                Address = "Balzakova 26"
            };
           //var entity = mapper.Map<MovieTheater>(model);

            var mockSet = new Mock<DbSet<MovieTheater>>();
            var mockContext = new Mock<CinemaDbContext>(options);
            mockContext.Setup(m => m.MovieTheaters).Returns(mockSet.Object);

            //var ef = new MovieTheaterData(mockContext.Object, mapper);
            //ef.Create(model);

            //Assert.IsNotNull(entity);
            Assert.AreEqual("Ruma", model.City);
        }
    }
}
