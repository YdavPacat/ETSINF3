using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Trip
    {
        public virtual double? CarriedWeight 
        {
            //set;
            get
            {
                double? carga = 0.0;
                foreach(Crate c in Crates)
                    {
                        carga += c.WeightInParcel;
                    }
                return carga;
            }
        }

        public DateTime? CoopArrival
        {
            set;
            get;
        }

        public int Id
        {
            set;
            get;
        }

        public DateTime? ParcelExit
        {
            set;
            get;
        }

        public DateTime? UnloadTime
        {
            set;
            get;
        }

        public virtual ICollection<Crate> Crates
        {
            get;
            set;
        }
        public virtual Truck Truck
        {
            get;
            set;
        }
    }
}
