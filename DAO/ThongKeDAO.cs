using System;
using System.Data;
using System.Data.SqlClient;

namespace QLS.Resources
{
    public class ThongKeDAO
    {
        private static ThongKeDAO instance;
        private const int PgSize = 10;
        public static ThongKeDAO Instance
        {
            get { if (instance == null) instance = new ThongKeDAO(); return instance; }
            private set { instance = value; }
        }

        private ThongKeDAO() { }

        public DataTable getDoanhThuHomNay()
        {
            string cmd = @"SELECT DAY(NGAYLAP) NGAYLAP, SUM(TONGTIEN) TONGTIEN, SUM(SOLUONG) SOLUONG
                            FROM HOADON, CHITIETHOADON
                            WHERE DAY(NGAYLAP) = DAY(GETDATE())
                            AND HOADON.MAHOADON = CHITIETHOADON.MAHOADON
                            GROUP BY DAY(NGAYLAP)";
            return DataProvider.Instance.ExecuteQuery(cmd);
        }

        public DataTable getDoanhThu7Ngay()
        {
            string cmd = @"SELECT DAY(NGAYLAP) NGAYLAP, SUM(TONGTIEN) TONGTIEN, SUM(SOLUONG) SOLUONG
                            FROM HOADON, CHITIETHOADON
                            WHERE HOADON.MAHOADON = CHITIETHOADON.MAHOADON
                            AND DAY(NGAYLAP) >= DAY(NGAYLAP) - 7
                            GROUP BY DAY(NGAYLAP)";
            return DataProvider.Instance.ExecuteQuery(cmd);
        }

        public DataTable getDoanhThuTheoThang()
        {
            string cmd = @"SELECT MONTH(NGAYLAP) NGAYLAP, SUM(TONGTIEN) TONGTIEN, SUM(SOLUONG) SOLUONG
                            FROM HOADON, CHITIETHOADON
                            WHERE HOADON.MAHOADON = CHITIETHOADON.MAHOADON
                            GROUP BY MONTH(NGAYLAP)";

            return DataProvider.Instance.ExecuteQuery(cmd);
        }
    }
}