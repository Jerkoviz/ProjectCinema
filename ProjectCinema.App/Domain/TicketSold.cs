
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Domain
{
    public class TicketSold
    {
       
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int MovieTheaterId { get; set; }        
    }
}
