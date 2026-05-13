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
           @"Data Source=LAPTOP-N057VS3J\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True ;TrustServerCertificate=True";
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
            SqlCommand cmd = new SqlCommand("Update Practitioner set Medical_expertise='" + medicalExperties_input.Text.ToString() + "'Where Practitioner_ID='" + practitionerID_input.Text.ToString() + "'", con);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
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

        private void showData_Click(object sender, EventArgs e)
        {
            this.pRACTITIONERTableAdapter.Fill(this.hospitalDataSet.PRACTITIONER);
        }

        private void insert_Click(object sender, EventArgs e)
        {

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
    }
}
