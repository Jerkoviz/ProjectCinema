using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.App.Services.EF
{
    public class Seed
    {
        public static void PopulateSeedData(IApplicationBuilder app) 
        { 
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<CinemaDbContext>();

                context.Database.Migrate();

                //Seed data here
                if (!context.Roles.Any()) SeedRolesAndSystemUser(serviceScope);
            }
        }

        private static void SeedRolesAndSystemUser(IServiceScope serviceScope)
        {
            var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //Creating roles
            var systemAdmin = new IdentityRole { Name = "systemAdmin" };
            var cinemaWorker = new IdentityRole { Name = "Worker" };
            var user = new IdentityRole { Name = "User" };

            roleManager.CreateAsync(systemAdmin).Wait();
            roleManager.CreateAsync(cinemaWorker).Wait();
            roleManager.CreateAsync(user).Wait();

            var userManager = serviceScope.ServiceProvider.GetService<UserManager<IdentityUser>>();

            //Creating users

            //Creating system admin user
            var admin = new IdentityUser();
            admin.Email = "system@cinema.it";

            var systemUserPassword = "CinemaAdmin#1";
            admin.UserName = admin.Email;
            userManager.CreateAsync(admin, systemUserPassword).Wait();
            userManager.AddToRoleAsync(admin, "SystemAdmin").Wait();

            //Creating cinema worker user
            var worker = new IdentityUser();
            worker.Email = "worker@cinema.it";
            var workerPassword = "CinemaWorker#1";
            worker.UserName = worker.Email;
            userManager.CreateAsync(worker, workerPassword).Wait();
            userManager.AddToRoleAsync(worker, "Worker");
            
        }
    }
}
