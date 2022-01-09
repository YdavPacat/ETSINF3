using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TarongISW.Entities;

namespace TarongISWObjectDesignTest
{
    [TestClass]
    public class TruckTest
    {
        public void VirtualPropertiesDefined()
        {
            PropertyInfo property = typeof(Truck).GetProperty("Trips");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Trips property should be declared virtual.");
            
        }

        [TestMethod]
        public void NoParamsConstructorInitializesMaintenances()
        {
            Truck truck = new Truck();
            Assert.AreNotSame(null, truck, "There must be a constructor without parameters.");
            Assert.IsNotNull(truck.Trips, "Collection of Trips not properly initialized. \n Patch the problem adding:  Trips = new List<Trip>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, truck.Trips.Count, "Collection of Trips not properly initialized. \n The list should be empty\n");
            
        }

        [TestMethod]
        public void ConstructorInitializesProps()
        {
            Truck truck = new Truck(TestData.EXPECTED_ID, TestData.EXPECTED_MAXIMUN_AUTHORISED_MASS, TestData.EXPECTED_TAREWEIGHT);
                
            Assert.AreEqual(TestData.EXPECTED_ID, truck.Id,"Truck registration not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_MAXIMUN_AUTHORISED_MASS, truck.MaximumAuthorisedMass, "MaximumWeight not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_TAREWEIGHT, truck.TareWeight, "TareWeight not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_MAXIMUN_WEIGHT, truck.MaximunWeight, "TareWeight not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");

            Assert.IsNotNull(truck.Trips, "Collection of Trips not properly initialized. \n Patch the problem adding:  Trips = new List<Trip>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, truck.Trips.Count, "Collection of Trips not properly initialized. \n The list should be empty\n");
            
           

        }
    }

   
}