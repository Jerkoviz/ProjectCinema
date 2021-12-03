using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectCinema.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.EF
{

    public class ScreeningTimeData : IBaseCinemaCRUD<ScreeningTime>
    {
        private readonly IMapper mapper;
        private readonly CinemaDbContext context;

        public ScreeningTimeData(IMapper mapper, CinemaDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public bool Create(ScreeningTime newInput)
        {
            var screeningTime = mapper.Map<Entities.ScreeningTime>(newInput);

            context.Add(screeningTime);
            context.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ScreeningTime> GetAll()
        {
           return mapper.Map<List<ScreeningTime>>(context.ScreeningTimes.AsNoTracking());
        }

        public ScreeningTime GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ScreeningTime> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(ScreeningTime update)
        {
            throw new NotImplementedException();
        }
    }
}
