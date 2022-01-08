using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TarongISW.Entities;

namespace TarongISWPesistenceTest
{
    [TestClass]
    public class TruckTest: BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {   /*Arrange

             - BaseTest.IniTests() is run before this code
             - Static Objects and variables used to create the object are inicialized in the class TestData 
             */

            //Act
            Truck truck = new Truck(TestData.EXPECTED_ID, TestData.EXPECTED_MAXIMUN_AUTHORISED_MASS, TestData.EXPECTED_TAREWEIGHT);
            dal.Insert(truck);
            dal.Commit();
            //Assert
            Truck truckDAL = dal.GetAll<Truck>().First();
            Assert.AreEqual(TestData.EXPECTED_ID, truckDAL.Id, "Truck registration not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_MAXIMUN_AUTHORISED_MASS, truckDAL.MaximumAuthorisedMass, "MaximumWeight not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_TAREWEIGHT, truckDAL.TareWeight, "TareWeight not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_MAXIMUN_WEIGHT, truckDAL.MaximunWeight, "TareWeight not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");

            Assert.IsNotNull(truckDAL.Trips, "Collection of Trips not properly initialized. \n Patch the problem adding:  Trips = new List<Trip>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, truckDAL.Trips.Count, "Collection of Trips not properly initialized. \n The list should be empty\n");
            //After assert: BaseTest.CleanTests() is run
        }

        [TestMethod]
        public void StoresTrip()
        {
            Truck truck = new Truck(TestData.EXPECTED_ID, TestData.EXPECTED_MAXIMUN_AUTHORISED_MASS, TestData.EXPECTED_TAREWEIGHT); 
            Trip trip = new Trip(truck);
            truck.Trips.Add(trip);
            dal.Insert(truck);
            dal.Commit();

            Truck truckDAL = dal.GetAll<Truck>().First();
            Assert.IsNotNull(truckDAL.Trips, "The collection of Trips was not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, truckDAL.Trips.Count, "The collection of Trips was not properly stored.");
            Assert.AreEqual(truckDAL, truckDAL.Trips.First().Truck, "Collection of Trips not properly stored. The Trip is not associated to the Truck.");
            // ¿iría en Trip esta comprobación? 
             Assert.AreEqual(trip, truckDAL.Trips.First(), "The first Trip of the Truck's trip list should be the same as this trip.");

        }
    }
}
