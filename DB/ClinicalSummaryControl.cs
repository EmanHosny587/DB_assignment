using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class ClinicalSummaryControl : UserControl
    {
        private ComboBox cmbConsultations;
        private TextBox txtSummaryId;
        private RichTextBox rtbDiagnosis;
        private DataGridView grid;

        public ClinicalSummaryControl()
        {
            BuildGui();
            LoadPendingConsultations();
            LoadSummaries();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Clinical Diagnosis Summary"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 220);
            Controls.Add(card);

            // Inputs
            card.Controls.Add(ModernStyle.CreateLabel("Summary ID", 20, 20));
            txtSummaryId = ModernStyle.CreateTextBox(160, 20);
            card.Controls.Add(txtSummaryId);

            card.Controls.Add(ModernStyle.CreateLabel("Select Appointment", 20, 65));
            cmbConsultations = new ComboBox();
            cmbConsultations.Location = new Point(160, 65);
            cmbConsultations.Size = new Size(300, 28);
            cmbConsultations.DropDownStyle = ComboBoxStyle.DropDownList;
            card.Controls.Add(cmbConsultations);

            card.Controls.Add(ModernStyle.CreateLabel("Diagnosis Details", 20, 110));
            rtbDiagnosis = new RichTextBox();
            rtbDiagnosis.Location = new Point(160, 110);
            rtbDiagnosis.Size = new Size(500, 80);
            rtbDiagnosis.Font = new Font("Segoe UI", 10);
            card.Controls.Add(rtbDiagnosis);

            // Buttons
            Button btnSave = ModernStyle.CreateSuccessButton("Save Diagnosis", 700, 20, 180);
            btnSave.Click += BtnSave_Click;
            card.Controls.Add(btnSave);

            // Grid
            grid = new DataGridView();
            ModernStyle.StyleGrid(grid);
            grid.Location = new Point(25, 320);
            grid.Size = new Size(950, 350);
            Controls.Add(grid);
        }

        private void LoadPendingConsultations()
        {
            // Fetching only Scheduled consultations to provide a diagnosis for them
            string query = @"
                SELECT C.CONSULTATION_ID, 
                       P.PATIENT_NAME + ' - ' + PR.PRACTITIONER_NAME as Info
                FROM CONSULTATION C
                JOIN PATIENT P ON C.PATIENT_ID = P.PATIENT_ID
                JOIN PRACTITIONER PR ON C.PRACTITIONER_ID = PR.PRACTITIONER_ID
                WHERE C.STATUS = 'Scheduled'";

            DataTable dt = DatabaseHelper.GetData(query);
            cmbConsultations.DataSource = dt;
            cmbConsultations.DisplayMember = "Info";
            cmbConsultations.ValueMember = "CONSULTATION_ID";
        }

        private void LoadSummaries()
        {
            string query = @"
                SELECT CS.CLINICAL_SUMMARY_ID, P.PATIENT_NAME, PR.PRACTITIONER_NAME, CS.DIAGNOSIS
                FROM CLINICAL_SUMMARY CS
                JOIN CONSULTATION C ON CS.CONSULTATION_ID = C.CONSULTATION_ID
                JOIN PATIENT P ON C.PATIENT_ID = P.PATIENT_ID
                JOIN PRACTITIONER PR ON C.PRACTITIONER_ID = PR.PRACTITIONER_ID";
            grid.DataSource = DatabaseHelper.GetData(query);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSummaryId.Text) || cmbConsultations.SelectedValue == null)
            {
                MessageBox.Show("Please provide Summary ID and select a Consultation.");
                return;
            }

            // Transactional Logic: 1. Insert Summary, 2. Update Consultation Status
            string insertQuery = @"
                INSERT INTO CLINICAL_SUMMARY (CLINICAL_SUMMARY_ID, CONSULTATION_ID, DIAGNOSIS)
                VALUES (@SummaryID, @ConsultationID, @Diagnosis);
                
                UPDATE CONSULTATION SET STATUS = 'Completed' 
                WHERE CONSULTATION_ID = @ConsultationID;";

            DatabaseHelper.ExecuteQuery(insertQuery,
                new SqlParameter("@SummaryID", txtSummaryId.Text),
                new SqlParameter("@ConsultationID", cmbConsultations.SelectedValue),
                new SqlParameter("@Diagnosis", rtbDiagnosis.Text)
            );

            LoadPendingConsultations();
            LoadSummaries();
            txtSummaryId.Clear();
            rtbDiagnosis.Clear();
        }
    }
}