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
    public class CrateTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {   /*Arrange

             - BaseTest.IniTests() is run before this code
             - Static Objects and variables used to create the object are inicialized in the class TestData 
             */

            //// Restricción constructor: La persona que recoge una caja debe formar parte del grupo
            Group group_contract_hired = new Group(TestData.EXPECTED_DATE, TestData.EXPECTED_PARCEL);
            //group_contract_hired.AddMember(TestData.EXPECTED_CRATE_CONTRACT);
            group_contract_hired.Members.Add(TestData.EXPECTED_CRATE_CONTRACT);
            TestData.EXPECTED_CRATE_GROUP = group_contract_hired;

            Crate crate = new Crate(TestData.EXPECTED_CRATE_PRODUCT, TestData.EXPECTED_CRATE_WEIGHTINPARCEL, TestData.EXPECTED_CRATE_CONTRACT, TestData.EXPECTED_CRATE_GROUP, TestData.EXPECTED_CRATE_TRIP);
            
            dal.Insert(crate);
            dal.Commit();

            //Assert
            Crate crateDAL = dal.GetAll<Crate>().First();
            Assert.AreEqual(TestData.EXPECTED_CRATE_PRODUCT, crateDAL.Product, "Product not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CRATE_WEIGHTINPARCEL, crateDAL.WeightInParcel, "WeightInParcel not properly initialized. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CRATE_CONTRACT, crateDAL.Contract, "Contract not properly stored. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CRATE_GROUP, crateDAL.Group, "Group not properly stored. Please check whether you have correctly assigned the parameters in the corresponding class.");
            Assert.AreEqual(TestData.EXPECTED_CRATE_TRIP, crateDAL.Trip, "Trip not properly stored. Please check whether you have correctly assigned the parameters in the corresponding class.");

            //Assert.AreEqual(crateDAL, TestData.EXPECTED_CRATE_CONTRACT.Crates.First(), "The first Contract of the Crate's contract list should be the same as this contract.");
            //Assert.AreEqual(crateDAL, TestData.EXPECTED_CRATE_GROUP.Crates.First(), "The first Group of the Crate's group list should be the same as this group.");
            //Assert.AreEqual(crateDAL, TestData.EXPECTED_CRATE_TRIP.Crates.First(), "The first Trip of the Crate's Trip list should be the same as this trip.");
        }

    }
    }
