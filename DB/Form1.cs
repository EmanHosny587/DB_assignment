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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=LAPTOP-N057VS3J\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.PATIENT' table. You can move, or remove it, as needed.


        }

        private void showData_Click(object sender, EventArgs e)
        {
            this.pATIENTTableAdapter.Fill(this.hospitalDataSet.PATIENT);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
