using System;
using System.Data;
using System.Data.SqlClient;

namespace QLS.Resources
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        private const int PgSize = 10;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }

        private KhachHangDAO() { }

        public DataTable GetCurrentRecords(int page)
        {
            string cmd = "";
            DataTable dt = new DataTable();
            if (page == 1)
            {
                cmd = "Select TOP " + PgSize + " * from KHACHHANG ORDER BY TENKH";
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * 20;

                cmd = @"Select TOP " + PgSize + " * from KHACHHANG WHERE TENKH NOT IN (Select TOP " + PreviousPageOffSet + " TENKH from KHACHHANG ORDER BY TENKH)";
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

                cmd = "Select * from KHACHHANG WHERE TENKH like '%" + keyword + "%' OR MAKH like '%" + keyword + "%' ORDER BY TENKH";
            }
            else
            {
                if (page == 1)
                {

                    cmd = "Select TOP " + PgSize + " * from KHACHHANG WHERE TENKH like '%" + keyword + "%' OR MAKH like '%" + keyword + "%' ORDER BY TENKH";
                }
                else
                {
                    int PreviousPageOffSet = (page - 1) * PgSize;

                    cmd = @"Select TOP " + PgSize + " * from KHACHHANG WHERE TENKH like '%" + keyword + "%' " +
                         "OR MAKH like '%" + keyword + "%'" +
                         "AND TENKH NOT IN (Select TOP " + PreviousPageOffSet + " TENKH " +
                         "from KHACHHANG WHERE TENKH like '%" + keyword + "%' ORDER BY TENKH)";

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
            String cmd = "SELECT COUNT (*) FROM KHACHHANG WHERE TENKH LIKE '%" + keyword + "%'";

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

        public bool ThemKHACHHANG(string MAKH, string TENKH, string DIACHI, string SDT, string email)
        {
            string cmd = "INSERT INTO KHACHHANG VALUES('" + MAKH + "', N'" + TENKH + "', N'" + DIACHI + "', N'" + SDT + "','" + email + "')";

            try
            {
                return DataProvider.Instance.ExecuteNonQuery(cmd) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool XoaKHACHHANG(string MAKH)
        {
            string cmd = "DELETE FROM KHACHHANG WHERE MAKH = @MAKH";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MAKH", SqlDbType.VarChar);
            param[0].Value = MAKH;

            try
            {
                return DataProvider.Instance.ExecuteNonQuery(cmd, param) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool SuaKHACHHANG(string MAKH, string TENKH, string theLoai, string tacGia, string nhaXuatBan, int namXuatBan, int giaMua, int giaBia, byte[] avatar)
        {
            string cmd = "UPDATE KHACHHANG SET TENKH = N'" + TENKH + "', THELOAI = N'" + theLoai + "', TACGIA = N'" + tacGia + "', NHAXUATBAN = N'" + nhaXuatBan + "', NAMXUATBAN = " + namXuatBan + ", GIAMUA = " + giaMua + ", GIABIA = " + giaBia + ", HINHANH = @avatar WHERE MAKH = '" + MAKH + "'";

            try
            {
                return DataProvider.Instance.ExecuteNonQuery(cmd, new SqlParameter[] { new SqlParameter("@avatar", avatar) }) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool KiemTraTrung(string MAKH)
        {
            string cmd = "SELECT * FROM KHACHHANG WHERE MAKH = @MAKH";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MAKH", SqlDbType.VarChar);
            param[0].Value = MAKH;

            try
            {
                return DataProvider.Instance.ExecuteQuery(cmd, param).Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable getKHACHHANG(string MAKH)
        {
            string cmd = "SELECT * FROM KHACHHANG WHERE MAKH = @MAKH";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MAKH", SqlDbType.VarChar);
            param[0].Value = MAKH;

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