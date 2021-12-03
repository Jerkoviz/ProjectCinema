using AutoMapper;
using ProjectCinema.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.EF
{
    public class TicketData : IBaseCinemaCRUD<Ticket>
    {
        private readonly IMapper mapper;
        private readonly CinemaDbContext context;

        public TicketData(IMapper mapper, CinemaDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public bool Create(Ticket newInput)
        {
            var ticket = mapper.Map<Entities.Ticket>(newInput);

            context.Add(ticket);
            context.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ticket GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ticket update)
        {
            throw new NotImplementedException();
        }
    }
}
