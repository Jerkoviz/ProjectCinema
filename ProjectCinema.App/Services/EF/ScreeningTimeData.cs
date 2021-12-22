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

    public class ScreeningTimeData : IBaseCinemaCRUD<ScreeningTime>, IScreeningTime
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
            var oldEntity = context.ScreeningTimes.AsNoTracking()
                .Where(s => s.ScreeningTimeId == newInput.ScreeningTimeId)
                .FirstOrDefault();

            if (oldEntity != null)
            {
                context.Attach(screeningTime);
                context.Entry(screeningTime).State = EntityState.Modified;
                context.SaveChanges();

                return true;
            }
            else
            {
                context.Add(screeningTime);
                context.SaveChanges();

                return true;
            }            
        }

        public bool Delete(int id)
        {
            var time = context.ScreeningTimes.Where(s => s.ScreeningTimeId == id);

            context.Attach(time);
            context.Entry(time).State = EntityState.Deleted;
            context.SaveChanges();

            return true;
        }

        public List<ScreeningTime> GetAll()
        {
           return mapper.Map<List<ScreeningTime>>(context.ScreeningTimes.AsNoTracking());
        }

        public ScreeningTime GetById(int id)
        {
            return mapper.Map<ScreeningTime>(context.ScreeningTimes.Where(s => s.ScreeningTimeId == id).FirstOrDefault());
        }

        public List<ScreeningTime> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScreeningTime> GetCurrentScreeningTimes()
        {

            var screeningTimes = mapper.Map<List<ScreeningTime>>(context.ScreeningTimes.AsNoTracking());
            var currently = context.CurrentlyInCinemas.AsNoTracking();
            var movies = context.Movies.AsNoTracking();

            IEnumerable<CurrentlyInCinema> join = (from cur in currently
                                                   join scr in screeningTimes on cur.ScreeningTimeId equals scr.ScreeningTimeId
                                                   join mov in movies on cur.MovieId equals mov.MovieId
                                                   select new CurrentlyInCinema
                                                   {
                                                       MovieId = cur.MovieId,
                                                       ScreeningTimeId = cur.ScreeningTimeId,
                                                       MovieTime = scr.MovieTime,
                                                       MovieName = mov.MovieName
                                                   }).ToList();

            return (IEnumerable<ScreeningTime>)join;
        }

        public bool Update(ScreeningTime update)
        {
            throw new NotImplementedException();
        }
    }
}
