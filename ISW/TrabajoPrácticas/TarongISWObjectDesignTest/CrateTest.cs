using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TarongISW.Entities;

namespace TarongISWObjectDesignTest
{
    [TestClass]
    public class CrateTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            PropertyInfo property = typeof(Crate).GetProperty("Contract");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Contract property should be declared virtual.");
            property = typeof(Crate).GetProperty("Trip");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Trip property should be declared virtual.");
            property = typeof(Crate).GetProperty("Group");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Group property should be declared virtual.");
        }

        [TestMethod]
        public void NoParamsConstructorInitializesMaintenances()
        {
            Crate crate = new Crate();
            Assert.AreNotSame(null, crate, "There must be a constructor without parameters.");
            //No collections
        }
        [TestMethod]
        public void ConstructorInitializesProps()
        {
            //// Restricción constructor: La persona que recoge una caja debe formar parte del grupo
            Group group_contract_hired = new Group(TestData.EXPECTED_DATE, TestData.EXPECTED_PARCEL);
            //// group_contract_hired.AddMember(TestData.EXPECTED_CRATE_CONTRACT);
			group_contract_hired.Members.Add(TestData.EXPECTED_CRATE_CONTRACT);
            TestData.EXPECTED_CRATE_GROUP = group_contract_hired; 

            Crate crate = new Crate(TestData.EXPECTED_CRATE_PRODUCT, TestData.EXPECTED_CRATE_WEIGHTINPARCEL, TestData.EXPECTED_CRATE_CONTRACT, TestData.EXPECTED_CRATE_GROUP, TestData.EXPECTED_CRATE_TRIP);
            
            Assert.AreEqual(TestData.EXPECTED_CRATE_PRODUCT, crate.Product, "Product not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CRATE_WEIGHTINPARCEL, crate.WeightInParcel, "WeightInParcel not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CRATE_CONTRACT, crate.Contract, "Contract not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CRATE_GROUP, crate.Group, "Group not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CRATE_TRIP, crate.Trip, "Trip not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
 
            Assert.AreEqual(null, crate.WeightInCoop, "WeightInCoop not properly initialized. Please check whether it is nullable or not.");
            Assert.AreEqual(null, crate.Loss, "Loss not properly initialized. Please check whether it is nullable or not.");

            //Añadido tras la revisión
            //// Restricción constructor: La persona que recoge una caja debe formar parte del grupo
            Assert.IsTrue(TestData.EXPECTED_CRATE_GROUP.Members.Contains(TestData.EXPECTED_CRATE_CONTRACT),"The person (Contract) that fills a crate must belong to the group.");
        }
    }
}
