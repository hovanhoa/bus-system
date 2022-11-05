using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class B_khach_hang
    {
        public static DataTable GetAllKhachHang()
        {
            return D_khach_hang.getData();
        }
    }
}
