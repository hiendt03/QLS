using System.Data;
using System.Data.SqlClient;

namespace QLS.Resources
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password, DataTable result)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE USERNAME = @username AND PASS_WORD = @password AND ROLE = 1";
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
    }
}