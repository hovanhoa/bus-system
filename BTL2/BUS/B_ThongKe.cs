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
    public class B_ThongKe
    {
        public static DataTable GetData(ThongKe tk)
        {
            return D_ThongKe.getData(tk);
        }
        public static DataTable GetAllTuyen()
        {
            return D_ThongKe.getAllTuyen();
        }
    }
}
