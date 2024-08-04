
namespace QLS
{
    partial class frmXoaTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaTacGia));
            this.fThoat = new System.Windows.Forms.Button();
            this.btnXoaTacGia = new System.Windows.Forms.Button();
            this.dgvXoaTacGia = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(468, 249);
            this.fThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(91, 19);
            this.fThoat.TabIndex = 17;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click_1);
            // 
            // btnXoaTacGia
            // 
            this.btnXoaTacGia.Location = new System.Drawing.Point(9, 249);
            this.btnXoaTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaTacGia.Name = "btnXoaTacGia";
            this.btnXoaTacGia.Size = new System.Drawing.Size(160, 19);
            this.btnXoaTacGia.TabIndex = 20;
            this.btnXoaTacGia.Text = "XÓA TÁC GIẢ";
            this.btnXoaTacGia.UseVisualStyleBackColor = true;
            this.btnXoaTacGia.Click += new System.EventHandler(this.bXoaTG_Click);
            // 
            // dgvXoaTacGia
            // 
            this.dgvXoaTacGia.HideSelection = false;
            this.dgvXoaTacGia.Location = new System.Drawing.Point(9, 8);
            this.dgvXoaTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvXoaTacGia.Name = "dgvXoaTacGia";
            this.dgvXoaTacGia.Size = new System.Drawing.Size(550, 239);
            this.dgvXoaTacGia.TabIndex = 19;
            this.dgvXoaTacGia.UseCompatibleStateImageBehavior = false;
            // 
            // frmXoaTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 276);
            this.Controls.Add(this.btnXoaTacGia);
            this.Controls.Add(this.dgvXoaTacGia);
            this.Controls.Add(this.fThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmXoaTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " XÓA TÁC GIẢ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Button btnXoaTacGia;
        private System.Windows.Forms.ListView dgvXoaTacGia;
    }
}