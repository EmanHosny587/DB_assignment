using System;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class ReportsControl : UserControl
    {
        private DataGridView grid;

        public ReportsControl()
        {
            BuildGui();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;
            Controls.Add(ModernStyle.CreateTitle("Business Intelligence Reports"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 280);
            Controls.Add(card);

            // Row 1: Required Business Questions
            AddReportButton(card, "Top Specialty (Last Month)", 20, 20, LoadTopSpecialty);
            AddReportButton(card, "Inactive Practitioners", 260, 20, LoadInactivePractitioners);
            AddReportButton(card, "Patient Medication Variety", 500, 20, LoadMedicationVariety);

            // Row 2: Operational Questions
            AddReportButton(card, "Busiest Branch (Patients)", 20, 80, LoadBusiestBranch);
            AddReportButton(card, "Branch Diagnosis Logs", 260, 80, LoadBranchDiagnoses);
            AddReportButton(card, "Full Patient Profiles", 500, 80, LoadPatientProfiles);

            grid = new DataGridView();
            ModernStyle.StyleGrid(grid);
            grid.Location = new Point(25, 380);
            grid.Size = new Size(950, 320);
            Controls.Add(grid);
        }

        private void AddReportButton(Panel p, string text, int x, int y, Action action)
        {
            Button btn = ModernStyle.CreateButton(text, x, y, 220);
            btn.Click += (s, e) => action();
            p.Controls.Add(btn);
        }

        // 1. Medical specialty with highest demand
        private void LoadTopSpecialty()
        {
            string query = @"
                SELECT TOP 1 S.SPECIALITY_NAME, COUNT(C.CONSULTATION_ID) as Total_Visits
                FROM SPECIALITY S
                JOIN PRACTITIONER PR ON S.SPECIALITY_ID = PR.SPECIALITY_ID
                JOIN CONSULTATION C ON PR.PRACTITIONER_ID = C.PRACTITIONER_ID
                WHERE C.SCHEDULED_DATETIME >= DATEADD(month, -1, GETDATE())
                GROUP BY S.SPECIALITY_NAME
                ORDER BY Total_Visits DESC";
            grid.DataSource = DatabaseHelper.GetData(query);
        }

        // 2. Practitioners with no consultations
        private void LoadInactivePractitioners()
        {
            string query = @"
                SELECT P.PRACTITIONER_NAME, P.MEDICAL_EXPERTISE
                FROM PRACTITIONER P
                LEFT JOIN CONSULTATION C ON P.PRACTITIONER_ID = C.PRACTITIONER_ID 
                     AND C.SCHEDULED_DATETIME >= DATEADD(month, -1, GETDATE())
                WHERE C.CONSULTATION_ID IS NULL";
            grid.DataSource = DatabaseHelper.GetData(query);
        }

        // 3. Patient with highest variety of different medications
        private void LoadMedicationVariety()
        {
            string query = @"
                SELECT TOP 1 P.PATIENT_NAME, COUNT(DISTINCT PI.MEDICATION_ID) as Unique_Meds
                FROM PATIENT P
                JOIN CONSULTATION C ON P.PATIENT_ID = C.PATIENT_ID
                JOIN CLINICAL_SUMMARY CS ON C.CONSULTATION_ID = CS.CONSULTATION_ID
                JOIN PRESCRIPTION PR ON CS.CLINICAL_SUMMARY_ID = PR.CLINICAL_SUMMARY_ID
                JOIN PRESCRIBEDIN PI ON PR.PRESCRIPTION_ID = PI.PRESCRIPTION_ID
                WHERE C.SCHEDULED_DATETIME >= DATEADD(month, -1, GETDATE())
                GROUP BY P.PATIENT_NAME
                ORDER BY Unique_Meds DESC";
            grid.DataSource = DatabaseHelper.GetData(query);
        }

        // 4. Branch that hosted maximum number of distinct patients
        private void LoadBusiestBranch()
        {
            string query = @"
                SELECT TOP 1 B.PHYSICAL_ADDRESS, COUNT(DISTINCT C.PATIENT_ID) as Patient_Count
                FROM MEDICAL_FACILITY_BRANCH B
                JOIN CONSULTATION C ON B.FACILITY_BRANCH_ID = C.FACILITY_BRANCH_ID
                WHERE C.SCHEDULED_DATETIME >= DATEADD(month, -1, GETDATE())
                GROUP BY B.PHYSICAL_ADDRESS
                ORDER BY Patient_Count DESC";
            grid.DataSource = DatabaseHelper.GetData(query);
        }

        // 5. Diagnosis details for a specific branch (logs)
        private void LoadBranchDiagnoses()
        {
            string query = @"
                SELECT B.PHYSICAL_ADDRESS, C.SCHEDULED_DATETIME, CS.DIAGNOSIS
                FROM MEDICAL_FACILITY_BRANCH B
                JOIN CONSULTATION C ON B.FACILITY_BRANCH_ID = C.FACILITY_BRANCH_ID
                JOIN CLINICAL_SUMMARY CS ON C.CONSULTATION_ID = CS.CONSULTATION_ID
                WHERE C.SCHEDULED_DATETIME >= DATEADD(month, -1, GETDATE())";
            grid.DataSource = DatabaseHelper.GetData(query);
        }

        // 6. Full patient profile and total prescriptions
        private void LoadPatientProfiles()
        {
            string query = @"
                SELECT P.PATIENT_NAME, P.DATE_OF_BIRTH, P.CONTACT_HISTORY, 
                       COUNT(PR.PRESCRIPTION_ID) as Total_Prescriptions
                FROM PATIENT P
                LEFT JOIN CONSULTATION C ON P.PATIENT_ID = C.PATIENT_ID
                LEFT JOIN CLINICAL_SUMMARY CS ON C.CONSULTATION_ID = CS.CONSULTATION_ID
                LEFT JOIN PRESCRIPTION PR ON CS.CLINICAL_SUMMARY_ID = PR.CLINICAL_SUMMARY_ID
                GROUP BY P.PATIENT_NAME, P.DATE_OF_BIRTH, P.CONTACT_HISTORY";
            grid.DataSource = DatabaseHelper.GetData(query);
        }
    }
}