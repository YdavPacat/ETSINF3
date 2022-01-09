using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Services; //Agregado para el exception

namespace TarongISW.Entities
{
    public partial class Contract
    {
        public Contract()
        {
            // Colecciones
            Crates = new List<Crate>();
            Groups = new List<Group>();
        }
        public Contract(string bankAccount, DateTime initialDate, string SSN, Person
        hired):this()
        {
            //Restriccion: Un trabajador no puede tener a la vez dos contratos activoz (ni fijo ni temporal)
            if (hired.LastActiveContract() != null)
                throw new ServiceException(hired.Name + " tiene un contrato activo.");
            // No se le da valor a Id porque se lo dará EF
            this.BankAccount = bankAccount;
            this.InitialDate = initialDate;
            this.SSN = SSN;
            // Relaciones a 1
            Hired = hired;
        }
        public bool Active()
        {
            if (this is Permanent) return true; //los permanentes son siempre activos
            else {
                Temporary t = (Temporary)this;
                if (t.FinalDate != null)
                {
                    if (t.FinalDate >= DateTime.Today)
                        return true; //fecha de finalizacion en el futuro u hoy
                    else return false; //fecha de finalizacion en el pasado
                }
                else return true; //no tiene fecha de finalizacion luego está activo

            }
        }
        public bool isWorking(DateTime date)
        {
            return Groups.Any(g => g.Date == date);
        }
    }
}
