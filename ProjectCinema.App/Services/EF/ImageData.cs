using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using ProjectCinema.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.EF
{
    public class ImageData : IBaseCinemaCRUD<Image>
    {
        private readonly IMapper mapper;
        private readonly CinemaDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ImageData(IMapper mapper, CinemaDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.mapper = mapper;
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }
        public bool Create(Image newInput)
        {
            var image = mapper.Map<Entities.Image>(newInput);

            context.Add(image);
            context.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetAll()
        {
            throw new NotImplementedException();
        }

        public Image GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool Update(Image update)
        {
            throw new NotImplementedException();
        }
    }
}
