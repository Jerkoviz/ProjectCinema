using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.Entities
{
    [Table("Movie")]
    public class Movie
    {
        public int MovieId { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public string MovieName { get; set; }
        public int MinutesOfPlay { get; set; }
        public string Genre { get; set; }
        public int YearOfMaking { get; set; }
        public string Director { get; set; }
        public string About { get; set; }
        public ICollection<CinemaMovie> CinemaMovies { get; set; }
        public ICollection<CurrentlyInCinema> CurrentlyInCinemas { get; set; }
    }
}
