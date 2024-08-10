using QLS.DAO;
using QLS.DTO;
using QLS.Resources;
using QLS.Toolbox_Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLS
{
    public partial class form_ChinhSuaTaiKhoanNguoiDung : Form
    {
        List<Textbox_Custom> textbox_Customs = new List<Textbox_Custom>();
        List<EditCompo> listEdit = new List<EditCompo>();
        public DataGridViewRow row;
        string tk;
        bool check_giaodien, check_ngonngu;

        public form_ChinhSuaTaiKhoanNguoiDung(DataGridViewRow row, string tk)
        {
            InitializeComponent();
            this.row = row;
            this.tk = tk;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            AddListTextBox();
            Reset();
            
            textbox_TaiKhoan.Enabled = false;
            label_Loi.ResetText();
            pictureBox_AnhDaiDien.Image = null;

            textbox_TaiKhoan.Texts = row.Cells[0].Value.ToString();
            textbox_MatKhau.Texts = row.Cells[1].Value.ToString();
            combobox_Role.SelectedIndex = Int32.Parse(row.Cells[2].Value.ToString()) - 1;
            textbox_Note.Texts = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value != DBNull.Value)
            {
                byte[] img = (byte[])row.Cells[4].Value;
                pictureBox_AnhDaiDien.Image = DataProvider.Instance.Base64ToImage(img);
            }
            textbox_HoVaTen.Texts = row.Cells[5].Value.ToString();
            textbox_DienThoai.Texts = row.Cells[6].Value.ToString();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #region Methods

        void AddListTextBox()
        {
            textbox_Customs.Add(textbox_TaiKhoan);
            textbox_Customs.Add(textbox_MatKhau);
            textbox_Customs.Add(textbox_HoVaTen);
            textbox_Customs.Add(textbox_Note);
            textbox_Customs.Add(textbox_DienThoai);
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

            // check combobox_role
            if (combobox_Role.SelectedIndex == -1)
            {
                combobox_Role.BorderColor = CaiDatDAO.Instance.color_Text_Red;
                combobox_Role.Focus();
                if (!check_ngonngu)
                {
                    label_Loi.Text = "Bạn chưa chọn chức vụ";
                }
                else
                {
                    label_Loi.Text = "You have not selected a role";
                }
                return false;
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
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            // PictureBox
            pictureBox_AnhDaiDien.Image = QLS.Properties.Resources.BG_Upload;

            //Textbox
            textbox_TaiKhoan.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TaiKhoan.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TaiKhoan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_MatKhau.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_MatKhau.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_MatKhau.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_HoVaTen.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_HoVaTen.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_HoVaTen.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;


            textbox_Note.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Note.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Note.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_DienThoai.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_DienThoai.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_DienThoai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            combobox_Role.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_Role.ListBackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_Role.ListTextColor = CaiDatDAO.Instance.color_Text_White_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = QLS.Properties.Resources.Icon_Black;

            //Button
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            // PictureBox
            pictureBox_AnhDaiDien.Image = QLS.Properties.Resources.BG_Upload_Black;

            //Textbox
            textbox_TaiKhoan.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TaiKhoan.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TaiKhoan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_MatKhau.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_MatKhau.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_MatKhau.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_HoVaTen.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_HoVaTen.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_HoVaTen.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Note.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Note.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Note.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_DienThoai.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_DienThoai.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_DienThoai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            combobox_Role.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_Role.ListBackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_Role.ListTextColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAIDAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            textbox_HoVaTen.PlaceholderText = "Họ và tên";
            textbox_TaiKhoan.PlaceholderText = "Tài khoản";
            textbox_MatKhau.PlaceholderText = "Mật khẩu";
            textbox_Note.PlaceholderText = "Ghi chú";
            textbox_DienThoai.PlaceholderText = "Điện thoại";
            combobox_Role.Texts = "Chức vụ";

            combobox_Role.Items.Add("Quản trị viên");
            combobox_Role.Items.Add("Nhân viên bán hàng");
            combobox_Role.Items.Add("Nhân viên kho");
        }

        public void Change_Language_EN()
        {
            textbox_HoVaTen.PlaceholderText = "Full name";
            textbox_TaiKhoan.PlaceholderText = "Account";
            textbox_MatKhau.PlaceholderText = "Password";
            textbox_Note.PlaceholderText = "Note";
            textbox_DienThoai.PlaceholderText = "Phone";
            combobox_Role.Texts = "Role";

            combobox_Role.Items.Add("Administrator");
            combobox_Role.Items.Add("Sales staff");
            combobox_Role.Items.Add("Warehouse staff");
        }

        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            Reset();
            if (KiemTra(textbox_Customs))
            {
                if (SuaNguoiDung())
                {
                    var f = this.Owner as form_ThongTin;
                    this.Close();
                    f.dataGridView.DataSource = AccountDAO.Instance.GetCurrentRecords(f.CurrentPageIndex);
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

        private bool SuaNguoiDung()
        {
            string tk = textbox_TaiKhoan.Texts;
            string mk = textbox_MatKhau.Texts;
            int role = combobox_Role.SelectedIndex + 1;
            string note = textbox_Note.Texts;
            byte[] avatar = DataProvider.Instance.ImageToBase64(Properties.Resources.Default_Avt, Properties.Resources.Default_Avt.RawFormat);
            if (((PictureBox_Custom)pictureBox_AnhDaiDien).Image != null)
            {
                avatar = DataProvider.Instance.ImageToByte(((PictureBox_Custom)pictureBox_AnhDaiDien).Image);
            }
            string fullname = textbox_HoVaTen.Texts;
            string phone = textbox_DienThoai.Texts;

            bool data = false;

            data = AccountDAO.Instance.SuaNguoiDung(tk, mk, role, note, avatar, fullname, phone);

            return data;
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
                form_CapNhatAnhDaiDien f = new form_CapNhatAnhDaiDien(tk, Image.FromFile(openFile.FileName));
                f.Owner = this;
                f.Show();
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            var f = (form_ThongTin)this.Owner;
            f.vt = -1;
            f.dataGridView.ClearSelection();
        }

        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_ChinhSua.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_TaiKhoan.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TaiKhoan.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_MatKhau.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_MatKhau.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_HoVaTen.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_HoVaTen.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Note.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Note.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_DienThoai.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_DienThoai.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            combobox_Role.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_Role.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_AnhDaiDien.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_AnhDaiDien.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;

        }
    }
}
