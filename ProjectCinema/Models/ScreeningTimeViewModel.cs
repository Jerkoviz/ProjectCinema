using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    public class ScreeningTimeViewModel
    {
        public int ScreeningTimeId { get; set; }

        //[Range(typeof(DateTime), "1/12/2021", "1/1/2030")]
        [BindProperty, DisplayFormat(DataFormatString = "{0:dd.MM.yyyyTHH:mm}", ApplyFormatInEditMode = true) ]
        [DataType(DataType.DateTime)]
        [DisplayName("Movie time")]
        public DateTime? MovieTime { get; set; }
        public List<ScreeningTimeViewModel> ScreeningTime { get; set; }
    }
}
