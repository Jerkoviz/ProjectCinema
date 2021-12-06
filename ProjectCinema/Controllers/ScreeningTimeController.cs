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
    public class ScreeningTimeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IBaseManager<ScreeningTime> manager;

        public ScreeningTimeController(IMapper mapper, IBaseManager<ScreeningTime> manager)
        {
            this.mapper = mapper;
            this.manager = manager;
        }
        public ActionResult Index()
        {
            var screeningTime = manager.GetAll();
            var model = new ScreeningTimeViewModel { ScreeningTime = mapper.Map<List<ScreeningTimeViewModel>>(screeningTime) };

            return View(model);
            
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public ActionResult Create(ScreeningTimeViewModel time)
        {
            var model = mapper.Map<ScreeningTime>(time);

            manager.Create(model);

            return RedirectToAction("Index");
        }
    }
}
