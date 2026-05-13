using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class PractitionersControl : UserControl
    {
        private TextBox txtPractitionerId;
        private TextBox txtPractitionerName;
        private TextBox txtSpecialityId;
        private TextBox txtMedicalExpertise;
        private DataGridView grid;

        public PractitionersControl()
        {
            BuildGui();
            LoadPractitioners();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Practitioners Management"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 180);
            Controls.Add(card);

            // Row 1
            card.Controls.Add(ModernStyle.CreateLabel("Practitioner ID", 20, 25));
            txtPractitionerId = ModernStyle.CreateTextBox(160, 25);
            card.Controls.Add(txtPractitionerId);

            card.Controls.Add(ModernStyle.CreateLabel("Full Name", 380, 25));
            txtPractitionerName = ModernStyle.CreateTextBox(520, 25, 380);
            card.Controls.Add(txtPractitionerName);

            // Row 2
            card.Controls.Add(ModernStyle.CreateLabel("Speciality ID", 20, 70));
            txtSpecialityId = ModernStyle.CreateTextBox(160, 70);
            card.Controls.Add(txtSpecialityId);

            card.Controls.Add(ModernStyle.CreateLabel("Expertise", 380, 70));
            txtMedicalExpertise = ModernStyle.CreateTextBox(520, 70, 380);
            card.Controls.Add(txtMedicalExpertise);

            // Action Buttons
            Button btnInsert = ModernStyle.CreateSuccessButton("Add Practitioner", 20, 120, 180);
            btnInsert.Click += BtnInsert_Click;
            card.Controls.Add(btnInsert);

            Button btnUpdate = ModernStyle.CreateButton("Update Details", 210, 120, 180);
            btnUpdate.Click += BtnUpdate_Click;
            card.Controls.Add(btnUpdate);

            Button btnDelete = ModernStyle.CreateDangerButton("Remove", 400, 120, 180);
            btnDelete.Click += BtnDelete_Click;
            card.Controls.Add(btnDelete);

            Button btnShow = ModernStyle.CreateButton("Refresh", 590, 120, 180);
            btnShow.Click += (sender, args) => LoadPractitioners();
            card.Controls.Add(btnShow);

            grid = new DataGridView();
            grid.Location = new Point(25, 290);
            grid.Size = new Size(950, 340);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadPractitioners()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT * FROM PRACTITIONER ORDER BY PRACTITIONER_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPractitionerId.Text)) return;

            string query = @"
                IF NOT EXISTS (SELECT 1 FROM PRACTITIONER WHERE PRACTITIONER_ID = @ID)
                INSERT INTO PRACTITIONER (PRACTITIONER_ID, PRACTITIONER_NAME, SPECIALITY_ID, MEDICAL_EXPERTISE)
                VALUES (@ID, @Name, @SpecialityID, @Expertise);
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPractitionerId.Text),
                new SqlParameter("@Name", txtPractitionerName.Text),
                new SqlParameter("@SpecialityID", txtSpecialityId.Text),
                new SqlParameter("@Expertise", txtMedicalExpertise.Text)
            );

            LoadPractitioners();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPractitionerId.Text)) return;

            string query = @"
                UPDATE PRACTITIONER
                SET PRACTITIONER_NAME = @Name,
                    SPECIALITY_ID = @SpecialityID,
                    MEDICAL_EXPERTISE = @Expertise
                WHERE PRACTITIONER_ID = @ID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPractitionerId.Text),
                new SqlParameter("@Name", txtPractitionerName.Text),
                new SqlParameter("@SpecialityID", txtSpecialityId.Text),
                new SqlParameter("@Expertise", txtMedicalExpertise.Text)
            );

            LoadPractitioners();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPractitionerId.Text)) return;

            string query = "DELETE FROM PRACTITIONER WHERE PRACTITIONER_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPractitionerId.Text)
            );

            LoadPractitioners();
        }
    }
}