using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Parcel
    {

        [Key]
        public string CadastralReference
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public Product Product
        {
            get;
            set;
        }
        public double Size
        {
            get;
            set;
        }
        public virtual Person Owner
        {
            get;
            set;
        }
        public virtual ICollection<Group> Groups
        {
            get;
            set;
        }
    }
}
