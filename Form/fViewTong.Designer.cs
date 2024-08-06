
namespace QLS
{
    partial class frmViewTong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTong));
            this.txbTenNguoiDung = new System.Windows.Forms.TextBox();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnQuanLi = new FontAwesome.Sharp.IconButton();
            this.pictureBox_TabMenu = new FontAwesome.Sharp.IconPictureBox();
            this.DangxuatToolStripMenuItem = new FontAwesome.Sharp.IconButton();
            this.btnCaiDat = new FontAwesome.Sharp.IconButton();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.button_Maximize = new FontAwesome.Sharp.IconButton();
            this.button_Minimize = new FontAwesome.Sharp.IconButton();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.label_Select = new System.Windows.Forms.Label();
            this.pictureBox_Select = new FontAwesome.Sharp.IconPictureBox();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.label_XinChao = new System.Windows.Forms.Label();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.txbSLKhach = new System.Windows.Forms.TextBox();
            this.lblSoLuongKhach = new System.Windows.Forms.Label();
            this.txbDoanhThu = new System.Windows.Forms.TextBox();
            this.lblDoanhthu = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnTrangChu = new QLS.Toolbox_Custom.Button_Custom();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabMenu)).BeginInit();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Select)).BeginInit();
            this.panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbTenNguoiDung
            // 
            this.txbTenNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbTenNguoiDung.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txbTenNguoiDung.Location = new System.Drawing.Point(1051, 28);
            this.txbTenNguoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTenNguoiDung.Name = "txbTenNguoiDung";
            this.txbTenNguoiDung.ReadOnly = true;
            this.txbTenNguoiDung.Size = new System.Drawing.Size(109, 20);
            this.txbTenNguoiDung.TabIndex = 3;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.panel_Menu.Controls.Add(this.btnTrangChu);
            this.panel_Menu.Controls.Add(this.btnTaiKhoan);
            this.panel_Menu.Controls.Add(this.btnHoaDon);
            this.panel_Menu.Controls.Add(this.btnThongKe);
            this.panel_Menu.Controls.Add(this.btnQuanLi);
            this.panel_Menu.Controls.Add(this.pictureBox_TabMenu);
            this.panel_Menu.Controls.Add(this.DangxuatToolStripMenuItem);
            this.panel_Menu.Controls.Add(this.btnCaiDat);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(267, 738);
            this.panel_Menu.TabIndex = 10;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTaiKhoan.IconSize = 40;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 162);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(267, 55);
            this.btnTaiKhoan.TabIndex = 16;
            this.btnTaiKhoan.Text = "TÀI KHOẢN";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaikhoan_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btnHoaDon.IconColor = System.Drawing.Color.White;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHoaDon.IconSize = 40;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 351);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(267, 55);
            this.btnHoaDon.TabIndex = 15;
            this.btnHoaDon.Text = "HÓA ĐƠN";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnThongKe.IconSize = 40;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 288);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(267, 55);
            this.btnThongKe.TabIndex = 14;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQuanLi
            // 
            this.btnQuanLi.FlatAppearance.BorderSize = 0;
            this.btnQuanLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLi.ForeColor = System.Drawing.Color.White;
            this.btnQuanLi.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQuanLi.IconColor = System.Drawing.Color.White;
            this.btnQuanLi.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnQuanLi.IconSize = 40;
            this.btnQuanLi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLi.Location = new System.Drawing.Point(0, 225);
            this.btnQuanLi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLi.Name = "btnQuanLi";
            this.btnQuanLi.Size = new System.Drawing.Size(267, 55);
            this.btnQuanLi.TabIndex = 13;
            this.btnQuanLi.Text = "QUẢN LÍ THÔNG TIN";
            this.btnQuanLi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLi.UseVisualStyleBackColor = true;
            this.btnQuanLi.Click += new System.EventHandler(this.btnQuanLi_Click);
            // 
            // pictureBox_TabMenu
            // 
            this.pictureBox_TabMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_TabMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_TabMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.pictureBox_TabMenu.IconColor = System.Drawing.Color.White;
            this.pictureBox_TabMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureBox_TabMenu.IconSize = 37;
            this.pictureBox_TabMenu.Location = new System.Drawing.Point(104, 687);
            this.pictureBox_TabMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_TabMenu.Name = "pictureBox_TabMenu";
            this.pictureBox_TabMenu.Size = new System.Drawing.Size(40, 37);
            this.pictureBox_TabMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_TabMenu.TabIndex = 11;
            this.pictureBox_TabMenu.TabStop = false;
            this.pictureBox_TabMenu.UseGdi = true;
            this.pictureBox_TabMenu.Click += new System.EventHandler(this.pictureBox_TabMenu_Click);
            // 
            // DangxuatToolStripMenuItem
            // 
            this.DangxuatToolStripMenuItem.FlatAppearance.BorderSize = 0;
            this.DangxuatToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DangxuatToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.DangxuatToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DangxuatToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.DangxuatToolStripMenuItem.IconColor = System.Drawing.Color.White;
            this.DangxuatToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.DangxuatToolStripMenuItem.IconSize = 40;
            this.DangxuatToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DangxuatToolStripMenuItem.Location = new System.Drawing.Point(0, 476);
            this.DangxuatToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DangxuatToolStripMenuItem.Name = "DangxuatToolStripMenuItem";
            this.DangxuatToolStripMenuItem.Size = new System.Drawing.Size(267, 55);
            this.DangxuatToolStripMenuItem.TabIndex = 8;
            this.DangxuatToolStripMenuItem.Text = "Đăng xuất";
            this.DangxuatToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DangxuatToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DangxuatToolStripMenuItem.UseVisualStyleBackColor = true;
            this.DangxuatToolStripMenuItem.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnCaiDat.IconColor = System.Drawing.Color.White;
            this.btnCaiDat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCaiDat.IconSize = 40;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 414);
            this.btnCaiDat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(267, 55);
            this.btnCaiDat.TabIndex = 7;
            this.btnCaiDat.Text = "CÀI ĐẶT";
            this.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel_Title.Controls.Add(this.button_Maximize);
            this.panel_Title.Controls.Add(this.button_Minimize);
            this.panel_Title.Controls.Add(this.button_Close);
            this.panel_Title.Controls.Add(this.label_Select);
            this.panel_Title.Controls.Add(this.pictureBox_Select);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(267, 0);
            this.panel_Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(866, 62);
            this.panel_Title.TabIndex = 11;
            // 
            // button_Maximize
            // 
            this.button_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.button_Maximize.FlatAppearance.BorderSize = 0;
            this.button_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.button_Maximize.IconColor = System.Drawing.Color.White;
            this.button_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Maximize.IconSize = 30;
            this.button_Maximize.Location = new System.Drawing.Point(786, 0);
            this.button_Maximize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Maximize.Name = "button_Maximize";
            this.button_Maximize.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.button_Maximize.Size = new System.Drawing.Size(40, 37);
            this.button_Maximize.TabIndex = 3;
            this.button_Maximize.TabStop = false;
            this.button_Maximize.UseVisualStyleBackColor = false;
            this.button_Maximize.Click += new System.EventHandler(this.button_Maximize_Click);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.button_Minimize.IconColor = System.Drawing.Color.White;
            this.button_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Minimize.IconSize = 30;
            this.button_Minimize.Location = new System.Drawing.Point(746, 0);
            this.button_Minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.button_Minimize.Size = new System.Drawing.Size(40, 37);
            this.button_Minimize.TabIndex = 2;
            this.button_Minimize.TabStop = false;
            this.button_Minimize.UseVisualStyleBackColor = false;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
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
            this.button_Close.Location = new System.Drawing.Point(826, 0);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(40, 37);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Select
            // 
            this.label_Select.AutoSize = true;
            this.label_Select.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_Select.ForeColor = System.Drawing.Color.White;
            this.label_Select.Location = new System.Drawing.Point(68, 20);
            this.label_Select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Select.Name = "label_Select";
            this.label_Select.Size = new System.Drawing.Size(128, 24);
            this.label_Select.TabIndex = 0;
            this.label_Select.Text = "TRANG CHỦ";
            // 
            // pictureBox_Select
            // 
            this.pictureBox_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.pictureBox_Select.IconChar = FontAwesome.Sharp.IconChar.House;
            this.pictureBox_Select.IconColor = System.Drawing.Color.White;
            this.pictureBox_Select.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureBox_Select.IconSize = 49;
            this.pictureBox_Select.Location = new System.Drawing.Point(7, 9);
            this.pictureBox_Select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Select.Name = "pictureBox_Select";
            this.pictureBox_Select.Size = new System.Drawing.Size(53, 49);
            this.pictureBox_Select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Select.TabIndex = 0;
            this.pictureBox_Select.TabStop = false;
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.White;
            this.panel_Main.Controls.Add(this.label_XinChao);
            this.panel_Main.Controls.Add(this.lblTenNguoiDung);
            this.panel_Main.Controls.Add(this.txbSLKhach);
            this.panel_Main.Controls.Add(this.lblSoLuongKhach);
            this.panel_Main.Controls.Add(this.txbDoanhThu);
            this.panel_Main.Controls.Add(this.lblDoanhthu);
            this.panel_Main.Controls.Add(this.lblTime);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(267, 62);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(866, 676);
            this.panel_Main.TabIndex = 12;
            // 
            // label_XinChao
            // 
            this.label_XinChao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_XinChao.BackColor = System.Drawing.Color.Transparent;
            this.label_XinChao.Font = new System.Drawing.Font("iCiel Cadena", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_XinChao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.label_XinChao.Location = new System.Drawing.Point(0, 0);
            this.label_XinChao.Margin = new System.Windows.Forms.Padding(0);
            this.label_XinChao.Name = "label_XinChao";
            this.label_XinChao.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.label_XinChao.Size = new System.Drawing.Size(866, 89);
            this.label_XinChao.TabIndex = 33;
            this.label_XinChao.Text = "Xin chào";
            this.label_XinChao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Coiny", 12F);
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.White;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(296, 101);
            this.lblTenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(248, 34);
            this.lblTenNguoiDung.TabIndex = 32;
            this.lblTenNguoiDung.Text = "Tên";
            this.lblTenNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbSLKhach
            // 
            this.txbSLKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbSLKhach.BackColor = System.Drawing.SystemColors.Control;
            this.txbSLKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSLKhach.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txbSLKhach.Location = new System.Drawing.Point(261, 597);
            this.txbSLKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSLKhach.Name = "txbSLKhach";
            this.txbSLKhach.Size = new System.Drawing.Size(284, 23);
            this.txbSLKhach.TabIndex = 31;
            this.txbSLKhach.TextChanged += new System.EventHandler(this.txbSLKhach_TextChanged);
            // 
            // lblSoLuongKhach
            // 
            this.lblSoLuongKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoLuongKhach.AutoSize = true;
            this.lblSoLuongKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuongKhach.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongKhach.Location = new System.Drawing.Point(8, 600);
            this.lblSoLuongKhach.Name = "lblSoLuongKhach";
            this.lblSoLuongKhach.Size = new System.Drawing.Size(142, 20);
            this.lblSoLuongKhach.TabIndex = 30;
            this.lblSoLuongKhach.Text = "SỐ LƯỢNG KHÁCH:";
            // 
            // txbDoanhThu
            // 
            this.txbDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbDoanhThu.BackColor = System.Drawing.SystemColors.Control;
            this.txbDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txbDoanhThu.Location = new System.Drawing.Point(261, 568);
            this.txbDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDoanhThu.Name = "txbDoanhThu";
            this.txbDoanhThu.Size = new System.Drawing.Size(284, 23);
            this.txbDoanhThu.TabIndex = 29;
            // 
            // lblDoanhthu
            // 
            this.lblDoanhthu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDoanhthu.AutoSize = true;
            this.lblDoanhthu.BackColor = System.Drawing.Color.Transparent;
            this.lblDoanhthu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDoanhthu.Location = new System.Drawing.Point(8, 570);
            this.lblDoanhthu.Name = "lblDoanhthu";
            this.lblDoanhthu.Size = new System.Drawing.Size(200, 20);
            this.lblDoanhthu.TabIndex = 28;
            this.lblDoanhthu.Text = "DOANH THU TRONG NGÀY:";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.lblTime.Font = new System.Drawing.Font("Coiny", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(203, 151);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(439, 34);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Chủ nhật, ngày 01 tháng 01 năm 0001";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.BackgroundImage = global::QLS.Properties.Resources.Logo;
            this.btnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrangChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.btnTrangChu.BorderRadius = 5;
            this.btnTrangChu.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Location = new System.Drawing.Point(16, 15);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(243, 103);
            this.btnTrangChu.TabIndex = 17;
            this.btnTrangChu.TextColor = System.Drawing.Color.White;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.bTrangChu_Click);
            // 
            // frmViewTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 738);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.txbTenNguoiDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmViewTong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG CHỦ";
            this.Load += new System.EventHandler(this.frmViewTong_Load);
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabMenu)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Select)).EndInit();
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbTenNguoiDung;
        public FontAwesome.Sharp.IconPictureBox pictureBox_TabMenu;
        public System.Windows.Forms.Panel panel_Menu;
        public FontAwesome.Sharp.IconButton DangxuatToolStripMenuItem;
        public FontAwesome.Sharp.IconButton btnCaiDat;
        public System.Windows.Forms.Panel panel_Title;
        public FontAwesome.Sharp.IconButton button_Maximize;
        public FontAwesome.Sharp.IconButton button_Minimize;
        public FontAwesome.Sharp.IconButton button_Close;
        public System.Windows.Forms.Label label_Select;
        public FontAwesome.Sharp.IconPictureBox pictureBox_Select;
        private System.Windows.Forms.Panel panel_Main;
        public System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txbSLKhach;
        private System.Windows.Forms.Label lblSoLuongKhach;
        private System.Windows.Forms.TextBox txbDoanhThu;
        private System.Windows.Forms.Label lblDoanhthu;
        public System.Windows.Forms.Label lblTenNguoiDung;
        public FontAwesome.Sharp.IconButton btnQuanLi;
        public FontAwesome.Sharp.IconButton btnThongKe;
        public System.Windows.Forms.Label label_XinChao;
        public FontAwesome.Sharp.IconButton btnHoaDon;
        public FontAwesome.Sharp.IconButton btnTaiKhoan;
        private Toolbox_Custom.Button_Custom btnTrangChu;
    }
}