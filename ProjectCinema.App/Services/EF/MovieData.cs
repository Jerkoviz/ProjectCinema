using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ProjectCinema.App.Services.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.EF
{
    public class MovieData : IBaseCinemaCRUD<Domain.Movie>
    {
        private readonly IMapper mapper;
        private readonly CinemaDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public MovieData(IMapper mapper, CinemaDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.mapper = mapper;
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        public bool Create(Domain.Movie newInput)
        {
            //Save image to folder Image
            string rootUrl = webHostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(newInput.Image.ImageFile.FileName);
            string extension = Path.GetExtension(newInput.Image.ImageFile.FileName);
            fileName = newInput.Image.ImageName = fileName + extension;
            string path = Path.Combine(rootUrl + "\\image", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                 newInput.Image.ImageFile.CopyToAsync(fileStream);
            }

            var newMovie = mapper.Map<Movie>(newInput);
            var oldEntity = context.Movies.AsNoTracking().Where(m => m.MovieId == newInput.MovieId).FirstOrDefault();

            if (oldEntity != null)
            {
                context.Attach(newMovie);
                context.Entry(newMovie).State = EntityState.Modified;
                context.SaveChanges();

                return true;
            }
            else
            {
                context.Add(newMovie);
                context.SaveChanges();

                return true;
            }
        }

        public bool Delete(int id)
        {
            var movie = context.Movies.Where(m => m.MovieId == id).FirstOrDefault();

            if (movie != null)
            {
                context.Entry(movie).State = EntityState.Deleted;
                context.SaveChanges();

                return true;
            }
            return false;
        }

        public List<Domain.Movie> GetAll()
        {
            var movies = context.Movies.AsNoTracking()
                .Include(to => to.Image).AsNoTracking()
                .OrderBy(m => m.MovieName)
                .ToList();

            return mapper.Map<List<Domain.Movie>>(movies);            
        }

        public Domain.Movie GetById(int id)
        {
            return mapper.Map<Domain.Movie>(
                context.Movies.AsNoTracking()
                .Include(i => i.Image)
                .FirstOrDefault(m => m.MovieId == id));
        }

        public List<Domain.Movie> GetBySearch(string searchTerm)
        {
            if(string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;               
            }

            var termToLower = searchTerm.ToLower();
            return mapper.Map<List<Domain.Movie>>(
                context.Movies.AsNoTracking()  
                .Where(c => c.Genre == termToLower || c.MinutesOfPlay.ToString() == termToLower || c.MovieName == termToLower || c.YearOfMaking.ToString() == termToLower));
        }

        public bool Update(Domain.Movie update)
        {
            var movie = mapper.Map<Entities.Movie>(update);

            if(update != null)
            {
                context.Movies.Attach(movie);
                context.Entry(movie).State = EntityState.Modified;

                context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
