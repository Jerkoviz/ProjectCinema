using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.Entities
{
    [Table("CinemaRepertoire")]
    public class CinemaRepertoire
    {
        public int CinemaRepertoireId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public DateTime TimeOfProjection { get; set; }
    }
}
