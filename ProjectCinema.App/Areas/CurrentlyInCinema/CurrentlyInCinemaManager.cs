using ProjectCinema.App.Domain;
using ProjectCinema.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Areas.CurrentlyInCinema
{
    public class CurrentlyInCinemaManager : IBaseManager<Domain.CurrentlyInCinema>, IRepertoireManager
    {
        private readonly IBaseCinemaCRUD<Domain.CurrentlyInCinema> currentlyInCinemaData;
        private readonly IRepertoire repertoireData;

        public CurrentlyInCinemaManager(IBaseCinemaCRUD<Domain.CurrentlyInCinema> currentlyInCinemaData, IRepertoire repertoireData)
        {
            this.currentlyInCinemaData = currentlyInCinemaData;
            this.repertoireData = repertoireData;
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

        public IEnumerable<CinemaRepertoire> GetAllRepertoire()
        {
            return repertoireData.GetAllRepertoire();
        }

        public Domain.CurrentlyInCinema GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.CurrentlyInCinema> GetBySearch(string searchTerm)
        {
            return currentlyInCinemaData.GetBySearch(searchTerm);
        }

        public IEnumerable<Banner> GetLastFive()
        {
            return repertoireData.GetLastFive();
        }     

        public bool Update(Domain.CurrentlyInCinema update)
        {
            throw new NotImplementedException();
        }

       
    }
}
