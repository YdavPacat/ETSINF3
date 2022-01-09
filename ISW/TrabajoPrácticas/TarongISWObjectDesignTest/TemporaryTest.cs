using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarongISW.Entities;

namespace TarongISWObjectDesignTest
{
    [TestClass]
    public class TemporaryTest
    {
        [TestMethod]
        public void NoParamsConstructorInitializesMaintenances()
        {
            Temporary temporary = new Temporary();
            Assert.AreNotSame(null, temporary, "There must be a constructor without parameters.");
            Assert.IsNotNull(temporary.Crates, "Collection of Crates not properly initialized. \n Patch the problem in the parent class (Contract) by adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, temporary.Crates.Count, "Collection of Crates not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(temporary.Groups, "Collection of Groups not properly initialized. \n Patch the problem in the parent class (Contract) by adding:  Group = new List<Group>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, temporary.Groups.Count, "Collection of Groups not properly initialized. \n The list should be empty\n");

        }
        [TestMethod]
        public void ConstructorInitializesProps()
        {
            Temporary temporary = new Temporary(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, TestData.EXPECTED_HIRED);
            Assert.AreEqual(TestData.EXPECTED_BANK_ACCOUNT, temporary.BankAccount, "Bank account not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class and are calling the base constructor when appropriate.");
            Assert.AreEqual(TestData.EXPECTED_INITIAL_DATE, temporary.InitialDate, "InitialDate not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class and are calling the base constructor when appropriate.");
            Assert.AreEqual(TestData.EXPECTED_SSN, temporary.SSN, "SSN not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class and are calling the base constructor when appropriate.");
            Assert.AreEqual(TestData.EXPECTED_HIRED, temporary.Hired, "Hired not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class and are calling the base constructor when appropriate.");
            Assert.AreEqual(null, temporary.FinalDate, "FinalDate not properly initialized. Please check whether it is nullable or not.");


            Assert.IsNotNull(temporary.Crates, "Collection of crates not properly initialized. \n Patch the problem in the parent class (Contract) by adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, temporary.Crates.Count, "Collection of Crates not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(temporary.Groups, "Collection of Groups not properly initialized. \n Patch the problem in the parent class (Contract) by adding:  Group = new List<Group>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, temporary.Groups.Count, "Collection of Groups not properly initialized. \n The list should be empty\n");

        }

    }
}
