namespace QLS
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.ListView();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.label_Loi = new System.Windows.Forms.Label();
            this.btnTimKiem = new QLS.Toolbox_Custom.Button_Custom();
            this.btnXuatBC = new QLS.Toolbox_Custom.Button_Custom();
            this.dateTimePicker_DenNgay = new QLS.DateTimePicker_Custom();
            this.dateTimePicker_TuNgay = new QLS.DateTimePicker_Custom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblTuNgay.Location = new System.Drawing.Point(2, 12);
            this.lblTuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(66, 19);
            this.lblTuNgay.TabIndex = 14;
            this.lblTuNgay.Text = "TỪ NGÀY";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker_TuNgay);
            this.panel1.Controls.Add(this.lblTuNgay);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 42);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker_DenNgay);
            this.panel2.Controls.Add(this.lblDenNgay);
            this.panel2.Location = new System.Drawing.Point(249, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 42);
            this.panel2.TabIndex = 17;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblDenNgay.Location = new System.Drawing.Point(2, 12);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(76, 19);
            this.lblDenNgay.TabIndex = 14;
            this.lblDenNgay.Text = "ĐẾN NGÀY";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.HideSelection = false;
            this.dgvThongKe.Location = new System.Drawing.Point(11, 57);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(828, 478);
            this.dgvThongKe.TabIndex = 21;
            this.dgvThongKe.UseCompatibleStateImageBehavior = false;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Bottom.Controls.Add(this.btnXuatBC);
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
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnTimKiem.BorderRadius = 5;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(728, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 43);
            this.btnTimKiem.TabIndex = 25;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.bTimKiem_Click);
            // 
            // btnXuatBC
            // 
            this.btnXuatBC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnXuatBC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnXuatBC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.btnXuatBC.BorderRadius = 5;
            this.btnXuatBC.BorderSize = 0;
            this.btnXuatBC.FlatAppearance.BorderSize = 0;
            this.btnXuatBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBC.ForeColor = System.Drawing.Color.White;
            this.btnXuatBC.Location = new System.Drawing.Point(737, 3);
            this.btnXuatBC.Name = "btnXuatBC";
            this.btnXuatBC.Size = new System.Drawing.Size(110, 44);
            this.btnXuatBC.TabIndex = 24;
            this.btnXuatBC.Text = "Xuất báo cáo";
            this.btnXuatBC.TextColor = System.Drawing.Color.White;
            this.btnXuatBC.UseVisualStyleBackColor = false;
            this.btnXuatBC.Click += new System.EventHandler(this.bXuatBC_Click);
            // 
            // dateTimePicker_DenNgay
            // 
            this.dateTimePicker_DenNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_DenNgay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker_DenNgay.BorderSize = 0;
            this.dateTimePicker_DenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTimePicker_DenNgay.Location = new System.Drawing.Point(88, 3);
            this.dateTimePicker_DenNgay.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker_DenNgay.Name = "dateTimePicker_DenNgay";
            this.dateTimePicker_DenNgay.Size = new System.Drawing.Size(153, 35);
            this.dateTimePicker_DenNgay.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.dateTimePicker_DenNgay.TabIndex = 15;
            this.dateTimePicker_DenNgay.TextColor = System.Drawing.Color.White;
            // 
            // dateTimePicker_TuNgay
            // 
            this.dateTimePicker_TuNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_TuNgay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker_TuNgay.BorderSize = 0;
            this.dateTimePicker_TuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTimePicker_TuNgay.Location = new System.Drawing.Point(71, 3);
            this.dateTimePicker_TuNgay.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker_TuNgay.Name = "dateTimePicker_TuNgay";
            this.dateTimePicker_TuNgay.Size = new System.Drawing.Size(154, 35);
            this.dateTimePicker_TuNgay.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.dateTimePicker_TuNgay.TabIndex = 15;
            this.dateTimePicker_TuNgay.TextColor = System.Drawing.Color.White;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.ListView dgvThongKe;
        private DateTimePicker_Custom dateTimePicker_TuNgay;
        private DateTimePicker_Custom dateTimePicker_DenNgay;
        private System.Windows.Forms.Panel panel_Bottom;
        private Toolbox_Custom.Button_Custom btnXuatBC;
        private System.Windows.Forms.Label label_Loi;
        private Toolbox_Custom.Button_Custom btnTimKiem;
    }
}