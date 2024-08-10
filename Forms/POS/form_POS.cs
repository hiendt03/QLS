using CrystalDecisions.Shared;
using QLS.DAO;
using QLS.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using QLS.DTO;


namespace QLS.Forms.POS
{
   

    public partial class form_POS : Form
    {
        string tk;
        bool check_giaodien, check_ngonngu;
        int vt = -1;
        DataGridViewRow row;
        public List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
        int tongtien = 0;
        public string MAHOADON = "";
        public form_POS(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            label_Loi1.Text = "";
            Update_GiaoDien_NgonNgu();
            dataGridView.DataSource = SachDAO.Instance.GetCurrentRecords(1, 100);
            listView1.Clear(); 
            listView1.View = View.Details; 
            listView1.Columns.Add("Mã Sách", 100);      
            listView1.Columns.Add("Số lượng", 100);    
            listView1.Columns.Add("Thành Tiền", 100);
            MAHOADON = DateTime.Now.ToString("yyMMddHHmmss");
        }


        private string TinhTongTien()
        {
            tongtien = 0;
            foreach (ChiTietHoaDon cthd in list)
            {
                tongtien += cthd.THANHTIEN;
            }

            return string.Format("{0:#,##0}", tongtien);
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

        private void form_POS_Load(object sender, EventArgs e)
        {
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
            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_SDT.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_SDT.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_SDT.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_TenKH.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TenKH.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TenKH.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            button_ThanhToan.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_ThemKhach.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_TimKhach.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            label1.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            label_TongTien.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

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
            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_SDT.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_SDT.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_SDT.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_TenKH.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TenKH.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TenKH.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            button_ThanhToan.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_ThemKhach.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_TimKhach.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            label1.ForeColor = CaiDatDAO.Instance.color_Text_DarkGray;
            label_TongTien.ForeColor = CaiDatDAO.Instance.color_Text_DarkGray;

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
            textbox_TimKiem.PlaceholderText = "Tìm kiếm...";
            textbox_SDT.PlaceholderText = "Số điện thoại...";
            textbox_TenKH.PlaceholderText = "Tên khách hàng...";
            button_ThanhToan.Text = "Thanh toán";
            button_ThemKhach.Text = "Thêm";
            button_TimKhach.Text = "Tìm";
            button_Xoa.Text = "Xóa";

            dataGridView.Columns[0].HeaderText = "Mã sách";
            dataGridView.Columns[1].HeaderText = "Tên sách";
            dataGridView.Columns[8].HeaderText = "Hình ảnh";
            dataGridView.Columns[5].HeaderText = "Giá tiền";
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Height = 40;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }

            row = dataGridView.Rows[vt];
            //if exist in list, add 1
            bool trung = false;
            foreach (ChiTietHoaDon cthd in list)
            {
                if (cthd.MASACH == row.Cells[0].Value.ToString())
                {
                    cthd.SOLUONG++;
                    cthd.THANHTIEN = cthd.SOLUONG * cthd.GIATIEN;
                    label_TongTien.Text = TinhTongTien();
                    trung = true;
                    break;
                }
            }

            if (!trung)
            {
                list.Add(new ChiTietHoaDon
                {
                    MAHOADON = MAHOADON,
                    MASACH = row.Cells[0].Value.ToString(),
                    SOLUONG = 1,
                    GIATIEN = int.Parse(row.Cells[5].Value.ToString(), NumberStyles.AllowThousands, CultureInfo.InvariantCulture),
                    THANHTIEN = int.Parse(row.Cells[5].Value.ToString(), NumberStyles.AllowThousands, CultureInfo.InvariantCulture)
                });
                label_TongTien.Text = TinhTongTien();
            }

            listView1.Items.Clear();
            foreach (ChiTietHoaDon cthd in list)
            {
                ListViewItem item = new ListViewItem(cthd.MASACH);
                item.SubItems.Add(cthd.SOLUONG.ToString());
                item.SubItems.Add(cthd.THANHTIEN.ToString());
                listView1.Items.Add(item);
            }

            if (!check_giaodien)
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            }
            else
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                return;
            }
            foreach (ChiTietHoaDon cthd in list)
            {
                if (cthd.MASACH == row.Cells[0].Value.ToString())
                {
                    list.Remove(cthd);
                    break;
                }
            }
            listView1.Items.Clear();
            foreach (ChiTietHoaDon cthd in list)
            {
                ListViewItem item = new ListViewItem(cthd.MASACH);
                item.SubItems.Add(cthd.SOLUONG.ToString());
                item.SubItems.Add(cthd.THANHTIEN.ToString());
                listView1.Items.Add(item);
            }
        }

        private void button_TimKhach_Click(object sender, EventArgs e)
        {
            label_Loi1.Text = "";
            string sdt = textbox_SDT.Texts;
            if (sdt == "")
            {
                return;
            }
            DataTable dt = KhachHangDAO.Instance.getKHACHHANG(sdt);
            if (dt.Rows.Count == 0)
            {
                label_Loi1.Text = "Không tìm thấy khách hàng, vui lòng nhập thêm tên để thêm khách hàng!";
                return;
            }
            textbox_TenKH.Texts = dt.Rows[0]["TENKH"].ToString();
        }

        private void button_ThemKhach_Click(object sender, EventArgs e)
        {
            label_Loi1.Text = "";
            if(textbox_TenKH.Texts == "" || textbox_SDT.Texts == "")
            {
                return;
            }

            if (KhachHangDAO.Instance.KiemTraTrung(textbox_SDT.Texts))
            {
                label_Loi1.Text = "Số điện thoại đã tồn tại!";
                return;
            }

            if (KhachHangDAO.Instance.ThemKHACHHANG(textbox_SDT.Texts, textbox_TenKH.Texts, "", textbox_SDT.Texts, ""))
            {
                label_Loi1.Text = "Thêm khách hàng thành công!";
            }
            else
            {
                label_Loi1.Text = "Thêm khách hàng thất bại!";
            }
        }

        private void textbox_TimKiem__TextChanged(object sender, EventArgs e)
        {
            vt = -1;
            dataGridView.DataSource = SachDAO.Instance.GetCurrentRecords(1, 100, textbox_TimKiem.Texts);
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                return;
            }

            if (textbox_SDT.Texts == "" || textbox_TenKH.Texts == "")
            {
                return;
            }

            if (HoaDonDAO.Instance.ThemHOADON(MAHOADON, textbox_SDT.Texts, tongtien))
            {
                foreach (ChiTietHoaDon cthd in list)
                {
                    HoaDonDAO.Instance.ThemChiTietHoaDon(cthd.MAHOADON, cthd.MASACH, cthd.SOLUONG, cthd.GIATIEN, cthd.THANHTIEN);
                }
                label_Loi1.Text = "Thanh toán thành công!";
                

                ExportBillReport(this.MAHOADON);
                list.Clear();
                listView1.Items.Clear();
                label_TongTien.Text = "";
                textbox_SDT.Texts = "";
                textbox_TenKH.Texts = "";

            }
            else
            {
                label_Loi1.Text = "Thanh toán thất bại!";
            }

           
        }

        private void ExportBillReport(string MAHOADON)
        {
            try
            {
                form_Bill form_Bill = new form_Bill(MAHOADON, textbox_TenKH.Texts, textbox_SDT.Texts, list);
                form_Bill.Owner = this;
                form_Bill.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất hóa đơn thất bại! Lỗi: " + ex.Message);
            }
        }

        public void Change_Language_EN()
        {
            textbox_TimKiem.PlaceholderText = "Search...";
            textbox_SDT.PlaceholderText = "Phone number...";
            textbox_TenKH.PlaceholderText = "Customer name...";
            button_ThanhToan.Text = "Pay";
            button_ThemKhach.Text = "Add";
            button_TimKhach.Text = "Search";
            button_Xoa.Text = "Delete";

            dataGridView.Columns[0].HeaderText = "Book ID";
            dataGridView.Columns[1].HeaderText = "Book name";
            dataGridView.Columns[8].HeaderText = "Image";
            dataGridView.Columns[5].HeaderText = "Price";

        }
        
    }


}
