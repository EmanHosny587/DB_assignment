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

        private void iS_SCHEDULEDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iS_SCHEDULEDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.PATIENT' table. You can move, or remove it, as needed.
            this.pATIENTTableAdapter.Fill(this.hospitalDataSet.PATIENT);
            // TODO: This line of code loads data into the 'hospitalDataSet.PRACTITIONER_BRANCH' table. You can move, or remove it, as needed.
            this.pRACTITIONER_BRANCHTableAdapter.Fill(this.hospitalDataSet.PRACTITIONER_BRANCH);
            // TODO: This line of code loads data into the 'hospitalDataSet.IS_SCHEDULED' table. You can move, or remove it, as needed.
            this.iS_SCHEDULEDTableAdapter.Fill(this.hospitalDataSet.IS_SCHEDULED);

        }
    }
}
