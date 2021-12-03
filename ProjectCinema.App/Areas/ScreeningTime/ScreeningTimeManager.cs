using ProjectCinema.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Areas.ScreeningTime
{
    public class ScreeningTimeManager : IBaseManager<Domain.ScreeningTime>
    {
        private readonly IBaseCinemaCRUD<Domain.ScreeningTime> screeningTimeData;

        public ScreeningTimeManager(IBaseCinemaCRUD<Domain.ScreeningTime> screeningTimeData)
        {
            this.screeningTimeData = screeningTimeData;
        }
        public bool Create(Domain.ScreeningTime newInput)
        {
            return screeningTimeData.Create(newInput);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.ScreeningTime> GetAll()
        {
            return screeningTimeData.GetAll();
        }

        public Domain.ScreeningTime GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.ScreeningTime> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(Domain.ScreeningTime update)
        {
            throw new NotImplementedException();
        }
    }
}
