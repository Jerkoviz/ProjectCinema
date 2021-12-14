using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var oldEntity = context.Tickets.AsNoTracking().Where(t => t.TicketId == newInput.TicketId).FirstOrDefault();

            if (oldEntity != null)
            {
                context.Attach(ticket);
                context.Entry(ticket).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            else
            {
                context.Add(ticket);
                context.SaveChanges();
                return true;
            }

            

            
        }

        public bool Delete(int id)
        {
            var ticket = context.Tickets.Where(t => t.TicketId == id).FirstOrDefault();

            if (ticket != null)
            {
                context.Attach(ticket);
                context.Entry(ticket).State = EntityState.Deleted;
                context.SaveChanges();

                return true;
            }
            return false;
        }

        public List<Ticket> GetAll()
        {
            return mapper.Map<List<Ticket>>(context.Tickets.AsNoTracking());

        }

        public Ticket GetById(int id)
        {
            return mapper.Map<Ticket>(context.Tickets.Where(t => t.TicketId == id).FirstOrDefault());
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
