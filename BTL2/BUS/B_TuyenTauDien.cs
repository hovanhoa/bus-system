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
    class B_TuyenTauDien
    {
        public static DataTable GetAllTuyenTauDien()
        {
            return D_TuyenTauDien.getData();
        }

        public static void Insert(TuyenTauDien t)
        {
            D_TuyenTauDien.insert(t);
        }
    }
}
