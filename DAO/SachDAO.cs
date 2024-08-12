using System;
using System.Data;
using System.Data.SqlClient;

namespace QLS.Resources
{
    public class SachDAO
    {
        private static SachDAO instance;
        private const int PgSize = 10;
        public static SachDAO Instance
        {
            get { if (instance == null) instance = new SachDAO(); return instance; }
            private set { instance = value; }
        }

        private SachDAO() { }

        public DataTable GetCurrentRecords(int page, int pagesize = 0, string keyword = "")
        {
            string cmd = "";
            DataTable dt = new DataTable();
            if (page == 1)
            {
                cmd = "Select TOP " + PgSize + " * from SACH ORDER BY TENSACH";
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * PgSize;

                cmd = @"Select TOP " + PgSize + " * from SACH WHERE TENSACH NOT IN (Select TOP " + PreviousPageOffSet + " TENSACH from SACH ORDER BY TENSACH)";
            }

            if(pagesize > 0 && keyword != "")
            {
               cmd = "Select TOP " + pagesize + " * from SACH WHERE TENSACH like '%" + keyword + "%' OR MASACH like '%" + keyword + "%' ORDER BY TENSACH";
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

                cmd = "Select * from SACH WHERE TENSACH like '%" + keyword + "%' OR MASACH like '%" + keyword + "%' ORDER BY TENSACH";
            }
            else
            {
                if (page == 1)
                {

                    cmd = "Select TOP " + PgSize + " * from SACH WHERE TENSACH like '%" + keyword + "%' OR MASACH like '%" + keyword + "%' ORDER BY TENSACH";
                }
                else
                {
                    int PreviousPageOffSet = (page - 1) * PgSize;

                    cmd = @"Select TOP " + PgSize + " * from SACH WHERE TENSACH like '%" + keyword + "%' " +
                         "OR MASACH like '%" + keyword + "%'"+
                         "AND TENSACH NOT IN (Select TOP " + PreviousPageOffSet + " TENSACH " +
                         "from SACH WHERE TENSACH like '%" + keyword + "%' ORDER BY TENSACH)";

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
            String cmd = "SELECT COUNT (*) FROM SACH WHERE TENSACH LIKE '%" + keyword + "%'";

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

        public bool ThemSach(string maSach, string tenSach, string theLoai, string tacGia,int giaMua, int giaBia, string nhaXuatBan, int namXuatBan,  byte[] avatar)
        {
            string cmd = "INSERT INTO SACH VALUES('" + maSach + "', N'" + tenSach + "', N'" + theLoai + "', N'" + tacGia + "'," + giaMua + ", " + giaBia + ", N'" + nhaXuatBan + "', " + namXuatBan + ",  @avatar)";

            try
            {
                return DataProvider.Instance.ExecuteNonQuery(cmd, new SqlParameter[] { new SqlParameter("@avatar", avatar) }) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool XoaSach(string maSach)
        {
            string cmd = "DELETE FROM SACH WHERE MASACH = @maSach";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@maSach", SqlDbType.VarChar);
            param[0].Value = maSach;

            try
            {
                return DataProvider.Instance.ExecuteNonQuery(cmd, param) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool SuaSach(string maSach, string tenSach, string theLoai, string tacGia, string nhaXuatBan, int namXuatBan, int giaMua, int giaBia, byte[] avatar)
        {
            string cmd = "UPDATE SACH SET TENSACH = N'" + tenSach + "', THELOAI = N'" + theLoai + "', TACGIA = N'" + tacGia + "', NHAXUATBAN = N'" + nhaXuatBan + "', NAMXUATBAN = " + namXuatBan + ", GIAMUA = " + giaMua + ", GIABIA = " + giaBia + ", HINHANH = @avatar WHERE MASACH = '"+ maSach +"'";

            try
            {
                return DataProvider.Instance.ExecuteNonQuery(cmd, new SqlParameter[] { new SqlParameter("@avatar", avatar) }) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool KiemTraTrung(string maSach)
        {
            string cmd = "SELECT * FROM SACH WHERE MASACH = @maSach";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@maSach", SqlDbType.VarChar);
            param[0].Value = maSach;

            try
            {
                return DataProvider.Instance.ExecuteQuery(cmd, param).Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable getSach(string maSach)
        {
            string cmd = "SELECT * FROM SACH WHERE MASACH = @maSach";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@maSach", SqlDbType.VarChar);
            param[0].Value = maSach;

            try
            {
                return DataProvider.Instance.ExecuteQuery(cmd, param);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable getSoluongSach(string maSach)
        {
            string cmd = "SELECT SOLUONG FROM KHO WHERE MASACH = @maSach";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@maSach", SqlDbType.VarChar);
            param[0].Value = maSach;

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