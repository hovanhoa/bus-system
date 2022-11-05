using BTL2.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.BUS
{
    public class B_GaTram
    {
        public static DataTable GetGa()
        {
            return D_GaTram.getData_GA();
        }

        public static DataTable GetTRAM()
        {
            return D_GaTram.getData_TRAM();
        }
    }
}
