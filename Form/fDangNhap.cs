using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QLS
{
    public partial class frmDangNhap : Form
    {
        private bool boolHienMatKhau;
        DataTable result = null;
        public int current = 0;
        public static Random random = new Random();
        public int num = random.Next(1, 5);
        public frmDangNhap()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            label_Loi.Text = string.Empty;
            Change_Image();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Login(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM TAIKHOAN WHERE USERNAME = @username AND PASS_WORD = @password AND ROLE = 1";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password)
                };
                result = DataProvider.Instance.ExecuteQuery(query, parameters);
                return result.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void bDangNhap_Click(object sender, EventArgs e)
        {

            Reset();
            if (string.IsNullOrWhiteSpace(txbTenDangNhap.Texts))
            {
                label_Loi.Text = "Bạn chưa nhập tài khoản";
                txbTenDangNhap.Focus();
                txbTenDangNhap.BorderColor = Color.FromArgb(250, 80, 100);
                txbTenDangNhap.BorderFocusColor = Color.FromArgb(250, 80, 100);
            }
            else if (string.IsNullOrWhiteSpace(txbMatKhau.Texts))
            {
                label_Loi.Text = "Bạn chưa nhập mật khẩu";
                txbMatKhau.Focus();
                txbMatKhau.BorderColor = Color.FromArgb(250, 80, 100);
                txbMatKhau.BorderFocusColor = Color.FromArgb(250, 80, 100);
            }
            else
            {
                string username = txbTenDangNhap.Texts.Trim();
                string password = txbMatKhau.Texts.Trim();
                if (Login(username, password))
                {
                    this.Hide();
                    form_Chinh form = new form_Chinh(username);
                    txbTenDangNhap.Enabled = false;
                    txbMatKhau.Enabled = false;
                    form.Owner = this;
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    label_Loi.Text = "Tài khoản hoặc mật khẩu không chính xác";
                }
            }
        }
        private void Reset()
        {
            label_Loi.Text = string.Empty;
            txbTenDangNhap.BorderColor = Color.FromArgb(226, 226, 226);
            txbTenDangNhap.BorderFocusColor = Color.FromArgb(58, 182, 148);
            txbMatKhau.BorderColor = Color.FromArgb(226, 226, 226);
            txbMatKhau.BorderFocusColor = Color.FromArgb(58, 182, 148);
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN THẬT SỰ MUỐN THOÁT CHƯƠNG TRÌNH?", "THÔNG BÁO", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        public void Change_Image()
        {
            if (num == 1)
            {
                pictureBox_Image.Image = QLS.Properties.Resources.BG_Login_Image_01;
            }
            else if (num == 2)
            {
                pictureBox_Image.Image = QLS.Properties.Resources.BG_Login_Image_02;
            }
            else if (num == 3)
            {
                pictureBox_Image.Image = QLS.Properties.Resources.BG_Login_Image_03;
            }
            else
            {
                pictureBox_Image.Image = QLS.Properties.Resources.BG_Login_Image_04;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void icopbHienMatKhau_Click(object sender, EventArgs e)
        {
            boolHienMatKhau = !boolHienMatKhau;
            if (boolHienMatKhau)
            {
                icopbHienMatKhau.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txbMatKhau.PasswordChar = false;
            }
            else
            {
                icopbHienMatKhau.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txbMatKhau.PasswordChar = true;
            }
        }

        private void icopbHienMatKhau_DoubleClick(object sender, EventArgs e)
        {
            boolHienMatKhau = !boolHienMatKhau;
            if (boolHienMatKhau)
            {
                icopbHienMatKhau.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txbMatKhau.PasswordChar = false;
            }
            else
            {
                icopbHienMatKhau.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txbMatKhau.PasswordChar = true;
            }
        }
    }
}
