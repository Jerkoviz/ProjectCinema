using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectCinema.App.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.EF
{
    public class MovieTheaterData :  IBaseCinemaCRUD<ProjectCinema.App.Domain.MovieTheater>
    {
        private readonly CinemaDbContext _context;
        private readonly IMapper _mapper;
        public MovieTheaterData(CinemaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool Create(Domain.MovieTheater movieTheater)
        {
            var movieTheaterEntity = _mapper.Map<MovieTheater>(movieTheater);

            if (movieTheaterEntity != null)
            {
                _context.MovieTheaters.Add(movieTheaterEntity);
                _context.SaveChanges();
                return true;
            }

            return false;
        }        

        public bool Delete(int theaterId)
        {
            var theater = _context.MovieTheaters.Where(m => m.MovieTheaterId == theaterId).FirstOrDefault();

            if (theater != null) 
            {
                _context.Entry(theater).State = EntityState.Deleted;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Domain.MovieTheater> GetAll()
        {
            var entityMovieTheaters = _context.MovieTheaters.AsNoTracking().ToList();
             return _mapper.Map<List<Domain.MovieTheater>>(entityMovieTheaters);           
          
        }

        public ProjectCinema.App.Domain.MovieTheater GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectCinema.App.Domain.MovieTheater> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }
               

        public bool Update(ProjectCinema.App.Domain.MovieTheater movieTheater)
        {
            throw new NotImplementedException();
        }

        
        }
    }

