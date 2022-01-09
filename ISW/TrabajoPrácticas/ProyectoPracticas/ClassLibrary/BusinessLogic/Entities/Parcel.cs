using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Parcel
    {
        public Parcel()
        {
            Groups = new List<Group>();
        }

        public Parcel(string cadastralReference, string name, Product product, double size, Person person)
        {
            this.CadastralReference = cadastralReference;
            this.Name = name;
            this.Product = product;
            this.Size = size;

            //Relaciones a 1
            Owner = person;

            //Colecciones
            Groups = new List<Group>();
        }

        public Group LastGroup() 
        {
            if (Groups.Count == 0) return null; //No tiene grupos

            Group lastGroup = Groups.OrderBy(cont => cont.Date).Last(); 

            return lastGroup;
        }
    }
}
