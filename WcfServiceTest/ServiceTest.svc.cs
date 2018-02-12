using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTest" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTest.svc or ServiceTest.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTest : ITestService
    {
        public string GetMyName()
        {
            return "Kevin Jensen";
        }
    }
}
