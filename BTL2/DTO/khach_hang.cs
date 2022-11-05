using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DTO
{
    public class khach_hang
    {
        private string Ma_khach_hang;
        private string CMND_CCCD;
        private string Nghe_nghiep;
        private string Dien_thoai;
        private char Gioi_tinh;
        private string Email;
        private DateTime Ngay_sinh;

        public khach_hang(string ma_khach_hang, string cMND_CCCD, string nghe_nghiep, string dien_thoai, char gioi_tinh, string email, DateTime ngay_sinh)
        {
            Ma_khach_hang = ma_khach_hang;
            CMND_CCCD = cMND_CCCD;
            Nghe_nghiep = nghe_nghiep;
            Dien_thoai = dien_thoai;
            Gioi_tinh = gioi_tinh;
            Email = email;
            Ngay_sinh = ngay_sinh;
        }

        public string Ma_khach_hang1 { get => Ma_khach_hang; set => Ma_khach_hang = value; }
        public string CMND_CCCD1 { get => CMND_CCCD; set => CMND_CCCD = value; }
        public string Nghe_nghiep1 { get => Nghe_nghiep; set => Nghe_nghiep = value; }
        public string Dien_thoai1 { get => Dien_thoai; set => Dien_thoai = value; }
        public char Gioi_tinh1 { get => Gioi_tinh; set => Gioi_tinh = value; }
        public string Email1 { get => Email; set => Email = value; }
        public DateTime Ngay_sinh1 { get => Ngay_sinh; set => Ngay_sinh = value; }
    }
}
