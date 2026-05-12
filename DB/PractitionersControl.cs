using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class PractitionersControl : UserControl
    {
        private TextBox txtPractitionerId;
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

            Panel card = ModernStyle.CreateCard(25, 85, 950, 170);
            Controls.Add(card);

            card.Controls.Add(ModernStyle.CreateLabel("Practitioner ID", 20, 25));
            txtPractitionerId = ModernStyle.CreateTextBox(180, 25);
            card.Controls.Add(txtPractitionerId);

            card.Controls.Add(ModernStyle.CreateLabel("Speciality ID", 20, 65));
            txtSpecialityId = ModernStyle.CreateTextBox(180, 65);
            card.Controls.Add(txtSpecialityId);

            card.Controls.Add(ModernStyle.CreateLabel("Expertise", 20, 105));
            txtMedicalExpertise = ModernStyle.CreateTextBox(180, 105);
            card.Controls.Add(txtMedicalExpertise);

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
            btnShow.Click += (sender, args) => LoadPractitioners();
            card.Controls.Add(btnShow);

            grid = new DataGridView();
            grid.Location = new Point(25, 280);
            grid.Size = new Size(950, 350);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadPractitioners()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT * FROM PRACTITIONER ORDER BY PRACTITIONER_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM PRACTITIONER WHERE PRACTITIONER_ID = @ID)
                INSERT INTO PRACTITIONER (PRACTITIONER_ID, SPECIALITY_ID, MEDICAL_EXPERTISE)
                VALUES (@ID, @SpecialityID, @Expertise);
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPractitionerId.Text),
                new SqlParameter("@SpecialityID", txtSpecialityId.Text),
                new SqlParameter("@Expertise", txtMedicalExpertise.Text)
            );

            LoadPractitioners();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"
                UPDATE PRACTITIONER
                SET SPECIALITY_ID = @SpecialityID,
                    MEDICAL_EXPERTISE = @Expertise
                WHERE PRACTITIONER_ID = @ID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPractitionerId.Text),
                new SqlParameter("@SpecialityID", txtSpecialityId.Text),
                new SqlParameter("@Expertise", txtMedicalExpertise.Text)
            );

            LoadPractitioners();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM PRACTITIONER WHERE PRACTITIONER_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtPractitionerId.Text)
            );

            LoadPractitioners();
        }
    }
}