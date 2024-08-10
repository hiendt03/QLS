using System;
using System.Data;
using System.Data.SqlClient;

namespace QLS.Resources
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        private const int PgSize = 20;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set { instance = value; }
        }

        private HoaDonDAO() { }

        public DataTable GetCurrentRecords(int page)
        {
            string cmd = "";
            DataTable dt = new DataTable();
            if (page == 1)
            {
                cmd = "Select TOP " + PgSize + " * from HOADON ORDER BY MAHOADON";
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * 20;

                cmd = @"Select TOP " + PgSize + " * from HOADON WHERE MAHOADON NOT IN (Select TOP " + PreviousPageOffSet + " MAHOADON from HOADON ORDER BY MAHOADON)";
            }
            try
            {
                dt = DataProvider.Instance.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public DataTable GetCurrentRecordsByKeyword(int page, string keyword)
        {
            string cmd = "";
            DataTable dt = new DataTable();
            if (page < 0)
            {

                cmd = "Select * from HOADON WHERE MAHOADON like '%" + keyword + "%' OR MAHOADON like '%" + keyword + "%' ORDER BY MAHOADON";
            }
            else
            {
                if (page == 1)
                {

                    cmd = "Select TOP " + PgSize + " * from HOADON WHERE MAHOADON like '%" + keyword + "%' ORDER BY MAHOADON";
                }
                else
                {
                    int PreviousPageOffSet = (page - 1) * 20;

                    cmd = @"Select TOP " + PgSize + " * from HOADON WHERE MAHOADON like '%" + keyword + "%' " +
                         "AND MAHOADON NOT IN (Select TOP " + PreviousPageOffSet + " MAHOADON " +
                         "from HOADON WHERE MAHOADON like '%" + keyword + "%' ORDER BY MAHOADON)";

                }
            }

            try
            {
                dt = DataProvider.Instance.ExecuteQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public int CountResult(string keyword)
        {
            object data = 0;
            String cmd = "SELECT COUNT (*) FROM HOADON WHERE MAHOADON LIKE '%" + keyword + "%'";

            try
            {
                data = DataProvider.Instance.ExecuteScalar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return (int)data;
        }

        public bool ThemHOADON(string MAHOADON, string MAKH, int TONGTIEN)
        {
            string NGAYLAP = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string cmd = "INSERT INTO HOADON (MAHOADON, MAKH, TONGTIEN, NGAYLAP) VALUES (@MAHOADON, @MAKH, @TONGTIEN, @NGAYLAP)";

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MAHOADON", MAHOADON),
                    new SqlParameter("@MAKH", MAKH),
                    new SqlParameter("@TONGTIEN", TONGTIEN),
                    new SqlParameter("@NGAYLAP", NGAYLAP)
                };
                return DataProvider.Instance.ExecuteNonQuery(cmd, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ThemChiTietHoaDon(string MAHOADON, string MASACH, int SOLUONG, int DONGIA, int THANHTIEN)
        {
            string cmd = "INSERT INTO CHITIETHOADON VALUES(@MAHOADON, @MASACH, @SOLUONG, @DONGIA, @THANHTIEN)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@MAHOADON", MAHOADON),
                new SqlParameter("@MASACH", MASACH),
                new SqlParameter("@SOLUONG", SOLUONG),
                new SqlParameter("@DONGIA", DONGIA),
                new SqlParameter("@THANHTIEN", THANHTIEN)
            };

            try
            {
                return DataProvider.Instance.ExecuteNonQuery(cmd, param) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable getChiTietHoaDon(string MAHOADON)
        {
            //cmd include tensach
            string cmd = "SELECT * FROM CHITIETHOADON WHERE MAHOADON = @MAHOADON";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MAHOADON", SqlDbType.VarChar);
            param[0].Value = MAHOADON;

            try
            {
                return DataProvider.Instance.ExecuteQuery(cmd, param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool KiemTraTrung(string maHOADON)
        {
            string cmd = "SELECT * FROM HOADON WHERE MAHOADON = @maHOADON";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@maHOADON", SqlDbType.VarChar);
            param[0].Value = maHOADON;

            try
            {
                return DataProvider.Instance.ExecuteQuery(cmd, param).Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable getHOADON(string maHOADON)
        {
            string cmd = "SELECT * FROM HOADON WHERE MAHOADON = @maHOADON";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@maHOADON", SqlDbType.VarChar);
            param[0].Value = maHOADON;

            try
            {
                return DataProvider.Instance.ExecuteQuery(cmd, param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}