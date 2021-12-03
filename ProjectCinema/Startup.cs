using AutoMapper;
using ProjectCinema.App.Services.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using ProjectCinema.AutoMapperProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCinema.App.Services;
using ProjectCinema.App.Domain;
using ProjectCinema.App.Areas;
using ProjectCinema.App.Areas.MovieTheater;
using ProjectCinema.App.Areas.Movie;
using ProjectCinema.App.Areas.Ticket;
using ProjectCinema.App.Areas.ScreeningTime;
using ProjectCinema.App.Areas.CurrentlyInCinema;

namespace ProjectCinema
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CinemaDbContext>(
                options => 
            options.UseSqlServer(Configuration.GetConnectionString("DbConnection")));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfiles.AutoMapperProfiles());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //Register application data services
            services.AddScoped(typeof(IBaseCinemaCRUD<MovieTheater>), typeof(MovieTheaterData));
            services.AddScoped<IBaseCinemaCRUD<CinemaMovie>, CinemaMovieData>();
            services.AddTransient<IBaseCinemaCRUD<Movie>, MovieData>();
            services.AddTransient<IBaseCinemaCRUD<Ticket>, TicketData>();
            services.AddTransient<IBaseCinemaCRUD<ScreeningTime>, ScreeningTimeData>();
            services.AddTransient<IBaseCinemaCRUD<CurrentlyInCinema>, CurrentlyInCinemaData>();

            //Register application managers
            services.AddScoped(typeof(IBaseManager<MovieTheater>), typeof(MovieTheaterManager));
            services.AddTransient<IBaseManager<Movie>, MovieManager>();
            services.AddTransient<IBaseManager<Ticket>, TicketManager>();
            services.AddTransient<IBaseManager<ScreeningTime>, ScreeningTimeManager>();
            services.AddTransient<IBaseManager<CurrentlyInCinema>, CurrentlyInCinemaManager>();
        }

        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
