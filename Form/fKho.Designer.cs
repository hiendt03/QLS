namespace QLS
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.label_Loi = new System.Windows.Forms.Label();
            this.lblSuaSach = new System.Windows.Forms.Label();
            this.lblChonSach = new System.Windows.Forms.Label();
            this.dgvChonSach = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChonSua = new System.Windows.Forms.Button();
            this.txbMaSachSua = new System.Windows.Forms.TextBox();
            this.Sua_numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongSua = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.lblMaSach_Sua = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChonThem = new System.Windows.Forms.Button();
            this.txbMaSachThem = new System.Windows.Forms.TextBox();
            this.Nhap_numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongThem = new System.Windows.Forms.Label();
            this.bThemKho = new System.Windows.Forms.Button();
            this.txMaSach_Them = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel_Bottom.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sua_numericUpDownSoLuong)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nhap_numericUpDownSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Bottom.Controls.Add(this.label_Loi);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 550);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(850, 50);
            this.panel_Bottom.TabIndex = 26;
            // 
            // label_Loi
            // 
            this.label_Loi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Loi.AutoSize = true;
            this.label_Loi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi.Location = new System.Drawing.Point(12, 17);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(0, 15);
            this.label_Loi.TabIndex = 23;
            // 
            // lblSuaSach
            // 
            this.lblSuaSach.AutoSize = true;
            this.lblSuaSach.BackColor = System.Drawing.Color.Transparent;
            this.lblSuaSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSuaSach.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSuaSach.Location = new System.Drawing.Point(3, 268);
            this.lblSuaSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuaSach.Name = "lblSuaSach";
            this.lblSuaSach.Size = new System.Drawing.Size(93, 19);
            this.lblSuaSach.TabIndex = 49;
            this.lblSuaSach.Text = "SỬA SÁCH";
            // 
            // lblChonSach
            // 
            this.lblChonSach.AutoSize = true;
            this.lblChonSach.BackColor = System.Drawing.Color.Transparent;
            this.lblChonSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblChonSach.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblChonSach.Location = new System.Drawing.Point(11, 9);
            this.lblChonSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChonSach.Name = "lblChonSach";
            this.lblChonSach.Size = new System.Drawing.Size(107, 19);
            this.lblChonSach.TabIndex = 48;
            this.lblChonSach.Text = "CHỌN SÁCH";
            // 
            // dgvChonSach
            // 
            this.dgvChonSach.BackColor = System.Drawing.SystemColors.Info;
            this.dgvChonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvChonSach.HideSelection = false;
            this.dgvChonSach.Location = new System.Drawing.Point(12, 30);
            this.dgvChonSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChonSach.Name = "dgvChonSach";
            this.dgvChonSach.Size = new System.Drawing.Size(827, 109);
            this.dgvChonSach.TabIndex = 47;
            this.dgvChonSach.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChonSua);
            this.panel3.Controls.Add(this.txbMaSachSua);
            this.panel3.Controls.Add(this.Sua_numericUpDownSoLuong);
            this.panel3.Controls.Add(this.lblSoLuongSua);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnXoaSach);
            this.panel3.Controls.Add(this.lblMaSach_Sua);
            this.panel3.Location = new System.Drawing.Point(11, 400);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(828, 136);
            this.panel3.TabIndex = 46;
            // 
            // btnChonSua
            // 
            this.btnChonSua.Location = new System.Drawing.Point(689, 15);
            this.btnChonSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonSua.Name = "btnChonSua";
            this.btnChonSua.Size = new System.Drawing.Size(126, 32);
            this.btnChonSua.TabIndex = 25;
            this.btnChonSua.Text = "CHỌN SỬA";
            this.btnChonSua.UseVisualStyleBackColor = true;
            this.btnChonSua.Click += new System.EventHandler(this.bChon_Click);
            // 
            // txbMaSachSua
            // 
            this.txbMaSachSua.Location = new System.Drawing.Point(91, 49);
            this.txbMaSachSua.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaSachSua.Name = "txbMaSachSua";
            this.txbMaSachSua.ReadOnly = true;
            this.txbMaSachSua.Size = new System.Drawing.Size(108, 20);
            this.txbMaSachSua.TabIndex = 19;
            // 
            // Sua_numericUpDownSoLuong
            // 
            this.Sua_numericUpDownSoLuong.Location = new System.Drawing.Point(91, 72);
            this.Sua_numericUpDownSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.Sua_numericUpDownSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Sua_numericUpDownSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sua_numericUpDownSoLuong.Name = "Sua_numericUpDownSoLuong";
            this.Sua_numericUpDownSoLuong.Size = new System.Drawing.Size(108, 20);
            this.Sua_numericUpDownSoLuong.TabIndex = 18;
            this.Sua_numericUpDownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuongSua
            // 
            this.lblSoLuongSua.AutoSize = true;
            this.lblSoLuongSua.Location = new System.Drawing.Point(8, 77);
            this.lblSoLuongSua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongSua.Name = "lblSoLuongSua";
            this.lblSoLuongSua.Size = new System.Drawing.Size(66, 13);
            this.lblSoLuongSua.TabIndex = 17;
            this.lblSoLuongSua.Text = "SỐ LƯỢNG:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(689, 87);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 32);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.bLuu_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(689, 51);
            this.btnXoaSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(126, 32);
            this.btnXoaSach.TabIndex = 14;
            this.btnXoaSach.Text = "XÓA SÁCH ";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.bXoaSach_Click);
            // 
            // lblMaSach_Sua
            // 
            this.lblMaSach_Sua.AutoSize = true;
            this.lblMaSach_Sua.Location = new System.Drawing.Point(8, 53);
            this.lblMaSach_Sua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSach_Sua.Name = "lblMaSach_Sua";
            this.lblMaSach_Sua.Size = new System.Drawing.Size(58, 13);
            this.lblMaSach_Sua.TabIndex = 0;
            this.lblMaSach_Sua.Text = "MÃ SÁCH:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChonThem);
            this.panel4.Controls.Add(this.txbMaSachThem);
            this.panel4.Controls.Add(this.Nhap_numericUpDownSoLuong);
            this.panel4.Controls.Add(this.lblSoLuongThem);
            this.panel4.Controls.Add(this.bThemKho);
            this.panel4.Controls.Add(this.txMaSach_Them);
            this.panel4.Location = new System.Drawing.Point(11, 143);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(828, 109);
            this.panel4.TabIndex = 45;
            // 
            // btnChonThem
            // 
            this.btnChonThem.Location = new System.Drawing.Point(689, 21);
            this.btnChonThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonThem.Name = "btnChonThem";
            this.btnChonThem.Size = new System.Drawing.Size(126, 32);
            this.btnChonThem.TabIndex = 26;
            this.btnChonThem.Text = "CHỌN THÊM";
            this.btnChonThem.UseVisualStyleBackColor = true;
            this.btnChonThem.Click += new System.EventHandler(this.bChonThem_Click);
            // 
            // txbMaSachThem
            // 
            this.txbMaSachThem.Location = new System.Drawing.Point(94, 26);
            this.txbMaSachThem.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaSachThem.Name = "txbMaSachThem";
            this.txbMaSachThem.ReadOnly = true;
            this.txbMaSachThem.Size = new System.Drawing.Size(103, 20);
            this.txbMaSachThem.TabIndex = 20;
            // 
            // Nhap_numericUpDownSoLuong
            // 
            this.Nhap_numericUpDownSoLuong.Location = new System.Drawing.Point(94, 61);
            this.Nhap_numericUpDownSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.Nhap_numericUpDownSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Nhap_numericUpDownSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nhap_numericUpDownSoLuong.Name = "Nhap_numericUpDownSoLuong";
            this.Nhap_numericUpDownSoLuong.Size = new System.Drawing.Size(103, 20);
            this.Nhap_numericUpDownSoLuong.TabIndex = 18;
            this.Nhap_numericUpDownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuongThem
            // 
            this.lblSoLuongThem.AutoSize = true;
            this.lblSoLuongThem.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuongThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoLuongThem.Location = new System.Drawing.Point(8, 64);
            this.lblSoLuongThem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongThem.Name = "lblSoLuongThem";
            this.lblSoLuongThem.Size = new System.Drawing.Size(68, 15);
            this.lblSoLuongThem.TabIndex = 17;
            this.lblSoLuongThem.Text = "SỐ LƯỢNG:";
            // 
            // bThemKho
            // 
            this.bThemKho.Location = new System.Drawing.Point(689, 57);
            this.bThemKho.Margin = new System.Windows.Forms.Padding(2);
            this.bThemKho.Name = "bThemKho";
            this.bThemKho.Size = new System.Drawing.Size(126, 32);
            this.bThemKho.TabIndex = 13;
            this.bThemKho.Text = "THÊM";
            this.bThemKho.UseVisualStyleBackColor = true;
            this.bThemKho.Click += new System.EventHandler(this.bThemKho_Click);
            // 
            // txMaSach_Them
            // 
            this.txMaSach_Them.AutoSize = true;
            this.txMaSach_Them.BackColor = System.Drawing.Color.Transparent;
            this.txMaSach_Them.Location = new System.Drawing.Point(8, 31);
            this.txMaSach_Them.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txMaSach_Them.Name = "txMaSach_Them";
            this.txMaSach_Them.Size = new System.Drawing.Size(58, 13);
            this.txMaSach_Them.TabIndex = 0;
            this.txMaSach_Them.Text = "MÃ SÁCH:";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 289);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(828, 107);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.lblSuaSach);
            this.Controls.Add(this.lblChonSach);
            this.Controls.Add(this.dgvChonSach);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHO";
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sua_numericUpDownSoLuong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nhap_numericUpDownSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Label label_Loi;
        private System.Windows.Forms.Label lblSuaSach;
        private System.Windows.Forms.Label lblChonSach;
        private System.Windows.Forms.ListView dgvChonSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChonSua;
        private System.Windows.Forms.TextBox txbMaSachSua;
        private System.Windows.Forms.NumericUpDown Sua_numericUpDownSoLuong;
        private System.Windows.Forms.Label lblSoLuongSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Label lblMaSach_Sua;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChonThem;
        private System.Windows.Forms.TextBox txbMaSachThem;
        private System.Windows.Forms.NumericUpDown Nhap_numericUpDownSoLuong;
        private System.Windows.Forms.Label lblSoLuongThem;
        private System.Windows.Forms.Button bThemKho;
        private System.Windows.Forms.Label txMaSach_Them;
        private System.Windows.Forms.ListView listView1;
    }
}