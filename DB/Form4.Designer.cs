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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button goToForm3;
            System.Windows.Forms.Button goToForm1;
            this.iS_SCHEDULEDDataGridView = new System.Windows.Forms.DataGridView();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new DB.HospitalDataSet();
            this.pATIENTTableAdapter = new DB.HospitalDataSetTableAdapters.PATIENTTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pATIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTHISTORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEMOGRAPHICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            goToForm3 = new System.Windows.Forms.Button();
            goToForm1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iS_SCHEDULEDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iS_SCHEDULEDDataGridView
            // 
            this.iS_SCHEDULEDDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iS_SCHEDULEDDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.iS_SCHEDULEDDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.iS_SCHEDULEDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iS_SCHEDULEDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iS_SCHEDULEDDataGridView.Location = new System.Drawing.Point(0, 0);
            this.iS_SCHEDULEDDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iS_SCHEDULEDDataGridView.Name = "iS_SCHEDULEDDataGridView";
            this.iS_SCHEDULEDDataGridView.RowHeadersWidth = 51;
            this.iS_SCHEDULEDDataGridView.RowTemplate.Height = 24;
            this.iS_SCHEDULEDDataGridView.Size = new System.Drawing.Size(1475, 624);
            this.iS_SCHEDULEDDataGridView.TabIndex = 0;
            this.iS_SCHEDULEDDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.iS_SCHEDULEDDataGridView_CellContentClick);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pATIENTIDDataGridViewTextBoxColumn,
            this.cONTACTHISTORYDataGridViewTextBoxColumn,
            this.dEMOGRAPHICDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pATIENTBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(460, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(673, 227);
            this.dataGridView1.TabIndex = 3;
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
            // pATIENTBindingSource1
            // 
            this.pATIENTBindingSource1.DataMember = "PATIENT";
            this.pATIENTBindingSource1.DataSource = this.hospitalDataSet;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.Location = new System.Drawing.Point(33, 214);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(186, 38);
            button2.TabIndex = 24;
            button2.Text = "Go to form 3";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // goToForm3
            // 
            goToForm3.BackColor = System.Drawing.SystemColors.ScrollBar;
            goToForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            goToForm3.Location = new System.Drawing.Point(33, 132);
            goToForm3.Name = "goToForm3";
            goToForm3.Size = new System.Drawing.Size(186, 38);
            goToForm3.TabIndex = 23;
            goToForm3.Text = "Go to form 2";
            goToForm3.UseVisualStyleBackColor = false;
            goToForm3.Click += new System.EventHandler(this.goToForm3_Click);
            // 
            // goToForm1
            // 
            goToForm1.BackColor = System.Drawing.SystemColors.ScrollBar;
            goToForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            goToForm1.Location = new System.Drawing.Point(33, 53);
            goToForm1.Name = "goToForm1";
            goToForm1.Size = new System.Drawing.Size(186, 38);
            goToForm1.TabIndex = 22;
            goToForm1.Text = "Go to form 1";
            goToForm1.UseVisualStyleBackColor = false;
            goToForm1.Click += new System.EventHandler(this.goToForm1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1167, 72);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select from Paitents That have consultation using join";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(button2);
            this.Controls.Add(goToForm3);
            this.Controls.Add(goToForm1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iS_SCHEDULEDDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Patient Schedule Join";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iS_SCHEDULEDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // This variable MUST be defined here so the Designer can "see" it
        private System.Windows.Forms.DataGridView iS_SCHEDULEDDataGridView;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private HospitalDataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTHISTORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEMOGRAPHICDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pATIENTBindingSource1;
        private System.Windows.Forms.Label label3;
    }
}