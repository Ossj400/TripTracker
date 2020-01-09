using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.BackService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TripTracker.BackService.Data
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext>options): base(options) { }
        public TripContext()
        {

        }
        public DbSet<Trip> Trips { get; set; }

        public static void SeedData(IServiceProvider serviceProvider)
        {

            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<TripContext>();

                context.Database.EnsureCreated();

                if (context.Trips.Any()) 
                    return;

                context.Trips.AddRange(new Trip[]
             {
                new Trip
                {
                    Id = 1,
                    Name = "MVP Summit",
                    StartDate = new DateTime(2020, 1, 15),
                    EndDate = new DateTime(2020, 1, 20)
                },

                new Trip
                 {
                     Id = 2,
                     Name = "Dev Meeting Orlando 2020",
                     StartDate = new DateTime(2020, 2, 15),
                     EndDate = new DateTime(2020, 2, 20)
                 },

              new Trip
              {
                  Id = 3,
                  Name = "Build 2020",
                  StartDate = new DateTime(2020, 5, 15),
                  EndDate = new DateTime(2020, 5, 20)
              }
             }
                        );
            
                context.SaveChanges();
            }
        }
    } 
}
