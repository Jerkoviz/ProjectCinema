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
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

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

            // Use custom shared views location
            services.Configure<RazorViewEngineOptions>(o =>
            {
                o.ViewLocationFormats.Clear();
                o.ViewLocationFormats.Add("Areas/{1}/{0}.cshtml");
                o.ViewLocationFormats.Add("Areas/Shared/{0}.cshtml");
                o.ViewLocationFormats.Add("Areas/Identity/Account/Shared/{0}.cshtml");
                o.ViewLocationFormats.Add("Areas/Shared/Culture/{0}.cshtml");
                o.ViewLocationFormats.Add("Areas/Shared/CountryContext/{0}.cshtml");
            });

            //Connect context with database
            services.AddDbContext<CinemaDbContext>(
                options => 
            options.UseSqlServer(Configuration.GetConnectionString("DbConnection")));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //Adding identity
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 1;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
                .AddRoles<IdentityRole>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<CinemaDbContext>()
                .AddDefaultUI();

            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddHttpClient();
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });
            


            //Adding mapper
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
            services.AddTransient<IRepertoire, CurrentlyInCinemaData>();

            //Register application managers
            services.AddScoped(typeof(IBaseManager<MovieTheater>), typeof(MovieTheaterManager));
            services.AddTransient<IBaseManager<Movie>, MovieManager>();
            services.AddTransient<IBaseManager<Ticket>, TicketManager>();
            services.AddTransient<IBaseManager<ScreeningTime>, ScreeningTimeManager>();
            services.AddTransient<IBaseManager<CurrentlyInCinema>, CurrentlyInCinemaManager>();
            services.AddTransient<IRepertoireManager, CurrentlyInCinemaManager>();
        }

        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {

            app.UseExceptionHandler(errorApp =>
                errorApp.Run(async context =>
                {
                    context.Response.StatusCode = 500;

                    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                    logger.LogError(exceptionHandlerPathFeature.Error, "Error");

                    if (context.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                    {
                        // Error response for ajax requests
                        context.Response.ContentType = "application/json";
                        await context.Response.WriteAsync(exceptionHandlerPathFeature.Error?.Message);
                    }
                    else
                    {
                        // Error response for document requests
                        context.Response.Redirect("/Home/Error");
                    }
                })
            );

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            //Seed database data here
            Seed.PopulateSeedData(app);
        }
    }
}
