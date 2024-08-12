using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using QLS.DTO;
using QLS.DAO;
using QLS.Resources;
using System.Data.SqlClient;
using System.Windows.Documents;


namespace QLS.Forms.POS
{
    public partial class form_Bill : Form
    {
        public form_Bill(string MAHOADON, string TENKH, string SDT, List<ChiTietHoaDon> list)
        {
            InitializeComponent();
            UpdateColorApp();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //dt report view
            HoaDon report = new HoaDon();
            DataTable dt = new DataTable();
            dt.Columns.Add("MASACH", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(int));
            dt.Columns.Add("DONGIA", typeof(float));
            dt.Columns.Add("THANHTIEN", typeof(float));

            foreach (ChiTietHoaDon item in list)
            {
                dt.Rows.Add(item.MASACH, item.SOLUONG, item.GIATIEN, item.THANHTIEN);
            }

            report.SetDataSource(dt);
            report.SetParameterValue("MAHOADON", MAHOADON);
            report.SetParameterValue("TENKH", TENKH);
            report.SetParameterValue("SDT", SDT);
            report.SetParameterValue("TONGTIEN", list.Sum(x => x.THANHTIEN).ToString("#,##0"));
            string NGAYLAP = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            report.SetParameterValue("NGAYLAP", NGAYLAP);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();

            //save pdf to bill folder with filename is MAHOADON
            string path = Application.StartupPath + @"..\..\..\Bills\" + MAHOADON + ".pdf";
            report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
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

        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
        }
    }

}
