using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TripTracker.BackService.Models
{
    public class Trip : TripTrackerDTO.Trip
    {
        public virtual ICollection<Segment> Segments { get; set; }

    }
}
