using QLS.Properties;
using QLS.Toolbox_Custom;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLS
{
    public partial class frmSach : Form
    {
        private Button_Custom currentBtn;
        private Panel leftBorderBtn;
        private int PgSize = 10;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;
        private DataGridViewRow row;

        public frmSach()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(120, 3);
            panel_Top.Controls.Add(leftBorderBtn);
            panel_Loading.BackColor = this.BackColor;

        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            CurrentPageIndex++;
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            CurrentPageIndex--;
        }

        private void CurrentPageIndexChange(object sender, EventArgs e)
        {
            CalculateTotalPages();
        }
        private void CalculateTotalPages()
        {
            // Tính tổng số trang
            string query = "Select Count(*) From SACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int TotalRecord = int.Parse(data.Rows[0][0].ToString());
            TotalPage = TotalRecord / PgSize;
            if (TotalRecord % PgSize > 0)
            {
                TotalPage++;
            }
            if (TotalPage == 0)
            {
                TotalPage = 1;
            }
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvSach.Columns.Count; i++)
            {
                dgvSach.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            frmSuaSach fcstknd = new frmSuaSach();
            fcstknd.Owner = this;
            fcstknd.ShowDialog();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                string MaSach = row.Cells[0].Value.ToString();
                string query = "Delete From SACH Where MASACH = '" + MaSach + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Đã xóa!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Chưa chọn sách nào!", "Thông báo");
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            frmThemSach fttknd = new frmThemSach();
            fttknd.Owner = this;
            fttknd.ShowDialog();
        }
        public void frmSach_Load(object sender, EventArgs e)
        {
            ActivateButton(btnSach);
            CurrentPageIndex = 1;
            CalculateTotalPages();
        }

        public void ActivateButton(object senderBtn)
        {
            if (senderBtn != null && senderBtn is Button_Custom)
            {
                DisableButton();
                currentBtn = (Button_Custom)senderBtn;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.Padding = new Padding(0, 0, 10, 0);
                leftBorderBtn.BackColor = currentBtn.BackColor;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y + 40);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.Padding = new Padding(0, 0, 0, 0);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSach.Rows.Count)
            {
                row = dgvSach.Rows[e.RowIndex];
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void button_TienLen2_Click(object sender, EventArgs e)
        {
            if (CurrentPageIndex < TotalPage)
            {
                CurrentPageIndex++;
            }
        }

        private void button_QuayLai2_Click(object sender, EventArgs e)
        {
            if (CurrentPageIndex > 1)
            {
                CurrentPageIndex--;
            }
        }

        private void bSach_Click(object sender, EventArgs e)
        {
            panel_Loading.Visible = false;

            string query = "Select MASACH, TENSACH, TENTG, TENLINHVUC, TENLOAISACH, " +
                "GIABIA, LANTAIBAN, TENNHAXUATBAN, NAMXUATBAN From SACH LEFT JOIN TACGIA " +
                "ON SACH.MATG = TACGIA.MATG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            dgvSach.Columns.Clear();
            dgvSach.AutoGenerateColumns = true;

            dgvSach.DataSource = data;
            dgvSach.ClearSelection();

            dgvSach.Columns[0].HeaderText = "MÃ SÁCH";
            dgvSach.Columns[1].HeaderText = "TÊN SÁCH";
            dgvSach.Columns[2].HeaderText = "TÁC GIẢ";
            dgvSach.Columns[3].HeaderText = "LĨNH VỰC";
            dgvSach.Columns[4].HeaderText = "LOẠI SÁCH";
            dgvSach.Columns[5].HeaderText = "GIÁ BÌA";
            dgvSach.Columns[6].HeaderText = "LẦN TÁI BẢN";
            dgvSach.Columns[7].HeaderText = "TÊN NXB";
            dgvSach.Columns[8].HeaderText = "NĂM XUẤT BẢN";

            dgvSach.Columns[0].Width = 80;
            dgvSach.Columns[1].Width = 80;
            dgvSach.Columns[2].Width = 80;
            dgvSach.Columns[3].Width = 80;
            dgvSach.Columns[4].Width = 80;
            dgvSach.Columns[5].Width = 80;
            dgvSach.Columns[6].Width = 80;
            dgvSach.Columns[7].Width = 80;
            dgvSach.Columns[8].Width = 80;

            dgvSach.Columns[5].DefaultCellStyle.Format = "N0";
            dgvSach.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSach.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSach.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void bKho_Click(object sender, EventArgs e)
        {
            // show in this form
            string query = "Select SACH.MASACH, TENSACH, SOLUONG From KHO LEFT JOIN SACH ON KHO.MASACH = SACH.MASACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            dgvSach.DataSource = data;
            dgvSach.ClearSelection();

            dgvSach.Columns[0].HeaderText = "MÃ SÁCH";
            dgvSach.Columns[1].HeaderText = "TÊN SÁCH";
            dgvSach.Columns[2].HeaderText = "SỐ LƯỢNG";

            dgvSach.Columns[0].Width = 80;
            dgvSach.Columns[1].Width = 80;
            dgvSach.Columns[2].Width = 80;

            dgvSach.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void bKhachHang_Click(object sender, EventArgs e)
        {
            string query = "Select TENKHACHHANG, TONGTIEN, NGAYLAP From HOADON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            dgvSach.DataSource = data;
            dgvSach.ClearSelection();

            dgvSach.Columns[0].HeaderText = "TÊN KHÁCH HÀNG";
            dgvSach.Columns[1].HeaderText = "TỔNG TIỀN";
            dgvSach.Columns[2].HeaderText = "NGÀY LẬP";

            dgvSach.Columns[0].Width = 80;
            dgvSach.Columns[1].Width = 80;
            dgvSach.Columns[2].Width = 80;

            dgvSach.Columns[1].DefaultCellStyle.Format = "N0";
            dgvSach.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

    }
}
