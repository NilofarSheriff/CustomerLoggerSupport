using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL;
using System.Security.Policy;

namespace DAL.Tests
{
    [TestFixture]
    public class Test
    {
        
        
        [TestCase(1,"123", ExpectedResult =true)]
        [TestCase(2, "ABC", ExpectedResult = false)]
        public bool verifyLogin(int id,string pass)
        {
            Login l = new Login();
            bool ans= l.Customer_support_Executive(id, pass);
            return ans;

        }

        [Test]
        public void AddLogs()
        {
            
            ComplaintRegister c1 = new ComplaintRegister();
            CustLogInfo c2 = new CustLogInfo();
            c2.LogId = 102;
            c2.UserId = 1;
            c2.CustName = "Zam";
            c2.CustEmail = "Zam@gmail.com";
            c2.LogStatus = "Logging";
            c2.Description = "Azure Error";
            bool ans = c1.addcustomerlog(c2);
            Assert.AreEqual(true, ans);
            
        }
    }
}
