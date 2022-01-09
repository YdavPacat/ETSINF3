using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Services;

namespace TarongISW.Entities
{
    public partial class Truck
    {
        public Truck()
        {
            Trips = new List<Trip>();
        }
        public Truck(string id, double maximumAutorishedMass, double tareWeight) : this()
        {
            this.Id = id;
            this.MaximumAuthorisedMass = maximumAutorishedMass;
            this.TareWeight = tareWeight;
        }

        public void AddTrip(Trip trip) 
        {
            Trips.Add(trip);
        }

        public Trip LastTrip()
        {
            return Trips.OrderBy(trip => trip.ParcelExit).Last(); 
        }

        public List<Trip> TripsByDate(DateTime ini, DateTime fin)
        {
            List<Trip> res = new List<Trip>();


            foreach (var trip in Trips)
            {
                if (trip.Crates.Count < 1)
                    continue;

                if (trip.Crates.First().Group.Date >= ini.Date && trip.Crates.First().Group.Date <= fin.Date)
                    res.Add(trip);
            }

            return res;
        }
    }
}
