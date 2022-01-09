using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TarongISW.Entities;

namespace TarongISWObjectDesignTest
{
    [TestClass]
    public class ParcelTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {

            PropertyInfo property = typeof(Parcel).GetProperty("Owner");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Owner property should be declared virtual.");
            property = typeof(Parcel).GetProperty("Groups");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Groups property should be declared virtual.");

        }
        [TestMethod]
        public void NoParamsConstructorInitializesMaintenances()
        {
            Parcel parcel = new Parcel();
            Assert.AreNotSame(null, parcel, "There must be a constructor without parameters.");
            Assert.IsNotNull(parcel.Groups, "Collection of Groups not properly initialized. \n Patch the problem adding:  Groups = new List<Group>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, parcel.Groups.Count, "Collection of Groups not properly initialized. \n The list should be empty\n");
            
        }
        [TestMethod]
        public void ConstructorInitializesProps()
        {
            Parcel parcel = new Parcel(TestData.EXPECTED_PARCEL_CADASTRALREFERENCE, TestData.EXPECTED_PARCEL_NAME, TestData.EXPECTED_PARCEL_PRODUCT, TestData.EXPECTED_PARCEL_SIZE, TestData.DEFAULT_PARCEL_OWNER);
            Assert.AreEqual(TestData.EXPECTED_PARCEL_CADASTRALREFERENCE, parcel.CadastralReference, "CadastralReference not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_NAME, parcel.Name, "Name not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_PRODUCT, parcel.Product, "Product not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_SIZE, parcel.Size, "Size not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.DEFAULT_PARCEL_OWNER, parcel.Owner, "Owner not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");

            Assert.IsNotNull(parcel.Groups, "Collection of Groups not properly initialized. \n Patch the problem adding:  Groups = new List<Group>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, parcel.Groups.Count, "Collection of Groups not properly initialized. \n The list should be empty\n");

        }
    }
}
