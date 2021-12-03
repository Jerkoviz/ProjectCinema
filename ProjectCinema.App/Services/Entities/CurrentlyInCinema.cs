using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.Entities
{
    [Table("CurrentlyInCinema")]
    public class CurrentlyInCinema
    {
        public int CurrentlyInCinemaId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ScreeningTimeId { get; set; }
        public ScreeningTime ScreeningTime { get; set; }
    }
}
