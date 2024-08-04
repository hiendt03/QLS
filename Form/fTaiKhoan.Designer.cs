
namespace QLS
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.lblMatKhauHienTai = new System.Windows.Forms.Label();
            this.txbMKMoi = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.txbMKMoiNhapLai = new System.Windows.Forms.TextBox();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.txbMKHienTai = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.ListView();
            this.btnChon = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMatKhauMoi.Location = new System.Drawing.Point(2, 79);
            this.lblMatKhauMoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(124, 21);
            this.lblMatKhauMoi.TabIndex = 0;
            this.lblMatKhauMoi.Text = "MẬT KHẨU MỚI:";
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNhapLai.Location = new System.Drawing.Point(2, 110);
            this.lblNhapLai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(81, 21);
            this.lblNhapLai.TabIndex = 0;
            this.lblNhapLai.Text = "NHẬP LẠI:";
            // 
            // lblMatKhauHienTai
            // 
            this.lblMatKhauHienTai.AutoSize = true;
            this.lblMatKhauHienTai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMatKhauHienTai.Location = new System.Drawing.Point(2, 48);
            this.lblMatKhauHienTai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhauHienTai.Name = "lblMatKhauHienTai";
            this.lblMatKhauHienTai.Size = new System.Drawing.Size(155, 21);
            this.lblMatKhauHienTai.TabIndex = 0;
            this.lblMatKhauHienTai.Text = "MẬT KHẨU HIỆN TẠI:";
            // 
            // txbMKMoi
            // 
            this.txbMKMoi.Location = new System.Drawing.Point(179, 79);
            this.txbMKMoi.Margin = new System.Windows.Forms.Padding(2);
            this.txbMKMoi.Name = "txbMKMoi";
            this.txbMKMoi.Size = new System.Drawing.Size(204, 20);
            this.txbMKMoi.TabIndex = 3;
            this.txbMKMoi.UseSystemPasswordChar = true;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenDangNhap.Location = new System.Drawing.Point(2, 15);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(135, 21);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "TÊN ĐĂNG NHẬP:";
            this.lblTenDangNhap.Click += new System.EventHandler(this.lblTenDangNhap1_Click);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(249, 145);
            this.btnCapNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(134, 36);
            this.btnCapNhap.TabIndex = 5;
            this.btnCapNhap.Text = "CẬP NHẬT";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.bCapNhap_Click);
            // 
            // txbMKMoiNhapLai
            // 
            this.txbMKMoiNhapLai.Location = new System.Drawing.Point(179, 111);
            this.txbMKMoiNhapLai.Margin = new System.Windows.Forms.Padding(2);
            this.txbMKMoiNhapLai.Name = "txbMKMoiNhapLai";
            this.txbMKMoiNhapLai.Size = new System.Drawing.Size(204, 20);
            this.txbMKMoiNhapLai.TabIndex = 4;
            this.txbMKMoiNhapLai.UseSystemPasswordChar = true;
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(179, 16);
            this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.ReadOnly = true;
            this.txbTenDangNhap.Size = new System.Drawing.Size(204, 20);
            this.txbTenDangNhap.TabIndex = 7;
            // 
            // txbMKHienTai
            // 
            this.txbMKHienTai.Location = new System.Drawing.Point(179, 49);
            this.txbMKHienTai.Margin = new System.Windows.Forms.Padding(2);
            this.txbMKHienTai.Name = "txbMKHienTai";
            this.txbMKHienTai.Size = new System.Drawing.Size(204, 20);
            this.txbMKHienTai.TabIndex = 3;
            this.txbMKHienTai.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMKHienTai);
            this.panel2.Controls.Add(this.txbTenDangNhap);
            this.panel2.Controls.Add(this.txbMKMoiNhapLai);
            this.panel2.Controls.Add(this.btnCapNhap);
            this.panel2.Controls.Add(this.lblTenDangNhap);
            this.panel2.Controls.Add(this.txbMKMoi);
            this.panel2.Controls.Add(this.lblMatKhauHienTai);
            this.panel2.Controls.Add(this.lblNhapLai);
            this.panel2.Controls.Add(this.lblMatKhauMoi);
            this.panel2.Location = new System.Drawing.Point(11, 263);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 197);
            this.panel2.TabIndex = 1;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.HideSelection = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(11, 11);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(400, 208);
            this.dgvTaiKhoan.TabIndex = 16;
            this.dgvTaiKhoan.UseCompatibleStateImageBehavior = false;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(312, 223);
            this.btnChon.Margin = new System.Windows.Forms.Padding(2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(99, 36);
            this.btnChon.TabIndex = 17;
            this.btnChon.Text = "CHỌN";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.bChon_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÀI KHOẢN";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.Label lblMatKhauHienTai;
        private System.Windows.Forms.TextBox txbMKMoi;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.TextBox txbMKMoiNhapLai;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.TextBox txbMKHienTai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView dgvTaiKhoan;
        private System.Windows.Forms.Button btnChon;
    }
}