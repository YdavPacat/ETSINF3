using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Validation;
using System.IO.Ports;

using TarongISW.Entities;
using TarongISW.Persistence;
using TarongISW.Services;


namespace BusinessLogicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ITarongISWService service = new TarongISWService(new EntityFrameworkDAL(new TarongISWDbContext()));

                new Program(service);
            }
            catch (Exception e)
            {
                printError(e);
                Console.WriteLine("Press any key.");
                Console.ReadLine();
            }


        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        private ITarongISWService service;

        Program(ITarongISWService service)
        {
            this.service = service;

            DBInitialization();

            AddPermanentContracts();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddTemporaryContracts();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddGroups();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddTripToTruck();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddCratesToTrip();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            MoreGroupsTripsCrates();

            QueryTravelsMadeByTruck();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        void DBInitialization()
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

            Console.WriteLine("DATA CREATED.");
        }

        void AddPermanentContracts() {
            Console.WriteLine();
            Console.WriteLine("ADDING PERMANENT CONTRACTS...");

            try
            {
                Person p2 = new Person("76543210S", "Andrés Trozado");
                service.AddPerson(p2);
                Permanent perm = new Permanent("ES9812340100951757864321", DateTime.Today.AddYears(-6), "SSN0033111144", p2, 14000.00);
                service.AddPermanent(perm);


                p2 = new Person("65432109F", "Helen Chufe");
                service.AddPerson(p2);
                perm = new Permanent("ES9812340100951757864321", DateTime.Today.AddYears(-2), "SSN4433221100", p2, 18000.00);
                service.AddPermanent(perm);

                // Ya está contratada
                p2 = service.FindPersonById("76543210S");
                perm = new Permanent("ES9812340100951577864321", DateTime.Today.AddYears(-1), "SSN0033111144", p2, 17000.00);
                service.AddPermanent(perm);
            }
            catch (Exception e)
            {
               printError(e);
            }

            // La persona ya está dada de alta (Id duplicado)
            try
            {
                Person p2 = new Person("76543210S", "Andrés Petido");
                service.AddPerson(p2);
                Permanent perm = new Permanent("ES9812340100951757864321", DateTime.Today.AddYears(-6), "SSN0033111144", p2, 14000.00);
                service.AddPermanent(perm);
            }
            catch (Exception e)
            {
                printError(e);
            }

            foreach (Contract c in service.GetAllContracts())
            {
                Console.WriteLine("Contract: " + c.Id + ", Id: " + c.Hired.Id + ", Name: " + c.Hired.Name);
            }
        }

       void AddTemporaryContracts()
       {
           Console.WriteLine();
           Console.WriteLine("ADDING TEMPORARY CONTRACTS...");

            Person p2;
            Temporary tc;
            try
            {
                p2 = new Person("87654321X", "Juan Sin Nombre");
                service.AddPerson(p2);
                tc = new Temporary("ES8912340100951757864321", DateTime.Today, "SSN0011223344", p2);
                tc.FinalDate = DateTime.Today.AddDays(10);
                service.AddTemporary(tc);
            }
            catch (Exception e)
            {
                printError(e);
            }

            try { 
                p2 = new Person("98765432M", "Aitor Tilla");
                service.AddPerson(p2);
                tc = new Temporary("ES9812340100951757864321", DateTime.Today.AddDays(-20), "SSN0112233354", p2);
                service.AddTemporary(tc);
            }
            catch (Exception e)
            {
                printError(e);
            }

            // Si está contratado no se puede volver a contratar
            try
            {
                p2 = service.FindPersonById("98765432M");
                tc = new Temporary("ES9812340100951757864321", DateTime.Today, "SSN0112233354", p2);
                tc.FinalDate = DateTime.Today.AddDays(10);
                service.AddTemporary(tc);
            }
            catch (Exception e)
            {
               printError(e);
            }

            // Si está contratado no se puede volver a contratar
            try
            {
                p2 = service.FindPersonById("87654321X");
                tc = new Temporary("ES9812340100951757864321", DateTime.Today, "SSN0011223344", p2);
                tc.FinalDate = DateTime.Today.AddDays(10);
                service.AddTemporary(tc);
            }
            catch (Exception e)
            {
                printError(e);
            }

            // Si está contratado no se puede volver a contratar
            try
            {
                p2 = service.FindPersonById("76543210S");
                tc = new Temporary("ES9812340100951757864321", DateTime.Today, "SSN0033111144", p2);
                tc.FinalDate = DateTime.Today.AddDays(10);
                service.AddTemporary(tc);
            }
            catch (Exception e)
            {
                printError(e);
            }

            foreach (Contract c in service.GetAllContracts())
            {
                if (c is Temporary)
                    Console.WriteLine("Contract: " + c.Id + ", Id: " + c.Hired.Id + ", Name: " + c.Hired.Name);
            }

        }

       void AddGroups()
       {
            Console.WriteLine();
            Console.WriteLine("ADDING GROUPS AND ASSIGN PEOPLE...");

            Person p;
            Contract c;
            Group g;
            Parcel parcel;

            try
            {
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                g = new Group(DateTime.Today, parcel);
                service.AddGroup(g);
            }
            catch (Exception e)
            {
                printError(e);
            }

            try
            {
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                g = parcel.LastGroup();

                p = service.FindPersonById("76543210S");
                c = p.LastActiveContract();

                g.AddMember(c);  
                service.Commit();
            }
            catch (Exception e)
            {
                printError(e);
            }


            try
            {
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                g = parcel.LastGroup();

                p = service.FindPersonById("98765432M");
                c = p.LastActiveContract();

                g.AddMember(c);  
                service.Commit();
            }
            catch (Exception e)
            {
                printError(e);
            }


            // dos grupos el mismo día en la misma parcela
            try
            {
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                g = new Group(DateTime.Today, parcel);
                service.AddGroup(g);
            }
            catch (Exception e)
            {
                printError(e);
            }

            // Dos veces la misma persona en un grupo
            try
            {
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                g = parcel.LastGroup();

                p = service.FindPersonById("98765432M");
                c = p.LastActiveContract();

                g.AddMember(c);
                service.Commit();
            }
            catch (Exception e)
            {
                printError(e);
            }

            // La misma persona en dos cuadrillas distintas el mismo día
            try
            {
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                g = new Group(DateTime.Today, parcel);
                service.AddGroup(g);

                p = service.FindPersonById("65432109F");
                c = p.LastActiveContract();
                g.AddMember(c);
                service.Commit();
            }
            catch (Exception e)
            {
                printError(e);
            }

            // Una persona que ya esta en un grupo no puede añadirse a otro
            try {
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                g = parcel.LastGroup();
                p = service.FindPersonById("98765432M");
                c = p.LastActiveContract();
                g.AddMember(c);
                service.Commit();
            }
            catch (Exception e)
            {
                printError(e);
            }

            // Mostrar la información almacenada de los grupos y sus miembros
            foreach (Group group in service.GetAllGroups())
            {
                    Console.WriteLine("Group: " + group.Id + ", Date: " + group.Date + ", Parcel: " + group.Parcel.CadastralReference + ", Parcel.Name: " + group.Parcel.Name);
                foreach(Contract contract in group.Members)
                {
                    Console.WriteLine("   Member: " + contract.Hired.Name);
                }
            }
        }

            
        void AddTripToTruck()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING TRIPS TO TRUCK...");

            Truck t;
            Trip trip;
            try
            {
                t = service.FindTruckById("1234BJP");
                trip = new Trip(t);
                t.AddTrip(trip);
                service.Commit();

                t = service.FindTruckById("1234AAA");
                trip = new Trip(t);
                t.AddTrip(trip);
                service.Commit();
            }
            catch (Exception e)
            {
                    printError(e);
            }

            // Mostrar la información de los viajes creados
            foreach (Trip tr in service.GetAllTrips())
            {
                Console.WriteLine("Trip: " + tr.Id + ", Truck: " + tr.Truck.Id);
                foreach (Crate cr in tr.Crates)
                {
                    Console.WriteLine("   Crate: " + cr.Id + ", Product: " + cr.Product + ", WeightInParcel: " + cr.WeightInParcel + ", WeightInCoop: " + cr.WeightInCoop);
                }
            }
        }

        void AddCratesToTrip()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING CRATES TO TRIP...");

            Trip trip;
            Crate c1, c2, c3;
            Parcel parcel;
            Contract contract;
            Group g;

            try
            {
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                g = parcel.LastGroup();
                trip = service.FindTruckById("1234AAA").LastTrip();
                contract = service.FindPersonById("65432109F").LastActiveContract();
                
                c1 = new Crate(parcel.Product, 20, contract, g, trip);
                service.AddCrate(c1);

                c2 = new Crate(parcel.Product, 30, contract, g, trip);
                service.AddCrate(c2);

                c3 = new Crate(parcel.Product, 25.5, contract, g, trip);
                service.AddCrate(c3);
            }
            catch (Exception e)
            {
                    printError(e);
            }

            try
            {
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
            }
            catch (Exception e)
            {
                printError(e);
            }

            // Miembro que no pertenece al grupo
            try
            {
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                g = parcel.LastGroup();
                trip = service.FindTruckById("1234BJP").LastTrip();
                contract = service.FindPersonById("65432109F").LastActiveContract();

                c1 = new Crate(parcel.Product, 50, contract, g, trip);
                service.AddCrate(c1);
            }
            catch (Exception e)
            {
                printError(e);
            }

            // Se añade una caja que excede el peso del camión
            try
            {
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                g = parcel.LastGroup();
                trip = service.FindTruckById("1234AAA").LastTrip();
                contract = service.FindPersonById("65432109F").LastActiveContract();

                c1 = new Crate(parcel.Product, 125, contract, g, trip);
                service.AddCrate(c1);
            }
            catch (Exception e)
            {
                printError(e);
            }

            // Mostrar la información de las cajas creadas
            foreach (Crate cr in service.GetAllCrates())
                Console.WriteLine("Crate: " + cr.Id + ", Member:" + cr.Contract.Hired.Name + ", Weight: " + cr.WeightInParcel + ", Truck: " + cr.Trip.Truck.Id + ", Parcel: " + cr.Group.Parcel.Name);
        }

        void MoreGroupsTripsCrates()
        {
            try
            {
                Parcel parcel = service.FindParcelById("1234567AB9999C0001DE");
                
                Group g = new Group(DateTime.Today.AddDays(1), parcel);
                service.AddGroup(g);

                Person p = service.FindPersonById("98765432M");
                Contract c = p.LastActiveContract();
                g.AddMember(c);
                service.Commit();

                Truck t = service.FindTruckById("1234BJP");

                Trip trip = new Trip(t);
                t.AddTrip(trip);
                service.Commit();

                Crate c1 = new Crate(parcel.Product, 20, c, g, trip);
                service.AddCrate(c1);

                c1 = new Crate(parcel.Product, 20, c, g, trip);
                service.AddCrate(c1);

                c1 = new Crate(parcel.Product, 21, c, g, trip);
                service.AddCrate(c1);
            }
            catch (Exception e)
            {
                printError(e);
            }
        }

        void QueryTravelsMadeByTruck()
        {
                Console.WriteLine();
                Console.WriteLine("QUERY TRIPS MADE BY TRUCK...");

            try
            {
                DateTime initialDate = DateTime.Today.AddDays(0);
                DateTime finalDate = DateTime.Today.AddDays(1); 

                Truck truck = service.FindTruckById("1234BJP");
                List<Trip> ltrips = truck.TripsByDate(initialDate, finalDate);
                Console.WriteLine("Trips by truck " + truck.Id + ", Number of trips: " + ltrips.Count);
            }
            catch (Exception e)
            {
                    printError(e);
            }
        }


    }


}
