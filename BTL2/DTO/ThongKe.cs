using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DTO
{
    public class ThongKe
    {
        private string Ma_tuyen;
        private DateTime TuNgay;//yyyy-MM-dd
        private DateTime DenNgay;

        public ThongKe(string ma_tuyen, DateTime tuNgay, DateTime denNgay)
        {
            Ma_tuyen1 = ma_tuyen;
            TuNgay1 = tuNgay;
            DenNgay1 = denNgay;
        }

        public string Ma_tuyen1 { get => Ma_tuyen; set => Ma_tuyen = value; }
        public DateTime TuNgay1 { get => TuNgay; set => TuNgay = value; }
        public DateTime DenNgay1 { get => DenNgay; set => DenNgay = value; }
    }
}
