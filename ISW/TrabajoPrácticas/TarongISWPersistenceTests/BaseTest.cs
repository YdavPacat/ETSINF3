
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarongISW.Persistence;


namespace TarongISWPesistenceTest
{
    [TestClass]
    public class BaseTest
    {
        protected private EntityFrameworkDAL dal;
   
        [TestInitialize]
        public void IniTests()
        {
            dal = new EntityFrameworkDAL(new TarongISWDbContext());
            dal.RemoveAllData();


        }
        [TestCleanup]
        public void CleanTests()
        {
            dal.RemoveAllData();
        }
    }
}
