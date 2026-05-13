using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class PatientsControl : UserControl
    {
        private TextBox txtPatientId;
        private TextBox txtPatientName;
        private DateTimePicker dtpBirthDate;
        private TextBox txtContactHistory;
        private TextBox txtDemographic;
        private DataGridView grid;

        public PatientsControl()
        {
            BuildGui();
            LoadPatients();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Patients Management"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 200);
            Controls.Add(card);

            // Left Column
            card.Controls.Add(ModernStyle.CreateLabel("Patient ID", 20, 20));
            txtPatientId = ModernStyle.CreateTextBox(160, 20);
            card.Controls.Add(txtPatientId);

            card.Controls.Add(ModernStyle.CreateLabel("Patient Name", 20, 60));
            txtPatientName = ModernStyle.CreateTextBox(160, 60);
            card.Controls.Add(txtPatientName);

            card.Controls.Add(ModernStyle.CreateLabel("Birth Date", 20, 100));
            dtpBirthDate = new DateTimePicker();
            dtpBirthDate.Location = new Point(160, 100);
            dtpBirthDate.Size = new Size(200, 25);
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            card.Controls.Add(dtpBirthDate);

            // Right Column
            card.Controls.Add(ModernStyle.CreateLabel("Contact Info", 410, 20));
            txtContactHistory = ModernStyle.CreateTextBox(550, 20, 350);
            card.Controls.Add(txtContactHistory);

            card.Controls.Add(ModernStyle.CreateLabel("Demographics", 410, 60));
            txtDemographic = ModernStyle.CreateTextBox(550, 60, 350);
            card.Controls.Add(txtDemographic);

            // Action Buttons
            Button btnInsert = ModernStyle.CreateSuccessButton("Register Patient", 410, 120, 150);
            btnInsert.Click += BtnInsert_Click;
            card.Controls.Add(btnInsert);

            Button btnUpdate = ModernStyle.CreateButton("Update Info", 570, 120, 150);
            btnUpdate.Click += BtnUpdate_Click;
            card.Controls.Add(btnUpdate);

            Button btnDelete = ModernStyle.CreateDangerButton("Delete Record", 730, 120, 150);
            btnDelete.Click += BtnDelete_Click;
            card.Controls.Add(btnDelete);

            grid = new DataGridView();
            grid.Location = new Point(25, 300);
            grid.Size = new Size(950, 330);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadPatients()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT PATIENT_ID, PATIENT_NAME, DATE_OF_BIRTH, CONTACT_HISTORY, DEMOGRAPHIC FROM PATIENT ORDER BY PATIENT_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientId.Text)) return;

            string query = @"
                IF NOT EXISTS (SELECT 1 FROM PATIENT WHERE PATIENT_ID = @ID)
                INSERT INTO PATIENT (PATIENT_ID, PATIENT_NAME, DATE_OF_BIRTH, CONTACT_HISTORY, DEMOGRAPHIC)
                VALUES (@ID, @Name, @DOB, @Contact, @Demographic);
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPatientId.Text),
                new SqlParameter("@Name", txtPatientName.Text),
                new SqlParameter("@DOB", dtpBirthDate.Value.Date),
                new SqlParameter("@Contact", txtContactHistory.Text),
                new SqlParameter("@Demographic", txtDemographic.Text)
            );

            LoadPatients();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientId.Text)) return;

            string query = @"
                UPDATE PATIENT
                SET PATIENT_NAME = @Name,
                    DATE_OF_BIRTH = @DOB,
                    CONTACT_HISTORY = @Contact,
                    DEMOGRAPHIC = @Demographic
                WHERE PATIENT_ID = @ID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPatientId.Text),
                new SqlParameter("@Name", txtPatientName.Text),
                new SqlParameter("@DOB", dtpBirthDate.Value.Date),
                new SqlParameter("@Contact", txtContactHistory.Text),
                new SqlParameter("@Demographic", txtDemographic.Text)
            );

            LoadPatients();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientId.Text)) return;

            string query = "DELETE FROM PATIENT WHERE PATIENT_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPatientId.Text)
            );

            LoadPatients();
        }
    }
}