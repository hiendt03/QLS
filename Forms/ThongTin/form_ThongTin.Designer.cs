
namespace QLS
{
    partial class form_ThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ThongTin));
            this.panel_SoTrang = new System.Windows.Forms.Panel();
            this.button_QuayLai2 = new FontAwesome.Sharp.IconButton();
            this.button_TienLen2 = new FontAwesome.Sharp.IconButton();
            this.label_TongSoTrang = new System.Windows.Forms.Label();
            this.label_TrangHienTai = new System.Windows.Forms.Label();
            this.button_QuayLai = new FontAwesome.Sharp.IconButton();
            this.button_TienLen = new FontAwesome.Sharp.IconButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clAvatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.clUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASS_WORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Bottom2 = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_TimKiem = new QLS.Toolbox_Custom.Button_Custom();
            this.textbox_TimKiem = new QLS.Toolbox_Custom.Textbox_Custom();
            this.button_Xoa = new QLS.Toolbox_Custom.Button_Custom();
            this.button_ChinhSua = new QLS.Toolbox_Custom.Button_Custom();
            this.button_Tao = new QLS.Toolbox_Custom.Button_Custom();
            this.panel_SoTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel_Bottom2.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_SoTrang
            // 
            this.panel_SoTrang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_SoTrang.Controls.Add(this.button_QuayLai2);
            this.panel_SoTrang.Controls.Add(this.button_TienLen2);
            this.panel_SoTrang.Controls.Add(this.label_TongSoTrang);
            this.panel_SoTrang.Controls.Add(this.label_TrangHienTai);
            this.panel_SoTrang.Controls.Add(this.button_QuayLai);
            this.panel_SoTrang.Controls.Add(this.button_TienLen);
            this.panel_SoTrang.Location = new System.Drawing.Point(433, 0);
            this.panel_SoTrang.Margin = new System.Windows.Forms.Padding(4);
            this.panel_SoTrang.Name = "panel_SoTrang";
            this.panel_SoTrang.Size = new System.Drawing.Size(267, 44);
            this.panel_SoTrang.TabIndex = 5;
            // 
            // button_QuayLai2
            // 
            this.button_QuayLai2.BackColor = System.Drawing.Color.DarkGray;
            this.button_QuayLai2.FlatAppearance.BorderSize = 0;
            this.button_QuayLai2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuayLai2.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.button_QuayLai2.IconColor = System.Drawing.Color.White;
            this.button_QuayLai2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_QuayLai2.IconSize = 30;
            this.button_QuayLai2.Location = new System.Drawing.Point(3, 4);
            this.button_QuayLai2.Margin = new System.Windows.Forms.Padding(4);
            this.button_QuayLai2.Name = "button_QuayLai2";
            this.button_QuayLai2.Padding = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.button_QuayLai2.Size = new System.Drawing.Size(40, 37);
            this.button_QuayLai2.TabIndex = 4;
            this.button_QuayLai2.TabStop = false;
            this.button_QuayLai2.UseVisualStyleBackColor = false;
            this.button_QuayLai2.Click += new System.EventHandler(this.button_QuayLai2_Click);
            // 
            // button_TienLen2
            // 
            this.button_TienLen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_TienLen2.FlatAppearance.BorderSize = 0;
            this.button_TienLen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TienLen2.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.button_TienLen2.IconColor = System.Drawing.Color.White;
            this.button_TienLen2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_TienLen2.IconSize = 30;
            this.button_TienLen2.Location = new System.Drawing.Point(224, 4);
            this.button_TienLen2.Margin = new System.Windows.Forms.Padding(4);
            this.button_TienLen2.Name = "button_TienLen2";
            this.button_TienLen2.Padding = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.button_TienLen2.Size = new System.Drawing.Size(40, 37);
            this.button_TienLen2.TabIndex = 3;
            this.button_TienLen2.TabStop = false;
            this.button_TienLen2.UseVisualStyleBackColor = false;
            this.button_TienLen2.Click += new System.EventHandler(this.button_TienLen2_Click);
            // 
            // label_TongSoTrang
            // 
            this.label_TongSoTrang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TongSoTrang.ForeColor = System.Drawing.Color.DarkGray;
            this.label_TongSoTrang.Location = new System.Drawing.Point(128, 11);
            this.label_TongSoTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TongSoTrang.Name = "label_TongSoTrang";
            this.label_TongSoTrang.Size = new System.Drawing.Size(47, 23);
            this.label_TongSoTrang.TabIndex = 0;
            this.label_TongSoTrang.Text = "/ 0";
            this.label_TongSoTrang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TrangHienTai
            // 
            this.label_TrangHienTai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TrangHienTai.ForeColor = System.Drawing.Color.DarkGray;
            this.label_TrangHienTai.Location = new System.Drawing.Point(96, 11);
            this.label_TrangHienTai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TrangHienTai.Name = "label_TrangHienTai";
            this.label_TrangHienTai.Size = new System.Drawing.Size(36, 23);
            this.label_TrangHienTai.TabIndex = 0;
            this.label_TrangHienTai.Text = "0";
            this.label_TrangHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_QuayLai
            // 
            this.button_QuayLai.BackColor = System.Drawing.Color.DarkGray;
            this.button_QuayLai.FlatAppearance.BorderSize = 0;
            this.button_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuayLai.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.button_QuayLai.IconColor = System.Drawing.Color.White;
            this.button_QuayLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_QuayLai.IconSize = 30;
            this.button_QuayLai.Location = new System.Drawing.Point(51, 4);
            this.button_QuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.button_QuayLai.Name = "button_QuayLai";
            this.button_QuayLai.Padding = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.button_QuayLai.Size = new System.Drawing.Size(40, 37);
            this.button_QuayLai.TabIndex = 1;
            this.button_QuayLai.TabStop = false;
            this.button_QuayLai.UseVisualStyleBackColor = false;
            this.button_QuayLai.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // button_TienLen
            // 
            this.button_TienLen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_TienLen.FlatAppearance.BorderSize = 0;
            this.button_TienLen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TienLen.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.button_TienLen.IconColor = System.Drawing.Color.White;
            this.button_TienLen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_TienLen.IconSize = 30;
            this.button_TienLen.Location = new System.Drawing.Point(176, 4);
            this.button_TienLen.Margin = new System.Windows.Forms.Padding(4);
            this.button_TienLen.Name = "button_TienLen";
            this.button_TienLen.Padding = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.button_TienLen.Size = new System.Drawing.Size(40, 37);
            this.button_TienLen.TabIndex = 2;
            this.button_TienLen.TabStop = false;
            this.button_TienLen.UseVisualStyleBackColor = false;
            this.button_TienLen.Click += new System.EventHandler(this.btnNxtPage_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
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
            this.clUsername,
            this.PASS_WORD,
            this.clFullname,
            this.clDienthoai,
            this.clNote,
            this.clRole});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(208)))), ((int)(((byte)(212)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
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
            this.dataGridView.Size = new System.Drawing.Size(1133, 676);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            // 
            // clAvatar
            // 
            this.clAvatar.DataPropertyName = "AVATAR";
            this.clAvatar.FillWeight = 136.9213F;
            this.clAvatar.HeaderText = "Ảnh đại diện";
            this.clAvatar.MinimumWidth = 6;
            this.clAvatar.Name = "clAvatar";
            this.clAvatar.ReadOnly = true;
            this.clAvatar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clAvatar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clUsername
            // 
            this.clUsername.DataPropertyName = "USERNAME";
            this.clUsername.FillWeight = 93.79107F;
            this.clUsername.HeaderText = "Tài khoản";
            this.clUsername.MinimumWidth = 6;
            this.clUsername.Name = "clUsername";
            this.clUsername.ReadOnly = true;
            // 
            // PASS_WORD
            // 
            this.PASS_WORD.DataPropertyName = "PASS_WORD";
            this.PASS_WORD.HeaderText = "PASS_WORD";
            this.PASS_WORD.MinimumWidth = 6;
            this.PASS_WORD.Name = "PASS_WORD";
            this.PASS_WORD.ReadOnly = true;
            this.PASS_WORD.Visible = false;
            // 
            // clFullname
            // 
            this.clFullname.DataPropertyName = "FULLNAME";
            this.clFullname.FillWeight = 93.79107F;
            this.clFullname.HeaderText = "Họ tên";
            this.clFullname.MinimumWidth = 6;
            this.clFullname.Name = "clFullname";
            this.clFullname.ReadOnly = true;
            // 
            // clDienthoai
            // 
            this.clDienthoai.DataPropertyName = "DIENTHOAI";
            this.clDienthoai.FillWeight = 93.79107F;
            this.clDienthoai.HeaderText = "Số điện thoại";
            this.clDienthoai.MinimumWidth = 6;
            this.clDienthoai.Name = "clDienthoai";
            this.clDienthoai.ReadOnly = true;
            // 
            // clNote
            // 
            this.clNote.DataPropertyName = "NOTE";
            this.clNote.FillWeight = 93.79107F;
            this.clNote.HeaderText = "Note";
            this.clNote.MinimumWidth = 6;
            this.clNote.Name = "clNote";
            this.clNote.ReadOnly = true;
            // 
            // clRole
            // 
            this.clRole.DataPropertyName = "ROLE";
            this.clRole.FillWeight = 87.91444F;
            this.clRole.HeaderText = "Phân quyền";
            this.clRole.MinimumWidth = 6;
            this.clRole.Name = "clRole";
            this.clRole.ReadOnly = true;
            this.clRole.Visible = false;
            // 
            // panel_Bottom2
            // 
            this.panel_Bottom2.BackColor = System.Drawing.Color.White;
            this.panel_Bottom2.Controls.Add(this.panel_SoTrang);
            this.panel_Bottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom2.Location = new System.Drawing.Point(0, 614);
            this.panel_Bottom2.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Bottom2.Name = "panel_Bottom2";
            this.panel_Bottom2.Size = new System.Drawing.Size(1133, 62);
            this.panel_Bottom2.TabIndex = 7;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Bottom.Controls.Add(this.button_TimKiem);
            this.panel_Bottom.Controls.Add(this.textbox_TimKiem);
            this.panel_Bottom.Controls.Add(this.button_Xoa);
            this.panel_Bottom.Controls.Add(this.button_ChinhSua);
            this.panel_Bottom.Controls.Add(this.button_Tao);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 676);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1133, 62);
            this.panel_Bottom.TabIndex = 3;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_TimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_TimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_TimKiem.BorderRadius = 5;
            this.button_TimKiem.BorderSize = 0;
            this.button_TimKiem.FlatAppearance.BorderSize = 0;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimKiem.Font = new System.Drawing.Font("iCiel Cadena", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.ForeColor = System.Drawing.Color.White;
            this.button_TimKiem.Location = new System.Drawing.Point(306, 12);
            this.button_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(149, 39);
            this.button_TimKiem.TabIndex = 4;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.TextColor = System.Drawing.Color.White;
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
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
            this.textbox_TimKiem.Location = new System.Drawing.Point(13, 15);
            this.textbox_TimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.textbox_TimKiem.Multiline = false;
            this.textbox_TimKiem.Name = "textbox_TimKiem";
            this.textbox_TimKiem.Padding = new System.Windows.Forms.Padding(13, 9, 13, 7);
            this.textbox_TimKiem.PasswordChar = false;
            this.textbox_TimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TimKiem.PlaceholderText = "Tìm kiếm...";
            this.textbox_TimKiem.Size = new System.Drawing.Size(285, 33);
            this.textbox_TimKiem.TabIndex = 3;
            this.textbox_TimKiem.Texts = "";
            this.textbox_TimKiem.UnderlinedStyle = false;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Xoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Xoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Xoa.BorderRadius = 5;
            this.button_Xoa.BorderSize = 0;
            this.button_Xoa.FlatAppearance.BorderSize = 0;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("iCiel Cadena", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(657, 10);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(149, 39);
            this.button_Xoa.TabIndex = 2;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.TextColor = System.Drawing.Color.White;
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_ChinhSua
            // 
            this.button_ChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ChinhSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ChinhSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ChinhSua.BorderRadius = 5;
            this.button_ChinhSua.BorderSize = 0;
            this.button_ChinhSua.FlatAppearance.BorderSize = 0;
            this.button_ChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChinhSua.Font = new System.Drawing.Font("iCiel Cadena", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChinhSua.ForeColor = System.Drawing.Color.White;
            this.button_ChinhSua.Location = new System.Drawing.Point(815, 10);
            this.button_ChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ChinhSua.Name = "button_ChinhSua";
            this.button_ChinhSua.Size = new System.Drawing.Size(149, 39);
            this.button_ChinhSua.TabIndex = 1;
            this.button_ChinhSua.Text = "Chỉnh sửa";
            this.button_ChinhSua.TextColor = System.Drawing.Color.White;
            this.button_ChinhSua.UseVisualStyleBackColor = false;
            this.button_ChinhSua.Click += new System.EventHandler(this.button_ChinhSua_Click);
            // 
            // button_Tao
            // 
            this.button_Tao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Tao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Tao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Tao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Tao.BorderRadius = 5;
            this.button_Tao.BorderSize = 0;
            this.button_Tao.FlatAppearance.BorderSize = 0;
            this.button_Tao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tao.Font = new System.Drawing.Font("iCiel Cadena", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tao.ForeColor = System.Drawing.Color.White;
            this.button_Tao.Location = new System.Drawing.Point(971, 10);
            this.button_Tao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Tao.Name = "button_Tao";
            this.button_Tao.Size = new System.Drawing.Size(149, 39);
            this.button_Tao.TabIndex = 0;
            this.button_Tao.Text = "Tạo";
            this.button_Tao.TextColor = System.Drawing.Color.White;
            this.button_Tao.UseVisualStyleBackColor = false;
            this.button_Tao.Click += new System.EventHandler(this.button_Tao_Click);
            // 
            // form_ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 738);
            this.Controls.Add(this.panel_Bottom2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel_Bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_ThongTin";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.form_ThongTin_Load);
            this.panel_SoTrang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel_Bottom2.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel_SoTrang;
        private System.Windows.Forms.Label label_TongSoTrang;
        private System.Windows.Forms.Label label_TrangHienTai;
        private FontAwesome.Sharp.IconButton button_QuayLai;
        private FontAwesome.Sharp.IconButton button_TienLen;
        private System.Windows.Forms.Panel panel_Bottom2;
        private FontAwesome.Sharp.IconButton button_QuayLai2;
        private FontAwesome.Sharp.IconButton button_TienLen2;
        private Toolbox_Custom.Button_Custom button_Tao;
        private Toolbox_Custom.Button_Custom button_ChinhSua;
        private Toolbox_Custom.Button_Custom button_Xoa;
        private System.Windows.Forms.Panel panel_Bottom;
        private Toolbox_Custom.Textbox_Custom textbox_TimKiem;
        private System.Windows.Forms.DataGridViewImageColumn clAvatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASS_WORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRole;
        private Toolbox_Custom.Button_Custom button_TimKiem;
    }
}