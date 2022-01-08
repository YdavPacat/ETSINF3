using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TarongISW.Entities;

namespace TarongISWPesistenceTest
{
    [TestClass]
    public class TemporaryTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {
            Temporary temporary = new Temporary(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, TestData.EXPECTED_HIRED);
            dal.Insert(temporary);
            dal.Commit();

            Temporary temporaryDAL = dal.GetAll<Temporary>().First();
            Assert.AreEqual(TestData.EXPECTED_BANK_ACCOUNT, temporaryDAL.BankAccount, "Bank account not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_INITIAL_DATE, temporaryDAL.InitialDate, "InitialDate not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_SSN, temporaryDAL.SSN, "SSN not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_HIRED, temporaryDAL.Hired, "Hired not properly stored.");
            Assert.AreEqual(null, temporaryDAL.FinalDate, "FinalDate not properly stored.");


            Assert.IsNotNull(temporaryDAL.Crates, "Collection of crates not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, temporaryDAL.Crates.Count, "Collection of Crates not properly stored. \n The list should be empty\n");
            Assert.IsNotNull(temporaryDAL.Groups, "Collection of Groups not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, temporaryDAL.Groups.Count, "Collection of Groups not properly stored. \n The list should be empty\n");

        }

    }
}
