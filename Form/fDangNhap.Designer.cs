
namespace QLS
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.label_Loi = new System.Windows.Forms.Label();
            this.icopbHienMatKhau = new FontAwesome.Sharp.IconPictureBox();
            this.txbMatKhau = new QLS.Toolbox_Custom.Textbox_Custom();
            this.txbTenDangNhap = new QLS.Toolbox_Custom.Textbox_Custom();
            this.bDangNhap = new QLS.Toolbox_Custom.Button_Custom();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icopbHienMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_Welcome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Welcome.Location = new System.Drawing.Point(420, 188);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(201, 16);
            this.label_Welcome.TabIndex = 43;
            this.label_Welcome.Text = "Chào mừng bạn đến với Book!";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.Transparent;
            this.label_Login.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.Location = new System.Drawing.Point(415, 139);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(180, 37);
            this.label_Login.TabIndex = 42;
            this.label_Login.Text = "Đăng nhập";
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.pictureBox_Image.Location = new System.Drawing.Point(3, 188);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(347, 321);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Image.TabIndex = 41;
            this.pictureBox_Image.TabStop = false;
            this.pictureBox_Image.UseWaitCursor = true;
            // 
            // label_Loi
            // 
            this.label_Loi.BackColor = System.Drawing.Color.Transparent;
            this.label_Loi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi.Location = new System.Drawing.Point(420, 344);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(295, 20);
            this.label_Loi.TabIndex = 0;
            this.label_Loi.Text = "Lỗi...";
            this.label_Loi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icopbHienMatKhau
            // 
            this.icopbHienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.icopbHienMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.icopbHienMatKhau.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.icopbHienMatKhau.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.icopbHienMatKhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icopbHienMatKhau.Location = new System.Drawing.Point(683, 289);
            this.icopbHienMatKhau.Name = "icopbHienMatKhau";
            this.icopbHienMatKhau.Size = new System.Drawing.Size(32, 32);
            this.icopbHienMatKhau.TabIndex = 44;
            this.icopbHienMatKhau.TabStop = false;
            this.icopbHienMatKhau.Click += new System.EventHandler(this.icopbHienMatKhau_Click);
            this.icopbHienMatKhau.DoubleClick += new System.EventHandler(this.icopbHienMatKhau_DoubleClick);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.BackColor = System.Drawing.Color.White;
            this.txbMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.txbMatKhau.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.txbMatKhau.BorderRadius = 0;
            this.txbMatKhau.BorderSize = 4;
            this.txbMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.txbMatKhau.IsPlaceHolder = true;
            this.txbMatKhau.Location = new System.Drawing.Point(420, 289);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMatKhau.Multiline = false;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Padding = new System.Windows.Forms.Padding(12, 10, 12, 8);
            this.txbMatKhau.PasswordChar = true;
            this.txbMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbMatKhau.PlaceholderText = "Mật khẩu";
            this.txbMatKhau.Size = new System.Drawing.Size(295, 37);
            this.txbMatKhau.TabIndex = 40;
            this.txbMatKhau.Texts = "";
            this.txbMatKhau.UnderlinedStyle = true;
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.BackColor = System.Drawing.Color.White;
            this.txbTenDangNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.txbTenDangNhap.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.txbTenDangNhap.BorderRadius = 0;
            this.txbTenDangNhap.BorderSize = 4;
            this.txbTenDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.txbTenDangNhap.IsPlaceHolder = true;
            this.txbTenDangNhap.Location = new System.Drawing.Point(420, 244);
            this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTenDangNhap.Multiline = false;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Padding = new System.Windows.Forms.Padding(12, 10, 12, 8);
            this.txbTenDangNhap.PasswordChar = false;
            this.txbTenDangNhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbTenDangNhap.PlaceholderText = "Tài khoản";
            this.txbTenDangNhap.Size = new System.Drawing.Size(295, 37);
            this.txbTenDangNhap.TabIndex = 39;
            this.txbTenDangNhap.Texts = "";
            this.txbTenDangNhap.UnderlinedStyle = true;
            // 
            // bDangNhap
            // 
            this.bDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.bDangNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.bDangNhap.BorderColor = System.Drawing.Color.White;
            this.bDangNhap.BorderRadius = 5;
            this.bDangNhap.BorderSize = 0;
            this.bDangNhap.FlatAppearance.BorderSize = 0;
            this.bDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDangNhap.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.bDangNhap.ForeColor = System.Drawing.Color.White;
            this.bDangNhap.Location = new System.Drawing.Point(420, 384);
            this.bDangNhap.Name = "bDangNhap";
            this.bDangNhap.Size = new System.Drawing.Size(295, 50);
            this.bDangNhap.TabIndex = 37;
            this.bDangNhap.Text = "Đăng nhập";
            this.bDangNhap.TextColor = System.Drawing.Color.White;
            this.bDangNhap.UseVisualStyleBackColor = false;
            this.bDangNhap.Click += new System.EventHandler(this.bDangNhap_Click);
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Image = global::QLS.Properties.Resources.Icon;
            this.pictureBox_Icon.Location = new System.Drawing.Point(3, 2);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Icon.TabIndex = 1;
            this.pictureBox_Icon.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.button_Close.IconColor = System.Drawing.Color.White;
            this.button_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Close.IconSize = 30;
            this.button_Close.Location = new System.Drawing.Point(710, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel_Top.Controls.Add(this.label_Title);
            this.panel_Top.Controls.Add(this.pictureBox_Icon);
            this.panel_Top.Controls.Add(this.button_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(740, 30);
            this.panel_Top.TabIndex = 45;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(34, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(68, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Đăng nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLS.Properties.Resources.BG_Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 510);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.icopbHienMatKhau);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.bDangNhap);
            this.Controls.Add(this.label_Loi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icopbHienMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private Toolbox_Custom.Textbox_Custom txbMatKhau;
        private Toolbox_Custom.Textbox_Custom txbTenDangNhap;
        private Toolbox_Custom.Button_Custom bDangNhap;
        private System.Windows.Forms.Label label_Loi;
        private FontAwesome.Sharp.IconPictureBox icopbHienMatKhau;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Close;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Title;
    }
}