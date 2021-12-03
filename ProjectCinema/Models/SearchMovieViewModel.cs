using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ProjectCinema.Models
{
    public class SearchMovieViewModel
    {
        public List<SearchResultViewModel> Results { get; set; }
       
    }
}
