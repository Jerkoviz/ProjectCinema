using ProjectCinema.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    public class MovieViewModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int MinutesOfPlay { get; set; } 
        public string Genre { get; set; }
        public int YearOfMaking { get; set; }
        public Image Image { get; set; }
        public string Director { get; set; }
        public string About { get; set; }       
        public List<MovieViewModel> Movies { get; set; }
    }
}
