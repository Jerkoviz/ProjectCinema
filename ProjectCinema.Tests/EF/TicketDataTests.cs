using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using ProjectCinema.App.Domain;
using ProjectCinema.App.Services.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Tests.EF
{
    [TestFixture]
    public class TicketDataTests
    {
        private static IMapper mapper;
        private static CinemaDbContext context;
        private static TicketData ticketData;
        //private static readonly object[] Tickets = {
        //    new Ticket { TicketId = 1, Ammount = 150, Price = 200 },
        //    new Ticket { TicketId = 2, Ammount = 123, Price = 1234 },
        //    new Ticket { TicketId = 3, Ammount = 1234, Price = 200 },
        //    new Ticket { TicketId = 4, Ammount = 151230, Price = 20120 },
        //    new Ticket { TicketId = 5, Ammount = 1530, Price = 20120 }
        //};
        Ticket Ticket = new Ticket
        {
            TicketId = 4,
            Price = 120,
            Ammount = 120
        };

        [SetUp]
        public void Setup()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ticket, App.Services.Entities.Ticket>());
            mapper = new Mapper(config);
            var options = new DbContextOptionsBuilder<CinemaDbContext>()
                .UseInMemoryDatabase(databaseName: "Cinema")
                .Options;
            context = new CinemaDbContext(options);

            ticketData = new TicketData(mapper, context);
        }

        [Test]
        //[TestCaseSource("Tickets")]       
        public void Create_EnterModel_ReturnTrue()
        {  
            //Act
            var movie = ticketData.Create(Ticket);

            //Assert
            Assert.IsTrue(movie);
        }

        [Test]
        
        public void Delete_EnterId_ReturnTrue()
        {
            
            var movie = ticketData.Delete(Ticket.TicketId);

            Assert.IsTrue(movie);
            
        }
    }
}
