using System;
using TarongISW.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TarongISWObjectDesignTest
{
    public class TestData
    {
        //GENERIC
        public static int EXPECTED_EMPTY_LIST_COUNT = 0;
        public static int EXPECTED_ONE_ELEMENT_LIST_COUNT = 1;
        //PERSON
        public static string EXPECTED_PERSON_ID = "94814560G";
        public static string EXPECTED_PERSON_NAME = "Fernando Alonso";

        //PARCEL
        public static string EXPECTED_PARCEL_CADASTRALREFERENCE = "1234567";
        public static string EXPECTED_PARCEL_NAME = "Los Naranjos";
        public static Product EXPECTED_PARCEL_PRODUCT = Product.Orange;
        public static double EXPECTED_PARCEL_SIZE = 235;
        public static Person DEFAULT_PARCEL_OWNER = new Person(EXPECTED_PERSON_ID, EXPECTED_PERSON_NAME);

        //CONTRACT

        public static string EXPECTED_BANK_ACCOUNT = "ES02029302910292";
        public static DateTime EXPECTED_INITIAL_DATE = DateTime.Parse("2021-10-07");
        public static string EXPECTED_SSN = "46019384054234";
        public static Person EXPECTED_HIRED = new Person("28341353V", "Carlos Sainz");


        //TEMPORARY


        //PERMANENT

        public static double EXPECTED_SALARY = 1200;

        //GROUP
        public static DateTime EXPECTED_DATE = DateTime.Parse("2021-10-07");
        public static Parcel EXPECTED_PARCEL = new Parcel(EXPECTED_PARCEL_CADASTRALREFERENCE, EXPECTED_PARCEL_NAME, EXPECTED_PARCEL_PRODUCT, EXPECTED_PARCEL_SIZE, DEFAULT_PARCEL_OWNER);

       //TRUCK
        public static string EXPECTED_ID = "2041-BKN" ; // Mátricula de camión
        public static double EXPECTED_MAXIMUN_AUTHORISED_MASS = 10000;
        public static double EXPECTED_TAREWEIGHT = 2000;
        public static double EXPECTED_MAXIMUN_WEIGHT = EXPECTED_MAXIMUN_AUTHORISED_MASS - EXPECTED_TAREWEIGHT;

        //TRIP
        public static Truck EXPECTED_TRUCK = new Truck(EXPECTED_ID, EXPECTED_MAXIMUN_AUTHORISED_MASS, EXPECTED_TAREWEIGHT);

        //CRATE
        public static double EXPECTED_CRATE_WEIGHTINPARCEL = 25;
        public static Product EXPECTED_CRATE_PRODUCT = EXPECTED_PARCEL_PRODUCT; 
        public static Contract EXPECTED_CRATE_CONTRACT = new Contract(TestData.EXPECTED_BANK_ACCOUNT, TestData.EXPECTED_INITIAL_DATE, TestData.EXPECTED_SSN, TestData.EXPECTED_HIRED);
        public static Group EXPECTED_CRATE_GROUP = new Group(TestData.EXPECTED_DATE, TestData.EXPECTED_PARCEL); 
        public static Trip EXPECTED_CRATE_TRIP = new Trip(TestData.EXPECTED_TRUCK);


    }
}
