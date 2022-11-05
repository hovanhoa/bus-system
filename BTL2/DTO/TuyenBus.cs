using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DTO
{
    public class TuyenBus
    {
        private int No;
        private string Ma_tuyen_tau_xe;
        private int STT;

        public TuyenBus(int no, string ma_tuyen_tau_xe, int sTT)
        {
            No1 = no;
            Ma_tuyen_tau_xe1 = ma_tuyen_tau_xe;
            STT1 = sTT;
        }

        public int No1 { get => No; set => No = value; }
        public string Ma_tuyen_tau_xe1 { get => Ma_tuyen_tau_xe; set => Ma_tuyen_tau_xe = value; }
        public int STT1 { get => STT; set => STT = value; }
    }
}
