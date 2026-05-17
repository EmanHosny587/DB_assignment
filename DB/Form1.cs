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
    @"Data Source=DESKTOP-058A3R7\MSSQLSERVER01;Initial Catalog=Hospital_managment;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (string.IsNullOrWhiteSpace(patientID_input.Text) ||
                string.IsNullOrWhiteSpace(demographic_input.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Data");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
            IF NOT EXISTS (SELECT 1 FROM PATIENT WHERE PATIENT_ID = @PatientID)
            BEGIN
                INSERT INTO PATIENT (PATIENT_ID, CONTACT_HISTORY, DEMOGRAPHIC)
                VALUES (@PatientID, 'N/A', @Demographic)
            END", con);

                cmd.Parameters.AddWithValue("@PatientID", int.Parse(patientID_input.Text.Trim()));
                cmd.Parameters.AddWithValue("@Demographic", demographic_input.Text.Trim());

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Patient inserted!", "Success");
                else
                    MessageBox.Show("Patient ID already exists.", "Duplicate");
            }

            LoadPatients();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand( "Update Patient set Demographic='"+demographic_input.Text.ToString()+"'Where patient_ID='"+ patientID_input.Text.ToString()+"'",con);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
            LoadPatients();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goToForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Patient Where patient_ID='" + patientID_input.Text.ToString() + "'", con);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        private void goToForm3_Click(object sender, EventArgs e)
        {
            Form3 form= new Form3();
            form.Show();
            this.Hide();
        }

        private void demographic_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void goToForm4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void dashback_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }
    
    }
}