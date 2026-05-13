namespace DB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pATIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTHISTORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEMOGRAPHICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new DB.HospitalDataSet();
            this.pATIENTTableAdapter = new DB.HospitalDataSetTableAdapters.PATIENTTableAdapter();
            this.showData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hospitalDataSet1 = new DB.HospitalDataSet();
            this.hospitalDataSet2 = new DB.HospitalDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pATIENTIDDataGridViewTextBoxColumn,
            this.cONTACTHISTORYDataGridViewTextBoxColumn,
            this.dEMOGRAPHICDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pATIENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(420, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pATIENTIDDataGridViewTextBoxColumn
            // 
            this.pATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pATIENTIDDataGridViewTextBoxColumn.Name = "pATIENTIDDataGridViewTextBoxColumn";
            this.pATIENTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cONTACTHISTORYDataGridViewTextBoxColumn
            // 
            this.cONTACTHISTORYDataGridViewTextBoxColumn.DataPropertyName = "CONTACT_HISTORY";
            this.cONTACTHISTORYDataGridViewTextBoxColumn.HeaderText = "CONTACT_HISTORY";
            this.cONTACTHISTORYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cONTACTHISTORYDataGridViewTextBoxColumn.Name = "cONTACTHISTORYDataGridViewTextBoxColumn";
            this.cONTACTHISTORYDataGridViewTextBoxColumn.Width = 125;
            // 
            // dEMOGRAPHICDataGridViewTextBoxColumn
            // 
            this.dEMOGRAPHICDataGridViewTextBoxColumn.DataPropertyName = "DEMOGRAPHIC";
            this.dEMOGRAPHICDataGridViewTextBoxColumn.HeaderText = "DEMOGRAPHIC";
            this.dEMOGRAPHICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEMOGRAPHICDataGridViewTextBoxColumn.Name = "dEMOGRAPHICDataGridViewTextBoxColumn";
            this.dEMOGRAPHICDataGridViewTextBoxColumn.Width = 125;
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
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(63, 163);
            this.showData.Margin = new System.Windows.Forms.Padding(2);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(160, 76);
            this.showData.TabIndex = 2;
            this.showData.Text = "show data";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.insert_Click);
            // 
            // hospitalDataSet1
            // 
            this.hospitalDataSet1.DataSetName = "HospitalDataSet";
            this.hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalDataSet2
            // 
            this.hospitalDataSet2.DataSetName = "HospitalDataSet";
            this.hospitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(420, 281);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(429, 191);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PRACTITIONER_ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SPECIALITY_ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MEDICAL_EXPERTISE";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private HospitalDataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTHISTORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEMOGRAPHICDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.Button button1;
        private HospitalDataSet hospitalDataSet1;
        private HospitalDataSet hospitalDataSet2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

