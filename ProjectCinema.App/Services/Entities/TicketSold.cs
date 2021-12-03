
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.Entities
{
    [Table("TicketSold")]
    public class TicketSold
    {
        [Key]
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int MovieTheaterId { get; set; }
        public MovieTheater MovieTheater { get; set; }
    }
}
