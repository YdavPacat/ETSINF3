using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Services;

namespace TarongISW.Entities
{
    public partial class Crate
    {
        public Crate()
        {
           
        }

        public Crate(Product product, double weightInParcel, Contract contract, Group group, Trip trip)
        {

            if (!contract.Groups.Contains(group))
            {
                 throw new ServiceException(contract.Hired.Name + " no esta en el grupo " + group.Id);
            }

            if (trip.Truck.MaximunWeight - trip.CarriedWeight < weightInParcel)
            {
                 throw new ServiceException("Esta caja excede el peso maximo.");
            }

            this.Product = product;
            this.WeightInCoop = null;
            this.WeightInParcel = weightInParcel;
 
            //Relaciones a 1
            Group = group;
            Trip = trip;
            Contract = contract;
        }
    }
}
