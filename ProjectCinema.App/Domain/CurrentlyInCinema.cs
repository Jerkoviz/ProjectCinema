using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Domain
{
   public class CurrentlyInCinema
    {
        public int CurrentlyInCinemaId { get; set; }
        public int MovieId { get; set; }
        public int ScreeningTimeId { get; set; }        
    }
}
