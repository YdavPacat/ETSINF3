using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarongISW.Entities;

namespace TarongISWObjectDesignTest
{
    [TestClass]
    public class PermanentTest
    {
        [TestMethod]
        public void NoParamsConstructorInitializesMaintenances()
        {
            Permanent permanent = new Permanent();
            Assert.AreNotSame(null, permanent, "There must be a constructor without parameters.");
            Assert.IsNotNull(permanent.Crates, "Collection of crates not properly initialized. \n Patch the problem in the parent class (Contract) by adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, permanent.Crates.Count, "Collection of Crates not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(permanent.Groups, "Collection of Groups not properly initialized. \n Patch the problem in the parent class (Contract) by adding:  Group = new List<Group>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, permanent.Groups.Count, "Collection of Groups not properly initialized. \n The list should be empty\n");

        }
        [TestMethod]
        public void ConstructorInitializesProps()
        {
            Permanent permanent = new Permanent(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, TestData.EXPECTED_HIRED, TestData.EXPECTED_SALARY);
            Assert.AreEqual(TestData.EXPECTED_BANK_ACCOUNT, permanent.BankAccount, "Bank account not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class and are calling the base constructor when appropriate.");
            Assert.AreEqual(TestData.EXPECTED_INITIAL_DATE, permanent.InitialDate, "InitialDate not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class and are calling the base constructor when appropriate.");
            Assert.AreEqual(TestData.EXPECTED_SSN, permanent.SSN, "SSN not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class and are calling the base constructor when appropriate.");
            Assert.AreEqual(TestData.EXPECTED_HIRED, permanent.Hired, "Hired not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class and are calling the base constructor when appropriate.");
            Assert.AreEqual(TestData.EXPECTED_SALARY, permanent.Salary, "Salary not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");

            Assert.IsNotNull(permanent.Crates, "Collection of crates not properly initialized. \n Patch the problem in the parent class (Contract) by adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, permanent.Crates.Count, "Collection of Crates not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(permanent.Groups, "Collection of Groups not properly initialized. \n Patch the problem in the parent class (Contract) by adding:  Group = new List<Group>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, permanent.Groups.Count, "Collection of Groups not properly initialized. \n The list should be empty\n");

        }
    }
}
