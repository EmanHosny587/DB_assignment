using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class SchedulesControl : UserControl
    {
        private TextBox txtPatientId;
        private TextBox txtConsultationId;
        private TextBox txtNewConsultationId;
        private DataGridView grid;

        public SchedulesControl()
        {
            BuildGui();
            LoadSchedules();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Schedules Management"));
            Controls.Add(ModernStyle.CreateSubtitle("This page uses the IS_SCHEDULED table.", 28, 70));

            Panel card = ModernStyle.CreateCard(25, 105, 950, 170);
            Controls.Add(card);

            card.Controls.Add(ModernStyle.CreateLabel("Patient ID", 20, 25));
            txtPatientId = ModernStyle.CreateTextBox(170, 25);
            card.Controls.Add(txtPatientId);

            card.Controls.Add(ModernStyle.CreateLabel("Consultation ID", 20, 65));
            txtConsultationId = ModernStyle.CreateTextBox(170, 65);
            card.Controls.Add(txtConsultationId);

            card.Controls.Add(ModernStyle.CreateLabel("New Consult. ID", 20, 105));
            txtNewConsultationId = ModernStyle.CreateTextBox(170, 105);
            card.Controls.Add(txtNewConsultationId);

            Button btnInsert = ModernStyle.CreateSuccessButton("Insert", 430, 25);
            btnInsert.Click += BtnInsert_Click;
            card.Controls.Add(btnInsert);

            Button btnUpdate = ModernStyle.CreateButton("Update", 620, 25);
            btnUpdate.Click += BtnUpdate_Click;
            card.Controls.Add(btnUpdate);

            Button btnDelete = ModernStyle.CreateDangerButton("Delete", 430, 80);
            btnDelete.Click += BtnDelete_Click;
            card.Controls.Add(btnDelete);

            Button btnShow = ModernStyle.CreateButton("Show", 620, 80);
            btnShow.Click += (sender, args) => LoadSchedules();
            card.Controls.Add(btnShow);

            grid = new DataGridView();
            grid.Location = new Point(25, 300);
            grid.Size = new Size(950, 330);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadSchedules()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT * FROM IS_SCHEDULED ORDER BY PATIENT_ID, CONSULTATION_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string query = @"
                IF NOT EXISTS (
                    SELECT 1 FROM IS_SCHEDULED
                    WHERE PATIENT_ID = @PatientID AND CONSULTATION_ID = @ConsultationID
                )
                INSERT INTO IS_SCHEDULED (PATIENT_ID, CONSULTATION_ID)
                VALUES (@PatientID, @ConsultationID);
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@PatientID", txtPatientId.Text),
                new SqlParameter("@ConsultationID", txtConsultationId.Text)
            );

            LoadSchedules();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"
                UPDATE IS_SCHEDULED
                SET CONSULTATION_ID = @NewConsultationID
                WHERE PATIENT_ID = @PatientID AND CONSULTATION_ID = @ConsultationID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@PatientID", txtPatientId.Text),
                new SqlParameter("@ConsultationID", txtConsultationId.Text),
                new SqlParameter("@NewConsultationID", txtNewConsultationId.Text)
            );

            LoadSchedules();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = @"
                DELETE FROM IS_SCHEDULED
                WHERE PATIENT_ID = @PatientID AND CONSULTATION_ID = @ConsultationID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@PatientID", txtPatientId.Text),
                new SqlParameter("@ConsultationID", txtConsultationId.Text)
            );

            LoadSchedules();
        }
    }
}