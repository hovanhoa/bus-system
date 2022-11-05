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
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            SetColorButton(0, 1, 0, 0);
            fTableKhachHang k = new fTableKhachHang();
            panel_show.Show();
            panel_show.Controls.Clear();
            k.TopLevel = false;
            k.Dock = DockStyle.Fill;
            panel_show.Controls.Add(k);
            k.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTuyen_Click(object sender, EventArgs e)
        {
            SetColorButton(0, 0, 1, 0);
            fTableTauXe t = new fTableTauXe();
            panel_show.Show();
            panel_show.Controls.Clear();
            t.TopLevel = false;
            t.Dock = DockStyle.Fill;
            panel_show.Controls.Add(t);
            t.Show();
        }
        private void SetColorButton(int a,int b, int c, int d)
        {
            if (a == 1) 
                btnIntro.BackColor = Color.LightBlue;
            else
                btnIntro.BackColor = Color.LightGray;

            if (b == 1) 
                btnKhachHang.BackColor = Color.LightBlue;
            else
                btnKhachHang.BackColor = Color.LightGray;

            if (c == 1)
                btnTuyen.BackColor = Color.LightBlue;
            else 
                btnTuyen.BackColor = Color.LightGray;

            if (d == 1) 
                btnThongKe.BackColor = Color.LightBlue;
            else 
                btnThongKe.BackColor = Color.LightGray;
        }
        private void btnIntro_Click(object sender, EventArgs e)
        {
            SetColorButton(1, 0, 0, 0);
            introduce i = new introduce();
            panel_show.Show();
            panel_show.Controls.Clear();
            //i.TopLevel = false;
            i.Dock = DockStyle.Fill;
            panel_show.Controls.Add(i);
            i.Show();
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            btnIntro.BackColor = Color.LightBlue;
            introduce i = new introduce();
            panel_show.Show();
            panel_show.Controls.Clear();
            //i.TopLevel = false;
            i.Dock = DockStyle.Fill;
            panel_show.Controls.Add(i);
            i.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetColorButton(0, 0, 0, 1);
            Thongke t = new Thongke();
            panel_show.Show();
            panel_show.Controls.Clear();
            t.TopLevel = false;
            t.Dock = DockStyle.Fill;
            panel_show.Controls.Add(t);
            t.Show();
        }

        private void panel_show_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
