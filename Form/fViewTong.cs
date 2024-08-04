using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLS
{
    public partial class frmViewTong : Form
    {
        private IconButton currentBtn;
        public Panel leftBorderBtn;
        private Form currentChildForm;
        public event PropertyChangedEventHandler PropertyChanged;
        //private clsNotification notification;
        public int colorApp;
        public bool check_TabMenu;
        public frmViewTong(string username)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_Menu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            listView1_SelectedIndexChanged();
            txbTenNguoiDung.Text = username;
            //End
            //OpenChildForm(new frmTaiKhoan());
        }
        //public frmViewTong(string username)
        //{
        //    InitializeComponent();
        //    listView1_SelectedIndexChanged();
        //    txbTenNguoiDung.Text = username;
        //}

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap login = new frmDangNhap();
            login.ShowDialog();
            this.Close();
        }

        private void frmViewTong_Load(object sender, EventArgs e)
        {
            DateTime tg = DateTime.Now;
            lblTime.Text = tg.ToString("dddd, dd/MM/yyyy");
            string query = "Select USERNAME From TAIKHOAN";
            object data = DataProvider.Instance.ExecuteScalar(query);
            lblTenNguoiDung.Text = data.ToString();
        }

        private void listView1_SelectedIndexChanged()
        {
            string timenow = DateTime.Now.ToString("yyyy/MM/dd");
            string query = "Select SUM(TONGTIEN) AS [DOANHTHU] From HOADON Where NGAYLAP = '" + timenow + "'";
            object data = DataProvider.Instance.ExecuteScalar(query);
            if (data.ToString() == "")
            {
                txbDoanhThu.Text = 0 + " VND";
            }
            else
            {
                txbDoanhThu.Text = data.ToString() + " VND";
            }

            string query2 = "Select Count(MAHOADON) From HOADON Where NGAYLAP = '" + timenow + "'";
            object data2 = DataProvider.Instance.ExecuteScalar(query2);
            txbSLKhach.Text = data2.ToString() + " người";
        }

        private void txbSLKhach_TextChanged(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.Owner = this;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_Select.Text = childForm.Text;
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(150, 200, 250);

                if (!check_TabMenu)
                {
                    currentBtn.Padding = new Padding(15, 0, 0, 0);
                    //Left border button

                    leftBorderBtn.Size = new Size(7, currentBtn.Height);
                    //Current Child Form Icon
                    pictureBox_Select.IconChar = currentBtn.IconChar;
                    pictureBox_Select.IconFont = IconFont.Solid;
                }
                else
                {
                    currentBtn.Padding = new Padding(0, 0, 0, 0);
                    //Current Child Form Icon
                    leftBorderBtn.Size = new Size(5, currentBtn.Height);
                    pictureBox_Select.IconChar = currentBtn.IconChar;
                    pictureBox_Select.IconFont = IconFont.Solid;
                }
                panel_Menu.Controls.Add(leftBorderBtn);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
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
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pictureBox_Select.IconChar = IconChar.Home;
            pictureBox_Select.IconFont = IconFont.Auto;
            label_Select.Text = "TRANG CHỦ";
        }

        private void pictureBox_TabMenu_Click(object sender, EventArgs e)
        {
            if (panel_Menu.Width == 200)
            {
                panel_Menu.Width = 2;
                check_TabMenu = true;
            }
            else
            {
                panel_Menu.Width = 250;
                check_TabMenu = false;
            }
        }

        private void bTrangChu_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaiKhoan());
        }
        private void btnQuanLi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmSach());
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmThongKe());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frmHoaDon());
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void button_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void Chinh_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
