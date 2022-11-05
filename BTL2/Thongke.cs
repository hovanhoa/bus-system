using BTL2.BUS;
using BTL2.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL2
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        void Populate_cbx_Ma_tuyenx()
        {
            DataTable dt = new DataTable();
            dt = B_ThongKe.GetAllTuyen();
            cbx_Ma_tuyen.ValueMember = "Ma_tuyen";
            cbx_Ma_tuyen.DisplayMember = "Ma_tuyen";
            DataRow topItem = dt.NewRow();
            //topItem[0] = 0;
            topItem[0] = "-Select-";
            dt.Rows.InsertAt(topItem, 0);
            cbx_Ma_tuyen.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tu_ngay = dtpTuNgay.Value;
            DateTime den_ngay = dtpDenNgay.Value;
            string ma_tuyen = cbx_Ma_tuyen.Text;

            ThongKe tk = new ThongKe(ma_tuyen,tu_ngay,den_ngay);
            dgvThongKe.DataSource= B_ThongKe.GetData(tk);
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            Populate_cbx_Ma_tuyenx();
        }

    }
}
