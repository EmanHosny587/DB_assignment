using System.Drawing;

namespace DB
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBranchID = new System.Windows.Forms.TextBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.btnPatientPrescription = new System.Windows.Forms.Button();
            this.btnBranch = new System.Windows.Forms.Button();
            this.btnDiagnosis = new System.Windows.Forms.Button();
            this.btnNoConsult = new System.Windows.Forms.Button();
            this.btnTopMeds = new System.Windows.Forms.Button();
            this.btnTopSpecialty = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(550, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtBranchID);
            this.panel1.Controls.Add(this.lblBranch);
            this.panel1.Controls.Add(this.btnPatientPrescription);
            this.panel1.Controls.Add(this.btnBranch);
            this.panel1.Controls.Add(this.btnDiagnosis);
            this.panel1.Controls.Add(this.btnNoConsult);
            this.panel1.Controls.Add(this.btnTopMeds);
            this.panel1.Controls.Add(this.btnTopSpecialty);
            this.panel1.Location = new System.Drawing.Point(25, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 596);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Firebrick;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 520);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back to Form1";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // txtBranchID
            // 
            this.txtBranchID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBranchID.Location = new System.Drawing.Point(20, 400);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(200, 30);
            this.txtBranchID.TabIndex = 1;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBranch.ForeColor = System.Drawing.Color.White;
            this.lblBranch.Location = new System.Drawing.Point(20, 370);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(135, 23);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "Enter Branch ID";
            // 
            // btnPatientPrescription
            // 
            this.btnPatientPrescription.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPatientPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientPrescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPatientPrescription.Location = new System.Drawing.Point(20, 450);
            this.btnPatientPrescription.Name = "btnPatientPrescription";
            this.btnPatientPrescription.Size = new System.Drawing.Size(200, 50);
            this.btnPatientPrescription.TabIndex = 3;
            this.btnPatientPrescription.Text = "Patient Prescriptions";
            this.btnPatientPrescription.UseVisualStyleBackColor = false;
            // 
            // btnBranch
            // 
            this.btnBranch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBranch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBranch.Location = new System.Drawing.Point(20, 230);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(200, 50);
            this.btnBranch.TabIndex = 4;
            this.btnBranch.Text = "Branch Stats";
            this.btnBranch.UseVisualStyleBackColor = false;
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiagnosis.Location = new System.Drawing.Point(20, 300);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.Size = new System.Drawing.Size(200, 50);
            this.btnDiagnosis.TabIndex = 5;
            this.btnDiagnosis.Text = "Branch Diagnosis";
            this.btnDiagnosis.UseVisualStyleBackColor = false;
            // 
            // btnNoConsult
            // 
            this.btnNoConsult.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNoConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoConsult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNoConsult.Location = new System.Drawing.Point(20, 90);
            this.btnNoConsult.Name = "btnNoConsult";
            this.btnNoConsult.Size = new System.Drawing.Size(200, 50);
            this.btnNoConsult.TabIndex = 6;
            this.btnNoConsult.Text = "No Consultations";
            this.btnNoConsult.UseVisualStyleBackColor = false;
            // 
            // btnTopMeds
            // 
            this.btnTopMeds.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTopMeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopMeds.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTopMeds.Location = new System.Drawing.Point(20, 160);
            this.btnTopMeds.Name = "btnTopMeds";
            this.btnTopMeds.Size = new System.Drawing.Size(200, 50);
            this.btnTopMeds.TabIndex = 7;
            this.btnTopMeds.Text = "Top Patients Meds";
            this.btnTopMeds.UseVisualStyleBackColor = false;
            // 
            // btnTopSpecialty
            // 
            this.btnTopSpecialty.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTopSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopSpecialty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTopSpecialty.Location = new System.Drawing.Point(20, 20);
            this.btnTopSpecialty.Name = "btnTopSpecialty";
            this.btnTopSpecialty.Size = new System.Drawing.Size(200, 50);
            this.btnTopSpecialty.TabIndex = 8;
            this.btnTopSpecialty.Text = "Top Specialty";
            this.btnTopSpecialty.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(320, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 500);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1471, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Name = "Form5";
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

}
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTopSpecialty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPatientPrescription;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.Button btnDiagnosis;
        private System.Windows.Forms.Button btnNoConsult;
        private System.Windows.Forms.Button btnTopMeds;
        private System.Windows.Forms.TextBox txtBranchID;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Button btnBack;
    }
}