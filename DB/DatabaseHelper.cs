using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB
{
    public static class DatabaseHelper
    {
        public static string ConnectionString =
            @"Data Source=DESKTOP-058A3R7\MSSQLSERVER01;Initial Catalog=AA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public static DataTable GetData(string query, params SqlParameter[] parameters)
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null && parameters.Length > 0)
                            cmd.Parameters.AddRange(parameters);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message);
            }

            return table;
        }

        public static void ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null && parameters.Length > 0)
                            cmd.Parameters.AddRange(parameters);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message);
            }
        }

        public static int GetCount(string tableName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM " + tableName;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}