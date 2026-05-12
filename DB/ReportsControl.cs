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

            Controls.Add(ModernStyle.CreateTitle("Reports and Join Results"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 150);
            Controls.Add(card);

            Button btnPractitionerJoin = ModernStyle.CreateButton("Practitioner + Speciality", 20, 30, 240);
            btnPractitionerJoin.Click += (sender, args) => LoadPractitionerSpecialityJoin();
            card.Controls.Add(btnPractitionerJoin);

            Button btnPrescriptionJoin = ModernStyle.CreateButton("Prescription + Medication", 280, 30, 240);
            btnPrescriptionJoin.Click += (sender, args) => LoadPrescriptionMedicationJoin();
            card.Controls.Add(btnPrescriptionJoin);

            Button btnScheduleJoin = ModernStyle.CreateButton("Patient + Schedule", 540, 30, 220);
            btnScheduleJoin.Click += (sender, args) => LoadPatientScheduleJoin();
            card.Controls.Add(btnScheduleJoin);

            Button btnBranchJoin = ModernStyle.CreateButton("Practitioner + Branch", 20, 85, 240);
            btnBranchJoin.Click += (sender, args) => LoadPractitionerBranchJoin();
            card.Controls.Add(btnBranchJoin);

            grid = new DataGridView();
            grid.Location = new Point(25, 260);
            grid.Size = new Size(950, 370);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadPractitionerSpecialityJoin()
        {
            string query = @"
                SELECT
                    P.PRACTITIONER_ID,
                    S.SPECIALITY_ID,
                    S.SPECIALITY_NAME,
                    P.MEDICAL_EXPERTISE
                FROM PRACTITIONER P
                INNER JOIN SPECIALITY S
                    ON P.SPECIALITY_ID = S.SPECIALITY_ID
                ORDER BY P.PRACTITIONER_ID;
            ";

            grid.DataSource = DatabaseHelper.GetData(query);
        }

        private void LoadPrescriptionMedicationJoin()
        {
            string query = @"
                SELECT
                    PR.PRESCRIPTION_ID,
                    PR.CLINICAL_SUMMARY_ID,
                    PR.DOSAGE,
                    PR.DURATION,
                    M.MEDICATION_ID,
                    M.MEDICATION_NAME
                FROM PRESCRIPTION PR
                INNER JOIN PRESCRIBEDIN PI
                    ON PR.PRESCRIPTION_ID = PI.PRESCRIPTION_ID
                INNER JOIN MEDICATION M
                    ON PI.MEDICATION_ID = M.MEDICATION_ID
                ORDER BY PR.PRESCRIPTION_ID;
            ";

            grid.DataSource = DatabaseHelper.GetData(query);
        }

        private void LoadPatientScheduleJoin()
        {
            string query = @"
                SELECT
                    P.PATIENT_ID,
                    P.CONTACT_HISTORY,
                    P.DEMOGRAPHIC,
                    S.CONSULTATION_ID
                FROM PATIENT P
                INNER JOIN IS_SCHEDULED S
                    ON P.PATIENT_ID = S.PATIENT_ID
                ORDER BY P.PATIENT_ID;
            ";

            grid.DataSource = DatabaseHelper.GetData(query);
        }

        private void LoadPractitionerBranchJoin()
        {
            string query = @"
                SELECT
                    P.PRACTITIONER_ID,
                    P.MEDICAL_EXPERTISE,
                    PB.PRACTITIONER_BRANCH_ID,
                    MFB.FACILITY_BRANCH_ID,
                    MFB.PHYSICAL_ADDRESS,
                    MFB.CONTACT_DETAILS
                FROM PRACTITIONER P
                INNER JOIN PRACTITIONER_BRANCH PB
                    ON P.PRACTITIONER_ID = PB.PRACTITIONER_ID
                INNER JOIN MEDICAL_FACILITY_BRANCH MFB
                    ON PB.FACILITY_BRANCH_ID = MFB.FACILITY_BRANCH_ID
                ORDER BY P.PRACTITIONER_ID;
            ";

            grid.DataSource = DatabaseHelper.GetData(query);
        }
    }
}