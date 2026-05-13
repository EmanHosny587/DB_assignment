using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class PrescriptionManagementControl : UserControl
    {
        private ComboBox cmbSummaries;
        private ComboBox cmbMedications;
        private TextBox txtPrescriptionId;
        private TextBox txtDosage;
        private TextBox txtDuration;
        private DataGridView grid;

        public PrescriptionManagementControl()
        {
            BuildGui();
            LoadSummaries();
            LoadMedications();
            LoadPrescriptions();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Medication Prescription Management"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 220);
            Controls.Add(card);

            // Row 1: IDs and Selection
            card.Controls.Add(ModernStyle.CreateLabel("Prescription ID", 20, 20));
            txtPrescriptionId = ModernStyle.CreateTextBox(160, 20);
            card.Controls.Add(txtPrescriptionId);

            card.Controls.Add(ModernStyle.CreateLabel("Select Diagnosis", 380, 20));
            cmbSummaries = new ComboBox();
            cmbSummaries.Location = new Point(520, 20);
            cmbSummaries.Size = new Size(380, 28);
            cmbSummaries.DropDownStyle = ComboBoxStyle.DropDownList;
            card.Controls.Add(cmbSummaries);

            // Row 2: Medication and Dosage
            card.Controls.Add(ModernStyle.CreateLabel("Medication", 20, 70));
            cmbMedications = new ComboBox();
            cmbMedications.Location = new Point(160, 70);
            cmbMedications.Size = new Size(200, 28);
            cmbMedications.DropDownStyle = ComboBoxStyle.DropDownList;
            card.Controls.Add(cmbMedications);

            card.Controls.Add(ModernStyle.CreateLabel("Dosage", 380, 70));
            txtDosage = ModernStyle.CreateTextBox(520, 70, 380);
            card.Controls.Add(txtDosage);

            // Row 3: Duration and Button
            card.Controls.Add(ModernStyle.CreateLabel("Duration (Days)", 20, 120));
            txtDuration = ModernStyle.CreateTextBox(160, 120);
            card.Controls.Add(txtDuration);

            Button btnAdd = ModernStyle.CreateSuccessButton("Issue Prescription", 400, 160, 220);
            btnAdd.Click += BtnAdd_Click;
            card.Controls.Add(btnAdd);

            // Results Grid
            grid = new DataGridView();
            ModernStyle.StyleGrid(grid);
            grid.Location = new Point(25, 320);
            grid.Size = new Size(950, 350);
            Controls.Add(grid);
        }

        private void LoadSummaries()
        {
            string query = @"
                SELECT CS.CLINICAL_SUMMARY_ID, 
                       P.PATIENT_NAME + ' (Diag: ' + CS.DIAGNOSIS + ')' as Info
                FROM CLINICAL_SUMMARY CS
                JOIN CONSULTATION C ON CS.CONSULTATION_ID = C.CONSULTATION_ID
                JOIN PATIENT P ON C.PATIENT_ID = P.PATIENT_ID";

            DataTable dt = DatabaseHelper.GetData(query);
            cmbSummaries.DataSource = dt;
            cmbSummaries.DisplayMember = "Info";
            cmbSummaries.ValueMember = "CLINICAL_SUMMARY_ID";
        }

        private void LoadMedications()
        {
            string query = "SELECT MEDICATION_ID, MEDICATION_NAME FROM MEDICATION";
            DataTable dt = DatabaseHelper.GetData(query);
            cmbMedications.DataSource = dt;
            cmbMedications.DisplayMember = "MEDICATION_NAME";
            cmbMedications.ValueMember = "MEDICATION_ID";
        }

        private void LoadPrescriptions()
        {
            string query = @"
                SELECT PR.PRESCRIPTION_ID, P.PATIENT_NAME, M.MEDICATION_NAME, 
                       PI.DOSAGE_INSTRUCTIONS, PI.DURATION_DAYS
                FROM PRESCRIBEDIN PI
                JOIN PRESCRIPTION PR ON PI.PRESCRIPTION_ID = PR.PRESCRIPTION_ID
                JOIN MEDICATION M ON PI.MEDICATION_ID = M.MEDICATION_ID
                JOIN CLINICAL_SUMMARY CS ON PR.CLINICAL_SUMMARY_ID = CS.CLINICAL_SUMMARY_ID
                JOIN CONSULTATION C ON CS.CONSULTATION_ID = C.CONSULTATION_ID
                JOIN PATIENT P ON C.PATIENT_ID = P.PATIENT_ID";
            grid.DataSource = DatabaseHelper.GetData(query);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrescriptionId.Text) || cmbSummaries.SelectedValue == null)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            // Logic: 1. Create Prescription entry if not exists, 2. Link medication in PRESCRIBEDIN
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM PRESCRIPTION WHERE PRESCRIPTION_ID = @PID)
                INSERT INTO PRESCRIPTION (PRESCRIPTION_ID, CLINICAL_SUMMARY_ID, PRESCRIPTION_DATE)
                VALUES (@PID, @SID, GETDATE());

                INSERT INTO PRESCRIBEDIN (PRESCRIPTION_ID, MEDICATION_ID, DOSAGE_INSTRUCTIONS, DURATION_DAYS)
                VALUES (@PID, @MID, @Dosage, @Duration);
            ";

            DatabaseHelper.ExecuteQuery(query,
                new SqlParameter("@PID", txtPrescriptionId.Text),
                new SqlParameter("@SID", cmbSummaries.SelectedValue),
                new SqlParameter("@MID", cmbMedications.SelectedValue),
                new SqlParameter("@Dosage", txtDosage.Text),
                new SqlParameter("@Duration", txtDuration.Text)
            );

            LoadPrescriptions();
        }
    }
}