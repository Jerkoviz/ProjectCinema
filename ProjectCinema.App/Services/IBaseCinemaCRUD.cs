using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services
{
    public interface IBaseCinemaCRUD<T>
    {
        bool Create(T newInput);
        bool Update(T update);
        bool Delete(int id);
        T GetById(int id);
        List<T> GetAll();
        List<T> GetBySearch(string searchTerm);
    }
}
