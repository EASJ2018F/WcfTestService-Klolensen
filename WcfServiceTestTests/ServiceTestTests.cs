using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceTest.Tests
{
    [TestClass()]
    public class ServiceTestTests
    {
        [TestMethod()]
        public void GetMyNameTest()
        {
            ServiceTest service = new ServiceTest();

            string result = service.GetMyName();

            Assert.AreEqual("Kevin Jensen", result);
        }

        [TestMethod()]
        public void GetMyAddressTest()
        {
            ServiceTest service = new ServiceTest();

            string result = service.GetMyAddress();

            Assert.AreEqual("Køgevej 54a", result);
        }

        [TestMethod()]
        public void GetDaysOfWeekTest()
        {
            ServiceTest service = new ServiceTest();

            List<string> result = service.GetDaysOfWeek();

            Assert.AreEqual("Mandag", result[0]);
            Assert.AreEqual("Tirsdag", result[1]);
            Assert.AreEqual("Onsdag", result[2]);
            Assert.AreEqual("Torsdag", result[3]);
            Assert.AreEqual("Fredag", result[4]);
            Assert.AreEqual("Lørdag", result[5]);
            Assert.AreEqual("Søndag", result[6]);
        }
    }
}