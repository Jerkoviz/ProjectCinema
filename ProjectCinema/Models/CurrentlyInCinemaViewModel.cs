using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    public class CurrentlyInCinemaViewModel
    {
        public int CurrentlyInCinemaId { get; set; }
        public int MovieId { get; set; }
        public int ScreeningTimeId { get; set; }
        public List<SelectListItem> Movies { get; set; }
        public List<SelectListItem> ScreeningTimes { get; set; }
        public SearchMovieViewModel SearchMovieViewModel { get; set; }

    }
}
