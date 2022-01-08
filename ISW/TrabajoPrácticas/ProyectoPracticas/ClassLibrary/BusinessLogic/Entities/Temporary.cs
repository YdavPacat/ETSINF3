using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Temporary
    {
        public Temporary()
        {

        }
        public Temporary(string bankAccount, DateTime initialDate, string SSN, Person hired) : base(bankAccount, initialDate, SSN, hired)
        {
            this.FinalDate = null;
        }
    }
}
