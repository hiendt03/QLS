using QLS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLS
{
    public partial class fCaiDat : Form
    {
        string userName;
        int colorApp;
        public fCaiDat(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        private void form_CaiDat_Load(object sender, EventArgs e)
        {
            // Giao diện
            if(KiemTraGiaoDien(userName))
            {
                Change_Color_Black();
                radioButton_Bat.Checked = true;
            }
            else
            {
                Change_Color_White();
                radioButton_Tat.Checked = true;
            }
            // Ngôn ngữ
            if(KiemTraNgonNgu(userName))
            {
                Change_Language_EN();
                radioButton_English.Checked = true;
            }
            else
            {
                Change_Language_VI();
                radioButton_TiengViet.Checked = true;
            }
            //Color App
            colorApp = KiemTraColorApp(userName);
            if (colorApp == 0)
            {
                radioButton_Blue.Checked = true;
            }
            else if (colorApp == 1)
            {
                radioButton_Red.Checked = true;
            }
            if (colorApp == 2)
            {
                radioButton_Green.Checked = true;
            }
            if (colorApp == 3)
            {
                radioButton_Orange.Checked = true;
            }
            if (colorApp == 4)
            {
                radioButton_Yellow.Checked = true;
            }
            if (colorApp == 5)
            {
                radioButton_BlueDark.Checked = true;
            }
            if (colorApp == 6)
            {
                radioButton_Violet.Checked = true;
            }
            if (colorApp == 7)
            {
                radioButton_Pink.Checked = true;
            }
            if (colorApp == 8)
            {
                radioButton_Brown.Checked = true;
            }
            if (colorApp == 9)
            {
                radioButton_Grey.Checked = true;
            }
        }
        // Giao diện
        public void CapNhatGiaoDien()
        {
            if (radioButton_Bat.Checked)
            {
                Setting.Instance.CapNhatGiaoDien(userName, 1);
            }
            else
            {
                Setting.Instance.CapNhatGiaoDien(userName, 0);
            }
        }
        public bool KiemTraGiaoDien(string userName)
        {
            string query = "SELECT * FROM dbo.SETTINGS WHERE USER_NAME = N'" + userName + "' AND THEMES = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Color_White()
        {
            //Background
            this.BackColor = Setting.Instance.color_BG_White_01;
            panel_Bottom.BackColor = Setting.Instance.color_BG_White_02;
            //Textbox
            textbox_MatKhauHienTai.BackColor = Setting.Instance.color_BG_White_01;
            textbox_MatKhauHienTai.ForeColor = Setting.Instance.color_Text_White_02;
            textbox_MatKhauHienTai.PlaceholderColor = Setting.Instance.color_Text_DarkGray;

            textbox_MatKhauMoi1.BackColor = Setting.Instance.color_BG_White_01;           
            textbox_MatKhauMoi1.ForeColor = Setting.Instance.color_Text_White_02;
            textbox_MatKhauMoi1.PlaceholderColor = Setting.Instance.color_Text_DarkGray;

            textbox_MatKhauMoi2.BackColor = Setting.Instance.color_BG_White_01;
            textbox_MatKhauMoi2.ForeColor = Setting.Instance.color_Text_White_02;
            textbox_MatKhauMoi2.PlaceholderColor = Setting.Instance.color_Text_DarkGray;

            //Label
            label_NgonNgu.ForeColor = Setting.Instance.color_Text_White_01;
            label_CheDoToi.ForeColor = Setting.Instance.color_Text_White_01;
            label_MatKhau.ForeColor = Setting.Instance.color_Text_White_01;
            label_MauChuDao.ForeColor = Setting.Instance.color_Text_White_01;
            //Button
            button_CapNhat.ForeColor = Setting.Instance.color_Text_Black_01;
            //Form Chính
            (this.Owner as form_Chinh).button_ThongTin.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_VeGiamGia.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_BangXepHang.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_HopThu.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_DonDatHang.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_BaoCao.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_ThongKe.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_CaiDat.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_DangXuat.ForeColor = Setting.Instance.color_Text_Black_01;

            (this.Owner as form_Chinh).button_ThongTin.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_VeGiamGia.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_BangXepHang.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_HopThu.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_DonDatHang.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_BaoCao.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_ThongKe.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_CaiDat.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_DangXuat.IconColor = Setting.Instance.color_Text_Black_01;

            (this.Owner as form_Chinh).label_Select.ForeColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).pictureBox_Select.IconColor = Setting.Instance.color_Text_Black_01;

            (this.Owner as form_Chinh).button_Close.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_Maximize.IconColor = Setting.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_Minimize.IconColor = Setting.Instance.color_Text_Black_01;

            (this.Owner as form_Chinh).leftBorderBtn.BackColor = Setting.Instance.color_BG_White_01;
            (this.Owner as form_Chinh).pictureBox_Logo.Image = QLS.Properties.Resources.Logo;
            if (!(this.Owner as form_Chinh).check_TabMenu)
            {
                (this.Owner as form_Chinh).pictureBox_Logo.Image = QLS.Properties.Resources.Logo;
            }
            else
            {
                (this.Owner as form_Chinh).pictureBox_Logo.Image = QLS.Properties.Resources.Icon;
            }
            (this.Owner as form_Chinh).pictureBox_TabMenu.IconColor = Setting.Instance.color_Text_Black_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = Setting.Instance.color_BG_Black_01;
            panel_Bottom.BackColor = Setting.Instance.color_BG_Black_02;
            //Textbox
            textbox_MatKhauHienTai.BackColor = Setting.Instance.color_BG_Black_01;
            textbox_MatKhauMoi1.BackColor = Setting.Instance.color_BG_Black_01;
            textbox_MatKhauMoi2.BackColor = Setting.Instance.color_BG_Black_01;

            textbox_MatKhauHienTai.ForeColor = Setting.Instance.color_Text_Black_02;
            textbox_MatKhauMoi1.ForeColor = Setting.Instance.color_Text_Black_02;
            textbox_MatKhauMoi2.ForeColor = Setting.Instance.color_Text_Black_02;

            textbox_MatKhauHienTai.PlaceholderColor = Setting.Instance.color_Text_DarkGray;
            textbox_MatKhauMoi1.PlaceholderColor = Setting.Instance.color_Text_DarkGray;
            textbox_MatKhauMoi2.PlaceholderColor = Setting.Instance.color_Text_DarkGray;

            //Label
            label_NgonNgu.ForeColor = Setting.Instance.color_Text_Black_01;
            label_CheDoToi.ForeColor = Setting.Instance.color_Text_Black_01;
            label_MatKhau.ForeColor = Setting.Instance.color_Text_Black_01;
            label_MauChuDao.ForeColor = Setting.Instance.color_Text_Black_01;

            //Button
            button_CapNhat.ForeColor = Setting.Instance.color_Text_White_01;
            //Form chính
            (this.Owner as form_Chinh).button_ThongTin.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_VeGiamGia.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_BangXepHang.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_HopThu.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_DonDatHang.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_BaoCao.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_ThongKe.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_CaiDat.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_DangXuat.ForeColor = Setting.Instance.color_Text_White_01;

            (this.Owner as form_Chinh).button_ThongTin.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_VeGiamGia.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_BangXepHang.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_HopThu.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_DonDatHang.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_BaoCao.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_ThongKe.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_CaiDat.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_DangXuat.IconColor = Setting.Instance.color_Text_White_01;

            (this.Owner as form_Chinh).label_Select.ForeColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).pictureBox_Select.IconColor = Setting.Instance.color_Text_White_01;

            (this.Owner as form_Chinh).button_Close.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_Maximize.IconColor = Setting.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_Minimize.IconColor = Setting.Instance.color_Text_White_01;

            (this.Owner as form_Chinh).leftBorderBtn.BackColor = Setting.Instance.color_BG_Black_01;
            if (!(this.Owner as form_Chinh).check_TabMenu)
            {
                (this.Owner as form_Chinh).pictureBox_Logo.Image = QLS.Properties.Resources.Logo_Black;
            }
            else
            {
                (this.Owner as form_Chinh).pictureBox_Logo.Image = QLS.Properties.Resources.Icon_Black;
            }
            (this.Owner as form_Chinh).pictureBox_TabMenu.IconColor = Setting.Instance.color_Text_White_01;
        }
        // Ngôn ngữ
        public void CapNhatNgonNgu()
        {
            if (radioButton_English.Checked)
            {
                Setting.Instance.CapNhatNgonNgu(userName, 1);
            }
            else
            {
                Setting.Instance.CapNhatNgonNgu(userName, 0);
            }
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.SETTINGS WHERE USER_NAME = N'" + userName + "' AND LANGUAGES = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            // Label
            label_NgonNgu.Text = "Ngôn ngữ";
            label_NgonNguNoiDung.Text = "Hãy điều chỉnh ngôn ngữ phù hợp với bạn.";
            label_CheDoToi.Text = "Chế độ tối";
            label_CheDoToiNoiDung.Text = "Điều chỉnh giao diện của Cupid để giảm độ chói và cho đôi mắt được nghỉ ngơi.";
            label_MatKhau.Text = "Mật khẩu";
            label_NoiDungMatKhau.Text = "Đổi mật khẩu thường xuyên sẽ giúp bạn bảo mật tài khoản tốt hơn.";
            // Radio Button
            radioButton_Bat.Text = "Bật";
            radioButton_Tat.Text = "Tắt";
            radioButton_TiengViet.Text = "Tiếng Việt";
            radioButton_English.Text = "English";
            // Textbox
            textbox_MatKhauHienTai.PlaceholderText = "Nhập mật khẩu cũ";
            textbox_MatKhauMoi1.PlaceholderText = "Nhập mật khẩu mới";
            textbox_MatKhauMoi2.PlaceholderText = "Nhập lại mật khẩu mới";
            //Button
            button_CapNhat.Text = "Cập nhật";

            //Form Chính
            (this.Owner as form_Chinh).button_ThongTin.Text = "Thông tin";
            (this.Owner as form_Chinh).button_VeGiamGia.Text = "Khuyến mãi";
            (this.Owner as form_Chinh).button_BangXepHang.Text = "Bảng xếp hạng";
            (this.Owner as form_Chinh).button_HopThu.Text = "Hộp thư";
            (this.Owner as form_Chinh).button_DonDatHang.Text = "Đơn đặt hàng";
            (this.Owner as form_Chinh).button_BaoCao.Text = "Báo cáo";
            (this.Owner as form_Chinh).button_ThongKe.Text = "Thống kê";
            (this.Owner as form_Chinh).button_LichSuHoatDong.Text = "Lịch sử hoạt động";
            (this.Owner as form_Chinh).button_LichSuGiaoDich.Text = "Lịch sử giao dịch";
            (this.Owner as form_Chinh).button_CaiDat.Text = "Cài đặt";
            (this.Owner as form_Chinh).button_DangXuat.Text = "Đăng xuất";

            (this.Owner as form_Chinh).label_Select.Text = "Cài đặt";
        }
        public void Change_Language_EN()
        {
            // Label
            label_NgonNgu.Text = "Language";
            label_NgonNguNoiDung.Text = "Adjust Cupid’s language to suit you.";
            label_CheDoToi.Text = "Dark mode";
            label_CheDoToiNoiDung.Text = "Adjust Cupid’s interface to reduce brightness and make your eyes feel better.";
            label_MatKhau.Text = "Password";
            label_NoiDungMatKhau.Text = "Change your password often will make your account more safer.";
            // Radio Button
            radioButton_Bat.Text = "On";
            radioButton_Tat.Text = "Off";
            radioButton_TiengViet.Text = "Tiếng Việt";
            radioButton_English.Text = "English";
            // Textbox
            textbox_MatKhauHienTai.PlaceholderText = "Enter your current password";
            textbox_MatKhauMoi1.PlaceholderText = "Enter a new password";
            textbox_MatKhauMoi2.PlaceholderText = "Enter your new password again";
            //Button
            button_CapNhat.Text = "Update";

            //Form Chính
            (this.Owner as form_Chinh).button_ThongTin.Text = "Information";
            (this.Owner as form_Chinh).button_VeGiamGia.Text = "Promotion";
            (this.Owner as form_Chinh).button_BangXepHang.Text = "Leaderboard";
            (this.Owner as form_Chinh).button_HopThu.Text = "Mailbox";
            (this.Owner as form_Chinh).button_DonDatHang.Text = "Order";
            (this.Owner as form_Chinh).button_BaoCao.Text = "Report";
            (this.Owner as form_Chinh).button_ThongKe.Text = "Statistical";
            (this.Owner as form_Chinh).button_LichSuHoatDong.Text = "Operation history";
            (this.Owner as form_Chinh).button_LichSuGiaoDich.Text = "Transaction history";
            (this.Owner as form_Chinh).button_CaiDat.Text = "Settings";
            (this.Owner as form_Chinh).button_DangXuat.Text = "Log Out";

            (this.Owner as form_Chinh).label_Select.Text = "Settings";
        }
        // Mật khẩu
        public void CapNhatMatKhau()
        {
            if (radioButton_TiengViet.Checked == true)
            {
                if (textbox_MatKhauHienTai.Texts == "" && textbox_MatKhauMoi1.Texts == "" && textbox_MatKhauMoi2.Texts == "")
                {
                    label_Loi.Text = "";
                }
                else if (textbox_MatKhauHienTai.Texts.Trim().Length > 0 || textbox_MatKhauMoi1.Texts.Trim().Length > 0 || textbox_MatKhauMoi2.Texts.Length > 0)
                {
                    label_Loi.ForeColor = Setting.Instance.color_Text_Red;
                    if (textbox_MatKhauMoi1.Texts == "" || textbox_MatKhauMoi2.Texts == "")
                    {
                        label_Loi.Text = "Mật khẩu không được để trống";
                    }
                    else if (textbox_MatKhauMoi1.Texts != textbox_MatKhauMoi2.Texts)
                    {
                        label_Loi.Text = "Mật khẩu mới không trùng khớp";
                    }
                    else
                    {
                        if (!KiemTraMatKhau(userName, textbox_MatKhauHienTai.Texts))
                        {
                            label_Loi.Text = "Mật khẩu cũ không chính xác";
                        }
                        else
                        {
                            if (textbox_MatKhauHienTai.Texts == textbox_MatKhauMoi1.Texts)
                            {
                                label_Loi.Text = "Mật khẩu mới không được giống mật khẩu cũ";
                            }
                            else
                            {
                                if (!UsersDAO.Instance.ChangePassword(userName, textbox_MatKhauMoi1.Texts))
                                {
                                    label_Loi.Text = "Đổi mật khẩu thất bại";
                                }
                                else
                                {
                                    textbox_MatKhauMoi1.Texts = "";
                                    textbox_MatKhauMoi2.Texts = "";
                                    textbox_MatKhauHienTai.Texts = "";
                                    label_Loi.Text = "Đổi mật khẩu thành công";
                                    label_Loi.ForeColor = Setting.Instance.color_Text_Green;
                                }
                            }

                        }
                    }
                }
            }
            else
            {
                if (textbox_MatKhauHienTai.Texts == "" && textbox_MatKhauMoi1.Texts == "" && textbox_MatKhauMoi2.Texts == "")
                {
                    label_Loi.Text = "";
                }
                else if (textbox_MatKhauHienTai.Texts.Trim().Length > 0 || textbox_MatKhauMoi1.Texts.Trim().Length > 0 || textbox_MatKhauMoi2.Texts.Length > 0)
                {
                    label_Loi.ForeColor = Setting.Instance.color_Text_Red;
                    if (textbox_MatKhauMoi1.Texts == "" || textbox_MatKhauMoi2.Texts == "")
                    {
                        label_Loi.Text = "Password can not be blank";
                    }
                    else if (textbox_MatKhauMoi1.Texts != textbox_MatKhauMoi2.Texts)
                    {
                        label_Loi.Text = "New password does not match";
                    }
                    else
                    {
                        if (!KiemTraMatKhau(userName, textbox_MatKhauHienTai.Texts))
                        {
                            label_Loi.Text = "Old password is incorrect";
                        }
                        else
                        {
                            if (textbox_MatKhauHienTai.Texts == textbox_MatKhauMoi1.Texts)
                            {
                                label_Loi.Text = "The new password cannot be the same as the old password";
                            }
                            else
                            {
                                if (!UsersDAO.Instance.ChangePassword(userName, textbox_MatKhauMoi1.Texts))
                                {
                                    label_Loi.Text = "Change password failed";
                                }
                                else
                                {
                                    textbox_MatKhauMoi1.Texts = "";
                                    textbox_MatKhauMoi2.Texts = "";
                                    textbox_MatKhauHienTai.Texts = "";
                                    label_Loi.Text = "Change password successfully";
                                    label_Loi.ForeColor = Setting.Instance.color_Text_Green;
                                }
                            }

                        }
                    }
                }
            }
        }
        public bool KiemTraMatKhau(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.USERS WHERE USER_NAME = N'" + userName + "' AND PASS_WORD = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        private void radioButton_Bat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Bat.Checked == true)
            {
                Change_Color_Black();
            }
            else
            {
                Change_Color_White();
            }
            label_Loi.Text = "";
            CapNhatGiaoDien();
        }
        private void radioButton_TiengViet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_TiengViet.Checked == true)
            {
                Change_Language_VI();
            }
            else
            {
                Change_Language_EN();
            }
            label_Loi.Text = "";
            CapNhatNgonNgu();
        }
        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            CapNhatMatKhau();
        }
        // Color App
        public int KiemTraColorApp(string userName)
        {
            string query = "SELECT COLOR_APP FROM dbo.SETTINGS WHERE USER_NAME = N'" + userName + "'";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        public void CapNhatColorApp()
        {
            if (radioButton_Blue.Checked)
            {
                Setting.Instance.CapNhatColorApp(userName, 0);
            }
            else if (radioButton_Red.Checked)
            {
                Setting.Instance.CapNhatColorApp(userName, 1);
            }
            else if (radioButton_Green.Checked)
            {
                Setting.Instance.CapNhatColorApp(userName, 2);
            }
            else if (radioButton_Orange.Checked)
            {
                Setting.Instance.CapNhatColorApp(userName, 3);
            }
            else if (radioButton_Yellow.Checked)
            {
                Setting.Instance.CapNhatColorApp(userName, 4);
            }
            else if (radioButton_BlueDark.Checked)
            {
                Setting.Instance.CapNhatColorApp(userName, 5);
            }
            else if (radioButton_Violet.Checked)
            {
                Setting.Instance.CapNhatColorApp(userName, 6);
            }
            else if (radioButton_Pink.Checked)
            {
                Setting.Instance.CapNhatColorApp(userName, 7);
            }
            else if (radioButton_Brown.Checked)
            {
                Setting.Instance.CapNhatColorApp(userName, 8);
            }
            else
            {
                Setting.Instance.CapNhatColorApp(userName, 9);
            }
            colorApp = KiemTraColorApp(userName);
            if (colorApp == 0)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_Blue_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_Blue_02;
            }
            else if (colorApp == 1)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_Red_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_Red_02;
            }
            if (colorApp == 2)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_Green_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_Green_02;
            }
            if (colorApp == 3)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_Orange_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_Orange_02;
            }
            if (colorApp == 4)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_Yellow_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_Yellow_02;
            }
            if (colorApp == 5)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_BlueDark_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_BlueDark_02;
            }
            if (colorApp == 6)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_Violet_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_Violet_02;
            }
            if (colorApp == 7)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_Pink_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_Pink_02;
            }
            if (colorApp == 8)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_Brown_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_Brown_02;
            }
            if (colorApp == 9)
            {
                Setting.Instance.color_BG_ColorApp_01 = Setting.Instance.color_BG_Grey_01;
                Setting.Instance.color_BG_ColorApp_02 = Setting.Instance.color_BG_Grey_02;
            }
            (this.Owner as form_Chinh).panel_Title.BackColor = Setting.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).button_Close.BackColor = Setting.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).button_Maximize.BackColor = Setting.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).button_Minimize.BackColor = Setting.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).panel_Menu.BackColor = Setting.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).button_ThongTin.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_VeGiamGia.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_BangXepHang.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_HopThu.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_DonDatHang.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_BaoCao.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_ThongKe.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_CaiDat.BackColor = Setting.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).button_DangXuat.BackColor = Setting.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).label_XinChao.ForeColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Time.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).label_ThoiGian.BackColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).label_NgayThangNam.BackColor = Setting.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).button_Facebook.ForeColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Youtube.ForeColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Twitter.ForeColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Instagram.ForeColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Tiktok.ForeColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Gmail.ForeColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Website.ForeColor = Setting.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).button_Facebook.IconColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Youtube.IconColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Twitter.IconColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Instagram.IconColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Tiktok.IconColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Gmail.IconColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Website.IconColor = Setting.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).label_GhiChu.ForeColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).textbox_GhiChu.ForeColor = Setting.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).textbox_GhiChu.PlaceholderColor = Setting.Instance.color_BG_ColorApp_01;
            ChangeColorApp();
        }
        public void ChangeColorApp()
        {
            radioButton_TiengViet.CheckedColor = Setting.Instance.color_BG_ColorApp_01;
            radioButton_English.CheckedColor = Setting.Instance.color_BG_ColorApp_01;
            radioButton_Bat.CheckedColor = Setting.Instance.color_BG_ColorApp_01;
            radioButton_Tat.CheckedColor = Setting.Instance.color_BG_ColorApp_01;

            textbox_MatKhauHienTai.BorderColor = Setting.Instance.color_BG_ColorApp_01;
            textbox_MatKhauHienTai.BorderFocusColor = Setting.Instance.color_BG_ColorApp_02;

            textbox_MatKhauMoi1.BorderColor = Setting.Instance.color_BG_ColorApp_01;
            textbox_MatKhauMoi1.BorderFocusColor = Setting.Instance.color_BG_ColorApp_02;

            textbox_MatKhauMoi2.BorderColor = Setting.Instance.color_BG_ColorApp_01;
            textbox_MatKhauMoi2.BorderFocusColor = Setting.Instance.color_BG_ColorApp_02;

            button_CapNhat.BackColor = Setting.Instance.color_BG_ColorApp_01;
        }
        private void radioButton_Blue_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Brown_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Green_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Orange_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Yellow_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_BlueDark_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Violet_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Pink_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Red_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Grey_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
    }
}
