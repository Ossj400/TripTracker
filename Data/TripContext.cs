using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.BackService.Models;
using Microsoft.EntityFrameworkCore;

namespace TripTracker.BackService.Data
{
    public class TripContext : DbContext
    {
       
        public DbSet<Trip> Trips { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Trip>().HasKey(t => t.Id);  // no need to make a PK coz convention found "Id" and made it PK
        }
    }

    
}
