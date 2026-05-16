using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form2 : Form
    {
        string connectionString =
        @"Data Source=DESKTOP-058A3R7\MSSQLSERVER01;Initial Catalog=Hospital_managment;Trust Server Certificate=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.PRACTITIONER' table. You can move, or remove it, as needed.


        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Practitioner set Speciality_ID='" + Speciality.Text.ToString() + "'Where Practitioner_ID='" + practitionerID_input.Text.ToString() + "'", con);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
            LoadPractitioners();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void practitionerID_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void goToForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void LoadPractitioners()
        {
            string query = "SELECT * FROM PRACTITIONER";

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
 
            LoadPractitioners();
        }

      private void insert_Click(object sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(practitionerID_input.Text) ||
        string.IsNullOrWhiteSpace(Speciality.Text) ||
        string.IsNullOrWhiteSpace(medicalExperties_input.Text))
    {
        MessageBox.Show("Please fill in all fields.", "Missing Data");
        return;
    }

    using (SqlConnection con = new SqlConnection(connectionString))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand(@"
            IF NOT EXISTS (SELECT 1 FROM PRACTITIONER WHERE PRACTITIONER_ID = @PractitionerID)
            BEGIN
                INSERT INTO PRACTITIONER (PRACTITIONER_ID, SPECIALITY_ID, MEDICAL_EXPERTISE)
                VALUES (@PractitionerID,@Speciality, @MedicalExpertise)
            END", con);

        cmd.Parameters.AddWithValue("@PractitionerID",   int.Parse(practitionerID_input.Text.Trim()));
        cmd.Parameters.AddWithValue("@MedicalExpertise", medicalExperties_input.Text.Trim());
        cmd.Parameters.AddWithValue("@Speciality",int.Parse(Speciality.Text.Trim()));

                int rows = cmd.ExecuteNonQuery();

        if (rows > 0)
            MessageBox.Show("Practitioner inserted!", "Success");
        else
            MessageBox.Show("Practitioner ID already exists.", "Duplicate");
    }
}

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Practitioner Where Practitioner_ID='" + practitionerID_input.Text.ToString() + "'", con);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        private void goToForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Speciality_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
