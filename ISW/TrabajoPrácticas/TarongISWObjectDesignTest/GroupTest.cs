using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TarongISW.Entities;

namespace TarongISWObjectDesignTest
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            PropertyInfo property = typeof(Group).GetProperty("Members");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Members property should be declared virtual.");
            property = typeof(Group).GetProperty("Parcel");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Parcel property should be declared virtual.");
            property = typeof(Group).GetProperty("Crates");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Crates property should be declared virtual.");
        }

        [TestMethod]
        public void NoParamsConstructorInitializesMaintenances()
        {
            Group group = new Group();
            Assert.AreNotSame(null, group, "There must be a constructor without parameters.");
            Assert.IsNotNull(group.Crates, "Collection of crates not properly initialized. \n Patch the problem adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, group.Crates.Count, "Collection of crates not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(group.Members, "Collection of contracts not properly initialized. \n Patch the problem adding:  Members = new List<Contract>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, group.Members.Count, "Collection of contracts not properly initialized. \n The list should be empty\n");
        }
        [TestMethod]
        public void ConstructorInitializesProps()
        {
            Group group = new Group(TestData.EXPECTED_DATE,TestData.EXPECTED_PARCEL);
            Assert.AreEqual(TestData.EXPECTED_DATE, group.Date, "Group Date not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL, group.Parcel, "Parcel not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.IsNotNull(group.Crates, "Collection of crates not properly initialized. \n Patch the problem adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, group.Crates.Count, "Collection of crates not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(group.Members, "Collection of contracts not properly initialized. \n Patch the problem adding:  Members = new List<Contract>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, group.Members.Count, "Collection of contracts not properly initialized. \n The list should be empty\n");

        }
    }
}
