using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Domain
{
    public class CinemaMovie
    {
        public int CinemaMovieId { get; set; }
        public int MovieTheaterId { get; set; }        
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

    }
}
