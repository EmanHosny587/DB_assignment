using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public partial class Form1 : Form
    {
        string connectionString =
            @"Data Source=DESKTOP-058A3R7\MSSQLSERVER01;Initial Catalog=AA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void LoadPatients()
        {
            string query = "SELECT * FROM PATIENT";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void showData_Click(object sender, EventArgs e)
        {
         

            LoadPatients();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExecuteQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
              ;
                int rows = cmd.ExecuteNonQuery();
            }

          
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string insertPatients = @"
        IF NOT EXISTS (SELECT 1 FROM PATIENT WHERE PATIENT_ID = 103)
        INSERT INTO PATIENT (PATIENT_ID, CONTACT_HISTORY, DEMOGRAPHIC)
        VALUES (103, '01018532698', 'Male, 99 years old');

        IF NOT EXISTS (SELECT 1 FROM PATIENT WHERE PATIENT_ID = 104)
        INSERT INTO PATIENT (PATIENT_ID, CONTACT_HISTORY, DEMOGRAPHIC)
        VALUES (104, '01016813826', 'Male, 48 years old');

        IF NOT EXISTS (SELECT 1 FROM PATIENT WHERE PATIENT_ID = 105)
        INSERT INTO PATIENT (PATIENT_ID, CONTACT_HISTORY, DEMOGRAPHIC)
        VALUES (105, '01005887614', 'Male, 36 years old');
    ";

            ExecuteQuery(insertPatients);
            LoadPatients();

        }
    }
}