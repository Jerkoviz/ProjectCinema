using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.Entities
{ 
    [Table("ScreeningTime")]
    public class ScreeningTime
    {
        public int ScreeningTimeId { get; set; }
        public DateTime? MovieTime { get; set; }
        
    }
}
