using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Trip
    {
        public Trip()
        {
            Crates = new List<Crate>();
        }
        public Trip(Truck truck) : this()
        {
            this.CoopArrival = null;
            this.ParcelExit = null;
            this.UnloadTime = null;

            //Relaciones a 1
            Truck = truck;
        }
    }
}
