
namespace QLS
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.ListView();
            this.btnChonSua = new System.Windows.Forms.Button();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.txThemHD = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.ListView();
            this.txbMaHD = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.btnChonSach = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.dgvChonSach = new System.Windows.Forms.ListView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbTenKH_Sua = new System.Windows.Forms.TextBox();
            this.lblTenKH_Sua = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimePicker_Sua = new System.Windows.Forms.DateTimePicker();
            this.lblNgayLap_Sua = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblSuaHD = new System.Windows.Forms.Label();
            this.lblChonSach = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txbTenKhachHang = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThemHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThemHD.Location = new System.Drawing.Point(577, 373);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(220, 42);
            this.btnThemHD.TabIndex = 9;
            this.btnThemHD.Text = "HOÀN THÀNH HÓA ĐƠN";
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.bThemHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(176, 163);
            this.btnXoaHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(93, 19);
            this.btnXoaHD.TabIndex = 10;
            this.btnXoaHD.Text = "XÓA HÓA ĐƠN";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.bXoaHD_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvHoaDon.HideSelection = false;
            this.dgvHoaDon.Location = new System.Drawing.Point(9, 8);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(456, 151);
            this.dgvHoaDon.TabIndex = 19;
            this.dgvHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // btnChonSua
            // 
            this.btnChonSua.Location = new System.Drawing.Point(9, 163);
            this.btnChonSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChonSua.Name = "btnChonSua";
            this.btnChonSua.Size = new System.Drawing.Size(91, 19);
            this.btnChonSua.TabIndex = 26;
            this.btnChonSua.Text = "CHỌN SỬA";
            this.btnChonSua.UseVisualStyleBackColor = true;
            this.btnChonSua.Click += new System.EventHandler(this.bChonSua_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.BackColor = System.Drawing.SystemColors.Info;
            this.btnCTHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCTHD.Location = new System.Drawing.Point(295, 163);
            this.btnCTHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCTHD.Size = new System.Drawing.Size(169, 21);
            this.btnCTHD.TabIndex = 27;
            this.btnCTHD.Text = "CHI TIẾT HÓA ĐƠN\r\n\r\n";
            this.btnCTHD.UseVisualStyleBackColor = false;
            this.btnCTHD.Click += new System.EventHandler(this.bCTHD_Click);
            // 
            // txThemHD
            // 
            this.txThemHD.AutoSize = true;
            this.txThemHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txThemHD.Location = new System.Drawing.Point(7, 302);
            this.txThemHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txThemHD.Name = "txThemHD";
            this.txThemHD.Size = new System.Drawing.Size(127, 21);
            this.txThemHD.TabIndex = 28;
            this.txThemHD.Text = "THÊM HÓA ĐƠN";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.BackColor = System.Drawing.SystemColors.Info;
            this.dgvChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvChiTietHoaDon.HideSelection = false;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(491, 21);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(381, 138);
            this.dgvChiTietHoaDon.TabIndex = 33;
            this.dgvChiTietHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // txbMaHD
            // 
            this.txbMaHD.Location = new System.Drawing.Point(153, 5);
            this.txbMaHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.ReadOnly = true;
            this.txbMaHD.Size = new System.Drawing.Size(254, 20);
            this.txbMaHD.TabIndex = 36;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaSach.Location = new System.Drawing.Point(2, 5);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(124, 21);
            this.lblMaSach.TabIndex = 35;
            this.lblMaSach.Text = "* MÃ HÓA ĐƠN:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTenKH);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Location = new System.Drawing.Point(56, 352);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 22);
            this.panel1.TabIndex = 37;
            // 
            // txbTenKH
            // 
            this.txbTenKH.Location = new System.Drawing.Point(153, 2);
            this.txbTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(254, 20);
            this.txbTenKH.TabIndex = 1;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenKH.Location = new System.Drawing.Point(2, 1);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(155, 21);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "* TÊN KHÁCH HÀNG:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMaHD);
            this.panel2.Controls.Add(this.lblMaSach);
            this.panel2.Location = new System.Drawing.Point(56, 322);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 25);
            this.panel2.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker_NgayLap);
            this.panel4.Controls.Add(this.lblNgayLap);
            this.panel4.Location = new System.Drawing.Point(56, 380);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 23);
            this.panel4.TabIndex = 12;
            // 
            // dateTimePicker_NgayLap
            // 
            this.dateTimePicker_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayLap.Location = new System.Drawing.Point(153, 2);
            this.dateTimePicker_NgayLap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_NgayLap.Name = "dateTimePicker_NgayLap";
            this.dateTimePicker_NgayLap.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker_NgayLap.TabIndex = 9;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgayLap.Location = new System.Drawing.Point(2, 2);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(96, 21);
            this.lblNgayLap.TabIndex = 0;
            this.lblNgayLap.Text = "* NGÀY LẬP:";
            // 
            // btnChonSach
            // 
            this.btnChonSach.Location = new System.Drawing.Point(295, 2);
            this.btnChonSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChonSach.Name = "btnChonSach";
            this.btnChonSach.Size = new System.Drawing.Size(84, 19);
            this.btnChonSach.TabIndex = 40;
            this.btnChonSach.Text = "CHỌN";
            this.btnChonSach.UseVisualStyleBackColor = true;
            this.btnChonSach.Click += new System.EventHandler(this.bChonSach_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numericUpDownSoLuong);
            this.panel5.Controls.Add(this.lblSoLuong);
            this.panel5.Controls.Add(this.btnChonSach);
            this.panel5.Location = new System.Drawing.Point(491, 341);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(381, 25);
            this.panel5.TabIndex = 41;
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(86, 3);
            this.numericUpDownSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(126, 20);
            this.numericUpDownSoLuong.TabIndex = 41;
            this.numericUpDownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSoLuong.Location = new System.Drawing.Point(2, 2);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(92, 21);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "SỐ LƯỢNG:";
            // 
            // dgvChonSach
            // 
            this.dgvChonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvChonSach.HideSelection = false;
            this.dgvChonSach.Location = new System.Drawing.Point(491, 189);
            this.dgvChonSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChonSach.Name = "dgvChonSach";
            this.dgvChonSach.Size = new System.Drawing.Size(381, 146);
            this.dgvChonSach.TabIndex = 42;
            this.dgvChonSach.UseCompatibleStateImageBehavior = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbTenKH_Sua);
            this.panel7.Controls.Add(this.lblTenKH_Sua);
            this.panel7.Location = new System.Drawing.Point(53, 228);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(410, 21);
            this.panel7.TabIndex = 39;
            // 
            // txbTenKH_Sua
            // 
            this.txbTenKH_Sua.Location = new System.Drawing.Point(155, 1);
            this.txbTenKH_Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTenKH_Sua.Name = "txbTenKH_Sua";
            this.txbTenKH_Sua.Size = new System.Drawing.Size(252, 20);
            this.txbTenKH_Sua.TabIndex = 1;
            // 
            // lblTenKH_Sua
            // 
            this.lblTenKH_Sua.AutoSize = true;
            this.lblTenKH_Sua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenKH_Sua.Location = new System.Drawing.Point(2, 1);
            this.lblTenKH_Sua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKH_Sua.Name = "lblTenKH_Sua";
            this.lblTenKH_Sua.Size = new System.Drawing.Size(155, 21);
            this.lblTenKH_Sua.TabIndex = 0;
            this.lblTenKH_Sua.Text = "* TÊN KHÁCH HÀNG:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimePicker_Sua);
            this.panel6.Controls.Add(this.lblNgayLap_Sua);
            this.panel6.Controls.Add(this.btnLuu);
            this.panel6.Location = new System.Drawing.Point(53, 250);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(410, 27);
            this.panel6.TabIndex = 13;
            // 
            // dateTimePicker_Sua
            // 
            this.dateTimePicker_Sua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Sua.Location = new System.Drawing.Point(155, 4);
            this.dateTimePicker_Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_Sua.Name = "dateTimePicker_Sua";
            this.dateTimePicker_Sua.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker_Sua.TabIndex = 9;
            // 
            // lblNgayLap_Sua
            // 
            this.lblNgayLap_Sua.AutoSize = true;
            this.lblNgayLap_Sua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNgayLap_Sua.Location = new System.Drawing.Point(2, 3);
            this.lblNgayLap_Sua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayLap_Sua.Name = "lblNgayLap_Sua";
            this.lblNgayLap_Sua.Size = new System.Drawing.Size(93, 21);
            this.lblNgayLap_Sua.TabIndex = 0;
            this.lblNgayLap_Sua.Text = "* NGÀY LẬP";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(315, 3);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 18);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.bLuu_Click);
            // 
            // lblSuaHD
            // 
            this.lblSuaHD.AutoSize = true;
            this.lblSuaHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSuaHD.Location = new System.Drawing.Point(7, 208);
            this.lblSuaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuaHD.Name = "lblSuaHD";
            this.lblSuaHD.Size = new System.Drawing.Size(116, 21);
            this.lblSuaHD.TabIndex = 46;
            this.lblSuaHD.Text = "SỬA HÓA ĐƠN";
            // 
            // lblChonSach
            // 
            this.lblChonSach.AutoSize = true;
            this.lblChonSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblChonSach.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblChonSach.Location = new System.Drawing.Point(491, 172);
            this.lblChonSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChonSach.Name = "lblChonSach";
            this.lblChonSach.Size = new System.Drawing.Size(107, 19);
            this.lblChonSach.TabIndex = 47;
            this.lblChonSach.Text = "CHỌN SÁCH";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenKhachHang.Location = new System.Drawing.Point(491, 6);
            this.lblTenKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(112, 15);
            this.lblTenKhachHang.TabIndex = 48;
            this.lblTenKhachHang.Text = "TÊN KHÁCH HÀNG:";
            // 
            // txbTenKhachHang
            // 
            this.txbTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txbTenKhachHang.Location = new System.Drawing.Point(593, 4);
            this.txbTenKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTenKhachHang.Name = "txbTenKhachHang";
            this.txbTenKhachHang.ReadOnly = true;
            this.txbTenKhachHang.Size = new System.Drawing.Size(250, 16);
            this.txbTenKhachHang.TabIndex = 49;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 425);
            this.Controls.Add(this.txbTenKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblChonSach);
            this.Controls.Add(this.lblSuaHD);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgvChonSach);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.txThemHD);
            this.Controls.Add(this.btnCTHD);
            this.Controls.Add(this.btnChonSua);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnThemHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.ListView dgvHoaDon;
        private System.Windows.Forms.Button btnChonSua;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.Label txThemHD;
        private System.Windows.Forms.ListView dgvChiTietHoaDon;
        private System.Windows.Forms.TextBox txbMaHD;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayLap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Button btnChonSach;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.ListView dgvChonSach;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbTenKH_Sua;
        private System.Windows.Forms.Label lblTenKH_Sua;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Sua;
        private System.Windows.Forms.Label lblNgayLap_Sua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblSuaHD;
        private System.Windows.Forms.Label lblChonSach;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txbTenKhachHang;
    }
}