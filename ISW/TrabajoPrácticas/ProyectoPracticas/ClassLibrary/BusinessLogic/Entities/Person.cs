using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Person
    {
        public Person()
        {
            Parcels = new List<Parcel>();
            Contracts = new List<Contract>();
        }
        public Person(string id, string name) : this()
        {
            this.Id = id;
            this.Name = name;
        }
        //Devuelve último contrato activo o null
        public Contract LastActiveContract()
        {
            if (Contracts.Count == 0) return null; //No tiene contratos

            Contract lastCont = Contracts.OrderBy(cont => cont.InitialDate).Last();
            if (lastCont.Active()) return lastCont;
            else return null;
         }
        public void AddParcel(Parcel parcel)
        {
            Parcels.Add(parcel);
        }

    }
}
