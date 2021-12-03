
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.Entities
{
    [Table("CinemaMovie")]
    public class CinemaMovie
    {
        
        public int CinemaMovieId { get; set; }
        public int MovieTheaterId { get; set; }
        public MovieTheater MovieTheater { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public DateTime DateTime { get; set; }        

    }
}
