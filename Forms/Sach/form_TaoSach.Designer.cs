namespace QLS
{
    partial class form_TaoSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_TaoSach));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.label_Loi = new System.Windows.Forms.Label();
            this.textbox_GiaBia = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_GiaMua = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_NamXuatBan = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_TheLoai = new QLS.Toolbox_Custom.Textbox_Custom();
            this.button_Tao = new QLS.Toolbox_Custom.Button_Custom();
            this.textbox_TenSach = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_TacGia = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_NXB = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_MaSach = new QLS.Toolbox_Custom.Textbox_Custom();
            this.pictureBox_AnhDaiDien = new QLS.Toolbox_Custom.PictureBox_Custom();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel_Top.Controls.Add(this.label_Title);
            this.panel_Top.Controls.Add(this.pictureBox_Icon);
            this.panel_Top.Controls.Add(this.button_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(997, 37);
            this.panel_Top.TabIndex = 82;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(45, 10);
            this.label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(72, 18);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Tạo sách";
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Image = global::QLS.Properties.Resources.Icon;
            this.pictureBox_Icon.Location = new System.Drawing.Point(4, 2);
            this.pictureBox_Icon.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(33, 31);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Icon.TabIndex = 1;
            this.pictureBox_Icon.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.button_Close.IconColor = System.Drawing.Color.White;
            this.button_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Close.IconSize = 30;
            this.button_Close.Location = new System.Drawing.Point(957, 0);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(40, 37);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Loi
            // 
            this.label_Loi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Loi.AutoSize = true;
            this.label_Loi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi.Location = new System.Drawing.Point(350, 397);
            this.label_Loi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(42, 18);
            this.label_Loi.TabIndex = 83;
            this.label_Loi.Text = "Lỗi...";
            // 
            // textbox_GiaBia
            // 
            this.textbox_GiaBia.BackColor = System.Drawing.Color.White;
            this.textbox_GiaBia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_GiaBia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_GiaBia.BorderRadius = 0;
            this.textbox_GiaBia.BorderSize = 4;
            this.textbox_GiaBia.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_GiaBia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_GiaBia.IsPlaceHolder = true;
            this.textbox_GiaBia.Location = new System.Drawing.Point(679, 308);
            this.textbox_GiaBia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_GiaBia.Multiline = false;
            this.textbox_GiaBia.Name = "textbox_GiaBia";
            this.textbox_GiaBia.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_GiaBia.PasswordChar = false;
            this.textbox_GiaBia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_GiaBia.PlaceholderText = "Giá bìa";
            this.textbox_GiaBia.Size = new System.Drawing.Size(276, 40);
            this.textbox_GiaBia.TabIndex = 94;
            this.textbox_GiaBia.Texts = "";
            this.textbox_GiaBia.UnderlinedStyle = true;
            // 
            // textbox_GiaMua
            // 
            this.textbox_GiaMua.BackColor = System.Drawing.Color.White;
            this.textbox_GiaMua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_GiaMua.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_GiaMua.BorderRadius = 0;
            this.textbox_GiaMua.BorderSize = 4;
            this.textbox_GiaMua.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_GiaMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_GiaMua.IsPlaceHolder = true;
            this.textbox_GiaMua.Location = new System.Drawing.Point(353, 308);
            this.textbox_GiaMua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_GiaMua.Multiline = false;
            this.textbox_GiaMua.Name = "textbox_GiaMua";
            this.textbox_GiaMua.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_GiaMua.PasswordChar = false;
            this.textbox_GiaMua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_GiaMua.PlaceholderText = "Giá mua";
            this.textbox_GiaMua.Size = new System.Drawing.Size(276, 40);
            this.textbox_GiaMua.TabIndex = 93;
            this.textbox_GiaMua.Texts = "";
            this.textbox_GiaMua.UnderlinedStyle = true;
            // 
            // textbox_NamXuatBan
            // 
            this.textbox_NamXuatBan.BackColor = System.Drawing.Color.White;
            this.textbox_NamXuatBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_NamXuatBan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_NamXuatBan.BorderRadius = 0;
            this.textbox_NamXuatBan.BorderSize = 4;
            this.textbox_NamXuatBan.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_NamXuatBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_NamXuatBan.IsPlaceHolder = true;
            this.textbox_NamXuatBan.Location = new System.Drawing.Point(679, 228);
            this.textbox_NamXuatBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_NamXuatBan.Multiline = false;
            this.textbox_NamXuatBan.Name = "textbox_NamXuatBan";
            this.textbox_NamXuatBan.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_NamXuatBan.PasswordChar = false;
            this.textbox_NamXuatBan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_NamXuatBan.PlaceholderText = "Năm xuất bản";
            this.textbox_NamXuatBan.Size = new System.Drawing.Size(276, 40);
            this.textbox_NamXuatBan.TabIndex = 92;
            this.textbox_NamXuatBan.Texts = "";
            this.textbox_NamXuatBan.UnderlinedStyle = true;
            // 
            // textbox_TheLoai
            // 
            this.textbox_TheLoai.BackColor = System.Drawing.Color.White;
            this.textbox_TheLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_TheLoai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_TheLoai.BorderRadius = 0;
            this.textbox_TheLoai.BorderSize = 4;
            this.textbox_TheLoai.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_TheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_TheLoai.IsPlaceHolder = true;
            this.textbox_TheLoai.Location = new System.Drawing.Point(679, 152);
            this.textbox_TheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_TheLoai.Multiline = false;
            this.textbox_TheLoai.Name = "textbox_TheLoai";
            this.textbox_TheLoai.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_TheLoai.PasswordChar = false;
            this.textbox_TheLoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TheLoai.PlaceholderText = "Thể loại";
            this.textbox_TheLoai.Size = new System.Drawing.Size(276, 40);
            this.textbox_TheLoai.TabIndex = 91;
            this.textbox_TheLoai.Texts = "";
            this.textbox_TheLoai.UnderlinedStyle = true;
            // 
            // button_Tao
            // 
            this.button_Tao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Tao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Tao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Tao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Tao.BorderRadius = 5;
            this.button_Tao.BorderSize = 0;
            this.button_Tao.FlatAppearance.BorderSize = 0;
            this.button_Tao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Tao.ForeColor = System.Drawing.Color.White;
            this.button_Tao.Location = new System.Drawing.Point(848, 387);
            this.button_Tao.Margin = new System.Windows.Forms.Padding(4);
            this.button_Tao.Name = "button_Tao";
            this.button_Tao.Size = new System.Drawing.Size(107, 37);
            this.button_Tao.TabIndex = 84;
            this.button_Tao.Text = "Tạo";
            this.button_Tao.TextColor = System.Drawing.Color.White;
            this.button_Tao.UseVisualStyleBackColor = false;
            this.button_Tao.Click += new System.EventHandler(this.button_Tao_Click);
            // 
            // textbox_TenSach
            // 
            this.textbox_TenSach.BackColor = System.Drawing.Color.White;
            this.textbox_TenSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_TenSach.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_TenSach.BorderRadius = 0;
            this.textbox_TenSach.BorderSize = 4;
            this.textbox_TenSach.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_TenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_TenSach.IsPlaceHolder = true;
            this.textbox_TenSach.Location = new System.Drawing.Point(679, 84);
            this.textbox_TenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_TenSach.Multiline = false;
            this.textbox_TenSach.Name = "textbox_TenSach";
            this.textbox_TenSach.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_TenSach.PasswordChar = false;
            this.textbox_TenSach.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TenSach.PlaceholderText = "Tên sách";
            this.textbox_TenSach.Size = new System.Drawing.Size(276, 40);
            this.textbox_TenSach.TabIndex = 86;
            this.textbox_TenSach.Texts = "";
            this.textbox_TenSach.UnderlinedStyle = true;
            // 
            // textbox_TacGia
            // 
            this.textbox_TacGia.BackColor = System.Drawing.Color.White;
            this.textbox_TacGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_TacGia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_TacGia.BorderRadius = 0;
            this.textbox_TacGia.BorderSize = 4;
            this.textbox_TacGia.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_TacGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_TacGia.IsPlaceHolder = true;
            this.textbox_TacGia.Location = new System.Drawing.Point(353, 152);
            this.textbox_TacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_TacGia.Multiline = false;
            this.textbox_TacGia.Name = "textbox_TacGia";
            this.textbox_TacGia.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_TacGia.PasswordChar = false;
            this.textbox_TacGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TacGia.PlaceholderText = "Tác giả";
            this.textbox_TacGia.Size = new System.Drawing.Size(276, 40);
            this.textbox_TacGia.TabIndex = 87;
            this.textbox_TacGia.Texts = "";
            this.textbox_TacGia.UnderlinedStyle = true;
            // 
            // textbox_NXB
            // 
            this.textbox_NXB.BackColor = System.Drawing.Color.White;
            this.textbox_NXB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_NXB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_NXB.BorderRadius = 0;
            this.textbox_NXB.BorderSize = 4;
            this.textbox_NXB.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_NXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_NXB.IsPlaceHolder = true;
            this.textbox_NXB.Location = new System.Drawing.Point(353, 228);
            this.textbox_NXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_NXB.Multiline = false;
            this.textbox_NXB.Name = "textbox_NXB";
            this.textbox_NXB.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_NXB.PasswordChar = false;
            this.textbox_NXB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_NXB.PlaceholderText = "Nhà xuất bản";
            this.textbox_NXB.Size = new System.Drawing.Size(276, 40);
            this.textbox_NXB.TabIndex = 88;
            this.textbox_NXB.Texts = "";
            this.textbox_NXB.UnderlinedStyle = true;
            // 
            // textbox_MaSach
            // 
            this.textbox_MaSach.BackColor = System.Drawing.Color.White;
            this.textbox_MaSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_MaSach.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_MaSach.BorderRadius = 0;
            this.textbox_MaSach.BorderSize = 4;
            this.textbox_MaSach.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_MaSach.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textbox_MaSach.IsPlaceHolder = true;
            this.textbox_MaSach.Location = new System.Drawing.Point(353, 84);
            this.textbox_MaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_MaSach.Multiline = false;
            this.textbox_MaSach.Name = "textbox_MaSach";
            this.textbox_MaSach.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_MaSach.PasswordChar = false;
            this.textbox_MaSach.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_MaSach.PlaceholderText = "Mã sách";
            this.textbox_MaSach.Size = new System.Drawing.Size(276, 40);
            this.textbox_MaSach.TabIndex = 85;
            this.textbox_MaSach.Texts = "";
            this.textbox_MaSach.UnderlinedStyle = true;
            // 
            // pictureBox_AnhDaiDien
            // 
            this.pictureBox_AnhDaiDien.BackgroundImage = global::QLS.Properties.Resources.BG_Upload;
            this.pictureBox_AnhDaiDien.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBox_AnhDaiDien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.pictureBox_AnhDaiDien.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.pictureBox_AnhDaiDien.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBox_AnhDaiDien.BorderSize = 6;
            this.pictureBox_AnhDaiDien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_AnhDaiDien.GradientAngle = 50F;
            this.pictureBox_AnhDaiDien.Location = new System.Drawing.Point(23, 84);
            this.pictureBox_AnhDaiDien.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_AnhDaiDien.Name = "pictureBox_AnhDaiDien";
            this.pictureBox_AnhDaiDien.Size = new System.Drawing.Size(280, 280);
            this.pictureBox_AnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_AnhDaiDien.TabIndex = 89;
            this.pictureBox_AnhDaiDien.TabStop = false;
            this.pictureBox_AnhDaiDien.Click += new System.EventHandler(this.pictureBox_AnhDaiDien_Click);
            // 
            // form_TaoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 452);
            this.Controls.Add(this.textbox_GiaBia);
            this.Controls.Add(this.textbox_GiaMua);
            this.Controls.Add(this.textbox_NamXuatBan);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.label_Loi);
            this.Controls.Add(this.textbox_TheLoai);
            this.Controls.Add(this.button_Tao);
            this.Controls.Add(this.textbox_TenSach);
            this.Controls.Add(this.textbox_TacGia);
            this.Controls.Add(this.textbox_NXB);
            this.Controls.Add(this.textbox_MaSach);
            this.Controls.Add(this.pictureBox_AnhDaiDien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_TaoSach";
            this.Text = "form_TaoSach";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Close;
        private System.Windows.Forms.Label label_Loi;
        private Toolbox_Custom.Textbox_Custom textbox_TheLoai;
        private Toolbox_Custom.Button_Custom button_Tao;
        private Toolbox_Custom.Textbox_Custom textbox_TenSach;
        private Toolbox_Custom.Textbox_Custom textbox_TacGia;
        private Toolbox_Custom.Textbox_Custom textbox_NXB;
        private Toolbox_Custom.Textbox_Custom textbox_MaSach;
        public Toolbox_Custom.PictureBox_Custom pictureBox_AnhDaiDien;
        private Toolbox_Custom.Textbox_Custom textbox_NamXuatBan;
        private Toolbox_Custom.Textbox_Custom textbox_GiaMua;
        private Toolbox_Custom.Textbox_Custom textbox_GiaBia;
    }
}