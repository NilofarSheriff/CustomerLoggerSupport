using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Login
    {
        public bool Customer_support_Executive(int id, string pass)
        {
            CustomerLoggerEntities context = new CustomerLoggerEntities();
            List<UserInfo> infos = context.UserInfoes.ToList();
            UserInfo found = infos.Find(x => x.UserId == id && x.Password == pass);
            if(found != null)
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
