using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Domain
{
    public class CinemaRepertoire
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime? DateTime { get; set; }
        public string ImageName { get; set; }
    }
}
