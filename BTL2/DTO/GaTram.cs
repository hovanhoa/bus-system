using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DTO
{
    public class GaTram
    {
        string Ma_ga_tram;
        string Dia_chi;
        string varchar;
        int Ga_tram;
        string Ma_giao_lo_1;
        string Ma_giao_lo_2;

        public GaTram(string ma_ga_tram, string dia_chi, string varchar, int ga_tram, string ma_giao_lo_1, string ma_giao_lo_2)
        {
            Ma_ga_tram1 = ma_ga_tram;
            Dia_chi1 = dia_chi;
            this.Varchar = varchar;
            Ga_tram1 = ga_tram;
            Ma_giao_lo_11 = ma_giao_lo_1;
            Ma_giao_lo_21 = ma_giao_lo_2;
        }

        public string Ma_ga_tram1 { get => Ma_ga_tram; set => Ma_ga_tram = value; }
        public string Dia_chi1 { get => Dia_chi; set => Dia_chi = value; }
        public string Varchar { get => varchar; set => varchar = value; }
        public int Ga_tram1 { get => Ga_tram; set => Ga_tram = value; }
        public string Ma_giao_lo_11 { get => Ma_giao_lo_1; set => Ma_giao_lo_1 = value; }
        public string Ma_giao_lo_21 { get => Ma_giao_lo_2; set => Ma_giao_lo_2 = value; }
    }
}
