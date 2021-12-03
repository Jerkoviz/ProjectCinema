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
            CreateMap<ProjectCinema.App.Services.Entities.MovieTheater, ProjectCinema.App.Domain.MovieTheater>().ReverseMap();
            CreateMap<MovieTheaterViewModel, ProjectCinema.App.Domain.MovieTheater>().ReverseMap();

            //SearchResultViewModel <-> MovieTheater

            CreateMap<SearchResultViewModel, App.Domain.MovieTheater>().ReverseMap();

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
        }
    }
}
