using ProjectCinema.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Areas.Movie
{
    public class MovieManager : IBaseManager<Domain.Movie>
    {
        private readonly IBaseCinemaCRUD<Domain.Movie> movieData;

        public MovieManager(IBaseCinemaCRUD<Domain.Movie> movieData)
        {
            this.movieData = movieData;
        }
        public bool Create(Domain.Movie newInput)
        {
            return movieData.Create(newInput);
            
        }

        public bool Delete(int id)
        {
            return movieData.Delete(id);
        }

        public List<Domain.Movie> GetAll()
        {
            return movieData.GetAll();
        }

        public Domain.Movie GetById(int id)
        {
            return movieData.GetById(id);
        }

        public List<Domain.Movie> GetBySearch(string searchTerm)
        {
            return movieData.GetBySearch(searchTerm);
        }

        public bool Update(Domain.Movie update)
        {
            return movieData.Update(update);
        }
    }
}
