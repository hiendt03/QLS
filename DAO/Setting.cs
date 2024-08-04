using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLS.DAO
{
    internal class Setting
    {
        private static Setting instance;

        internal static Setting Instance
        {
            get
            {
                if (instance == null)
                    instance = new Setting();
                return Setting.instance;
            }
            private set { Setting.instance = value; }
        }

        public Color color_BG_ColorApp_01;
        public Color color_BG_ColorApp_02;

        public Color color_BG_Blue_01 = Color.FromArgb(150, 200, 250); // nhạt
        public Color color_BG_Blue_02 = Color.FromArgb(130, 180, 230); // đậm

        public Color color_BG_Red_01 = Color.FromArgb(250, 80, 100); // nhạt
        public Color color_BG_Red_02 = Color.FromArgb(200, 80, 100); // đậm

        public Color color_BG_Green_01 = Color.FromArgb(100, 200, 80); // nhạt
        public Color color_BG_Green_02 = Color.FromArgb(100, 150, 80); // đậm

        public Color color_BG_Orange_01 = Color.FromArgb(250, 100, 80); // nhạt
        public Color color_BG_Orange_02 = Color.FromArgb(200, 100, 80); // đậm

        public Color color_BG_Yellow_01 = Color.FromArgb(200, 200, 0); // nhạt
        public Color color_BG_Yellow_02 = Color.FromArgb(150, 150, 0); // đậm

        public Color color_BG_BlueDark_01 = Color.FromArgb(80, 150, 250); // nhạt
        public Color color_BG_BlueDark_02 = Color.FromArgb(80, 100, 250); // đậm

        public Color color_BG_Violet_01 = Color.FromArgb(200, 80, 250); // nhạt
        public Color color_BG_Violet_02 = Color.FromArgb(150, 80, 250); // đậm

        public Color color_BG_Pink_01 = Color.FromArgb(250, 150, 200); // nhạt
        public Color color_BG_Pink_02 = Color.FromArgb(250, 100, 150); // đậm

        public Color color_BG_Brown_01 = Color.FromArgb(100, 50, 50); // nhạt
        public Color color_BG_Brown_02 = Color.FromArgb(100, 0, 0); // đậm

        public Color color_BG_Grey_01 = Color.FromArgb(150, 150, 150); // nhạt
        public Color color_BG_Grey_02 = Color.FromArgb(70, 70, 70); // đậm

        public Color color_BG_White_01 = Color.FromArgb(255, 255, 255);
        public Color color_BG_White_02 = Color.FromArgb(240, 242, 245);
        public Color color_BG_Black_01 = Color.FromArgb(36, 37, 38);
        public Color color_BG_Black_02 = Color.FromArgb(24, 25, 26);

        public Color color_Text_White_01 = Color.FromArgb(0, 0, 0); // màu đen
        public Color color_Text_White_02 = Color.FromArgb(5, 5, 5);
        public Color color_Text_Black_01 = Color.FromArgb(255, 255, 255); // màu trắng
        public Color color_Text_Black_02 = Color.FromArgb(228, 230, 235);

        public Color color_Text_Red = Color.FromArgb(250, 80, 100);
        public Color color_Text_Green = Color.FromArgb(100, 250, 80);

        public Color color_Grid = Color.FromArgb(206, 208, 212);
        public Color color_Gridview_Hover_White = Color.FromArgb(228, 230, 233);
        public Color color_Gridview_Hover_Black = Color.FromArgb(58, 59, 60);

        public Color color_Text_DarkGray = Color.DarkGray;

        public void CapNhatGiaoDien(string userName , int giaodien)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE SETTINGS SET THEMES = '" + giaodien + "' WHERE USER_NAME = '" + userName + "'");
        }
        public void CapNhatNgonNgu(string userName , int ngonngu)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE SETTINGS SET LANGUAGES = '" + ngonngu + "' WHERE USER_NAME = '" + userName + "'");
        }
        public void CapNhatTabMenu(string userName , int tabmenu)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE SETTINGS SET MENU_TAB = '" + tabmenu + "' WHERE USER_NAME = '" + userName + "'");
        }
        public void CapNhatColorApp(string userName , int colorapp)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE SETTINGS SET COLOR_APP = '" + colorapp + "' WHERE USER_NAME = '" + userName + "'");
        }
    }
}
