using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectCinema.App.Areas;
using ProjectCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Views.Shared.Components.CurrentlyInCinema
{
    public class BannerViewComponent : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IRepertoireManager repertoirManager;

        public BannerViewComponent(IMapper mapper, IRepertoireManager repertoirManager)
        {
            this.mapper = mapper;
            this.repertoirManager = repertoirManager;
        }
        public IViewComponentResult Invoke()
        {
            var banner = repertoirManager.GetLastFive();
             
            var model = mapper.Map<List<BannerViewModel>>(banner);

            return View(model);
        }
    }
}
