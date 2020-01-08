using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
             new Trip
             {
                 Id = 1,
                 Name = "MVP Summit",
                 StartDate = new DateTime(2020,1,15),
                 EndDate = new DateTime(2020,1,20)
             },

             new Trip
             {
                Id = 2,
                Name = "Dev Meeting Orlando 2020",
                StartDate = new DateTime(2020,2,15),
                EndDate = new DateTime(2020,2,20)
             },

              new Trip
             {
                Id = 3,
                Name = "Build 2020",
                StartDate = new DateTime(2020,5,15),
                EndDate = new DateTime(2020,5,20)
             },
        };

        public List<Trip> Get()
        {
            return MyTrips;
        }

        public Trip Get(int id)
        {
            return MyTrips.First(d => d.Id == id);
        }

        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
        }
    }
}
