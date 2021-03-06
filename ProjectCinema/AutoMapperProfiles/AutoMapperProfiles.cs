using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCinema.Models;
using ProjectCinema.App.Domain;

namespace ProjectCinema.AutoMapperProfiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            //MovieTheater
            CreateMap<App.Services.Entities.MovieTheater, MovieTheater>().ReverseMap();
            CreateMap<MovieTheaterViewModel, MovieTheater>().ReverseMap();

            //SearchResultViewModel <-> MovieTheater
            CreateMap<SearchResultViewModel, MovieTheater>().ReverseMap();

            //MovieEntities <-> MovieDomain
            CreateMap<App.Services.Entities.Movie, Movie>().ReverseMap();
            CreateMap<MovieViewModel, Movie>().ReverseMap();
            CreateMap<SearchResultViewModel, Movie>().ReverseMap();
            

            //Image
            CreateMap<Image, App.Services.Entities.Image>().ReverseMap();

            //Ticket
            CreateMap<Ticket, App.Services.Entities.Ticket>().ReverseMap();
            CreateMap<Ticket, TicketViewModel>().ReverseMap();

            //ScreeningTime
            CreateMap<ScreeningTime, App.Services.Entities.ScreeningTime>().ReverseMap();
            CreateMap<ScreeningTime, ScreeningTimeViewModel>().ReverseMap();

            //CurrentyInCinema
            CreateMap<CurrentlyInCinema, App.Services.Entities.CurrentlyInCinema>().ReverseMap();
            CreateMap<CurrentlyInCinema, CurrentlyInCinemaViewModel>().ReverseMap();

            //CinemaRepertoire
            CreateMap<CinemaRepertoireViewModel, CinemaRepertoire>().ReverseMap();

            //Banner
            CreateMap<Banner, BannerViewModel>().ReverseMap();
        }
    }
}
