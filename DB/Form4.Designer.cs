namespace DB
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.iS_SCHEDULEDDataGridView = new System.Windows.Forms.DataGridView();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new DB.HospitalDataSet();
            this.pATIENTTableAdapter = new DB.HospitalDataSetTableAdapters.PATIENTTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pATIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dEMOGRAPHICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTHISTORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iS_SCHEDULEDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iS_SCHEDULEDDataGridView
            // 
            this.iS_SCHEDULEDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iS_SCHEDULEDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iS_SCHEDULEDDataGridView.Location = new System.Drawing.Point(0, 0);
            this.iS_SCHEDULEDDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.iS_SCHEDULEDDataGridView.Name = "iS_SCHEDULEDDataGridView";
            this.iS_SCHEDULEDDataGridView.RowHeadersWidth = 51;
            this.iS_SCHEDULEDDataGridView.RowTemplate.Height = 24;
            this.iS_SCHEDULEDDataGridView.Size = new System.Drawing.Size(600, 366);
            this.iS_SCHEDULEDDataGridView.TabIndex = 0;
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT";
            this.pATIENTBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pATIENTTableAdapter
            // 
            this.pATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pATIENTIDDataGridViewTextBoxColumn,
            this.cONTACTHISTORYDataGridViewTextBoxColumn,
            this.dEMOGRAPHICDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pATIENTBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(244, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // pATIENTBindingSource1
            // 
            this.pATIENTBindingSource1.DataMember = "PATIENT";
            this.pATIENTBindingSource1.DataSource = this.hospitalDataSet;
            // 
            // dEMOGRAPHICDataGridViewTextBoxColumn
            // 
            this.dEMOGRAPHICDataGridViewTextBoxColumn.DataPropertyName = "DEMOGRAPHIC";
            this.dEMOGRAPHICDataGridViewTextBoxColumn.HeaderText = "DEMOGRAPHIC";
            this.dEMOGRAPHICDataGridViewTextBoxColumn.Name = "dEMOGRAPHICDataGridViewTextBoxColumn";
            // 
            // cONTACTHISTORYDataGridViewTextBoxColumn
            // 
            this.cONTACTHISTORYDataGridViewTextBoxColumn.DataPropertyName = "CONTACT_HISTORY";
            this.cONTACTHISTORYDataGridViewTextBoxColumn.HeaderText = "CONTACT_HISTORY";
            this.cONTACTHISTORYDataGridViewTextBoxColumn.Name = "cONTACTHISTORYDataGridViewTextBoxColumn";
            // 
            // pATIENTIDDataGridViewTextBoxColumn
            // 
            this.pATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.Name = "pATIENTIDDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iS_SCHEDULEDDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Patient Schedule Join";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iS_SCHEDULEDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // This variable MUST be defined here so the Designer can "see" it
        private System.Windows.Forms.DataGridView iS_SCHEDULEDDataGridView;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private HospitalDataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTHISTORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEMOGRAPHICDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pATIENTBindingSource1;
    }
}