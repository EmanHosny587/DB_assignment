using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class MedicationsControl : UserControl
    {
        private TextBox txtMedicationId;
        private TextBox txtMedicationName;
        private DataGridView grid;

        public MedicationsControl()
        {
            BuildGui();
            LoadMedications();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Medications Management"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 150);
            Controls.Add(card);

            card.Controls.Add(ModernStyle.CreateLabel("Medication ID", 20, 25));
            txtMedicationId = ModernStyle.CreateTextBox(170, 25);
            card.Controls.Add(txtMedicationId);

            card.Controls.Add(ModernStyle.CreateLabel("Medication Name", 20, 70));
            txtMedicationName = ModernStyle.CreateTextBox(170, 70);
            card.Controls.Add(txtMedicationName);

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
            btnShow.Click += (sender, args) => LoadMedications();
            card.Controls.Add(btnShow);

            grid = new DataGridView();
            grid.Location = new Point(25, 260);
            grid.Size = new Size(950, 370);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadMedications()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT * FROM MEDICATION ORDER BY MEDICATION_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM MEDICATION WHERE MEDICATION_ID = @ID)
                INSERT INTO MEDICATION (MEDICATION_ID, MEDICATION_NAME)
                VALUES (@ID, @Name);
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtMedicationId.Text),
                new SqlParameter("@Name", txtMedicationName.Text)
            );

            LoadMedications();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"
                UPDATE MEDICATION
                SET MEDICATION_NAME = @Name
                WHERE MEDICATION_ID = @ID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtMedicationId.Text),
                new SqlParameter("@Name", txtMedicationName.Text)
            );

            LoadMedications();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM MEDICATION WHERE MEDICATION_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtMedicationId.Text)
            );

            LoadMedications();
        }
    }
}