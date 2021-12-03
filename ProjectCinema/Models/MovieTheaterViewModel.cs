using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    public class MovieTheaterViewModel
    {
        public int MovieTheaterId { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public SearchTheater SearchTheater { get; set; }

    }

    public class SearchTheater
    {
        public List<SearchResultViewModel> Results { get; set; }
    }

    
}
