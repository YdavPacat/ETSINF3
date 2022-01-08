using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TarongISW.Entities;

namespace TarongISWObjectDesignTest
{
    [TestClass]
    public class ContractTest
    {
        [TestMethod]
        public void VirtualPropertiesDefined()
        {
            PropertyInfo property = typeof(Contract).GetProperty("Groups");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Groups property should be declared virtual.");
            property = typeof(Contract).GetProperty("Crates");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Crates property should be declared virtual.");
            property = typeof(Contract).GetProperty("Hired");
            Assert.IsTrue(property.GetMethod.IsVirtual, "Hired property should be declared virtual.");
        }

        [TestMethod]
        public void NoParamsConstructorInitializesMaintenances()
        {
            Contract contract = new Contract();
            Assert.AreNotSame(null, contract, "There must be a constructor without parameters.");
            Assert.IsNotNull(contract.Crates, "Collection of Crates not properly initialized. \n Patch the problem adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, contract.Crates.Count, "Collection of Crates not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(contract.Groups, "Collection of Groups not properly initialized. \n Patch the problem adding:  Group = new List<Group>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, contract.Groups.Count, "Collection of Groups not properly initialized. \n The list should be empty\n");
            
        }
        [TestMethod]
        public void ConstructorInitializesProps()
        {
            Contract contract = new Contract(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, TestData.EXPECTED_HIRED);
            Assert.AreEqual(TestData.EXPECTED_BANK_ACCOUNT, contract.BankAccount, "Bank account not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_INITIAL_DATE, contract.InitialDate, "InitialDate not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_SSN, contract.SSN, "SSN not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_HIRED, contract.Hired, "Hired not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");

            Assert.IsNotNull(contract.Crates, "Collection of crates not properly initialized. \n Patch the problem adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, contract.Crates.Count, "Collection of Crates not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(contract.Groups, "Collection of Groups not properly initialized. \n Patch the problem adding:  Group = new List<Group>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, contract.Groups.Count, "Collection of Groups not properly initialized. \n The list should be empty\n");
            
        }
    }
}
