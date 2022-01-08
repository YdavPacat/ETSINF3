using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TarongISW.Entities;

namespace TarongISWPesistenceTest
{
    [TestClass]
    public class ContractTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {
            Contract contract = new Contract(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, TestData.EXPECTED_HIRED);
            dal.Insert(contract);
            dal.Commit();

            Contract contractDAL = dal.GetAll<Contract>().First();
            Assert.AreEqual(TestData.EXPECTED_BANK_ACCOUNT, contractDAL.BankAccount, "Bank account not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_INITIAL_DATE, contractDAL.InitialDate, "InitialDate not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_SSN, contractDAL.SSN, "SSN not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_HIRED, contractDAL.Hired, "Hired not properly stored.");


            Assert.IsNotNull(contractDAL.Crates, "Collection of crates not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, contractDAL.Crates.Count, "Collection of Crates not properly stored. \n The list should be empty\n");
            Assert.IsNotNull(contractDAL.Groups, "Collection of Groups not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, contractDAL.Groups.Count, "Collection of Groups not properly stored. \n The list should be empty\n");

        }

        [TestMethod]
        public void StoresDataWithRelations()
        {
            Contract contract = new Contract(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, TestData.EXPECTED_HIRED);
            Group group = new Group(TestData.EXPECTED_DATE, TestData.EXPECTED_PARCEL);
            group.Members.Add(contract);
            contract.Groups.Add(group);
            Crate crate = new Crate(TestData.EXPECTED_CRATE_PRODUCT, TestData.EXPECTED_CRATE_WEIGHTINPARCEL, contract, group, TestData.EXPECTED_CRATE_TRIP);
            contract.Crates.Add(crate);
            dal.Insert(contract);
            dal.Commit();

            Contract contractDAL = dal.GetAll<Contract>().First();
            Assert.AreEqual(TestData.EXPECTED_BANK_ACCOUNT, contractDAL.BankAccount, "Bank account not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_INITIAL_DATE, contractDAL.InitialDate, "InitialDate not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_SSN, contractDAL.SSN, "SSN not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_HIRED, contractDAL.Hired, "Hired not properly stored.");


            Assert.IsNotNull(contractDAL.Crates, "Collection of crates not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, contractDAL.Crates.Count, "Collection of Crates not properly stored. \n The list should have one element.\n");
            Assert.IsNotNull(contractDAL.Groups, "Collection of Groups not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, contractDAL.Groups.Count, "Collection of Groups not properly stored. \n The list should have one element.\n");

        }

    }
}
