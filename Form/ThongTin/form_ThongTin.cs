using QLS.DAO;
using QLS.Toolbox_Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using QLS.Resources;


namespace QLS
{
    public partial class form_ThongTin : Form
    {
        public DataGridViewRow row;
        string tk;
        bool check_giaodien, check_ngonngu;
        private int TotalPage = 0;
        private const int PgSize = 20;
        private int CurrentPageIndex = 1;
        private int TotalPageSearch = 0;
        private int CurrentPageIndexSearch = 1;
       
        public form_ThongTin(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            panel_Loading.BackColor = this.BackColor;
            dataGridView.RowTemplate.Height = 40;
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            vt = -1;
            dataGridView.ClearSelection();
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                if (this.CurrentPageIndexSearch < this.TotalPageSearch)
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    this.CurrentPageIndexSearch++;
                    label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
                    this.dataGridView.DataSource =
              AccountDAO.Instance.GetCurrentRecordsByKeyword(this.CurrentPageIndexSearch, textbox_TimKiem.Texts);
                }
                if (CurrentPageIndexSearch == TotalPageSearch)
                {
                    button_TienLen.BackColor = Color.DarkGray;
                    button_TienLen2.BackColor = Color.DarkGray;


                }
                else
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                }
                if (TotalPageSearch != 0 && TotalPageSearch != 1)
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
            else
            {
                if (this.CurrentPageIndex < this.TotalPage)
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    this.CurrentPageIndex++;
                    label_TrangHienTai.Text = CurrentPageIndex.ToString();
                    this.dataGridView.DataSource =
                AccountDAO.Instance.GetCurrentRecords(this.CurrentPageIndex);
                }
                if (CurrentPageIndex == TotalPage)
                {
                    button_TienLen.BackColor = Color.DarkGray;
                    button_TienLen2.BackColor = Color.DarkGray;

                }
                else
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

                }
            }
        }
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            vt = -1;
            dataGridView.ClearSelection();
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                if (this.CurrentPageIndexSearch > 1)
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    this.CurrentPageIndexSearch--;
                    label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
                    this.dataGridView.DataSource =
                AccountDAO.Instance.GetCurrentRecordsByKeyword(this.CurrentPageIndexSearch, textbox_TimKiem.Texts);
                }
                if (CurrentPageIndexSearch == 1)
                {
                    button_QuayLai.BackColor = Color.DarkGray;
                    button_QuayLai2.BackColor = Color.DarkGray;

                }
                else
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPageSearch != 0 && TotalPageSearch != 1)
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
            else
            {
                if (this.CurrentPageIndex > 1)
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    this.CurrentPageIndex--;
                    label_TrangHienTai.Text = CurrentPageIndex.ToString();
                    this.dataGridView.DataSource =
                AccountDAO.Instance.GetCurrentRecords(this.CurrentPageIndex);
                }
                if (CurrentPageIndex == 1)
                {
                    button_QuayLai.BackColor = Color.DarkGray;
                    button_QuayLai2.BackColor = Color.DarkGray;

                }
                else
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

                }
            }


        }
        private void CalculateTotalPages()
        {
            CurrentPageIndex = 1;
            int rowCount = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM TAIKHOAN");
            TotalPage = rowCount / PgSize;
           
            if (rowCount % PgSize > 0)
                TotalPage += 1;
            if (TotalPage == 1 || TotalPage == 0)
            {
                button_TienLen.BackColor = Color.DarkGray;
                button_TienLen2.BackColor = Color.DarkGray;
                button_QuayLai.BackColor = Color.DarkGray;
                button_QuayLai2.BackColor = Color.DarkGray;
            }
            else
            {
                button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_QuayLai.BackColor = Color.DarkGray;
                button_QuayLai2.BackColor = Color.DarkGray;
            }
            label_TongSoTrang.Text = "/ " + TotalPage.ToString();
            label_TrangHienTai.Text = CurrentPageIndex.ToString();
        }
        private void CalculateTotalPagesSearch()
        {
            CurrentPageIndexSearch = 1;
            int rowCount = AccountDAO.Instance.CountResult(textbox_TimKiem.Texts);

           
            TotalPageSearch = rowCount / PgSize;
            // if any row left after calculated pages, add one more page 
            if (rowCount % PgSize > 0)
                TotalPageSearch += 1;
            if (TotalPageSearch == 1 || TotalPageSearch == 0)
            {
                button_TienLen.BackColor = Color.DarkGray;
                button_TienLen2.BackColor = Color.DarkGray;
                button_QuayLai.BackColor = Color.DarkGray;
                button_QuayLai2.BackColor = Color.DarkGray;
            }
            else
            {
                button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_QuayLai.BackColor = Color.DarkGray;
                button_QuayLai2.BackColor = Color.DarkGray;
            }
            label_TongSoTrang.Text = "/ " + TotalPageSearch.ToString();
            label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
        }
        
        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
       
        private void button_Tao_Click(object sender, EventArgs e)
        {
            form_TaoTaiKhoanNguoiDung fttknd = new form_TaoTaiKhoanNguoiDung(tk);
            fttknd.Owner = this;
            fttknd.ShowDialog();
        }
        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                form_ChinhSuaTaiKhoanNguoiDung fcstknd = new form_ChinhSuaTaiKhoanNguoiDung(row, tk);
                fcstknd.Owner = this;
                fcstknd.ShowDialog();
            }
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                if (dataGridView.SelectedRows.Count == 1)
                {
                    form_XoaTaiKhoanNguoiDung fxtknd = new form_XoaTaiKhoanNguoiDung(row, tk);
                    fxtknd.Owner = this;
                    fxtknd.ShowDialog();
                }
                else
                {
                    List<string> listtk = new List<string>();
                    for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                    {
                        listtk.Add(dataGridView.SelectedRows[i].Cells[0].Value.ToString());
                    }
                    form_XoaTaiKhoanNguoiDung fxtknd = new form_XoaTaiKhoanNguoiDung(listtk, tk);
                    fxtknd.Owner = this;
                    fxtknd.ShowDialog();
                }

            }
        }

        public int vt = -1;
        public void form_ThongTin_Load(object sender, EventArgs e)
        {
            panel_Loading.Visible = true;
            timer1.Start();
            if (!check_giaodien)
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_White_01;
                dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_White_01;
            }
            else
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_Black_01;
                dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            }
        }
      
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }

            row = dataGridView.Rows[vt];
            if (!check_giaodien)
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            }
            else
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            }

        }
        private void Update_GiaoDien_NgonNgu()
        {
            // Giao diện
            if (KiemTraGiaoDien(tk))
            {
                Change_Color_Black();
                check_giaodien = true;
            }
            else
            {
                Change_Color_White();
                check_giaodien = false;
            }
            // Ngôn ngữ
            if (KiemTraNgonNgu(tk))
            {
                Change_Language_EN();
                check_ngonngu = true;
            }
            else
            {
                Change_Language_VI();
                check_ngonngu = false;
            }
        }
        public bool KiemTraGiaoDien(string userName)
        {
            string query = "SELECT * FROM dbo.CAIDAT WHERE TAI_KHOAN = N'" + userName + "' AND GIAO_DIEN = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Color_White()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            panel_Bottom2.BackColor = CaiDatDAO.Instance.color_BG_White_01;

            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //DataGirdview
            dataGridView.BackgroundColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            dataGridView.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_White_01;

        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            panel_Bottom2.BackColor = CaiDatDAO.Instance.color_BG_Black_01;

            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //DataGirdview
            dataGridView.BackgroundColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            dataGridView.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAIDAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            button_Tao.Text = "Tạo";
            button_ChinhSua.Text = "Chỉnh sửa";
            button_Xoa.Text = "Xóa";
            textbox_TimKiem.PlaceholderText = "Tìm kiếm...";

            dataGridView.Columns[0].HeaderText = "Ảnh đại diện";
            dataGridView.Columns[1].HeaderText = "Tài khoản";
            dataGridView.Columns[3].HeaderText = "Họ tên";
            dataGridView.Columns[4].HeaderText = "Số điện thoại";
            dataGridView.Columns[5].HeaderText = "Ghi chú";
            dataGridView.Columns[6].HeaderText = "Quyền";
            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            CalculateTotalPages();
            dataGridView.DataSource = AccountDAO.Instance.GetCurrentRecords(CurrentPageIndex);
            panel_Loading.Visible = false;
            timer1.Stop();
        }

        private void button_TienLen2_Click(object sender, EventArgs e)
        {
            vt = -1;
            dataGridView.ClearSelection();
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                if (this.CurrentPageIndexSearch < this.TotalPageSearch)
                {
                    button_TienLen2.BackColor = Color.DarkGray;
                    this.CurrentPageIndexSearch = TotalPageSearch;
                    label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
                    this.dataGridView.DataSource =
              AccountDAO.Instance.GetCurrentRecordsByKeyword(this.TotalPageSearch, textbox_TimKiem.Texts);
                }
                if (CurrentPageIndexSearch == TotalPageSearch)
                {
                    button_TienLen2.BackColor = Color.DarkGray;
                    button_TienLen.BackColor = Color.DarkGray;
                }
                else
                {
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
            else
            {
                if (this.CurrentPageIndex < this.TotalPage)
                {
                    button_TienLen2.BackColor = Color.DarkGray;
                    this.CurrentPageIndex = TotalPage;
                    label_TrangHienTai.Text = CurrentPageIndex.ToString();
                    this.dataGridView.DataSource =
                AccountDAO.Instance.GetCurrentRecords(this.TotalPage);
                }
                if (CurrentPageIndex == TotalPage)
                {
                    button_TienLen2.BackColor = Color.DarkGray;
                    button_TienLen.BackColor = Color.DarkGray;
                }
                else
                {
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
        }

        private void button_QuayLai2_Click(object sender, EventArgs e)
        {
            vt = -1;
            dataGridView.ClearSelection();
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                if (this.CurrentPageIndexSearch > 1)
                {
                    button_QuayLai2.BackColor = Color.DarkGray;
                    this.CurrentPageIndexSearch = 1;
                    label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
                    this.dataGridView.DataSource =
                AccountDAO.Instance.GetCurrentRecordsByKeyword(this.CurrentPageIndexSearch, textbox_TimKiem.Texts);
                }
                if (CurrentPageIndexSearch == 1)
                {
                    button_QuayLai2.BackColor = Color.DarkGray;
                    button_QuayLai.BackColor = Color.DarkGray;

                }
                else
                {
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPageSearch != 0 && TotalPageSearch != 1)
                {
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
            else
            {
                if (this.CurrentPageIndex > 1)
                {
                    button_QuayLai2.BackColor = Color.DarkGray;
                    this.CurrentPageIndex = 1;
                    label_TrangHienTai.Text = CurrentPageIndex.ToString();
                    this.dataGridView.DataSource =
                AccountDAO.Instance.GetCurrentRecords(this.CurrentPageIndex);
                }
                if (CurrentPageIndex == 1)
                {
                    button_QuayLai2.BackColor = Color.DarkGray;
                    button_QuayLai.BackColor = Color.DarkGray;

                }
                else
                {
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
        }

        public void Change_Language_EN()
        {
            button_Tao.Text = "Create";
            button_ChinhSua.Text = "Edit";
            button_Xoa.Text = "Delete";
            textbox_TimKiem.PlaceholderText = "Search...";

            dataGridView.Columns[0].HeaderText = "Avatar";
            dataGridView.Columns[1].HeaderText = "Account";
            dataGridView.Columns[3].HeaderText = "Full name";
            dataGridView.Columns[4].HeaderText = "Phone number";
            dataGridView.Columns[5].HeaderText = "Note";
            dataGridView.Columns[6].HeaderText = "Role";
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["clAvatar"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                if (e.Value != null)
                {
                    Image img = DataProvider.Instance.ByteToImage((byte[])e.Value);
                    int imgWidth = 35; // Chiều rộng cố định của ảnh
                    int imgHeight = 35; // Chiều cao cố định của ảnh
                    int x = e.CellBounds.Left + (e.CellBounds.Width - imgWidth) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - imgHeight) / 2;
                    e.Graphics.DrawImage(img, new Rectangle(x, y, imgWidth, imgHeight));
                }

                e.Handled = true;
            }
        }

        public void UpdateColorApp()
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Tao.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_ChinhSua.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
