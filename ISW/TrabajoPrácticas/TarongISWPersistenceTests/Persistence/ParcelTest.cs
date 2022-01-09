using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TarongISW.Entities;

namespace TarongISWPesistenceTest
{
    [TestClass]
    public class ParcelTest : BaseTest
    {
        [TestMethod]
        public void StoresInitialData()
        {

            Parcel parcel = new Parcel(TestData.EXPECTED_PARCEL_CADASTRALREFERENCE, TestData.EXPECTED_PARCEL_NAME, TestData.EXPECTED_PARCEL_PRODUCT, TestData.EXPECTED_PARCEL_SIZE, TestData.EXPECTED_PARCEL_OWNER);
            
            dal.Insert(parcel);
            dal.Commit();

            Parcel parcelDAL = dal.GetAll<Parcel>().First();
            Assert.AreEqual(TestData.EXPECTED_PARCEL_CADASTRALREFERENCE, parcelDAL.CadastralReference, "Cadastral Reference not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_NAME, parcelDAL.Name, "Name not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_PRODUCT, parcelDAL.Product, "Product not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_SIZE, parcelDAL.Size, "Size not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_OWNER, parcelDAL.Owner, "Owner not properly stored.");
        }

        [TestMethod]
        public void StoresDataWithRelations()
        {
            Parcel parcel = new Parcel(TestData.EXPECTED_PARCEL_CADASTRALREFERENCE, TestData.EXPECTED_PARCEL_NAME, TestData.EXPECTED_PARCEL_PRODUCT, TestData.EXPECTED_PARCEL_SIZE, TestData.EXPECTED_PARCEL_OWNER);
            Group group = new Group(TestData.EXPECTED_DATE, parcel);
            parcel.Groups.Add(group);

            dal.Insert(parcel);
            dal.Commit();

            Parcel parcelDAL = dal.GetAll<Parcel>().First();
            Assert.AreEqual(TestData.EXPECTED_PARCEL_CADASTRALREFERENCE, parcelDAL.CadastralReference, "Cadastral Reference not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_NAME, parcelDAL.Name, "Name not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_PRODUCT, parcelDAL.Product, "Product not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_SIZE, parcelDAL.Size, "Size not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_PARCEL_OWNER, parcelDAL.Owner, "Owner not properly stored.");

            Assert.IsNotNull(parcelDAL.Groups, "Collection of groups not properly stored.");
            Assert.AreEqual(TestData.EXPECTED_ONE_ELEMENT_LIST_COUNT, parcelDAL.Groups.Count, "Collection of Groups not properly stored. \n The list should have one element.\n");


        }

    }
}
