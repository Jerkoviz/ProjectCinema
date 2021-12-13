using ProjectCinema.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services
{
    public interface IRepertoire
    {
        IEnumerable<CinemaRepertoire> GetAllRepertoire();
        IEnumerable<Banner> GetLastFive();
    }
}
