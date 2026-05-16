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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button dashback;
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
            this.label3 = new System.Windows.Forms.Label();
            this.Speciality = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            goToForm1 = new System.Windows.Forms.Button();
            goToForm3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            dashback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRACTITIONERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // goToForm1
            // 
            goToForm1.BackColor = System.Drawing.SystemColors.ScrollBar;
            goToForm1.Location = new System.Drawing.Point(33, 53);
            goToForm1.Name = "goToForm1";
            goToForm1.Size = new System.Drawing.Size(165, 38);
            goToForm1.TabIndex = 13;
            goToForm1.Text = "Go to form 1";
            goToForm1.UseVisualStyleBackColor = false;
            goToForm1.Click += new System.EventHandler(this.goToForm1_Click);
            // 
            // goToForm3
            // 
            goToForm3.BackColor = System.Drawing.SystemColors.ScrollBar;
            goToForm3.Location = new System.Drawing.Point(33, 116);
            goToForm3.Name = "goToForm3";
            goToForm3.Size = new System.Drawing.Size(165, 38);
            goToForm3.TabIndex = 15;
            goToForm3.Text = "Go to form 3";
            goToForm3.UseVisualStyleBackColor = false;
            goToForm3.Click += new System.EventHandler(this.goToForm3_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            button1.Location = new System.Drawing.Point(33, 177);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(165, 38);
            button1.TabIndex = 18;
            button1.Text = "Go to form 4";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRACTITIONERIDDataGridViewTextBoxColumn,
            this.sPECIALITYIDDataGridViewTextBoxColumn,
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRACTITIONERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(355, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pRACTITIONERIDDataGridViewTextBoxColumn
            // 
            this.pRACTITIONERIDDataGridViewTextBoxColumn.DataPropertyName = "PRACTITIONER_ID";
            this.pRACTITIONERIDDataGridViewTextBoxColumn.HeaderText = "PRACTITIONER_ID";
            this.pRACTITIONERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRACTITIONERIDDataGridViewTextBoxColumn.Name = "pRACTITIONERIDDataGridViewTextBoxColumn";
            // 
            // sPECIALITYIDDataGridViewTextBoxColumn
            // 
            this.sPECIALITYIDDataGridViewTextBoxColumn.DataPropertyName = "SPECIALITY_ID";
            this.sPECIALITYIDDataGridViewTextBoxColumn.HeaderText = "SPECIALITY_ID";
            this.sPECIALITYIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sPECIALITYIDDataGridViewTextBoxColumn.Name = "sPECIALITYIDDataGridViewTextBoxColumn";
            // 
            // mEDICALEXPERTISEDataGridViewTextBoxColumn
            // 
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn.DataPropertyName = "MEDICAL_EXPERTISE";
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn.HeaderText = "MEDICAL_EXPERTISE";
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mEDICALEXPERTISEDataGridViewTextBoxColumn.Name = "mEDICALEXPERTISEDataGridViewTextBoxColumn";
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
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Update.BackColor = System.Drawing.Color.Silver;
            this.Update.Location = new System.Drawing.Point(793, 473);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(182, 39);
            this.Update.TabIndex = 6;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(1017, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Practitioner id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(973, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Medical experties";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // practitionerID_input
            // 
            this.practitionerID_input.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.practitionerID_input.Location = new System.Drawing.Point(1183, 224);
            this.practitionerID_input.Name = "practitionerID_input";
            this.practitionerID_input.Size = new System.Drawing.Size(112, 22);
            this.practitionerID_input.TabIndex = 9;
            this.practitionerID_input.TextChanged += new System.EventHandler(this.practitionerID_input_TextChanged);
            // 
            // medicalExperties_input
            // 
            this.medicalExperties_input.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.medicalExperties_input.Location = new System.Drawing.Point(1183, 257);
            this.medicalExperties_input.Name = "medicalExperties_input";
            this.medicalExperties_input.Size = new System.Drawing.Size(112, 22);
            this.medicalExperties_input.TabIndex = 10;
            // 
            // showData
            // 
            this.showData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showData.BackColor = System.Drawing.Color.Silver;
            this.showData.Location = new System.Drawing.Point(1060, 473);
            this.showData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(182, 39);
            this.showData.TabIndex = 11;
            this.showData.Text = "show data";
            this.showData.UseVisualStyleBackColor = false;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // insert
            // 
            this.insert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.insert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.insert.Location = new System.Drawing.Point(278, 473);
            this.insert.Margin = new System.Windows.Forms.Padding(4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(182, 39);
            this.insert.TabIndex = 12;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete.BackColor = System.Drawing.Color.Firebrick;
            this.delete.Location = new System.Drawing.Point(533, 473);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(182, 39);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(1045, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Specialty";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Speciality
            // 
            this.Speciality.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Speciality.Location = new System.Drawing.Point(1183, 293);
            this.Speciality.Name = "Speciality";
            this.Speciality.Size = new System.Drawing.Size(112, 22);
            this.Speciality.TabIndex = 17;
            this.Speciality.TextChanged += new System.EventHandler(this.Speciality_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 72);
            this.label4.TabIndex = 19;
            this.label4.Text = "Table Practitioner";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dashback
            // 
            dashback.BackColor = System.Drawing.SystemColors.ScrollBar;
            dashback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dashback.Location = new System.Drawing.Point(33, 224);
            dashback.Name = "dashback";
            dashback.Size = new System.Drawing.Size(165, 38);
            dashback.TabIndex = 28;
            dashback.Text = "Go to  Dashboard";
            dashback.UseVisualStyleBackColor = false;
            dashback.Click += new System.EventHandler(this.dashback_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1472, 648);
            this.Controls.Add(dashback);
            this.Controls.Add(this.label4);
            this.Controls.Add(button1);
            this.Controls.Add(this.Speciality);
            this.Controls.Add(this.label3);
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Speciality;
        private System.Windows.Forms.Label label4;
    }
}