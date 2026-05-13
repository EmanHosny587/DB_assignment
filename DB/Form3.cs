using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form3 : Form
    {
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
            // TODO: This line of code loads data into the 'hospitalDataSet.PRACTITIONER' table. You can move, or remove it, as needed.
            this.pRACTITIONERTableAdapter.Fill(this.hospitalDataSet.PRACTITIONER);
            // TODO: This line of code loads data into the 'hospitalDataSet.SPECIALITY' table. You can move, or remove it, as needed.
            this.sPECIALITYTableAdapter.Fill(this.hospitalDataSet.SPECIALITY);

        }
    }
}
