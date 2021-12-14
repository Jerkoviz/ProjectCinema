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

        [HttpGet]
        public IActionResult GetAll()
        {
            var tickets = manager.GetAll();
            var model = new TicketViewModel { Tickets = mapper.Map<List<TicketViewModel>>(tickets) };

            return View("Update", model);
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var ticket = manager.GetById(id);
            var model = mapper.Map<TicketViewModel>(ticket);

            return View("Update", model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(TicketViewModel model)
        {
            if(ModelState.IsValid)
            {
                var ticket = mapper.Map<Ticket>(model);
                manager.Create(ticket);

                return RedirectToAction(nameof(GetAll));
            }

            return RedirectToAction("Home", "Index");
        }

        [HttpPost]

        public IActionResult Delete(int id)
        {
            manager.Delete(id);

            return RedirectToAction(nameof(GetAll));
        }
    }
}
