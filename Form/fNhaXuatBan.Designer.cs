
namespace QLS
{
    partial class frmNhaXuatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaXuatBan));
            this.dgvNhaXuatBan = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbThemNXB = new System.Windows.Forms.TextBox();
            this.lblThemNXB = new System.Windows.Forms.Label();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboXoaNXB = new System.Windows.Forms.ComboBox();
            this.lblXoaNXB = new System.Windows.Forms.Label();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhaXuatBan
            // 
            this.dgvNhaXuatBan.HideSelection = false;
            this.dgvNhaXuatBan.Location = new System.Drawing.Point(8, 8);
            this.dgvNhaXuatBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNhaXuatBan.Name = "dgvNhaXuatBan";
            this.dgvNhaXuatBan.Size = new System.Drawing.Size(481, 144);
            this.dgvNhaXuatBan.TabIndex = 17;
            this.dgvNhaXuatBan.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbThemNXB);
            this.panel1.Controls.Add(this.lblThemNXB);
            this.panel1.Controls.Add(this.btnThemNXB);
            this.panel1.Location = new System.Drawing.Point(8, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 45);
            this.panel1.TabIndex = 18;
            // 
            // txbThemNXB
            // 
            this.txbThemNXB.Location = new System.Drawing.Point(115, 7);
            this.txbThemNXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbThemNXB.Name = "txbThemNXB";
            this.txbThemNXB.Size = new System.Drawing.Size(243, 20);
            this.txbThemNXB.TabIndex = 1;
            // 
            // lblThemNXB
            // 
            this.lblThemNXB.AutoSize = true;
            this.lblThemNXB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblThemNXB.Location = new System.Drawing.Point(2, 7);
            this.lblThemNXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThemNXB.Name = "lblThemNXB";
            this.lblThemNXB.Size = new System.Drawing.Size(88, 21);
            this.lblThemNXB.TabIndex = 0;
            this.lblThemNXB.Text = "THÊM NXB:";
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(374, 6);
            this.btnThemNXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(91, 19);
            this.btnThemNXB.TabIndex = 13;
            this.btnThemNXB.Text = "THÊM";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            this.btnThemNXB.Click += new System.EventHandler(this.bThemNXB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboXoaNXB);
            this.panel2.Controls.Add(this.lblXoaNXB);
            this.panel2.Controls.Add(this.btnXoaNXB);
            this.panel2.Location = new System.Drawing.Point(8, 203);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 45);
            this.panel2.TabIndex = 19;
            // 
            // cboXoaNXB
            // 
            this.cboXoaNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXoaNXB.FormattingEnabled = true;
            this.cboXoaNXB.Location = new System.Drawing.Point(115, 6);
            this.cboXoaNXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboXoaNXB.Name = "cboXoaNXB";
            this.cboXoaNXB.Size = new System.Drawing.Size(244, 21);
            this.cboXoaNXB.TabIndex = 15;
            // 
            // lblXoaNXB
            // 
            this.lblXoaNXB.AutoSize = true;
            this.lblXoaNXB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblXoaNXB.Location = new System.Drawing.Point(2, 6);
            this.lblXoaNXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXoaNXB.Name = "lblXoaNXB";
            this.lblXoaNXB.Size = new System.Drawing.Size(78, 21);
            this.lblXoaNXB.TabIndex = 0;
            this.lblXoaNXB.Text = "XÓA NXB:";
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.Location = new System.Drawing.Point(374, 6);
            this.btnXoaNXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(91, 19);
            this.btnXoaNXB.TabIndex = 14;
            this.btnXoaNXB.Text = "XÓA";
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            this.btnXoaNXB.Click += new System.EventHandler(this.bXoaNXB_Click);
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 253);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNhaXuatBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÀ XUẤT BẢN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dgvNhaXuatBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbThemNXB;
        private System.Windows.Forms.Label lblThemNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboXoaNXB;
        private System.Windows.Forms.Label lblXoaNXB;
        private System.Windows.Forms.Button btnXoaNXB;
    }
}