using ProjectCinema.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Areas.CurrentlyInCinema
{
    public class CurrentlyInCinemaManager : IBaseManager<Domain.CurrentlyInCinema>
    {
        private readonly IBaseCinemaCRUD<Domain.CurrentlyInCinema> currentlyInCinemaData;

        public CurrentlyInCinemaManager(IBaseCinemaCRUD<Domain.CurrentlyInCinema> currentlyInCinemaData)
        {
            this.currentlyInCinemaData = currentlyInCinemaData;
        }
        public bool Create(Domain.CurrentlyInCinema newInput)
        {
            return currentlyInCinemaData.Create(newInput);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.CurrentlyInCinema> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.CurrentlyInCinema GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.CurrentlyInCinema> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(Domain.CurrentlyInCinema update)
        {
            throw new NotImplementedException();
        }
    }
}
