using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ComplaintRegister
    {
        CustomerLoggerEntities context = new CustomerLoggerEntities();
        public bool addcustomerlog(CustLogInfo Info )
        {
            try
            {
                context.CustLogInfoes.Add(Info);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool showcustomerlog()
        {
            CustomerLoggerEntities context = new CustomerLoggerEntities();
            List<CustLogInfo> logs = context.CustLogInfoes.ToList();
            if(logs.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
