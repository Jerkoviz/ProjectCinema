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
        private readonly IBaseManager<ScreeningTime> baseManager;

        public ScreeningTimeController(IMapper mapper, IBaseManager<ScreeningTime> baseManager)
        {
            this.mapper = mapper;
            this.baseManager = baseManager;
        }
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public ActionResult Create(ScreeningTimeViewModel screeningTime)
        {
            var model = mapper.Map<ScreeningTime>(screeningTime);

            baseManager.Create(model);

            return RedirectToAction("Index");
        }
    }
}
