using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TarongISW.Entities;

namespace TarongISWObjectDesignTest
{
    [TestClass]
    public class TripTest
    {
        public void VirtualPropertiesDefined()
        {
            PropertyInfo property = typeof(Trip).GetProperty("Crates");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Crates property should be declared virtual.");
            property = typeof(Person).GetProperty("Truck");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Truck property should be declared virtual.");
        }

        [TestMethod]
        public void NoParamsConstructorInitializesMaintenances()
        {
            Trip trip = new Trip();
            Assert.AreNotSame(null, trip, "There must be a constructor without parameters.");
            Assert.IsNotNull(trip.Crates, "Collection of Crates not properly initialized. \n Patch the problem adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, trip.Crates.Count, "Collection of Crates not properly initialized. \n The list should be empty\n");

        }

        [TestMethod]
        public void ConstructorInitializesProps()
        {
            Trip trip = new Trip(TestData.EXPECTED_TRUCK);

            Assert.AreEqual(TestData.EXPECTED_TRUCK, trip.Truck);
            Assert.AreNotSame(null, trip, "There must be a constructor without parameters.");
            Assert.IsNotNull(trip.Crates, "Collection of Crates not properly initialized. \n Patch the problem adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, trip.Crates.Count, "Collection of Crates not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(null, trip.ParcelExit, "ParcelExit not properly initialized. Please check whether it is nullable or not.");
            Assert.AreEqual(null, trip.UnloadTime, "UnloadTime not properly initialized. Please check whether it is nullable or not.");
            Assert.AreEqual(null, trip.CoopArrival, "CoopArrival not properly initialized. Please check whether it is nullable or not.");

        }
    }

   
}