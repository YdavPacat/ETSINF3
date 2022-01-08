using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Services;

namespace TarongISW.Entities
{
    public partial class Group
    {
        public Group()
        {
            Crates = new List<Crate>();
            Members = new List<Contract>();
        }

        public Group(DateTime date, Parcel parcel) 
        {
            List<Group> groups = (List<Group>)parcel.Groups;
            bool sameDateAndParcel = false;
            Group same = null;

            foreach (Group g in groups)
            {
               if (g.Date.Day == date.Day)
                {
                    sameDateAndParcel = true;
                    same = g;
                } 
            }

            if (sameDateAndParcel)
            {
               throw new NotImplementedException("Ya hay un grupo para esta fecha y parcela ");
            } 
            //No se le da valor a Id porque se lo dará EF
            this.Date = date;

            //Relaciones a 1
            Parcel = parcel;

            //Colleciones
            Crates = new List<Crate>();
            Members = new List<Contract>();
        }
        public void AddMember(Contract c)
        {
            if (!Members.Contains(c))
            {
                List<Group> groups = (List<Group>)c.Groups;
                bool groupSameDate = false;

                foreach (Group g in  groups)
                {
                    if (g.Date == this.Date)
                        groupSameDate = true;
                }

                if (groupSameDate) { 
                    throw new ServiceException(c.Hired.Name + " ya esta en un grupo para esta fecha ");
                } 
                Members.Add(c);

            }  else
            
            throw new ServiceException(c.Hired.Name + " ya esta en el grupo ");
        }
    }
}
