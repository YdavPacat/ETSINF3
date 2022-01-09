using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TarongISW.Entities;

namespace TarongISWPesistenceTest
{
    [TestClass]
    public class PersonTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {
            Person person = new Person(TestData.EXPECTED_PERSON_ID, TestData.EXPECTED_PERSON_NAME);
            dal.Insert(person);
            dal.Commit();

            Person personDAL = dal.GetAll<Person>().First();
            Assert.AreEqual(TestData.EXPECTED_PERSON_ID, personDAL.Id, "Id not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PERSON_NAME, personDAL.Name, "Name not properly stored.");

            Assert.IsNotNull(personDAL.Parcels, "Collection of Parcels not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, personDAL.Parcels.Count, "Collection of Parcels not properly initialized. \n The list should be empty\n");
            Assert.IsNotNull(personDAL.Contracts, "Collection of Contracts not properly stored");
            Assert.AreEqual(TestData.EXPECTED_EMPTY_LIST_COUNT, personDAL.Contracts.Count, "Collection of Contracts not properly initialized. \n The list should be empty\n");

        }

        [TestMethod]
        public void StoresDataWithRelations()
        {
            Person person = new Person(TestData.EXPECTED_PERSON_ID, TestData.EXPECTED_PERSON_NAME);

            Contract contract = new Contract(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, person);
            Parcel parcel =new Parcel(TestData.EXPECTED_PARCEL_CADASTRALREFERENCE, TestData.EXPECTED_PARCEL_NAME, TestData.EXPECTED_PARCEL_PRODUCT, TestData.EXPECTED_PARCEL_SIZE, person);

            person.Contracts.Add(contract);
            person.Parcels.Add(parcel);
            
            dal.Insert(person);
            dal.Commit();


            Person personDAL = dal.GetAll<Person>().First();
            Assert.AreEqual(TestData.EXPECTED_PERSON_ID, personDAL.Id, "Id not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PERSON_NAME, personDAL.Name, "Name not properly stored.");

            Assert.IsNotNull(personDAL.Parcels, "Collection of Parcels not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, personDAL.Parcels.Count, "Collection of Parcels not properly initialized. \n The list should have one element\n");
            Assert.IsNotNull(personDAL.Contracts, "Collection of Contracts not properly stored");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, personDAL.Contracts.Count, "Collection of Contracts not properly initialized. \n The list should have one element\n");
     
        }

    }
}
