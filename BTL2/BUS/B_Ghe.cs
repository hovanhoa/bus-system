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
    class B_Ghe
    {
        public static DataTable GetGhe(string Ma_tuyen)
        {
            return D_Ghe.getData(Ma_tuyen);
        }

        public static void Insert(string Ma_tuyen, int STT, Ghe G)
        {
            D_Ghe.insert(Ma_tuyen, STT,G);
        }
    }
}
