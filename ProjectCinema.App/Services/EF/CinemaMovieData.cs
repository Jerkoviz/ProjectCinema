using ProjectCinema.App.Domain;
using ProjectCinema.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.EF
{
    public class CinemaMovieData : IBaseCinemaCRUD<CinemaMovie>
    {
        public bool Create(CinemaMovie newInput)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CinemaMovie> GetAll()
        {
            throw new NotImplementedException();
        }

        public CinemaMovie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CinemaMovie> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(CinemaMovie update)
        {
            throw new NotImplementedException();
        }
    }
}
