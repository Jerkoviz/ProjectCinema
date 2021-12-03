using ProjectCinema.App.Services.EF;
using ProjectCinema.App.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCinema.App.Services;

namespace ProjectCinema.App.Areas.MovieTheater
{
    public class MovieTheaterManager : IBaseManager<Domain.MovieTheater>
    {
        private readonly IBaseCinemaCRUD<Domain.MovieTheater> movieTheaterData;

        public MovieTheaterManager(IBaseCinemaCRUD<Domain.MovieTheater> movieTheaterData)
        {
            this.movieTheaterData = movieTheaterData;
        }

        public bool Create(Domain.MovieTheater newInput)
        {
            return movieTheaterData.Create(newInput);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.MovieTheater> GetAll()
        {
            return movieTheaterData.GetAll();
        }

        public Domain.MovieTheater GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.MovieTheater> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(Domain.MovieTheater update)
        {
            throw new NotImplementedException();
        }
    }
}
