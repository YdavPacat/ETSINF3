using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Truck {
        public virtual double? MaximunWeight 
        {
            get
            {
                return MaximumAuthorisedMass - TareWeight;
            }
        }

        [Key]
        public string Id {
            get;
            set;
        }

        public double MaximumAuthorisedMass {
            get;
            set;
        }
        public double TareWeight {
            get;
            set;
        }
        public virtual ICollection<Trip> Trips {
            get;
            set;
        }
    }
}
