using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DTO
{
    public class TuyenTauDien
    {
        private string Ma_tuyen;
        private string ten_tuyen;
        private int don_gia;
        private string Ma_tuyen_tau_xe;
        private int STT;

        public TuyenTauDien(string ma_tuyen, string ten_tuyen, int don_gia, string ma_tuyen_tau_xe, int sTT)
        {
            Ma_tuyen1 = ma_tuyen;
            this.Ten_tuyen = ten_tuyen;
            this.Don_gia = don_gia;
            Ma_tuyen_tau_xe1 = ma_tuyen_tau_xe;
            STT1 = sTT;
        }

        public string Ma_tuyen1 { get => Ma_tuyen; set => Ma_tuyen = value; }
        public string Ten_tuyen { get => ten_tuyen; set => ten_tuyen = value; }
        public int Don_gia { get => don_gia; set => don_gia = value; }
        public string Ma_tuyen_tau_xe1 { get => Ma_tuyen_tau_xe; set => Ma_tuyen_tau_xe = value; }
        public int STT1 { get => STT; set => STT = value; }
    }
}
