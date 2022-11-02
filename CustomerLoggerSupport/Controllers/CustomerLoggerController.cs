using System;
using System.Collections.Generic;
using System.Linq;
using CustomerLoggerSupport.Models;
using System.Web;
using System.Web.Mvc;
using DAL;


namespace CustomerLoggerSupport.Controllers
{
    public class CustomerLoggerController : Controller
    {
        // GET: CustomerLogger
        public ActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        public ActionResult Index(newuser u)
        {
            Login l1 = new Login();
            

            l1.Customer_support_Executive(u.userid,u.password);
            return RedirectToAction("Complaints", new{userid = u.userid});
        }
        public ActionResult Complaints(int userid)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Complaints(Customerlogs info)
        {
            ComplaintRegister r1 = new ComplaintRegister();
            CustLogInfo info1 = new CustLogInfo();
            info1.LogId = info.logid;
            info1.CustName = info.custname;
            info1.CustEmail = info.custemail;
            info1.Description = info.desc;
            info1.UserId = info.userid;
            info1.LogStatus = info.logstatus;
            r1.addcustomerlog(info1);
            ViewBag.Message = "Complaint is registered sucessfully!!";
            return View();
        }
    }
}