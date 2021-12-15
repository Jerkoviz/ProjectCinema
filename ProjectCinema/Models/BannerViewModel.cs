using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    public class BannerViewModel
    {
        public int MovieId { get; set; }
        public string About { get; set; }
        public string ImageName { get; set; }
        public string MovieName { get; set; }
    }
}
