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
    }
}
