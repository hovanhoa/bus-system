using BTL2.DAL;
using BTL2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.BUS
{
    public class B_TuyenBus
    {
        public static DataTable GetAllTuyenBus()
        {
            return D_TuyenBus.getData();
        }

        public static void Insert(TuyenBus t)
        {
            D_TuyenBus.insert(t);
        }
    }
}
