namespace DB
{
    partial class Form2
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
            System.Windows.Forms.Button goToForm1;
            System.Windows.Forms.Button goToForm3;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRACTITIONERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPECIALITYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACTITIONERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new DB.HospitalDataSet();
            this.pRACTITIONERTableAdapter = new DB.HospitalDataSetTableAdapters.PRACTITIONERTableAdapter();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.practitionerID_input = new System.Windows.Forms.TextBox();
            this.medicalExperties_input = new System.Windows.Forms.TextBox();
            this.showData = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            goToForm1 = new System.Windows.Forms.Button();
            goToForm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // goToForm1
            // 
            goToForm1.Location = new System.Drawing.Point(12, 426);
            goToForm1.Name = "goToForm1";
            goToForm1.Size = new System.Drawing.Size(167, 38);
            goToForm1.TabIndex = 13;
            goToForm1.Text = "Go to form 1";
            goToForm1.UseVisualStyleBackColor = true;
            goToForm1.Click += new System.EventHandler(this.goToForm1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRACTITIONERIDDataGridViewTextBoxColumn,
            this.sPECIALITYIDDataGridViewTextBoxColumn,
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRACTITIONERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(425, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // pRACTITIONERIDDataGridViewTextBoxColumn
            // 
            this.pRACTITIONERIDDataGridViewTextBoxColumn.DataPropertyName = "PRACTITIONER_ID";
            this.pRACTITIONERIDDataGridViewTextBoxColumn.HeaderText = "PRACTITIONER_ID";
            this.pRACTITIONERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRACTITIONERIDDataGridViewTextBoxColumn.Name = "pRACTITIONERIDDataGridViewTextBoxColumn";
            this.pRACTITIONERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sPECIALITYIDDataGridViewTextBoxColumn
            // 
            this.sPECIALITYIDDataGridViewTextBoxColumn.DataPropertyName = "SPECIALITY_ID";
            this.sPECIALITYIDDataGridViewTextBoxColumn.HeaderText = "SPECIALITY_ID";
            this.sPECIALITYIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sPECIALITYIDDataGridViewTextBoxColumn.Name = "sPECIALITYIDDataGridViewTextBoxColumn";
            this.sPECIALITYIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mEDICALEXPERTISEDataGridViewTextBoxColumn
            // 
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn.DataPropertyName = "MEDICAL_EXPERTISE";
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn.HeaderText = "MEDICAL_EXPERTISE";
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn.Name = "mEDICALEXPERTISEDataGridViewTextBoxColumn";
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRACTITIONERBindingSource
            // 
            this.pRACTITIONERBindingSource.DataMember = "PRACTITIONER";
            this.pRACTITIONERBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRACTITIONERTableAdapter
            // 
            this.pRACTITIONERTableAdapter.ClearBeforeFill = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(677, 426);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(182, 38);
            this.Update.TabIndex = 6;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Practitioner id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Medical experties";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // practitionerID_input
            // 
            this.practitionerID_input.Location = new System.Drawing.Point(234, 138);
            this.practitionerID_input.Name = "practitionerID_input";
            this.practitionerID_input.Size = new System.Drawing.Size(100, 22);
            this.practitionerID_input.TabIndex = 9;
            this.practitionerID_input.TextChanged += new System.EventHandler(this.practitionerID_input_TextChanged);
            // 
            // medicalExperties_input
            // 
            this.medicalExperties_input.Location = new System.Drawing.Point(234, 190);
            this.medicalExperties_input.Name = "medicalExperties_input";
            this.medicalExperties_input.Size = new System.Drawing.Size(100, 22);
            this.medicalExperties_input.TabIndex = 10;
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(882, 426);
            this.showData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(182, 38);
            this.showData.TabIndex = 11;
            this.showData.Text = "show data";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(443, 425);
            this.insert.Margin = new System.Windows.Forms.Padding(4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(182, 39);
            this.insert.TabIndex = 12;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(216, 426);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(182, 38);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // goToForm3
            // 
            goToForm3.Location = new System.Drawing.Point(12, 470);
            goToForm3.Name = "goToForm3";
            goToForm3.Size = new System.Drawing.Size(167, 38);
            goToForm3.TabIndex = 15;
            goToForm3.Text = "Go to form 3";
            goToForm3.UseVisualStyleBackColor = true;
            goToForm3.Click += new System.EventHandler(this.goToForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 633);
            this.Controls.Add(goToForm3);
            this.Controls.Add(this.delete);
            this.Controls.Add(goToForm1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.medicalExperties_input);
            this.Controls.Add(this.practitionerID_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pRACTITIONERBindingSource;
        private HospitalDataSetTableAdapters.PRACTITIONERTableAdapter pRACTITIONERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACTITIONERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPECIALITYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDICALEXPERTISEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox practitionerID_input;
        private System.Windows.Forms.TextBox medicalExperties_input;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
    }
}