using System;
using System.Data;
using System.Data.SqlClient;

namespace QLS.Resources
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private const int PgSize = 10;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            DataTable result = new DataTable();
            string query = "SELECT * FROM TAIKHOAN WHERE USERNAME = @username AND PASS_WORD = @password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            result = DataProvider.Instance.ExecuteQuery(query, parameters);
            return result.Rows.Count > 0;
        }
        public DataTable getNguoiDung(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN WHERE ROLE = @id");
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return data;
        }
        public bool UpdateAccount(string username, string password, string newpassword)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE USERNAME = @username AND PASS_WORD = @password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                query = "UPDATE TAIKHOAN SET PASS_WORD = @newpassword WHERE USERNAME = @username";
                SqlParameter[] parameters1 = new SqlParameter[]
                {
                    new SqlParameter("@username", username),
                    new SqlParameter("@newpassword", newpassword)
                };
                DataProvider.Instance.ExecuteNonQuery(query, parameters1);
                return true;
            }
            return false;
        }

        public int ThemNote(string note, string tk)
        {
            int data = 0;
            data = DataProvider.Instance.ExecuteNonQuery("UPDATE TAIKHOAN SET NOTE = '" + note + "' WHERE USERNAME = '" + tk + "'");
            return data;
        }

        public bool DoiMatKhau(string tk, string mk)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("UPDATE TAIKHOAN SET PASS_WORD = '" + mk + "' WHERE USERNAME = '" + tk + "'");

            return data > 0;
        }

        public DataTable getNote(string tk)
        {
            string query = "select note from taikhoan where username = '" + tk + "'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public DataTable kiemTraTrung(string tk)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN WHERE USERNAME = '" + tk + "' ");

            return dt;
        }

        public bool XoaNguoiDung(string TK)
        {
            int data = 0;
            string query = "DELETE FROM TAIKHOAN WHERE USERNAME = '" + TK + "'";

            data = DataProvider.Instance.ExecuteNonQuery(query);

            return data > 0;
        }

        public bool ThemNguoiDung(string tk, string mk, int role, string note, byte[] avatar, string fullname, string phone)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("INSERT INTO TAIKHOAN VALUES ('" + tk + "', '" + mk + "', " + role + ", '" + note + "', @avatar, N'" + fullname + "', '" + phone + "')", 
                new SqlParameter[] { new SqlParameter("@avatar", avatar) });

            int data1 = ThemCaiDat(tk) ? 1 : 0;
            
            return data > 0 && data1 > 0;
        }

        public bool ThemCaiDat(string tk)
        {
           string query = "INSERT INTO CAIDAT VALUES ('" + tk + "', 0, 0, 0, 1)";

            int data = DataProvider.Instance.ExecuteNonQuery(query);

            return data > 0;
        }

        public bool SuaNguoiDung(string tk, string mk, int role, string note, byte[] avatar, string fullname, string phone)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("UPDATE TAIKHOAN SET PASS_WORD = '" + mk + "', ROLE = " + role + ", NOTE = '" + note + "', AVATAR = @avatar, FULLNAME = N'" + fullname + "', DIENTHOAI = '" + phone + "' WHERE USERNAME = '" + tk + "'", 
                new SqlParameter[] { new SqlParameter("@avatar", avatar) });

            return data > 0;
        }

        public DataTable GetCurrentRecords(int page)
        {
            string cmd = "";
            DataTable dt = new DataTable();
            if (page == 1)
            {
                cmd = "Select TOP " + PgSize + " * from TAIKHOAN ORDER BY USERNAME";
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * PgSize;

                cmd = @"Select TOP " + PgSize + " * from TAIKHOAN WHERE USERNAME NOT IN (Select TOP " + PreviousPageOffSet + " USERNAME from TAIKHOAN ORDER BY USERNAME)";
            }
            try
            {
                dt = DataProvider.Instance.ExecuteQuery(cmd);
            }
            catch(Exception ex)
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
               
                 cmd = "Select * from TAIKHOAN WHERE USERNAME like '%" + keyword + "%' ORDER BY USERNAME";
            }
            else
            {
                if (page == 1)
                {
                   
                    cmd = "Select TOP " + PgSize + " * from TAIKHOAN WHERE USERNAME like '%" + keyword + "%' ORDER BY USERNAME";
                }
                else
                {
                   int PreviousPageOffSet = (page - 1) * PgSize;
                   
                   cmd = @"Select TOP " + PgSize + " * from TAIKHOAN WHERE USERNAME like '%" + keyword + "%' " +
                        "AND USERNAME NOT IN (Select TOP " + PreviousPageOffSet + " USERNAME " +
                        "from TAIKHOAN WHERE USERNAME like '%" + keyword + "%' ORDER BY USERNAME)";

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
            String cmd = "SELECT COUNT (*) FROM TAIKHOAN WHERE USERNAME LIKE '%" + keyword + "%'";

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
    }
}