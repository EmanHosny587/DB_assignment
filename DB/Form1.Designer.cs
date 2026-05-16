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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Button dashback;
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
            this.delete = new System.Windows.Forms.Button();
            this.goToForm4 = new System.Windows.Forms.Button();
            this.goToForm3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            dashback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pATIENTIDDataGridViewTextBoxColumn,
            this.cONTACTHISTORYDataGridViewTextBoxColumn,
            this.dEMOGRAPHICDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pATIENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(378, 180);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(469, 243);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pATIENTIDDataGridViewTextBoxColumn
            // 
            this.pATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT_ID";
            this.pATIENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pATIENTIDDataGridViewTextBoxColumn.Name = "pATIENTIDDataGridViewTextBoxColumn";
            // 
            // cONTACTHISTORYDataGridViewTextBoxColumn
            // 
            this.cONTACTHISTORYDataGridViewTextBoxColumn.DataPropertyName = "CONTACT_HISTORY";
            this.cONTACTHISTORYDataGridViewTextBoxColumn.HeaderText = "CONTACT_HISTORY";
            this.cONTACTHISTORYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cONTACTHISTORYDataGridViewTextBoxColumn.Name = "cONTACTHISTORYDataGridViewTextBoxColumn";
            // 
            // dEMOGRAPHICDataGridViewTextBoxColumn
            // 
            this.dEMOGRAPHICDataGridViewTextBoxColumn.DataPropertyName = "DEMOGRAPHIC";
            this.dEMOGRAPHICDataGridViewTextBoxColumn.HeaderText = "DEMOGRAPHIC";
            this.dEMOGRAPHICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEMOGRAPHICDataGridViewTextBoxColumn.Name = "dEMOGRAPHICDataGridViewTextBoxColumn";
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
            this.showData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showData.BackColor = System.Drawing.Color.LightGray;
            this.showData.Location = new System.Drawing.Point(1103, 466);
            this.showData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(205, 39);
            this.showData.TabIndex = 2;
            this.showData.Text = "show data";
            this.showData.UseVisualStyleBackColor = false;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(239, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
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
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Update.BackColor = System.Drawing.Color.Silver;
            this.Update.Location = new System.Drawing.Point(831, 466);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(205, 39);
            this.Update.TabIndex = 5;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.update_Click);
            // 
            // patientID_input
            // 
            this.patientID_input.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.patientID_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientID_input.Location = new System.Drawing.Point(1123, 241);
            this.patientID_input.Name = "patientID_input";
            this.patientID_input.Size = new System.Drawing.Size(145, 26);
            this.patientID_input.TabIndex = 6;
            this.patientID_input.Text = " ";
            this.patientID_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // demographic_input
            // 
            this.demographic_input.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.demographic_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demographic_input.Location = new System.Drawing.Point(1123, 310);
            this.demographic_input.Name = "demographic_input";
            this.demographic_input.Size = new System.Drawing.Size(145, 26);
            this.demographic_input.TabIndex = 7;
            this.demographic_input.TextChanged += new System.EventHandler(this.demographic_input_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(948, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "paitent id";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(948, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dempgraphic";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // goToForm2
            // 
            this.goToForm2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.goToForm2.Location = new System.Drawing.Point(33, 53);
            this.goToForm2.Name = "goToForm2";
            this.goToForm2.Size = new System.Drawing.Size(165, 38);
            this.goToForm2.TabIndex = 10;
            this.goToForm2.Text = "Go to form 2";
            this.goToForm2.UseVisualStyleBackColor = false;
            this.goToForm2.Click += new System.EventHandler(this.goToForm2_Click);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete.BackColor = System.Drawing.Color.Firebrick;
            this.delete.Location = new System.Drawing.Point(544, 466);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(205, 39);
            this.delete.TabIndex = 11;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // goToForm4
            // 
            this.goToForm4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.goToForm4.Location = new System.Drawing.Point(33, 170);
            this.goToForm4.Name = "goToForm4";
            this.goToForm4.Size = new System.Drawing.Size(165, 38);
            this.goToForm4.TabIndex = 12;
            this.goToForm4.Text = "Go to form 4";
            this.goToForm4.UseVisualStyleBackColor = false;
            this.goToForm4.Click += new System.EventHandler(this.goToForm4_Click);
            // 
            // goToForm3
            // 
            this.goToForm3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.goToForm3.Location = new System.Drawing.Point(33, 109);
            this.goToForm3.Name = "goToForm3";
            this.goToForm3.Size = new System.Drawing.Size(165, 38);
            this.goToForm3.TabIndex = 13;
            this.goToForm3.Text = "Go to form 3";
            this.goToForm3.UseVisualStyleBackColor = false;
            this.goToForm3.Click += new System.EventHandler(this.goToForm3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 72);
            this.label3.TabIndex = 14;
            this.label3.Text = "Table Patient";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dashback
            // 
            dashback.BackColor = System.Drawing.SystemColors.ScrollBar;
            dashback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dashback.Location = new System.Drawing.Point(33, 241);
            dashback.Name = "dashback";
            dashback.Size = new System.Drawing.Size(165, 38);
            dashback.TabIndex = 29;
            dashback.Text = "Go to  Dashboard";
            dashback.UseVisualStyleBackColor = false;
            dashback.Click += new System.EventHandler(this.dashback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1471, 701);
            this.Controls.Add(dashback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goToForm3);
            this.Controls.Add(this.goToForm4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.goToForm2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.demographic_input);
            this.Controls.Add(this.patientID_input);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_2);
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
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button goToForm4;
        private System.Windows.Forms.Button goToForm3;
        private System.Windows.Forms.Label label3;
    }
}

