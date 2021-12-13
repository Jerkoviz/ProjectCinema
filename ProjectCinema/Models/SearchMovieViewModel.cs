using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ProjectCinema.Models
{
    public class SearchMovieViewModel
    {
        public List<SearchResultViewModel> Results { get; set; }
        public List<CinemaRepertoireViewModel> CinemaRepertoires { get; set; }
        //public List<MovieViewModel> Movies { get; set; }
        //public List<ScreeningTimeViewModel> ScreeningTimes { get; set; }
        //public string MovieName { get; set; }
        //public DateTime DateTime { get; set; }

    }
}
