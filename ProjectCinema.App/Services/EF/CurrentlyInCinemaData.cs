using AutoMapper;
using ProjectCinema.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.EF
{
    public class CurrentlyInCinemaData : IBaseCinemaCRUD<CurrentlyInCinema>
    {
        private readonly IMapper mapper;
        private readonly CinemaDbContext context;

        public CurrentlyInCinemaData(IMapper mapper, CinemaDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public bool Create(CurrentlyInCinema newInput)
        {
            var currentlyInCinema = mapper.Map<Entities.CurrentlyInCinema>(newInput);

            context.Add(currentlyInCinema);
            context.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CurrentlyInCinema> GetAll()
        {
            throw new NotImplementedException();
        }

        public CurrentlyInCinema GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CurrentlyInCinema> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(CurrentlyInCinema update)
        {
            throw new NotImplementedException();
        }
    }
}
