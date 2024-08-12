using QLS.DAO;
using QLS.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLS.Forms.ThongKe
{
    public partial class form_ThongKe : Form
    {
        string tk = "";
        bool check_giaodien, check_ngonngu;
        DataTable doanhThuHomNay = new DataTable();
        DataTable doanhThu7Ngay = new DataTable();
        DataTable doanhThuTheoThang = new DataTable();
        public form_ThongKe(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            chart1.Series.Clear();
            chart2.Series.Clear();

            chart1.Titles.Add("Doanh thu hôm nay");
            chart1.Titles[0].Font = new Font("iCiel Cadena", 16, FontStyle.Bold);

            chart2.Titles.Add("Số lượng sản phẩm bán ra hôm nay");
            chart2.Titles[0].Font = new Font("iCiel Cadena", 16, FontStyle.Bold);

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Tắt lưới dọc
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Tắt lưới ngang

            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Tắt lưới dọc
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Tắt lưới ngang

            doanhThuHomNay = ThongKeDAO.Instance.getDoanhThuHomNay();
            doanhThu7Ngay = ThongKeDAO.Instance.getDoanhThu7Ngay();
            doanhThuTheoThang = ThongKeDAO.Instance.getDoanhThuTheoThang();

            Series seriesSoluong = new Series("Số lượng")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                IsValueShownAsLabel = true
            };

            Series seriesTongTien = new Series("Tổng tiền")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Green,
                IsValueShownAsLabel = true
            };

            foreach (DataRow row in doanhThuHomNay.Rows)
            {
                string ngay = row["NGAYLAP"].ToString();
                int soLuong = Convert.ToInt32(row["SOLUONG"]);
                string tongTien = Convert.ToDecimal(row["TONGTIEN"]).ToString("#,##0");

                seriesSoluong.Points.AddXY(ngay, soLuong);
                seriesTongTien.Points.AddXY(ngay, tongTien);
                seriesTongTien.Points[seriesTongTien.Points.Count - 1].Label = tongTien;
            }

            chart1.Series.Add(seriesTongTien);
            chart2.Series.Add(seriesSoluong);
        }

        private void combobox_XemTheo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear old data
            chart1.Series.Clear();
            chart2.Series.Clear();

            // Lấy giá trị chọn từ ComboBox
            string selected = combobox_XemTheo.SelectedItem.ToString();

            Series seriesSoluong = new Series("Số lượng")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                IsValueShownAsLabel = true
            };

            Series seriesTongTien = new Series("Tổng tiền")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Green,
                IsValueShownAsLabel = true
            };

            if (selected == "Hôm nay" || selected == "Today")
            {
                chart1.Titles[0].Text = "Doanh thu hôm nay";
                chart2.Titles[0].Text = "Số lượng sản phẩm bán ra hôm nay";

                foreach (DataRow row in doanhThuHomNay.Rows)
                {
                    string ngay = row["NGAYLAP"].ToString();
                    int soLuong = Convert.ToInt32(row["SOLUONG"]);
                    string tongTien = Convert.ToDecimal(row["TONGTIEN"]).ToString("#,##0");

                    seriesSoluong.Points.AddXY(ngay, soLuong);
                    seriesTongTien.Points.AddXY(ngay, tongTien);
                    seriesTongTien.Points[seriesTongTien.Points.Count - 1].Label = tongTien;
                }
            }
            else if (selected == "7 ngày" || selected == "7 days")
            {
                chart1.Titles[0].Text = "Doanh thu 7 ngày";
                chart2.Titles[0].Text = "Số lượng sản phẩm bán ra 7 ngày";

                foreach (DataRow row in doanhThu7Ngay.Rows)
                {
                    string ngay = row["NGAYLAP"].ToString();
                    int soLuong = Convert.ToInt32(row["SOLUONG"]);
                    string tongTien = Convert.ToDecimal(row["TONGTIEN"]).ToString("#,##0");

                    seriesSoluong.Points.AddXY(ngay, soLuong);
                    seriesTongTien.Points.AddXY(ngay, tongTien);
                    seriesTongTien.Points[seriesTongTien.Points.Count - 1].Label = tongTien;
                }
            }
            else if (selected == "Tháng")
            {
                chart1.Titles[0].Text = "Doanh thu theo tháng";
                chart2.Titles[0].Text = "Số lượng sản phẩm bán ra theo tháng";

                foreach (DataRow row in doanhThuTheoThang.Rows)
                {
                    string ngay = row["NGAYLAP"].ToString();
                    int soLuong = Convert.ToInt32(row["SOLUONG"]);
                    string tongTien = Convert.ToDecimal(row["TONGTIEN"]).ToString("#,##0");

                    seriesSoluong.Points.AddXY(ngay, soLuong);
                    seriesTongTien.Points.AddXY(ngay, tongTien);
                    seriesTongTien.Points[seriesTongTien.Points.Count - 1].Label = tongTien;
                }
            }
            
            chart1.Series.Add(seriesTongTien);
            chart2.Series.Add(seriesSoluong);
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
           
            //Textbox
            combobox_XemTheo.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_XemTheo.ListBackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_XemTheo.ListTextColor = CaiDatDAO.Instance.color_Text_White_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            
            //Textbox
            combobox_XemTheo.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_XemTheo.ListBackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_XemTheo.ListTextColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAIDAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            combobox_XemTheo.Items.Clear();
            combobox_XemTheo.Items.Add("Hôm nay");
            combobox_XemTheo.Items.Add("7 ngày");
            combobox_XemTheo.Items.Add("Tháng");
        }

        public void Change_Language_EN()
        {
            combobox_XemTheo.Items.Clear();
            combobox_XemTheo.Items.Add("Today");
            combobox_XemTheo.Items.Add("7 days");
            combobox_XemTheo.Items.Add("Month");
        }

       

        public void UpdateColorApp()
        {
            combobox_XemTheo.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_XemTheo.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
