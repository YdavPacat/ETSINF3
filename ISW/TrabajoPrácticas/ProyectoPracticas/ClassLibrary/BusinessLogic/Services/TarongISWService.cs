using TarongISW.Entities;
using TarongISW.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Services
{
    public class TarongISWService: ITarongISWService 
    {
        private readonly IDAL dal;

        public TarongISWService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void AddPerson(Person person)
        {
            // Restricción: No puede haber dos personas con el mismo DNI
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                dal.Commit();
            }
            else throw new ServiceException(person.Name + " ya esta dado de alta ");
        }

        public void AddParcel(Parcel parcel)
        {
            // Restricción: No puede haber dos parcelas con el mismo nombre
            if(!dal.GetWhere<Parcel>(x=>x.Name == parcel.Name).Any())
            {
                dal.Insert<Parcel>(parcel);
                dal.Commit();
            }
            else throw new ServiceException("Parcela con nombre: " + parcel.Name + ", ya existe");
        }

        public void AddTruck(Truck truck)
        {
            // Restricción: No puede haber dos camiones con la misma matrícula
            if (dal.GetById<Truck>(truck.Id) == null)
            {
                dal.Insert<Truck>(truck);
				dal.Commit();
            }
            else throw new ServiceException("Camion con matricula " + truck.Id + " ya existe ");
        }

        // A partir de aquí vuestro código

        public void AddPermanent(Permanent permanent)
        {
            dal.Insert<Permanent>(permanent);
            dal.Commit();
        }

        public void AddTemporary(Temporary temporary)
        {
            dal.Insert<Temporary>(temporary);
            dal.Commit();
        }

        public Person FindPersonById(string id)
        {
            return dal.GetById<Person>(id);
        }

        public Parcel FindParcelById(string id)
        {
            return dal.GetById<Parcel>(id);
        }

        public void AddGroup(Group group)
        {
                dal.Insert<Group>(group);
                dal.Commit();
        }

        public Truck FindTruckById(string id)
        {
            return dal.GetById<Truck>(id);
        }

        public IList<Trip> GetAllTrips()
        {
            return new List<Trip>(dal.GetAll<Trip>());
        }

        public void AddCrate(Crate crate)
        {
            dal.Insert<Crate>(crate);
            dal.Commit();
        }

        public IList<Contract> GetAllContracts()
        {
            return new List<Contract>(dal.GetAll<Contract>());
        }

        public IList<Group> GetAllGroups()
        {
            return new List<Group>(dal.GetAll<Group>());
        }

        public IList<Crate> GetAllCrates()
        {
            return new List<Crate>(dal.GetAll<Crate>());
        }

        public IList<Parcel> GetAllParcels()
        {
            return new List<Parcel>(dal.GetAll<Parcel>());
        }

        public IList<Truck> GetAllTrucks()
        {
            return new List<Truck>(dal.GetAll<Truck>());
        }

        public IList<Person> GetAllPeople()
        {
            return new List<Person>(dal.GetAll<Person>());
        }

        public Trip FindTripById(string id)
        {
            return dal.GetById<Trip>(id);
        }
    }
}
