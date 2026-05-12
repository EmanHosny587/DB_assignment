using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class PatientsControl : UserControl
    {
        private TextBox txtPatientId;
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

            Panel card = ModernStyle.CreateCard(25, 85, 950, 170);
            Controls.Add(card);

            card.Controls.Add(ModernStyle.CreateLabel("Patient ID", 20, 25));
            txtPatientId = ModernStyle.CreateTextBox(160, 25);
            card.Controls.Add(txtPatientId);

            card.Controls.Add(ModernStyle.CreateLabel("Contact History", 20, 65));
            txtContactHistory = ModernStyle.CreateTextBox(160, 65);
            card.Controls.Add(txtContactHistory);

            card.Controls.Add(ModernStyle.CreateLabel("Demographic", 20, 105));
            txtDemographic = ModernStyle.CreateTextBox(160, 105);
            card.Controls.Add(txtDemographic);

            Button btnInsert = ModernStyle.CreateSuccessButton("Insert", 410, 25);
            btnInsert.Click += BtnInsert_Click;
            card.Controls.Add(btnInsert);

            Button btnUpdate = ModernStyle.CreateButton("Update", 600, 25);
            btnUpdate.Click += BtnUpdate_Click;
            card.Controls.Add(btnUpdate);

            Button btnDelete = ModernStyle.CreateDangerButton("Delete", 410, 80);
            btnDelete.Click += BtnDelete_Click;
            card.Controls.Add(btnDelete);

            Button btnShow = ModernStyle.CreateButton("Show", 600, 80);
            btnShow.Click += (sender, args) => LoadPatients();
            card.Controls.Add(btnShow);

            grid = new DataGridView();
            grid.Location = new Point(25, 280);
            grid.Size = new Size(950, 350);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadPatients()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT * FROM PATIENT ORDER BY PATIENT_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM PATIENT WHERE PATIENT_ID = @ID)
                INSERT INTO PATIENT (PATIENT_ID, CONTACT_HISTORY, DEMOGRAPHIC)
                VALUES (@ID, @Contact, @Demographic);
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPatientId.Text),
                new SqlParameter("@Contact", txtContactHistory.Text),
                new SqlParameter("@Demographic", txtDemographic.Text)
            );

            LoadPatients();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"
                UPDATE PATIENT
                SET CONTACT_HISTORY = @Contact,
                    DEMOGRAPHIC = @Demographic
                WHERE PATIENT_ID = @ID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPatientId.Text),
                new SqlParameter("@Contact", txtContactHistory.Text),
                new SqlParameter("@Demographic", txtDemographic.Text)
            );

            LoadPatients();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM PATIENT WHERE PATIENT_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPatientId.Text)
            );

            LoadPatients();
        }
    }
}