using QLS.DAO;
using QLS.Resources;
using QLS.Toolbox_Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLS
{
    public partial class form_ChinhSuaSach : Form
    {
        List<Textbox_Custom> textbox_Customs = new List<Textbox_Custom>();
        string tk;
        bool check_giaodien, check_ngonngu;
        public Image avatar;
        public form_ChinhSuaSach( DataGridViewRow row, string tk)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            label_Loi.ResetText();
            AddListTextBox();
            Reset();
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            textbox_MaSach.Enabled = false;
            pictureBox_AnhDaiDien.Image = null;

            textbox_MaSach.Texts = row.Cells[0].Value.ToString();
            textbox_TenSach.Texts = row.Cells[1].Value.ToString();
            textbox_TacGia.Texts = row.Cells[2].Value.ToString();
            textbox_TheLoai.Texts = row.Cells[3].Value.ToString();
            textbox_GiaMua.Texts = row.Cells[4].Value.ToString();
            textbox_GiaBia.Texts = row.Cells[5].Value.ToString();
            textbox_NXB.Texts = row.Cells[6].Value.ToString();
            textbox_NamXuatBan.Texts = row.Cells[7].Value.ToString();
            pictureBox_AnhDaiDien.Image = DataProvider.Instance.ByteToImage((byte[])row.Cells[8].Value);
        }
        private void form_ChinhSuaSach_Load(object sender, EventArgs e)
        {
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Events
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            var f = (form_Sach)this.Owner;
            f.vt = -1;
            f.dataGridView.ClearSelection();
        }

        private void pictureBox_AnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox_AnhDaiDien.Image = Image.FromFile(openFile.FileName);
                pictureBox_AnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
                form_CapNhatAnh f = new form_CapNhatAnh(tk, Image.FromFile(openFile.FileName));
                f.Owner = this;
                f.Show();
            }
        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            Reset();
            if (KiemTra(textbox_Customs))
            {
                if (ThemSach())
                {
                    var f = this.Owner as form_Sach;
                    this.Close();
                    f.dataGridView.DataSource = SachDAO.Instance.GetCurrentRecords(f.CurrentPageIndex);
                    f.dataGridView.ClearSelection();
                }
                else
                {
                    if (!check_ngonngu)
                    {
                        label_Loi.Text = "Có lỗi xảy ra";
                    }
                    else
                    {
                        label_Loi.Text = "An error occurred";
                    }
                }
            }

        }

        #endregion

        #region Methods

        private bool ThemSach()
        {
            string maSach = textbox_MaSach.Texts;
            string tenSach = textbox_TenSach.Texts;
            string theLoai = textbox_TheLoai.Texts;
            string tacGia = textbox_TacGia.Texts;
            string nhaXuatBan = textbox_NXB.Texts;
            int namXuatBan = textbox_NamXuatBan.Texts == "" ? 0 : int.Parse(textbox_NamXuatBan.Texts);
            int giaMua = int.Parse(textbox_GiaMua.Texts);
            int giaBia = int.Parse(textbox_GiaBia.Texts);
            byte[] avatar = DataProvider.Instance.ImageToBase64(Properties.Resources.Default_Avt, Properties.Resources.Default_Avt.RawFormat);
            if (((PictureBox_Custom)pictureBox_AnhDaiDien).Image != null)
            {
                avatar = DataProvider.Instance.ImageToByte(((PictureBox_Custom)pictureBox_AnhDaiDien).Image);
            }


            bool data = false;

            data = SachDAO.Instance.SuaSach(maSach, tenSach, theLoai, tacGia,  nhaXuatBan, namXuatBan,giaMua, giaBia, avatar);

            return data;
        }

        void AddListTextBox()
        {
            textbox_Customs.Add(textbox_MaSach);
            textbox_Customs.Add(textbox_TenSach);
            textbox_Customs.Add(textbox_GiaMua);
            textbox_Customs.Add(textbox_GiaBia);
        }


        private bool KiemTra(List<Textbox_Custom> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Texts.Trim().Equals(""))
                {
                    ls[i].BorderFocusColor = CaiDatDAO.Instance.color_Text_Red;
                    ls[i].BorderColor = CaiDatDAO.Instance.color_Text_Red;
                    ls[i].Focus();
                    if (!check_ngonngu)
                    {
                        label_Loi.Text = "Bạn chưa nhập " + ls[i].PlaceholderText;
                    }
                    else
                    {
                        label_Loi.Text = "You have not entered " + ls[i].PlaceholderText;
                    }
                    return false;
                }
            }

            return true;

        }
        private void Reset()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Textbox_Custom)
                {
                    ((Textbox_Custom)x).Text = String.Empty;
                    ((Textbox_Custom)x).BorderColor = CaiDatDAO.Instance.color_BG_Blue_01;
                    ((Textbox_Custom)x).BorderFocusColor = CaiDatDAO.Instance.color_BG_Blue_02;
                }
            }
            label_Loi.ResetText();

        }
        #endregion

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
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            pictureBox_Icon.Image = QLS.Properties.Resources.Icon;

            //Button
            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            // PictureBox
            pictureBox_AnhDaiDien.Image = QLS.Properties.Resources.BG_Upload;

            //Textbox
            textbox_TenSach.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TenSach.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TenSach.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_MaSach.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_MaSach.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_MaSach.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_GiaMua.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_GiaMua.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_GiaMua.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_GiaBia.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_GiaBia.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_GiaBia.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_TacGia.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TacGia.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TacGia.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NXB.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_NXB.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_NXB.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NamXuatBan.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_NamXuatBan.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_NamXuatBan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_TheLoai.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TheLoai.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TheLoai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = QLS.Properties.Resources.Icon_Black;

            //Button
            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            // PictureBox
            pictureBox_AnhDaiDien.Image = QLS.Properties.Resources.BG_Upload_Black;

            //Textbox
            textbox_TenSach.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TenSach.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TenSach.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_MaSach.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_MaSach.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_MaSach.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_GiaMua.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_GiaMua.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_GiaMua.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_GiaBia.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_GiaBia.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_GiaBia.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_TacGia.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TacGia.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TacGia.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NXB.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_NXB.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_NXB.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NamXuatBan.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_NamXuatBan.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_NamXuatBan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_TheLoai.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TheLoai.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TheLoai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAIDAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            textbox_TenSach.PlaceholderText = "Tên sách";
            textbox_MaSach.PlaceholderText = "Mã sách";
            textbox_GiaMua.PlaceholderText = "Giá mua";
            textbox_GiaBia.PlaceholderText = "Giá bìa";
            textbox_TacGia.PlaceholderText = "Tác giả";
            textbox_NXB.PlaceholderText = "Nhà xuất bản";
            textbox_NamXuatBan.PlaceholderText = "Năm xuất bản";
            textbox_TheLoai.PlaceholderText = "Thể loại";
        }

        private void textbox_SoTienThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        public void Change_Language_EN()
        {
            textbox_TenSach.PlaceholderText = "Book name";
            textbox_MaSach.PlaceholderText = "Book code";
            textbox_GiaMua.PlaceholderText = "Purchase price";
            textbox_GiaBia.PlaceholderText = "Cover price";
            textbox_TacGia.PlaceholderText = "Author";
            textbox_NXB.PlaceholderText = "Publisher";
            textbox_NamXuatBan.PlaceholderText = "Publishing year";
            textbox_TheLoai.PlaceholderText = "Category";
        }

        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_Tao.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_TenSach.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TenSach.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_MaSach.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_MaSach.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_GiaMua.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_GiaMua.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_GiaBia.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_GiaBia.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_TacGia.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TacGia.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_NXB.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_NXB.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_NamXuatBan.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_NamXuatBan.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_TheLoai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TheLoai.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_AnhDaiDien.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_AnhDaiDien.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;

        }
    }
}
