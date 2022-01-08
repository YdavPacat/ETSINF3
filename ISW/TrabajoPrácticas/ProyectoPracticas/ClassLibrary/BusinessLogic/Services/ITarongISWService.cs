using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Entities;


namespace TarongISW.Services
{
    public interface ITarongISWService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void AddPerson(Person p);
        void AddParcel(Parcel parcel);
        void AddTruck(Truck truck);

        // A partir de aquí vuestros métodos
        void AddPermanent(Permanent permanent);
        void AddTemporary(Temporary temporary);
        Person FindPersonById(String id);
        Parcel FindParcelById(String id);
        void AddGroup(Group group);
        Truck FindTruckById(String id);
        IList<Trip> GetAllTrips();
        void AddCrate(Crate crate);
        IList<Contract> GetAllContracts();
        IList<Group> GetAllGroups();
        IList<Crate> GetAllCrates();
        IList<Parcel> GetAllParcels();
        IList<Truck> GetAllTrucks();
        IList<Person> GetAllPeople();
        Trip FindTripById(String id);
    }
}