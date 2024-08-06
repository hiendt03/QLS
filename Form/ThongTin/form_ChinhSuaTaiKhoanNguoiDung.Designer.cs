
namespace QLS
{
    partial class form_ChinhSuaTaiKhoanNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ChinhSuaTaiKhoanNguoiDung));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.label_Loi = new System.Windows.Forms.Label();
            this.textbox_DienThoai = new QLS.Toolbox_Custom.Textbox_Custom();
            this.combobox_Role = new QLS.Combobox_Custom();
            this.button_ChinhSua = new QLS.Toolbox_Custom.Button_Custom();
            this.pictureBox_AnhDaiDien = new QLS.Toolbox_Custom.PictureBox_Custom();
            this.textbox_MatKhau = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_HoVaTen = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_Note = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_TaiKhoan = new QLS.Toolbox_Custom.Textbox_Custom();
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
            this.label_Title.Size = new System.Drawing.Size(193, 18);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Sửa tài khoản người dùng";
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
            this.label_Loi.Location = new System.Drawing.Point(351, 301);
            this.label_Loi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(42, 18);
            this.label_Loi.TabIndex = 83;
            this.label_Loi.Text = "Lỗi...";
            // 
            // textbox_DienThoai
            // 
            this.textbox_DienThoai.BackColor = System.Drawing.Color.White;
            this.textbox_DienThoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_DienThoai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_DienThoai.BorderRadius = 0;
            this.textbox_DienThoai.BorderSize = 4;
            this.textbox_DienThoai.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_DienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_DienThoai.IsPlaceHolder = true;
            this.textbox_DienThoai.Location = new System.Drawing.Point(680, 126);
            this.textbox_DienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_DienThoai.Multiline = false;
            this.textbox_DienThoai.Name = "textbox_DienThoai";
            this.textbox_DienThoai.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_DienThoai.PasswordChar = false;
            this.textbox_DienThoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_DienThoai.PlaceholderText = "Số điện thoại";
            this.textbox_DienThoai.Size = new System.Drawing.Size(276, 40);
            this.textbox_DienThoai.TabIndex = 91;
            this.textbox_DienThoai.Texts = "";
            this.textbox_DienThoai.UnderlinedStyle = true;
            // 
            // combobox_Role
            // 
            this.combobox_Role.BackColor = System.Drawing.Color.White;
            this.combobox_Role.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.combobox_Role.BorderSize = 3;
            this.combobox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combobox_Role.Font = new System.Drawing.Font("Arial", 9.75F);
            this.combobox_Role.ForeColor = System.Drawing.Color.DarkGray;
            this.combobox_Role.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.combobox_Role.ListBackColor = System.Drawing.Color.White;
            this.combobox_Role.ListTextColor = System.Drawing.Color.Black;
            this.combobox_Role.Location = new System.Drawing.Point(680, 201);
            this.combobox_Role.Margin = new System.Windows.Forms.Padding(4);
            this.combobox_Role.MinimumSize = new System.Drawing.Size(228, 32);
            this.combobox_Role.Name = "combobox_Role";
            this.combobox_Role.Padding = new System.Windows.Forms.Padding(4);
            this.combobox_Role.Size = new System.Drawing.Size(276, 41);
            this.combobox_Role.TabIndex = 90;
            this.combobox_Role.Texts = "Phân quyền";
            // 
            // button_ChinhSua
            // 
            this.button_ChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_ChinhSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_ChinhSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_ChinhSua.BorderRadius = 5;
            this.button_ChinhSua.BorderSize = 0;
            this.button_ChinhSua.FlatAppearance.BorderSize = 0;
            this.button_ChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChinhSua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_ChinhSua.ForeColor = System.Drawing.Color.White;
            this.button_ChinhSua.Location = new System.Drawing.Point(849, 301);
            this.button_ChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.button_ChinhSua.Name = "button_ChinhSua";
            this.button_ChinhSua.Size = new System.Drawing.Size(107, 37);
            this.button_ChinhSua.TabIndex = 84;
            this.button_ChinhSua.Text = "Lưu";
            this.button_ChinhSua.TextColor = System.Drawing.Color.White;
            this.button_ChinhSua.UseVisualStyleBackColor = false;
            this.button_ChinhSua.Click += new System.EventHandler(this.button_ChinhSua_Click);
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
            this.pictureBox_AnhDaiDien.Location = new System.Drawing.Point(24, 58);
            this.pictureBox_AnhDaiDien.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_AnhDaiDien.Name = "pictureBox_AnhDaiDien";
            this.pictureBox_AnhDaiDien.Size = new System.Drawing.Size(280, 280);
            this.pictureBox_AnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_AnhDaiDien.TabIndex = 89;
            this.pictureBox_AnhDaiDien.TabStop = false;
            this.pictureBox_AnhDaiDien.Click += new System.EventHandler(this.pictureBox_AnhDaiDien_Click);
            // 
            // textbox_MatKhau
            // 
            this.textbox_MatKhau.BackColor = System.Drawing.Color.White;
            this.textbox_MatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_MatKhau.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_MatKhau.BorderRadius = 0;
            this.textbox_MatKhau.BorderSize = 4;
            this.textbox_MatKhau.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_MatKhau.IsPlaceHolder = true;
            this.textbox_MatKhau.Location = new System.Drawing.Point(680, 58);
            this.textbox_MatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_MatKhau.Multiline = false;
            this.textbox_MatKhau.Name = "textbox_MatKhau";
            this.textbox_MatKhau.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_MatKhau.PasswordChar = false;
            this.textbox_MatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_MatKhau.PlaceholderText = "Mật khẩu";
            this.textbox_MatKhau.Size = new System.Drawing.Size(276, 40);
            this.textbox_MatKhau.TabIndex = 86;
            this.textbox_MatKhau.Texts = "";
            this.textbox_MatKhau.UnderlinedStyle = true;
            // 
            // textbox_HoVaTen
            // 
            this.textbox_HoVaTen.BackColor = System.Drawing.Color.White;
            this.textbox_HoVaTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_HoVaTen.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_HoVaTen.BorderRadius = 0;
            this.textbox_HoVaTen.BorderSize = 4;
            this.textbox_HoVaTen.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_HoVaTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_HoVaTen.IsPlaceHolder = true;
            this.textbox_HoVaTen.Location = new System.Drawing.Point(354, 126);
            this.textbox_HoVaTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_HoVaTen.Multiline = false;
            this.textbox_HoVaTen.Name = "textbox_HoVaTen";
            this.textbox_HoVaTen.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_HoVaTen.PasswordChar = false;
            this.textbox_HoVaTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_HoVaTen.PlaceholderText = "Họ và tên";
            this.textbox_HoVaTen.Size = new System.Drawing.Size(276, 40);
            this.textbox_HoVaTen.TabIndex = 87;
            this.textbox_HoVaTen.Texts = "";
            this.textbox_HoVaTen.UnderlinedStyle = true;
            // 
            // textbox_Note
            // 
            this.textbox_Note.BackColor = System.Drawing.Color.White;
            this.textbox_Note.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_Note.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_Note.BorderRadius = 0;
            this.textbox_Note.BorderSize = 4;
            this.textbox_Note.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_Note.IsPlaceHolder = true;
            this.textbox_Note.Location = new System.Drawing.Point(354, 202);
            this.textbox_Note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_Note.Multiline = false;
            this.textbox_Note.Name = "textbox_Note";
            this.textbox_Note.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_Note.PasswordChar = false;
            this.textbox_Note.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_Note.PlaceholderText = "Ghi chú";
            this.textbox_Note.Size = new System.Drawing.Size(276, 40);
            this.textbox_Note.TabIndex = 88;
            this.textbox_Note.Texts = "";
            this.textbox_Note.UnderlinedStyle = true;
            // 
            // textbox_TaiKhoan
            // 
            this.textbox_TaiKhoan.BackColor = System.Drawing.Color.White;
            this.textbox_TaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_TaiKhoan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_TaiKhoan.BorderRadius = 0;
            this.textbox_TaiKhoan.BorderSize = 4;
            this.textbox_TaiKhoan.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_TaiKhoan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textbox_TaiKhoan.IsPlaceHolder = true;
            this.textbox_TaiKhoan.Location = new System.Drawing.Point(354, 58);
            this.textbox_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_TaiKhoan.Multiline = false;
            this.textbox_TaiKhoan.Name = "textbox_TaiKhoan";
            this.textbox_TaiKhoan.Padding = new System.Windows.Forms.Padding(12, 11, 12, 9);
            this.textbox_TaiKhoan.PasswordChar = false;
            this.textbox_TaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TaiKhoan.PlaceholderText = "Tài khoản";
            this.textbox_TaiKhoan.Size = new System.Drawing.Size(276, 40);
            this.textbox_TaiKhoan.TabIndex = 85;
            this.textbox_TaiKhoan.Texts = "";
            this.textbox_TaiKhoan.UnderlinedStyle = true;
            // 
            // form_ChinhSuaTaiKhoanNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 381);
            this.Controls.Add(this.textbox_DienThoai);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.label_Loi);
            this.Controls.Add(this.combobox_Role);
            this.Controls.Add(this.button_ChinhSua);
            this.Controls.Add(this.pictureBox_AnhDaiDien);
            this.Controls.Add(this.textbox_MatKhau);
            this.Controls.Add(this.textbox_HoVaTen);
            this.Controls.Add(this.textbox_Note);
            this.Controls.Add(this.textbox_TaiKhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1015, 788);
            this.Name = "form_ChinhSuaTaiKhoanNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa tài khoản người dùng";
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
        private Combobox_Custom combobox_Role;
        private Toolbox_Custom.Button_Custom button_ChinhSua;
        public Toolbox_Custom.PictureBox_Custom pictureBox_AnhDaiDien;
        private Toolbox_Custom.Textbox_Custom textbox_MatKhau;
        private Toolbox_Custom.Textbox_Custom textbox_HoVaTen;
        private Toolbox_Custom.Textbox_Custom textbox_Note;
        private Toolbox_Custom.Textbox_Custom textbox_TaiKhoan;
        private Toolbox_Custom.Textbox_Custom textbox_DienThoai;
    }
}