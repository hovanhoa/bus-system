using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DTO
{
    public class Ghe
    {
        
        string Ma_ga_tram;
        int STT_ ;
        string Gio_ghe;
        string Gio_di;

        public Ghe(string ma_ga_tram, int sTT_, string gio_ghe, string gio_di)
        {
            Ma_ga_tram1 = ma_ga_tram;
            STT_1 = sTT_;
            Gio_ghe1 = gio_ghe;
            Gio_di1 = gio_di;
        }

        public string Ma_ga_tram1 { get => Ma_ga_tram; set => Ma_ga_tram = value; }
        public int STT_1 { get => STT_; set => STT_ = value; }
        public string Gio_ghe1 { get => Gio_ghe; set => Gio_ghe = value; }
        public string Gio_di1 { get => Gio_di; set => Gio_di = value; }
    }
}
