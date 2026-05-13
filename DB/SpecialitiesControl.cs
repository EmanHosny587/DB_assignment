using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class SpecialitiesControl : UserControl
    {
        private TextBox txtSpecialityId;
        private TextBox txtSpecialityName;
        private DataGridView grid;

        public SpecialitiesControl()
        {
            BuildGui();
            LoadSpecialities();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Medical Specialities"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 160);
            Controls.Add(card);

            // Input Fields
            card.Controls.Add(ModernStyle.CreateLabel("Speciality ID", 20, 30));
            txtSpecialityId = ModernStyle.CreateTextBox(180, 30);
            card.Controls.Add(txtSpecialityId);

            card.Controls.Add(ModernStyle.CreateLabel("Speciality Name", 20, 80));
            txtSpecialityName = ModernStyle.CreateTextBox(180, 80, 350);
            card.Controls.Add(txtSpecialityName);

            // Action Buttons
            Button btnInsert = ModernStyle.CreateSuccessButton("Add New", 550, 30, 160);
            btnInsert.Click += BtnInsert_Click;
            card.Controls.Add(btnInsert);

            Button btnUpdate = ModernStyle.CreateButton("Update Name", 720, 30, 160);
            btnUpdate.Click += BtnUpdate_Click;
            card.Controls.Add(btnUpdate);

            Button btnDelete = ModernStyle.CreateDangerButton("Remove", 550, 85, 160);
            btnDelete.Click += BtnDelete_Click;
            card.Controls.Add(btnDelete);

            Button btnShow = ModernStyle.CreateButton("Refresh", 720, 85, 160);
            btnShow.Click += (sender, args) => LoadSpecialities();
            card.Controls.Add(btnShow);

            // Grid View
            grid = new DataGridView();
            grid.Location = new Point(25, 270);
            grid.Size = new Size(950, 360);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadSpecialities()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT SPECIALITY_ID, SPECIALITY_NAME FROM SPECIALITY ORDER BY SPECIALITY_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpecialityId.Text) || string.IsNullOrWhiteSpace(txtSpecialityName.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query = @"
                IF NOT EXISTS (SELECT 1 FROM SPECIALITY WHERE SPECIALITY_ID = @ID)
                INSERT INTO SPECIALITY (SPECIALITY_ID, SPECIALITY_NAME)
                VALUES (@ID, @Name);
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtSpecialityId.Text),
                new SqlParameter("@Name", txtSpecialityName.Text)
            );

            LoadSpecialities();
            ClearInputs();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpecialityId.Text)) return;

            string query = "UPDATE SPECIALITY SET SPECIALITY_NAME = @Name WHERE SPECIALITY_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtSpecialityId.Text),
                new SqlParameter("@Name", txtSpecialityName.Text)
            );

            LoadSpecialities();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpecialityId.Text)) return;

            string query = "DELETE FROM SPECIALITY WHERE SPECIALITY_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtSpecialityId.Text)
            );

            LoadSpecialities();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtSpecialityId.Clear();
            txtSpecialityName.Clear();
        }
    }
}