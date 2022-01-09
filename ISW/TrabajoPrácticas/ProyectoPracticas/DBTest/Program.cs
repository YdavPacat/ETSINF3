using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using TarongISW.Entities;
using TarongISW.Persistence;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            createSampleDB(new EntityFrameworkDAL(new TarongISWDbContext()));    
        }

        private static void createSampleDB(IDAL dal)
        {
            // Remove all data from DB
            dal.RemoveAllData();

            Console.WriteLine("Creando los datos y almacenándolos en la BD.");
            Person p1 = new Person("12345678Z", "Juan Abelló");
            dal.Insert<Person>(p1);
            dal.Commit();
            Parcel parcel = new Parcel("1234567AB9999C0001DE", "El Lobillo, Alhambra (Ciudad Real)", Product.Kiwi, 10000, p1);
            dal.Insert<Parcel>(parcel);
            p1.AddParcel(parcel);
            dal.Commit();
            // Populate here the rest of the database with data
        }
    }
}
