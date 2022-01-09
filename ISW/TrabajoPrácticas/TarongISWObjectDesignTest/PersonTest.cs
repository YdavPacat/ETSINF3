using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TarongISW.Entities;

namespace TarongISWObjectDesignTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            PropertyInfo property = typeof(Person).GetProperty("Contracts");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Contracts property should be declared virtual.");
            property = typeof(Person).GetProperty("Parcels");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Parcels property should be declared virtual.");
        }
        [TestMethod]
        public void NoParamsConstructorInitializesMaintenances()
        {
            Person person = new Person();
            Assert.AreNotSame(null, person, "There must be a constructor without parameters.");
            Assert.IsNotNull(person.Parcels, "Collection of Parcels not properly initialized. \n Patch the problem adding:  Parcels = new List<Parcel>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, person.Parcels.Count, "Collection of Parcels not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(person.Contracts, "Collection of Contracts not properly initialized. \n Patch the problem adding:  Contracts = new List<Contract>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, person.Contracts.Count, "Collection of Contracts not properly initialized. \n The list should be empty\n");
            
        }
        [TestMethod]
        public void ConstructorInitializesProps()
        {
            Person person = new Person(TestData.EXPECTED_PERSON_ID, TestData.EXPECTED_PERSON_NAME);            
            Assert.AreEqual(TestData.EXPECTED_PERSON_ID, person.Id, "Id not properly initialized.Please check if you have called the constructor of the parent class by calling base(), and whether you have correctly assigned the parameters in the corresponding class.");            
            Assert.AreEqual(TestData.EXPECTED_PERSON_NAME, person.Name, "Name not properly initialized. Please check if you have called the constructor of the parent class by calling base(), and whether you have correctly assigned the parameters in the corresponding class.");            

            Assert.IsNotNull(person.Parcels, "Collection of Parcels no properly initialized. \n Patch the problem adding:  Parcels = new List<Parcel>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, person.Parcels.Count, "Collection of Parcels not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(person.Contracts, "Collection of Contracts not properly initialized. \n Patch the problem adding:  Contracts = new List<Contract>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, person.Contracts.Count, "Collection of Contracts not properly initialized. \n The list should be empty\n");
           
        }
    }
}
