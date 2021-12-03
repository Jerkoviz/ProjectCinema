using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.Entities
{
    [Table("Ticket")]
    public class Ticket
    {
        public int TicketId { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        //public string SeatNumber { get; set; }
        public int Ammount { get; set; }

        public TicketSold TicketSold { get; set; }
    }
}
