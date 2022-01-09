using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TarongISW.Entities;

namespace TarongISWPesistenceTest
{
    [TestClass]
    public class GroupTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {   /*Arrange

             - BaseTest.IniTests() is run before this code
             - Static Objects and variables used to create the object are inicialized in the class TestData 
             */

            Group group = new Group(TestData.EXPECTED_DATE, TestData.EXPECTED_PARCEL);
            dal.Insert(group);
            dal.Commit();

            //Assert
            Group groupDAL = dal.GetAll<Group>().First();
            Assert.AreEqual(TestData.EXPECTED_DATE, groupDAL.Date, "Group Date not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL, groupDAL.Parcel, "Parcel not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.IsNotNull(groupDAL.Crates, "Collection of crates not properly initialized. \n Patch the problem adding:  Crates = new List<Crate>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, groupDAL.Crates.Count, "Collection of crates not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(groupDAL.Members, "Collection of contracts not properly initialized. \n Patch the problem adding:  Members = new List<Contract>();");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, groupDAL.Members.Count, "Collection of contracts not properly initialized. \n The list should be empty\n");
            Assert.AreEqual(groupDAL, TestData.EXPECTED_PARCEL.Groups.First(), "The first Group of the Parcel's group list should be the same as this group.");
        }
        [TestMethod]
        public void StoresCrate()
        {
            Group group = new Group(TestData.EXPECTED_DATE, TestData.EXPECTED_PARCEL);
            //// Restricción constructor de Crate: La persona que recoge una caja debe formar parte del grupo
            TestData.EXPECTED_CRATE_CONTRACT.Groups.Add(group);
            group.Members.Add(TestData.EXPECTED_CRATE_CONTRACT);
            Crate crate = new Crate(TestData.EXPECTED_CRATE_PRODUCT, TestData.EXPECTED_CRATE_WEIGHTINPARCEL, TestData.EXPECTED_CRATE_CONTRACT, group, TestData.EXPECTED_CRATE_TRIP);
            group.Crates.Add(crate);
            dal.Insert(group);
            dal.Commit();

            //Assert
            Group groupDAL = dal.GetAll<Group>().First();
            Assert.IsNotNull(groupDAL.Crates, "The collection of Crates was not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, groupDAL.Crates.Count, "The collection of Crates was not properly stored.");
            Assert.AreEqual(groupDAL, groupDAL.Crates.First().Group, "Collection of Crates not properly stored. The Crate is not associated to the Group.");
            // ¿iría en Crate esta comprobación? 
             Assert.AreEqual(crate, groupDAL.Crates.First(), "The first Crate of the Group's crate list should be the same as this crate.");

        }
        [TestMethod]
        public void StoresContract()
        {
            Group group = new Group(TestData.EXPECTED_DATE, TestData.EXPECTED_PARCEL);
            Contract permanent = new Permanent(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, TestData.EXPECTED_HIRED, TestData.EXPECTED_SALARY);
            group.Members.Add(permanent);
            dal.Insert(group);
            dal.Commit();

            //Assert
            Group groupDAL = dal.GetAll<Group>().First();
            Assert.IsNotNull(groupDAL.Members, "The collection of Contracts (Members) was not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, groupDAL.Members.Count, "The collection of Contracts (Members) was not properly stored.");
            Assert.AreEqual(groupDAL, groupDAL.Members.First().Groups.First(), "Collection of Contracts (Members) not properly stored. The Contract is not associated to the Group.");
            // ¿iría en Contract esta comprobación? 
             Assert.AreEqual(permanent, groupDAL.Members.First(), "The first Contract of the Group's contract list should be the same as this contract.");

        }
    }
    }
