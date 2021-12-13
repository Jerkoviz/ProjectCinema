using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    public class HeaderViewModel
    {
        public List<SelectListItem> Movies { get; set; }
        public List<SelectListItem> Dates { get; set; }
        public MovieViewModel Movie { get; set; }
        public ImageViewModel Image { get; set; }     
                
    }
}
