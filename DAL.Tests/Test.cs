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
    public class UserInfoTest
    {


        [TestCase(1, "123", ExpectedResult = true)]
        [TestCase(2, "ABC", ExpectedResult = false)]
        public bool ValidateUserTest(int id, string pass)
        {
            Login l = new Login();
            bool ans = l.Customer_support_Executive(id, pass);
            return ans;

        }
    }
    [TestFixture]
    public class CustLogInfoTest { 

        [Test]
        public void GetAllLogInfoesTest()
        {
            ComplaintRegister c1 = new ComplaintRegister();
            bool ans = c1.showcustomerlog();
            Assert.AreEqual(true, ans);

        }
        [Test]
        public void SaveCustLogInfoTest()
        {
            
            ComplaintRegister c1 = new ComplaintRegister();
            CustLogInfo c2 = new CustLogInfo();
            c2.LogId = 111;
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
