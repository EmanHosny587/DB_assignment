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

            Controls.Add(ModernStyle.CreateTitle("Specialities Management"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 150);
            Controls.Add(card);

            card.Controls.Add(ModernStyle.CreateLabel("Speciality ID", 20, 25));
            txtSpecialityId = ModernStyle.CreateTextBox(170, 25);
            card.Controls.Add(txtSpecialityId);

            card.Controls.Add(ModernStyle.CreateLabel("Speciality Name", 20, 70));
            txtSpecialityName = ModernStyle.CreateTextBox(170, 70);
            card.Controls.Add(txtSpecialityName);

            Button btnInsert = ModernStyle.CreateSuccessButton("Insert", 420, 25);
            btnInsert.Click += BtnInsert_Click;
            card.Controls.Add(btnInsert);

            Button btnUpdate = ModernStyle.CreateButton("Update", 610, 25);
            btnUpdate.Click += BtnUpdate_Click;
            card.Controls.Add(btnUpdate);

            Button btnDelete = ModernStyle.CreateDangerButton("Delete", 420, 80);
            btnDelete.Click += BtnDelete_Click;
            card.Controls.Add(btnDelete);

            Button btnShow = ModernStyle.CreateButton("Show", 610, 80);
            btnShow.Click += (sender, args) => LoadSpecialities();
            card.Controls.Add(btnShow);

            grid = new DataGridView();
            grid.Location = new Point(25, 260);
            grid.Size = new Size(950, 370);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadSpecialities()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT * FROM SPECIALITY ORDER BY SPECIALITY_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
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
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"
                UPDATE SPECIALITY
                SET SPECIALITY_NAME = @Name
                WHERE SPECIALITY_ID = @ID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtSpecialityId.Text),
                new SqlParameter("@Name", txtSpecialityName.Text)
            );

            LoadSpecialities();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM SPECIALITY WHERE SPECIALITY_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtSpecialityId.Text)
            );

            LoadSpecialities();
        }
    }
}