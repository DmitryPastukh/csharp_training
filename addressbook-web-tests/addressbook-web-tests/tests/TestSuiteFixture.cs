using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        public static ApplicationManager app;
        [SetUp]
        public void InitApplicationManager()
        {
         ApplicationManager app = ApplicationManager.GetInstance();
            

            

        
        }
       
    }
}
