using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TarongISW.Entities;

namespace TarongISWPesistenceTest
{
    [TestClass]
    public class PermanentTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {
            Permanent permanent = new Permanent(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, TestData.EXPECTED_HIRED, TestData.EXPECTED_SALARY);
            dal.Insert(permanent);
            dal.Commit();

            Permanent permanentDAL = dal.GetAll<Permanent>().First();
            Assert.AreEqual(TestData.EXPECTED_BANK_ACCOUNT, permanentDAL.BankAccount, "Bank account not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_INITIAL_DATE, permanentDAL.InitialDate, "InitialDate not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_SSN, permanentDAL.SSN, "SSN not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_HIRED, permanentDAL.Hired, "Hired not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_SALARY, permanentDAL.Salary, "Salary not properly stored.");


            Assert.IsNotNull(permanentDAL.Crates, "Collection of crates not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, permanentDAL.Crates.Count, "Collection of Crates not properly stored. \n The list should be empty\n");
            Assert.IsNotNull(permanentDAL.Groups, "Collection of Groups not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, permanentDAL.Groups.Count, "Collection of Groups not properly stored. \n The list should be empty\n");

        }

    }
}
