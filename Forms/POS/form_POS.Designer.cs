namespace QLS.Forms.POS
{
    partial class form_POS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clAvatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.clMASACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGIABIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label_Loi1 = new System.Windows.Forms.Label();
            this.label_TongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ThanhToan = new QLS.Toolbox_Custom.Button_Custom();
            this.button_ThemKhach = new QLS.Toolbox_Custom.Button_Custom();
            this.textbox_SDT = new QLS.Toolbox_Custom.Textbox_Custom();
            this.textbox_TenKH = new QLS.Toolbox_Custom.Textbox_Custom();
            this.button_TimKhach = new QLS.Toolbox_Custom.Button_Custom();
            this.button_Xoa = new QLS.Toolbox_Custom.Button_Custom();
            this.textbox_TimKiem = new QLS.Toolbox_Custom.Textbox_Custom();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("iCiel Cadena", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 36;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAvatar,
            this.clMASACH,
            this.clTENSACH,
            this.clGIABIA,
            this.clTacGia,
            this.clNXB,
            this.clNamXB,
            this.clTheLoai,
            this.clGiaMua});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 83);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 40;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(733, 605);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // clAvatar
            // 
            this.clAvatar.DataPropertyName = "HINHANH";
            this.clAvatar.FillWeight = 136.9213F;
            this.clAvatar.HeaderText = "Hình ảnh";
            this.clAvatar.MinimumWidth = 6;
            this.clAvatar.Name = "clAvatar";
            this.clAvatar.ReadOnly = true;
            this.clAvatar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clAvatar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clMASACH
            // 
            this.clMASACH.DataPropertyName = "MASACH";
            this.clMASACH.HeaderText = "Mã sách";
            this.clMASACH.MinimumWidth = 6;
            this.clMASACH.Name = "clMASACH";
            this.clMASACH.ReadOnly = true;
            // 
            // clTENSACH
            // 
            this.clTENSACH.DataPropertyName = "TENSACH";
            this.clTENSACH.HeaderText = "Tên sách";
            this.clTENSACH.MinimumWidth = 6;
            this.clTENSACH.Name = "clTENSACH";
            this.clTENSACH.ReadOnly = true;
            // 
            // clGIABIA
            // 
            this.clGIABIA.DataPropertyName = "GIABIA";
            this.clGIABIA.HeaderText = "Giá bìa";
            this.clGIABIA.MinimumWidth = 6;
            this.clGIABIA.Name = "clGIABIA";
            this.clGIABIA.ReadOnly = true;
            // 
            // clTacGia
            // 
            this.clTacGia.DataPropertyName = "NAMXUATBAN";
            this.clTacGia.HeaderText = "Column1";
            this.clTacGia.MinimumWidth = 6;
            this.clTacGia.Name = "clTacGia";
            this.clTacGia.ReadOnly = true;
            this.clTacGia.Visible = false;
            // 
            // clNXB
            // 
            this.clNXB.DataPropertyName = "NHAXUATBAN";
            this.clNXB.HeaderText = "Column1";
            this.clNXB.MinimumWidth = 6;
            this.clNXB.Name = "clNXB";
            this.clNXB.ReadOnly = true;
            this.clNXB.Visible = false;
            // 
            // clNamXB
            // 
            this.clNamXB.DataPropertyName = "TACGIA";
            this.clNamXB.HeaderText = "Column1";
            this.clNamXB.MinimumWidth = 6;
            this.clNamXB.Name = "clNamXB";
            this.clNamXB.ReadOnly = true;
            this.clNamXB.Visible = false;
            // 
            // clTheLoai
            // 
            this.clTheLoai.DataPropertyName = "THELOAI";
            this.clTheLoai.HeaderText = "Column1";
            this.clTheLoai.MinimumWidth = 6;
            this.clTheLoai.Name = "clTheLoai";
            this.clTheLoai.ReadOnly = true;
            this.clTheLoai.Visible = false;
            // 
            // clGiaMua
            // 
            this.clGiaMua.DataPropertyName = "GIAMUA";
            this.clGiaMua.HeaderText = "Column1";
            this.clGiaMua.MinimumWidth = 6;
            this.clGiaMua.Name = "clGiaMua";
            this.clGiaMua.ReadOnly = true;
            this.clGiaMua.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label_Loi1);
            this.groupBox1.Controls.Add(this.label_TongTien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_ThanhToan);
            this.groupBox1.Controls.Add(this.button_ThemKhach);
            this.groupBox1.Controls.Add(this.textbox_SDT);
            this.groupBox1.Controls.Add(this.textbox_TenKH);
            this.groupBox1.Controls.Add(this.button_TimKhach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(754, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 667);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 262);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(295, 301);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label_Loi1
            // 
            this.label_Loi1.AutoSize = true;
            this.label_Loi1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi1.Location = new System.Drawing.Point(29, 212);
            this.label_Loi1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Loi1.MaximumSize = new System.Drawing.Size(300, 100);
            this.label_Loi1.Name = "label_Loi1";
            this.label_Loi1.Size = new System.Drawing.Size(42, 18);
            this.label_Loi1.TabIndex = 20;
            this.label_Loi1.Text = "Lỗi...";
            // 
            // label_TongTien
            // 
            this.label_TongTien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_TongTien.AutoSize = true;
            this.label_TongTien.Font = new System.Drawing.Font("iCiel Cadena", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TongTien.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_TongTien.Location = new System.Drawing.Point(156, 570);
            this.label_TongTien.Name = "label_TongTien";
            this.label_TongTien.Size = new System.Drawing.Size(0, 31);
            this.label_TongTien.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("iCiel Cadena", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(26, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tổng tiền: ";
            // 
            // button_ThanhToan
            // 
            this.button_ThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ThanhToan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ThanhToan.BorderRadius = 5;
            this.button_ThanhToan.BorderSize = 0;
            this.button_ThanhToan.FlatAppearance.BorderSize = 0;
            this.button_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThanhToan.Font = new System.Drawing.Font("iCiel Cadena", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.button_ThanhToan.Location = new System.Drawing.Point(30, 611);
            this.button_ThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ThanhToan.Name = "button_ThanhToan";
            this.button_ThanhToan.Size = new System.Drawing.Size(297, 39);
            this.button_ThanhToan.TabIndex = 20;
            this.button_ThanhToan.Text = "Thanh toán";
            this.button_ThanhToan.TextColor = System.Drawing.Color.White;
            this.button_ThanhToan.UseVisualStyleBackColor = false;
            this.button_ThanhToan.Click += new System.EventHandler(this.button_ThanhToan_Click);
            // 
            // button_ThemKhach
            // 
            this.button_ThemKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ThemKhach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ThemKhach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ThemKhach.BorderRadius = 5;
            this.button_ThemKhach.BorderSize = 0;
            this.button_ThemKhach.FlatAppearance.BorderSize = 0;
            this.button_ThemKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThemKhach.Font = new System.Drawing.Font("iCiel Cadena", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemKhach.ForeColor = System.Drawing.Color.White;
            this.button_ThemKhach.Location = new System.Drawing.Point(186, 154);
            this.button_ThemKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ThemKhach.Name = "button_ThemKhach";
            this.button_ThemKhach.Size = new System.Drawing.Size(141, 39);
            this.button_ThemKhach.TabIndex = 16;
            this.button_ThemKhach.Text = "Thêm";
            this.button_ThemKhach.TextColor = System.Drawing.Color.White;
            this.button_ThemKhach.UseVisualStyleBackColor = false;
            this.button_ThemKhach.Click += new System.EventHandler(this.button_ThemKhach_Click);
            // 
            // textbox_SDT
            // 
            this.textbox_SDT.BackColor = System.Drawing.Color.White;
            this.textbox_SDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.textbox_SDT.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.textbox_SDT.BorderRadius = 5;
            this.textbox_SDT.BorderSize = 2;
            this.textbox_SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_SDT.IsPlaceHolder = true;
            this.textbox_SDT.Location = new System.Drawing.Point(30, 95);
            this.textbox_SDT.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_SDT.Multiline = false;
            this.textbox_SDT.Name = "textbox_SDT";
            this.textbox_SDT.Padding = new System.Windows.Forms.Padding(16, 11, 16, 9);
            this.textbox_SDT.PasswordChar = false;
            this.textbox_SDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_SDT.PlaceholderText = "Số điện thoại";
            this.textbox_SDT.Size = new System.Drawing.Size(298, 41);
            this.textbox_SDT.TabIndex = 18;
            this.textbox_SDT.Texts = "";
            this.textbox_SDT.UnderlinedStyle = false;
            // 
            // textbox_TenKH
            // 
            this.textbox_TenKH.BackColor = System.Drawing.Color.White;
            this.textbox_TenKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.textbox_TenKH.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.textbox_TenKH.BorderRadius = 5;
            this.textbox_TenKH.BorderSize = 2;
            this.textbox_TenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_TenKH.IsPlaceHolder = true;
            this.textbox_TenKH.Location = new System.Drawing.Point(30, 41);
            this.textbox_TenKH.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_TenKH.Multiline = false;
            this.textbox_TenKH.Name = "textbox_TenKH";
            this.textbox_TenKH.Padding = new System.Windows.Forms.Padding(16, 11, 16, 9);
            this.textbox_TenKH.PasswordChar = false;
            this.textbox_TenKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TenKH.PlaceholderText = "Tên khách hàng";
            this.textbox_TenKH.Size = new System.Drawing.Size(298, 41);
            this.textbox_TenKH.TabIndex = 19;
            this.textbox_TenKH.Texts = "";
            this.textbox_TenKH.UnderlinedStyle = false;
            // 
            // button_TimKhach
            // 
            this.button_TimKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_TimKhach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_TimKhach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_TimKhach.BorderRadius = 5;
            this.button_TimKhach.BorderSize = 0;
            this.button_TimKhach.FlatAppearance.BorderSize = 0;
            this.button_TimKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimKhach.Font = new System.Drawing.Font("iCiel Cadena", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKhach.ForeColor = System.Drawing.Color.White;
            this.button_TimKhach.Location = new System.Drawing.Point(30, 154);
            this.button_TimKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_TimKhach.Name = "button_TimKhach";
            this.button_TimKhach.Size = new System.Drawing.Size(140, 39);
            this.button_TimKhach.TabIndex = 15;
            this.button_TimKhach.Text = "Tìm";
            this.button_TimKhach.TextColor = System.Drawing.Color.White;
            this.button_TimKhach.UseVisualStyleBackColor = false;
            this.button_TimKhach.Click += new System.EventHandler(this.button_TimKhach_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Xoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Xoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Xoa.BorderRadius = 5;
            this.button_Xoa.BorderSize = 0;
            this.button_Xoa.FlatAppearance.BorderSize = 0;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("iCiel Cadena", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(316, 26);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(106, 39);
            this.button_Xoa.TabIndex = 19;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.TextColor = System.Drawing.Color.White;
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // textbox_TimKiem
            // 
            this.textbox_TimKiem.BackColor = System.Drawing.Color.White;
            this.textbox_TimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.textbox_TimKiem.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.textbox_TimKiem.BorderRadius = 5;
            this.textbox_TimKiem.BorderSize = 2;
            this.textbox_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_TimKiem.IsPlaceHolder = true;
            this.textbox_TimKiem.Location = new System.Drawing.Point(14, 26);
            this.textbox_TimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.textbox_TimKiem.Multiline = false;
            this.textbox_TimKiem.Name = "textbox_TimKiem";
            this.textbox_TimKiem.Padding = new System.Windows.Forms.Padding(13, 9, 13, 7);
            this.textbox_TimKiem.PasswordChar = false;
            this.textbox_TimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TimKiem.PlaceholderText = "Tìm kiếm...";
            this.textbox_TimKiem.Size = new System.Drawing.Size(285, 33);
            this.textbox_TimKiem.TabIndex = 11;
            this.textbox_TimKiem.Texts = "";
            this.textbox_TimKiem.UnderlinedStyle = false;
            this.textbox_TimKiem._TextChanged += new System.EventHandler(this.textbox_TimKiem__TextChanged);
            // 
            // form_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 691);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.textbox_TimKiem);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_POS";
            this.Text = "form_POS";
            this.Load += new System.EventHandler(this.form_POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private Toolbox_Custom.Textbox_Custom textbox_TimKiem;
        private Toolbox_Custom.Button_Custom button_TimKhach;
        private Toolbox_Custom.Button_Custom button_ThemKhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private Toolbox_Custom.Button_Custom button_ThanhToan;
        private Toolbox_Custom.Button_Custom button_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn clAvatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMASACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGIABIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaMua;
        public Toolbox_Custom.Textbox_Custom textbox_SDT;
        public Toolbox_Custom.Textbox_Custom textbox_TenKH;
        public System.Windows.Forms.Label label_Loi1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label label_TongTien;
    }
}