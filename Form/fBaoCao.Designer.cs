
namespace QLS
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txbTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lblLoiNhuan = new System.Windows.Forms.Label();
            this.txbLoiNhuan = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 8);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(597, 265);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(9, 281);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(109, 13);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "TỔNG DOANH THU:";
            // 
            // txbTongDoanhThu
            // 
            this.txbTongDoanhThu.BackColor = System.Drawing.SystemColors.Control;
            this.txbTongDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txbTongDoanhThu.Location = new System.Drawing.Point(121, 280);
            this.txbTongDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.txbTongDoanhThu.Name = "txbTongDoanhThu";
            this.txbTongDoanhThu.Size = new System.Drawing.Size(162, 19);
            this.txbTongDoanhThu.TabIndex = 2;
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Location = new System.Drawing.Point(9, 306);
            this.lblLoiNhuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(69, 13);
            this.lblLoiNhuan.TabIndex = 3;
            this.lblLoiNhuan.Text = "LỢI NHUẬN:";
            // 
            // txbLoiNhuan
            // 
            this.txbLoiNhuan.BackColor = System.Drawing.SystemColors.Control;
            this.txbLoiNhuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLoiNhuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txbLoiNhuan.Location = new System.Drawing.Point(121, 304);
            this.txbLoiNhuan.Margin = new System.Windows.Forms.Padding(2);
            this.txbLoiNhuan.Name = "txbLoiNhuan";
            this.txbLoiNhuan.Size = new System.Drawing.Size(162, 19);
            this.txbLoiNhuan.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(508, 300);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 19);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 327);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txbLoiNhuan);
            this.Controls.Add(this.lblLoiNhuan);
            this.Controls.Add(this.txbTongDoanhThu);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txbTongDoanhThu;
        private System.Windows.Forms.Label lblLoiNhuan;
        private System.Windows.Forms.TextBox txbLoiNhuan;
        private System.Windows.Forms.Button btnThoat;
    }
}