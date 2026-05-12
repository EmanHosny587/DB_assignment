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
            this.Update = new System.Windows.Forms.Button();
            this.patientID_input = new System.Windows.Forms.TextBox();
            this.demographic_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goToForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(560, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 231);
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
            this.showData.Location = new System.Drawing.Point(640, 321);
            this.showData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(213, 42);
            this.showData.TabIndex = 2;
            this.showData.Text = "show data";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 39);
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
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(933, 321);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(199, 42);
            this.Update.TabIndex = 5;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.update_Click);
            // 
            // patientID_input
            // 
            this.patientID_input.Location = new System.Drawing.Point(359, 68);
            this.patientID_input.Name = "patientID_input";
            this.patientID_input.Size = new System.Drawing.Size(129, 22);
            this.patientID_input.TabIndex = 6;
            this.patientID_input.Text = " ";
            this.patientID_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // demographic_input
            // 
            this.demographic_input.Location = new System.Drawing.Point(359, 121);
            this.demographic_input.Name = "demographic_input";
            this.demographic_input.Size = new System.Drawing.Size(129, 22);
            this.demographic_input.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "paitent id";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dempgraphic";
            // 
            // goToForm2
            // 
            this.goToForm2.Location = new System.Drawing.Point(85, 321);
            this.goToForm2.Name = "goToForm2";
            this.goToForm2.Size = new System.Drawing.Size(209, 38);
            this.goToForm2.TabIndex = 10;
            this.goToForm2.Text = "Go to form 2";
            this.goToForm2.UseVisualStyleBackColor = true;
            this.goToForm2.Click += new System.EventHandler(this.goToForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 623);
            this.Controls.Add(this.goToForm2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.demographic_input);
            this.Controls.Add(this.patientID_input);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox patientID_input;
        private System.Windows.Forms.TextBox demographic_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goToForm2;
    }
}

