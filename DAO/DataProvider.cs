using System;
using System.Data;
using System.Data.SqlClient;

namespace QLS
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = Properties.Settings.Default.ConnectionString;

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while executing the query." + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    data = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while executing the non-query: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    data = command.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while executing the scalar query.", ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }
    }
}
