using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    public class ImageViewModel
    {
        public string Title { get; set; }        
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
