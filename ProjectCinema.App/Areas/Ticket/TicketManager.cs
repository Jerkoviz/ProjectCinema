using ProjectCinema.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Areas.Ticket
{
    public class TicketManager : IBaseManager<Domain.Ticket>
    {
        private readonly IBaseCinemaCRUD<Domain.Ticket> ticket;

        public TicketManager(IBaseCinemaCRUD<Domain.Ticket> ticket)
        {
            this.ticket = ticket;
        }
        public bool Create(Domain.Ticket newInput)
        {
            return ticket.Create(newInput);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Ticket GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Ticket> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(Domain.Ticket update)
        {
            throw new NotImplementedException();
        }
    }
}
