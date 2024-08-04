
namespace QLS
{
    partial class frmLoaiSach
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
            this.dgvLoaiSach = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbThemLoaiSach = new System.Windows.Forms.TextBox();
            this.lblThemLoaiSach = new System.Windows.Forms.Label();
            this.btnThemLoaiSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboXoaLoaiSach = new System.Windows.Forms.ComboBox();
            this.lblXoaLoaiSach = new System.Windows.Forms.Label();
            this.btnXoaLoaiSach = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoaiSach
            // 
            this.dgvLoaiSach.HideSelection = false;
            this.dgvLoaiSach.Location = new System.Drawing.Point(8, 8);
            this.dgvLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLoaiSach.Name = "dgvLoaiSach";
            this.dgvLoaiSach.Size = new System.Drawing.Size(481, 143);
            this.dgvLoaiSach.TabIndex = 16;
            this.dgvLoaiSach.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbThemLoaiSach);
            this.panel1.Controls.Add(this.lblThemLoaiSach);
            this.panel1.Controls.Add(this.btnThemLoaiSach);
            this.panel1.Location = new System.Drawing.Point(8, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 45);
            this.panel1.TabIndex = 17;
            // 
            // txbThemLoaiSach
            // 
            this.txbThemLoaiSach.Location = new System.Drawing.Point(136, 7);
            this.txbThemLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbThemLoaiSach.Name = "txbThemLoaiSach";
            this.txbThemLoaiSach.Size = new System.Drawing.Size(222, 20);
            this.txbThemLoaiSach.TabIndex = 1;
            // 
            // lblThemLoaiSach
            // 
            this.lblThemLoaiSach.AutoSize = true;
            this.lblThemLoaiSach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblThemLoaiSach.Location = new System.Drawing.Point(2, 7);
            this.lblThemLoaiSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThemLoaiSach.Name = "lblThemLoaiSach";
            this.lblThemLoaiSach.Size = new System.Drawing.Size(135, 21);
            this.lblThemLoaiSach.TabIndex = 0;
            this.lblThemLoaiSach.Text = "THÊM LOẠI SÁCH:";
            // 
            // btnThemLoaiSach
            // 
            this.btnThemLoaiSach.Location = new System.Drawing.Point(374, 6);
            this.btnThemLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemLoaiSach.Name = "btnThemLoaiSach";
            this.btnThemLoaiSach.Size = new System.Drawing.Size(91, 19);
            this.btnThemLoaiSach.TabIndex = 13;
            this.btnThemLoaiSach.Text = "THÊM";
            this.btnThemLoaiSach.UseVisualStyleBackColor = true;
            this.btnThemLoaiSach.Click += new System.EventHandler(this.bThemSach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboXoaLoaiSach);
            this.panel2.Controls.Add(this.lblXoaLoaiSach);
            this.panel2.Controls.Add(this.btnXoaLoaiSach);
            this.panel2.Location = new System.Drawing.Point(8, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 45);
            this.panel2.TabIndex = 18;
            // 
            // cboXoaLoaiSach
            // 
            this.cboXoaLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXoaLoaiSach.FormattingEnabled = true;
            this.cboXoaLoaiSach.Location = new System.Drawing.Point(136, 6);
            this.cboXoaLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboXoaLoaiSach.Name = "cboXoaLoaiSach";
            this.cboXoaLoaiSach.Size = new System.Drawing.Size(223, 21);
            this.cboXoaLoaiSach.TabIndex = 15;
            // 
            // lblXoaLoaiSach
            // 
            this.lblXoaLoaiSach.AutoSize = true;
            this.lblXoaLoaiSach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblXoaLoaiSach.Location = new System.Drawing.Point(2, 6);
            this.lblXoaLoaiSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXoaLoaiSach.Name = "lblXoaLoaiSach";
            this.lblXoaLoaiSach.Size = new System.Drawing.Size(125, 21);
            this.lblXoaLoaiSach.TabIndex = 0;
            this.lblXoaLoaiSach.Text = "XÓA LOẠI SÁCH:";
            // 
            // btnXoaLoaiSach
            // 
            this.btnXoaLoaiSach.Location = new System.Drawing.Point(374, 6);
            this.btnXoaLoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaLoaiSach.Name = "btnXoaLoaiSach";
            this.btnXoaLoaiSach.Size = new System.Drawing.Size(91, 19);
            this.btnXoaLoaiSach.TabIndex = 14;
            this.btnXoaLoaiSach.Text = "XÓA";
            this.btnXoaLoaiSach.UseVisualStyleBackColor = true;
            this.btnXoaLoaiSach.Click += new System.EventHandler(this.bXoaSach_Click);
            // 
            // frmLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 255);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLoaiSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI SÁCH";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dgvLoaiSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbThemLoaiSach;
        private System.Windows.Forms.Label lblThemLoaiSach;
        private System.Windows.Forms.Button btnThemLoaiSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboXoaLoaiSach;
        private System.Windows.Forms.Label lblXoaLoaiSach;
        private System.Windows.Forms.Button btnXoaLoaiSach;
    }
}