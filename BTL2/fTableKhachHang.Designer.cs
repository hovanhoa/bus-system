
namespace BTL2
{
    partial class fTableKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpDbirth = new System.Windows.Forms.DateTimePicker();
            this.lDbirth = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.lJob = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox_Female = new System.Windows.Forms.CheckBox();
            this.checkBox_Male = new System.Windows.Forms.CheckBox();
            this.lSex = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbSdt = new System.Windows.Forms.TextBox();
            this.lSdt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbCmnd = new System.Windows.Forms.TextBox();
            this.lCmnd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lMaKhachHang = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(919, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(663, 110);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(199, 65);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpDbirth);
            this.panel7.Controls.Add(this.lDbirth);
            this.panel7.Location = new System.Drawing.Point(613, 23);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(295, 52);
            this.panel7.TabIndex = 3;
            // 
            // dtpDbirth
            // 
            this.dtpDbirth.Checked = false;
            this.dtpDbirth.CustomFormat = "yyyy-MM-dd";
            this.dtpDbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDbirth.Location = new System.Drawing.Point(84, 15);
            this.dtpDbirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDbirth.MaxDate = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            this.dtpDbirth.Name = "dtpDbirth";
            this.dtpDbirth.ShowCheckBox = true;
            this.dtpDbirth.Size = new System.Drawing.Size(205, 22);
            this.dtpDbirth.TabIndex = 1;
            this.dtpDbirth.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            // 
            // lDbirth
            // 
            this.lDbirth.AutoSize = true;
            this.lDbirth.Location = new System.Drawing.Point(4, 18);
            this.lDbirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDbirth.Name = "lDbirth";
            this.lDbirth.Size = new System.Drawing.Size(71, 17);
            this.lDbirth.TabIndex = 0;
            this.lDbirth.Text = "Ngày sinh";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbEmail);
            this.panel6.Controls.Add(this.lEmail);
            this.panel6.Location = new System.Drawing.Point(311, 142);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 52);
            this.panel6.TabIndex = 3;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(121, 15);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(151, 22);
            this.txbEmail.TabIndex = 1;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(4, 18);
            this.lEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(42, 17);
            this.lEmail.TabIndex = 0;
            this.lEmail.Text = "Email";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbJob);
            this.panel5.Controls.Add(this.lJob);
            this.panel5.Location = new System.Drawing.Point(311, 82);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 52);
            this.panel5.TabIndex = 3;
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(121, 15);
            this.txbJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(151, 22);
            this.txbJob.TabIndex = 1;
            // 
            // lJob
            // 
            this.lJob.AutoSize = true;
            this.lJob.Location = new System.Drawing.Point(4, 18);
            this.lJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lJob.Name = "lJob";
            this.lJob.Size = new System.Drawing.Size(89, 17);
            this.lJob.TabIndex = 0;
            this.lJob.Text = "Nghề nghiệp";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBox_Female);
            this.panel4.Controls.Add(this.checkBox_Male);
            this.panel4.Controls.Add(this.lSex);
            this.panel4.Location = new System.Drawing.Point(311, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 52);
            this.panel4.TabIndex = 3;
            // 
            // checkBox_Female
            // 
            this.checkBox_Female.AutoSize = true;
            this.checkBox_Female.Location = new System.Drawing.Point(209, 17);
            this.checkBox_Female.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Female.Name = "checkBox_Female";
            this.checkBox_Female.Size = new System.Drawing.Size(48, 21);
            this.checkBox_Female.TabIndex = 2;
            this.checkBox_Female.Text = "Nữ";
            this.checkBox_Female.UseVisualStyleBackColor = true;
            this.checkBox_Female.CheckedChanged += new System.EventHandler(this.checkBox_Female_CheckedChanged);
            // 
            // checkBox_Male
            // 
            this.checkBox_Male.AutoSize = true;
            this.checkBox_Male.Location = new System.Drawing.Point(121, 17);
            this.checkBox_Male.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Male.Name = "checkBox_Male";
            this.checkBox_Male.Size = new System.Drawing.Size(59, 21);
            this.checkBox_Male.TabIndex = 1;
            this.checkBox_Male.Text = "Nam";
            this.checkBox_Male.UseVisualStyleBackColor = true;
            this.checkBox_Male.CheckedChanged += new System.EventHandler(this.checkBox_Male_CheckedChanged);
            // 
            // lSex
            // 
            this.lSex.AutoSize = true;
            this.lSex.Location = new System.Drawing.Point(4, 18);
            this.lSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(60, 17);
            this.lSex.TabIndex = 0;
            this.lSex.Text = "Giới tính";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbSdt);
            this.panel3.Controls.Add(this.lSdt);
            this.panel3.Location = new System.Drawing.Point(8, 142);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 52);
            this.panel3.TabIndex = 3;
            // 
            // txbSdt
            // 
            this.txbSdt.Location = new System.Drawing.Point(121, 15);
            this.txbSdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSdt.Name = "txbSdt";
            this.txbSdt.Size = new System.Drawing.Size(151, 22);
            this.txbSdt.TabIndex = 1;
            // 
            // lSdt
            // 
            this.lSdt.AutoSize = true;
            this.lSdt.Location = new System.Drawing.Point(4, 18);
            this.lSdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSdt.Name = "lSdt";
            this.lSdt.Size = new System.Drawing.Size(91, 17);
            this.lSdt.TabIndex = 0;
            this.lSdt.Text = "Số điện thoại";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbCmnd);
            this.panel2.Controls.Add(this.lCmnd);
            this.panel2.Location = new System.Drawing.Point(8, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 52);
            this.panel2.TabIndex = 3;
            // 
            // txbCmnd
            // 
            this.txbCmnd.Location = new System.Drawing.Point(121, 15);
            this.txbCmnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCmnd.Name = "txbCmnd";
            this.txbCmnd.Size = new System.Drawing.Size(151, 22);
            this.txbCmnd.TabIndex = 1;
            // 
            // lCmnd
            // 
            this.lCmnd.AutoSize = true;
            this.lCmnd.Location = new System.Drawing.Point(4, 18);
            this.lCmnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCmnd.Name = "lCmnd";
            this.lCmnd.Size = new System.Drawing.Size(89, 17);
            this.lCmnd.TabIndex = 0;
            this.lCmnd.Text = "CMND/CCCD";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.lMaKhachHang);
            this.panel1.Location = new System.Drawing.Point(8, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 52);
            this.panel1.TabIndex = 2;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(121, 15);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(151, 22);
            this.txbID.TabIndex = 1;
            // 
            // lMaKhachHang
            // 
            this.lMaKhachHang.AutoSize = true;
            this.lMaKhachHang.Location = new System.Drawing.Point(4, 18);
            this.lMaKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMaKhachHang.Name = "lMaKhachHang";
            this.lMaKhachHang.Size = new System.Drawing.Size(105, 17);
            this.lMaKhachHang.TabIndex = 0;
            this.lMaKhachHang.Text = "Mã khách hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(16, 244);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.Size = new System.Drawing.Size(919, 250);
            this.dgvKhachHang.TabIndex = 1;
            // 
            // fTableKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(951, 508);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fTableKhachHang";
            this.Text = "fTableKhachHang";
            this.Load += new System.EventHandler(this.fTableKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lMaKhachHang;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lDbirth;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.Label lJob;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lSex;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbSdt;
        private System.Windows.Forms.Label lSdt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbCmnd;
        private System.Windows.Forms.Label lCmnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDbirth;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.CheckBox checkBox_Female;
        private System.Windows.Forms.CheckBox checkBox_Male;
    }
}