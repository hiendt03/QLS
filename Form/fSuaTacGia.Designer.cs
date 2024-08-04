
namespace QLS
{
    partial class frmSuaTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaTacGia));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMaTacGia = new System.Windows.Forms.TextBox();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txbTenTacGia = new System.Windows.Forms.TextBox();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.chkQueQuan = new System.Windows.Forms.CheckBox();
            this.txbQueQuan = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.chkNgaySinh = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.chkNgayMat = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_NgayMat = new System.Windows.Forms.DateTimePicker();
            this.lblNgayMat = new System.Windows.Forms.Label();
            this.dgvTacGia = new System.Windows.Forms.ListView();
            this.btnChon = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMaTacGia);
            this.panel2.Controls.Add(this.lblMaTacGia);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Location = new System.Drawing.Point(426, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 226);
            this.panel2.TabIndex = 3;
            // 
            // txbMaTacGia
            // 
            this.txbMaTacGia.Location = new System.Drawing.Point(109, 16);
            this.txbMaTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaTacGia.Name = "txbMaTacGia";
            this.txbMaTacGia.ReadOnly = true;
            this.txbMaTacGia.Size = new System.Drawing.Size(275, 20);
            this.txbMaTacGia.TabIndex = 2;
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.BackColor = System.Drawing.Color.Transparent;
            this.lblMaTacGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaTacGia.Location = new System.Drawing.Point(2, 15);
            this.lblMaTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(97, 21);
            this.lblMaTacGia.TabIndex = 0;
            this.lblMaTacGia.Text = "MÃ TÁC GIẢ:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(226, 182);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(146, 34);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.bbLuu_Click);
            // 
            // txbTenTacGia
            // 
            this.txbTenTacGia.Location = new System.Drawing.Point(535, 56);
            this.txbTenTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenTacGia.Name = "txbTenTacGia";
            this.txbTenTacGia.Size = new System.Drawing.Size(275, 20);
            this.txbTenTacGia.TabIndex = 1;
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.BackColor = System.Drawing.Color.Transparent;
            this.lblTenTacGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenTacGia.Location = new System.Drawing.Point(428, 55);
            this.lblTenTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(101, 21);
            this.lblTenTacGia.TabIndex = 0;
            this.lblTenTacGia.Text = "TÊN TÁC GIẢ:";
            // 
            // chkQueQuan
            // 
            this.chkQueQuan.AutoSize = true;
            this.chkQueQuan.BackColor = System.Drawing.Color.Transparent;
            this.chkQueQuan.Location = new System.Drawing.Point(737, 92);
            this.chkQueQuan.Margin = new System.Windows.Forms.Padding(2);
            this.chkQueQuan.Name = "chkQueQuan";
            this.chkQueQuan.Size = new System.Drawing.Size(75, 17);
            this.chkQueQuan.TabIndex = 12;
            this.chkQueQuan.Text = "CHƯA RÕ";
            this.chkQueQuan.UseVisualStyleBackColor = false;
            this.chkQueQuan.CheckedChanged += new System.EventHandler(this.checkBox_QueQuan_CheckedChanged);
            // 
            // txbQueQuan
            // 
            this.txbQueQuan.Location = new System.Drawing.Point(535, 90);
            this.txbQueQuan.Margin = new System.Windows.Forms.Padding(2);
            this.txbQueQuan.Name = "txbQueQuan";
            this.txbQueQuan.Size = new System.Drawing.Size(181, 20);
            this.txbQueQuan.TabIndex = 1;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.BackColor = System.Drawing.Color.Transparent;
            this.lblQueQuan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblQueQuan.Location = new System.Drawing.Point(428, 90);
            this.lblQueQuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(93, 21);
            this.lblQueQuan.TabIndex = 0;
            this.lblQueQuan.Text = "QUÊ QUÁN:";
            // 
            // chkNgaySinh
            // 
            this.chkNgaySinh.AutoSize = true;
            this.chkNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.chkNgaySinh.Location = new System.Drawing.Point(737, 129);
            this.chkNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.chkNgaySinh.Name = "chkNgaySinh";
            this.chkNgaySinh.Size = new System.Drawing.Size(75, 17);
            this.chkNgaySinh.TabIndex = 10;
            this.chkNgaySinh.Text = "CHƯA RÕ";
            this.chkNgaySinh.UseVisualStyleBackColor = false;
            this.chkNgaySinh.CheckedChanged += new System.EventHandler(this.checkBox_NgaySinh_CheckedChanged);
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(535, 127);
            this.dateTimePicker_NgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker_NgaySinh.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgaySinh.Location = new System.Drawing.Point(428, 125);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(94, 21);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "NGÀY SINH:";
            // 
            // chkNgayMat
            // 
            this.chkNgayMat.AutoSize = true;
            this.chkNgayMat.BackColor = System.Drawing.Color.Transparent;
            this.chkNgayMat.Location = new System.Drawing.Point(737, 164);
            this.chkNgayMat.Margin = new System.Windows.Forms.Padding(2);
            this.chkNgayMat.Name = "chkNgayMat";
            this.chkNgayMat.Size = new System.Drawing.Size(75, 17);
            this.chkNgayMat.TabIndex = 11;
            this.chkNgayMat.Text = "CHƯA RÕ";
            this.chkNgayMat.UseVisualStyleBackColor = false;
            this.chkNgayMat.CheckedChanged += new System.EventHandler(this.checkBox_NgayMat_CheckedChanged);
            // 
            // dateTimePicker_NgayMat
            // 
            this.dateTimePicker_NgayMat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayMat.Location = new System.Drawing.Point(535, 162);
            this.dateTimePicker_NgayMat.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_NgayMat.Name = "dateTimePicker_NgayMat";
            this.dateTimePicker_NgayMat.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker_NgayMat.TabIndex = 9;
            // 
            // lblNgayMat
            // 
            this.lblNgayMat.AutoSize = true;
            this.lblNgayMat.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayMat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgayMat.Location = new System.Drawing.Point(428, 160);
            this.lblNgayMat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayMat.Name = "lblNgayMat";
            this.lblNgayMat.Size = new System.Drawing.Size(90, 21);
            this.lblNgayMat.TabIndex = 0;
            this.lblNgayMat.Text = "NGÀY MẤT:";
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.HideSelection = false;
            this.dgvTacGia.Location = new System.Drawing.Point(9, 8);
            this.dgvTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.Size = new System.Drawing.Size(403, 172);
            this.dgvTacGia.TabIndex = 17;
            this.dgvTacGia.UseCompatibleStateImageBehavior = false;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(314, 190);
            this.btnChon.Margin = new System.Windows.Forms.Padding(2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(98, 34);
            this.btnChon.TabIndex = 18;
            this.btnChon.Text = "CHỌN";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.bChon_Click);
            // 
            // frmSuaTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 245);
            this.Controls.Add(this.chkNgayMat);
            this.Controls.Add(this.chkNgaySinh);
            this.Controls.Add(this.dateTimePicker_NgayMat);
            this.Controls.Add(this.chkQueQuan);
            this.Controls.Add(this.lblNgayMat);
            this.Controls.Add(this.dateTimePicker_NgaySinh);
            this.Controls.Add(this.txbTenTacGia);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txbQueQuan);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.lblTenTacGia);
            this.Controls.Add(this.dgvTacGia);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSuaTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA TÁC GIẢ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMaTacGia;
        private System.Windows.Forms.TextBox txbTenTacGia;
        private System.Windows.Forms.Label lblTenTacGia;
        private System.Windows.Forms.TextBox txbQueQuan;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.CheckBox chkNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.CheckBox chkNgayMat;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayMat;
        private System.Windows.Forms.Label lblNgayMat;
        private System.Windows.Forms.ListView dgvTacGia;
        private System.Windows.Forms.TextBox txbMaTacGia;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.CheckBox chkQueQuan;
    }
}