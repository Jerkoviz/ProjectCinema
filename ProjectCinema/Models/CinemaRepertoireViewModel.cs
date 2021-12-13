using ProjectCinema.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    public class CinemaRepertoireViewModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }

        public DateTime? DateTime { get; set; }
        public string ImageName { get; set; }
    }
}
