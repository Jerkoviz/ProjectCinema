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
    public class CurrentlyInCinemaData : IBaseCinemaCRUD<CurrentlyInCinema>, IRepertoire
    {
        private readonly IMapper mapper;
        private readonly CinemaDbContext context;

        public CurrentlyInCinemaData(IMapper mapper, CinemaDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public bool Create(CurrentlyInCinema newInput)
        {
            var currentlyInCinema = mapper.Map<Entities.CurrentlyInCinema>(newInput);

            context.Add(currentlyInCinema);
            context.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CurrentlyInCinema> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CinemaRepertoire> GetAllRepertoire()
        {
                var movies = context.Movies.AsNoTracking();
                var screening = context.ScreeningTimes.AsNoTracking();
                var images = context.Images.AsNoTracking();
                var currently = mapper.Map<List<CurrentlyInCinema>>(
                    context.CurrentlyInCinemas
                    .AsNoTracking());

                IEnumerable<CinemaRepertoire> join = (from cur in currently
                                                      join mov in movies on cur.MovieId equals mov.MovieId
                                                      join scr in screening on cur.ScreeningTimeId equals scr.ScreeningTimeId
                                                      join img in images on mov.ImageId equals img.ImageId
                                                      select new CinemaRepertoire { MovieName = mov.MovieName, DateTime = scr.MovieTime, ImageName = img.ImageName, MovieId = mov.MovieId }).ToList();

                //var innerJoinMovie = currently.Join(movies,
                //    m => m.MovieId,
                //    c => c.MovieId,
                //    (m, c) =>
                //    new Movie
                //    {
                //        MovieName = c.MovieName

                //    })
                //    .Join(screening, c => c.MovieId, s => s.ScreeningTimeId, (s, c) => new ScreeningTime { MovieTime = DateTime.Now })
                //    .Select(s => new CinemaRepertoire { DateTime = s.MovieTime, MovieName = s.ScreeningTimeId.ToString() });

                //var innerJoinScreening = screening.Join(currently, s => s.ScreeningTimeId, c => c.ScreeningTimeId, (s, c) => new ScreeningTime { MovieTime = s.MovieTime });

                //var repertoire = new CinemaRepertoire { Movies = (List<Movie>)innerJoinMovie, ScreeningTimes = (List<ScreeningTime>)innerJoinScreening };

                return (List<CinemaRepertoire>)join;
            
        }

        public CurrentlyInCinema GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CurrentlyInCinema> GetBySearch(string searchTerm)
        {

            throw new NotImplementedException();
        }

        public IEnumerable<Banner> GetLastFive()
        {            
            var movie = context.Movies.AsNoTracking();
            movie = movie.Skip(Math.Max(0, movie.Count()-3));

            return movie.Select(b => new Banner { MovieName = b.MovieName, About = b.About, ImageName = b.Image.ImageName }).ToList();
            
        }

        public bool Update(CurrentlyInCinema update)
        {
            throw new NotImplementedException();
        }
        
       
    }
}
