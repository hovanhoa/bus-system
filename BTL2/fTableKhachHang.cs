using BTL2.BUS;
using BTL2.DTO;
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
    public partial class fTableKhachHang : Form
    {
        public fTableKhachHang()
        {
            InitializeComponent();
        }

        private void fTableKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = B_khach_hang.GetAllKhachHang();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string CMND = txbCmnd.Text;
            string job = txbJob.Text;
            string phone = txbSdt.Text;
            string Sex="";
            if (checkBox_Male.Checked) Sex = "M";
            if (checkBox_Female.Checked) Sex = "F";
            string email = txbEmail.Text;
            string dob = dtpDbirth.Text;
            if (dtpDbirth.Checked == false) dob = "";
            dgvKhachHang.DataSource = B_khach_hang.B_sreach(id, CMND, job, phone, Sex, email, dob);
        }

        private void checkBox_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Male.Checked == true) checkBox_Female.Checked = false;
        }

        private void checkBox_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Female.Checked == true) checkBox_Male.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
