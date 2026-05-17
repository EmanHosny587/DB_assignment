using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form3 : Form
    {

        // Using the central connection string
        string connectionString =
       @"Data Source=DESKTOP-058A3R7\MSSQLSERVER01;Initial Catalog=Hospital_managment;Integrated Security=True;TrustServerCertificate=True";


        public Form3()
        {
            InitializeComponent();
        }

        private void sPECIALITYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sPECIALITYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                this.pRACTITIONERTableAdapter.Connection.ConnectionString = connectionString;
                this.sPECIALITYTableAdapter.Connection.ConnectionString = connectionString;

                this.pRACTITIONERTableAdapter.Fill(this.hospitalDataSet.PRACTITIONER);
                this.sPECIALITYTableAdapter.Fill(this.hospitalDataSet.SPECIALITY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Load Error: " + ex.Message);
            }
        }

        private void pRACTITIONERDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void goToForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void goToForm3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form4 form4 = new Form4();
            //form4.Show();
            //this.Hide();
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
