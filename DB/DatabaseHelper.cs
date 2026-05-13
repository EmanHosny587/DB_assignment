using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB
{
    public static class DatabaseHelper
    {
        // Use your actual connection string here
        public static string ConnectionString = @"Data Source=DESKTOP-A9UPH8B\SQLEXPRESS;Initial Catalog=fin;Integrated Security=True;TrustServerCertificate=True";

        // Method to fetch data for GridViews and ComboBoxes
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
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Retrieval Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }

        // Method to execute Insert, Update, and Delete operations
        public static int ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(parameters);
                        }
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Command executed but no records were affected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return rows;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Specifically handling Foreign Key reference errors (Common in Delete operations)
                if (ex.Number == 547)
                    MessageBox.Show("Constraint Error: This record is linked to other data and cannot be modified or deleted.", "Integrity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Database Execution Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return -1;
            }
        }

        // The missing method required by HomeControl.cs
        public static int GetCount(string tableName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = $"SELECT COUNT(*) FROM [{tableName}]";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch
            {
                return 0; // Return 0 if the table is empty or doesn't exist
            }
        }
    }
}