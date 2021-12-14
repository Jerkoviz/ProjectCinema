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
        private readonly IBaseCinemaCRUD<Domain.Ticket> ticketData;

        public TicketManager(IBaseCinemaCRUD<Domain.Ticket> ticketData)
        {
            this.ticketData = ticketData;
        }
        public bool Create(Domain.Ticket newInput)
        {
            return ticketData.Create(newInput);
        }

        public bool Delete(int id)
        {
            return ticketData.Delete(id);
        }

        public List<Domain.Ticket> GetAll()
        {
            return ticketData.GetAll();
        }

        public Domain.Ticket GetById(int id)
        {
            return ticketData.GetById(id);
        }

        public List<Domain.Ticket> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(Domain.Ticket update)
        {
            return ticketData.Update(update);
        }
    }
}
