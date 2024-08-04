
using System.Windows.Forms;

namespace QLS
{
    partial class frmXoaSach
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaSach));
            this.btnXoa = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.dgvXoaSach = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(5, 253);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 19);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "XÓA SÁCH";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(480, 253);
            this.fThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(91, 19);
            this.fThoat.TabIndex = 14;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // dgvXoaSach
            // 
            this.dgvXoaSach.FullRowSelect = true;
            this.dgvXoaSach.GridLines = true;
            this.dgvXoaSach.HideSelection = false;
            this.dgvXoaSach.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.dgvXoaSach.Location = new System.Drawing.Point(5, 3);
            this.dgvXoaSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvXoaSach.Name = "dgvXoaSach";
            this.dgvXoaSach.Size = new System.Drawing.Size(566, 248);
            this.dgvXoaSach.TabIndex = 15;
            this.dgvXoaSach.UseCompatibleStateImageBehavior = false;
            this.dgvXoaSach.View = System.Windows.Forms.View.Details;
            // 
            // frmXoaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 278);
            this.Controls.Add(this.dgvXoaSach);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.btnXoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmXoaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XÓA SÁCH";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.ListView dgvXoaSach;


    }
}