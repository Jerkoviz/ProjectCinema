using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    public class TicketViewModel
    {
        public int TicketId { get; set; }
        public int Price { get; set; }
        public int Ammount { get; set; }

        public bool IsAvaliable { get; set; }
    }
}
