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
    public class B_khach_hang
    {
        public static DataTable GetAllKhachHang()
        {
            return D_khach_hang.getData();
        }

        public static DataTable B_sreach(string id, string CMND, string job, string phone, string Sex, string email, string dob)
        {
            return D_khach_hang.search(id,CMND,job,phone,Sex,email,dob);
        }
    }
}
