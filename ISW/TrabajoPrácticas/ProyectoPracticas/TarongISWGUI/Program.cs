using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.Entities;
using TarongISW.Persistence;
using TarongISW.Services;

namespace TarongISWGUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ITarongISWService service = new TarongISWService(new EntityFrameworkDAL(new TarongISWDbContext()));
            //DBInitialization(service);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TarongISWApp(service));
        }

        static void DBInitialization(ITarongISWService service)
        {
            service.RemoveAllData();

            Console.WriteLine("INITIALIZATING DB...");

            Person p1;
            p1 = new Person("12345678Z", "Juan Abelló");
            service.AddPerson(p1);

            Parcel parcel = new Parcel("1234567AB9999C0001DE", "El Lobillo, Alhambra (Ciudad Real)", Product.Orange, 10000, p1);
            service.AddParcel(parcel);

            p1 = new Person("23456789D", "José María Aristrian");
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB9999C0001DE", "Valdepuercas, Alia (Cáceres)", Product.Avocado, 18000, p1);
            service.AddParcel(parcel);

            p1 = new Person("34567890V", "Junta de Andalucía");
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB1111C0001DE", "La Almoraima (Cadiz)", Product.Kiwi, 16000, p1);
            service.AddParcel(parcel);

            Truck t = new Truck("1234AAA", 3200, 3000);
            service.AddTruck(t);

            t = new Truck("1234BJP", 3500, 2660);
            service.AddTruck(t);

            t = new Truck("1234LKP", 18000, 3660);
            service.AddTruck(t);


            //

            Person p2 = new Person("76543210S", "Andrés Trozado");
            service.AddPerson(p2);
            Permanent perm = new Permanent("ES9812340100951757864321", DateTime.Today.AddYears(-6), "SSN0033111144", p2, 14000.00);
            service.AddPermanent(perm);


            p2 = new Person("65432109F", "Helen Chufe");
            service.AddPerson(p2);
            perm = new Permanent("ES9812340100951757864321", DateTime.Today.AddYears(-2), "SSN4433221100", p2, 18000.00);
            service.AddPermanent(perm);

            p2 = new Person("98765432M", "Aitor Tilla");
            service.AddPerson(p2);
            Temporary tc = new Temporary("ES9812340100951757864321", DateTime.Today.AddDays(-20), "SSN0112233354", p2);
            service.AddTemporary(tc);


            // AddGroup

            parcel = service.FindParcelById("1234567AB9999C0001DE");
            Group g = new Group(DateTime.Today, parcel);
            service.AddGroup(g);



            parcel = service.FindParcelById("1234567AB9999C0001DE");
            g = parcel.LastGroup();

            Person p = service.FindPersonById("76543210S");
            Contract c = p.LastActiveContract();

            g.AddMember(c);  
            service.Commit();

            parcel = service.FindParcelById("1234567AB9999C0001DE");
            g = parcel.LastGroup();

            p = service.FindPersonById("98765432M");
            c = p.LastActiveContract();

            g.AddMember(c);  
            service.Commit();

            parcel = service.FindParcelById("7654321AB9999C0001DE");
            g = new Group(DateTime.Today, parcel);
            service.AddGroup(g);

            p = service.FindPersonById("65432109F");
            c = p.LastActiveContract();
            g.AddMember(c);
            service.Commit();



            t = service.FindTruckById("1234BJP");
            Trip trip = new Trip(t);
            t.AddTrip(trip);
            service.Commit();

            t = service.FindTruckById("1234AAA");
            trip = new Trip(t);
            t.AddTrip(trip);
            service.Commit();



            parcel = service.FindParcelById("7654321AB9999C0001DE");
            g = parcel.LastGroup();
            trip = service.FindTruckById("1234AAA").LastTrip();
            Contract contract = service.FindPersonById("65432109F").LastActiveContract();
                
            Crate c1 = new Crate(parcel.Product, 20, contract, g, trip);
            service.AddCrate(c1);

            Crate c2 = new Crate(parcel.Product, 30, contract, g, trip);
            service.AddCrate(c2);

            Crate c3 = new Crate(parcel.Product, 25.5, contract, g, trip);
            service.AddCrate(c3);


            parcel = service.FindParcelById("1234567AB9999C0001DE");
            g = parcel.LastGroup();
            trip = service.FindTruckById("1234BJP").LastTrip();
            contract = service.FindPersonById("98765432M").LastActiveContract();

            c1 = new Crate(parcel.Product, 50, contract, g, trip);
            service.AddCrate(c1);

            c2 = new Crate(parcel.Product, 45, contract, g, trip);
            service.AddCrate(c2);

            c3 = new Crate(parcel.Product, 35.5, contract, g, trip);
            service.AddCrate(c3);
            

            parcel = service.FindParcelById("1234567AB9999C0001DE");
            
            g = new Group(DateTime.Today.AddDays(1), parcel);
            service.AddGroup(g);

            p = service.FindPersonById("98765432M");
            c = p.LastActiveContract();
            g.AddMember(c);
            service.Commit();

            t = service.FindTruckById("1234BJP");

            trip = new Trip(t);
            t.AddTrip(trip);
            service.Commit();

            c1 = new Crate(parcel.Product, 20, c, g, trip);
            service.AddCrate(c1);

            c1 = new Crate(parcel.Product, 20, c, g, trip);
            service.AddCrate(c1);

            c1 = new Crate(parcel.Product, 21, c, g, trip);
            service.AddCrate(c1);
            Console.WriteLine("DATA CREATED.");
        }
    }
}
