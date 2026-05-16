using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB
{
    public partial class Form4 : Form
    {
        // Using the central connection string
        string connectionString =
      @"Data Source=DESKTOP-058A3R7\MSSQLSERVER01;Initial Catalog=Hospital_managment;Integrated Security=True;TrustServerCertificate=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Call the join method as soon as the form opens
            LoadMyCustomJoin();
        }

        private void LoadMyCustomJoin()
        {
            
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                SELECT 
                    p.PATIENT_ID, 
                    p.CONTACT_HISTORY, 
                    p.DEMOGRAPHIC, 
                    c.CONSULTATION_ID
                FROM PATIENT p 
                   INNER JOIN CLINIC_CONSULTATION c ON p.PATIENT_ID = c.PATIENT_ID";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                  
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = table;
                    dataGridView1.Refresh();
                }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Refresh the data when button is clicked
            LoadMyCustomJoin();
        }

        private void iS_SCHEDULEDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goToForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void goToForm3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}