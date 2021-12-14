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
            ViewBag.Title = "Screening Time";
                
            return View();
        }

        public IActionResult GetAll()
        {
            var screeningTime = manager.GetAll();
            var model = new ScreeningTimeViewModel { ScreeningTime = mapper.Map<List<ScreeningTimeViewModel>>(screeningTime) };

            return View("Update", model);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var time = manager.GetById(id);
            var model = mapper.Map<ScreeningTimeViewModel>(time);

            return View("Update", model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(ScreeningTimeViewModel model)
        {
            var time = mapper.Map<ScreeningTime>(model);

            manager.Create(time);

            return RedirectToAction("GetAll");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            manager.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
