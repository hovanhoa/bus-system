using BTL2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.BUS
{
    public class B_Account
    {
        public static bool Login(string user,string pass)
        {
            return D_Account.checkLogin(user, pass);
        }
    }
}
