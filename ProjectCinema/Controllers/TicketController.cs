using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectCinema.App.Areas;
using ProjectCinema.App.Domain;
using ProjectCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Controllers
{
    public class TicketController : Controller
    {
        private readonly IMapper mapper;
        private readonly IBaseManager<Ticket> manager;

        public TicketController(IMapper mapper, IBaseManager<Ticket> manager)
        {
            this.mapper = mapper;
            this.manager = manager;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Ticket";
            return View();
        }

        [HttpPost]
        public IActionResult Create(TicketViewModel ticket)
        {
            var model = mapper.Map<Ticket>(ticket);
            manager.Create(model);

            return RedirectToAction("Index", "Home");
        }
    }
}
