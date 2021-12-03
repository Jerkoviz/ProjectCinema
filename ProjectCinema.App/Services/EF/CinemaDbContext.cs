using ProjectCinema.App.Services.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.EF
{
    public class CinemaDbContext: IdentityDbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options): base (options)
        {

        }

        public DbSet<MovieTheater> MovieTheaters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CinemaMovie> CinemaMovies { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketSold> TicketSolds { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ScreeningTime> Dates { get; set; }
        public DbSet<CurrentlyInCinema> CurrentlyInCinemas { get; set; }
        public DbSet<ScreeningTime> ScreeningTimes { get; set; }
    }
}
