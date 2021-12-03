using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Domain
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MinutesOfPlay { get; set; }
        public string Genre { get; set; }
        public string YearOfMaking { get; set; }
        public Image Image { get; set; }        
        public List<CinemaMovie> CinemaMovies { get; set; }
    }
}
