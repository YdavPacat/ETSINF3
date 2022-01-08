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
    public class TripTest: BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {   /*Arrange

             - BaseTest.IniTests() is run before this code
             - Static Objects and variables used to create the object are inicialized in the class TestData 
             */

            //Act
            Trip trip = new Trip(TestData.EXPECTED_TRUCK);
            dal.Insert(trip);
            dal.Commit();
            //Assert
            Trip tripDAL = dal.GetAll<Trip>().First();
            Assert.AreEqual(TestData.EXPECTED_TRUCK, tripDAL.Truck, "Truck not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.IsNotNull(tripDAL.Crates, "Collection of Crates not properly initialized. \n Patch the problem adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, tripDAL.Crates.Count, "Collection of Crates not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(null, tripDAL.ParcelExit, "ParcelExit not properly initialized. Please check whether it is nullable or not.");
            Assert.AreEqual(null, tripDAL.UnloadTime, "UnloadTime not properly initialized. Please check whether it is nullable or not.");
            Assert.AreEqual(null, tripDAL.CoopArrival, "CoopArrival not properly initialized. Please check whether it is nullable or not.");
            Assert.AreEqual(tripDAL, TestData.EXPECTED_TRUCK.Trips.First(), "The first Trip of the Truck's trip list should be the same as this trip.");
            //After assert: BaseTest.CleanTests() is run
        }

        [TestMethod]
        public void StoresCrates()
        {
            
            Trip trip = new Trip(TestData.EXPECTED_TRUCK);
            //// Restricción constructor de Crate: La persona que recoge una caja debe formar parte del grupo
            TestData.EXPECTED_CRATE_CONTRACT.Groups.Add(TestData.EXPECTED_CRATE_GROUP);
            TestData.EXPECTED_CRATE_GROUP.Members.Add(TestData.EXPECTED_CRATE_CONTRACT);
            Crate crate = new Crate(TestData.EXPECTED_CRATE_PRODUCT, TestData.EXPECTED_CRATE_WEIGHTINPARCEL, TestData.EXPECTED_CRATE_CONTRACT, TestData.EXPECTED_CRATE_GROUP, trip);

            trip.Crates.Add(crate);
            dal.Insert(trip);
            dal.Commit();

            Trip tripDAL = dal.GetAll<Trip>().First();
            Assert.IsNotNull(tripDAL.Crates, "The collection of Crates was not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, tripDAL.Crates.Count, "The collection of Crates was not properly stored.");
            Assert.AreEqual(tripDAL, tripDAL.Crates.First().Trip, "Collection of Crates not properly stored. The Crate is not associated to the Trip.");
            // ¿iría en Crate esta comprobación? 
             Assert.AreEqual(crate, tripDAL.Crates.First(), "The first Crate of the Trip's crate list should be the same as this crate.");

        }
    }
}
