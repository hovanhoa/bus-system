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
    public partial class fTableTauXe : Form
    {
        public fTableTauXe()
        {
            InitializeComponent();
            btnBus.BackColor = Color.LightBlue;
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("Ma_ga_tram", typeof(string));
            table.Columns.Add("STT_", typeof(int));
            table.Columns.Add("Gio_ghe", typeof(string));
            table.Columns.Add("Gio_di", typeof(string));
        }
        DataTable dtbl = new DataTable();
        DataTable table = new DataTable();
        private bool btnBusWasClicked = true;
        private bool btnTauWasClicked = false;
        void PopulateMa_ga_tramcbx()
        {


            if (btnBusWasClicked)
            {
                dtbl.Clear();
                comboBox_Magatram.ValueMember = "Ma_ga_tram";
                comboBox_Magatram.DisplayMember = "Ma_ga_tram";
                dtbl = B_GaTram.GetTRAM();
                DataRow topItem = dtbl.NewRow();
                //topItem[0] = 0;
                topItem[0] = "-Select-";
                dtbl.Rows.InsertAt(topItem, 0);
                comboBox_Magatram.DataSource = dtbl;
            }
            else
            {
                dtbl.Clear();
                comboBox_Magatram.ValueMember = "Ma_ga_tram";
                comboBox_Magatram.DisplayMember = "Ma_ga_tram";
                dtbl = B_GaTram.GetGa();
                DataRow topItem = dtbl.NewRow();
                //topItem[0] = 0;
                topItem[0] = "-Select-";
                dtbl.Rows.InsertAt(topItem, 0);
                comboBox_Magatram.DataSource = dtbl;
            }


        }

        public void LoadTuyenTau()
        {
            btnTau.BackColor = Color.LightBlue;
            btnBus.BackColor = Color.LightGray;
            btnBusWasClicked = false;
            btnTauWasClicked = true;
            panelBus.Hide();
            panelTau.Show();
            dgvTauXe.Show();
            dgvTuyenBus.Hide();
            PopulateMa_ga_tramcbx();
            dgvTauXe.DataSource = B_TuyenTauDien.GetAllTuyenTauDien();
        }

        public void LoadTuyenBus()
        {
            btnBus.BackColor = Color.LightBlue;
            btnTau.BackColor = Color.LightGray;
            btnBusWasClicked = true;
            btnTauWasClicked = false;
            panelTau.Hide();
            panelBus.Show();
            dgvTauXe.Hide();
            dgvTuyenBus.Show();
            PopulateMa_ga_tramcbx();
            dgvTuyenBus.DataSource = B_TuyenBus.GetAllTuyenBus();
        }

        private void btnTau_Click(object sender, EventArgs e)
        {
            LoadTuyenTau();
            table.Clear();
            dgvGhe.DataSource = table;
        }
        
        private void btnBus_Click(object sender, EventArgs e)
        {

            LoadTuyenBus();
            table.Clear();
            dgvGhe.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                string ma_tuyen = txbMaTuyen.Text;
                int stt = int.Parse(txbSTT.Text);
                string ma_ga_tram = comboBox_Magatram.Text;
                int stt_ga_tram = int.Parse(txbSTT_tramdung.Text);
                string gio_ghe = dtpGioDen.Text;
                string gio_di = dtpGioDi.Text;
                if (btnTauWasClicked)
                {
                    string ma_tuyen_tau = txbMaTuyenTau.Text;
                    string ten_tuyen = txbTenTuyenTau.Text;
                    int don_gia = int.Parse(txbGia.Text);

                    TuyenTauDien t = new TuyenTauDien(ma_tuyen_tau, ten_tuyen, don_gia, ma_tuyen, stt);
                    B_TuyenTauDien.Insert(t);
                    dgvTauXe.DataSource = B_TuyenTauDien.GetAllTuyenTauDien();
                }
                else
                {
                    int No = int.Parse(txbNo.Text);
                    TuyenBus t = new TuyenBus(No, ma_tuyen, stt);
                    B_TuyenBus.Insert(t);
                    dgvTuyenBus.DataSource = B_TuyenBus.GetAllTuyenBus();
                }
                foreach (DataRow row in table.Rows)
                {
                    //MessageBox.Show(row["Ma_ga_tram"].ToString());
                    Ghe g = new Ghe(row["Ma_ga_tram"].ToString(), int.Parse(row["STT_"].ToString()), row["Gio_ghe"].ToString(), row["Gio_di"].ToString());
                    B_Ghe.Insert(ma_tuyen, stt, g);
                }

                table.Clear();
                dgvGhe.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                table.Clear();
                dgvGhe.DataSource = table;
            }
            
        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {
                int stt = int.Parse(txbSTT.Text);
                string ma_ga_tram = comboBox_Magatram.Text;
                int stt_ga_tram = int.Parse(txbSTT_tramdung.Text);
                string gio_ghe = dtpGioDen.Text;
                string gio_di = dtpGioDi.Text;
                table.Rows.Add(stt, ma_ga_tram, stt_ga_tram, gio_ghe, gio_di);
                dgvGhe.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fTableTauXe_Load(object sender, EventArgs e)
        {
            LoadTuyenBus();
        }

        private void dgvTauXe_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvTauXe.Rows[e.RowIndex];
            string ma_tuyen = row.Cells[0].Value.ToString();
            dgvGhe.DataSource = B_Ghe.GetGhe(ma_tuyen);
        }

        private void dgvTuyenBus_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvTuyenBus.Rows[e.RowIndex];
            string ma_tuyen = row.Cells[0].Value.ToString();
            dgvGhe.DataSource = B_Ghe.GetGhe(ma_tuyen);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


/*try
{

}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}*/