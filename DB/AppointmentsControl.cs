using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class AppointmentsControl : UserControl
    {
        private TextBox txtConsultationId;
        private TextBox txtPatientId;
        private TextBox txtPractitionerId;
        private TextBox txtBranchId;
        private DateTimePicker dateTimePicker;
        private ComboBox cmbStatus;
        private DataGridView grid;

        public AppointmentsControl()
        {
            BuildGui();
            LoadConsultations();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Consultations Management"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 210);
            Controls.Add(card);

            card.Controls.Add(ModernStyle.CreateLabel("Consultation ID", 20, 25));
            txtConsultationId = ModernStyle.CreateTextBox(180, 25);
            card.Controls.Add(txtConsultationId);

            card.Controls.Add(ModernStyle.CreateLabel("Patient ID", 20, 65));
            txtPatientId = ModernStyle.CreateTextBox(180, 65);
            card.Controls.Add(txtPatientId);

            card.Controls.Add(ModernStyle.CreateLabel("Practitioner ID", 20, 105));
            txtPractitionerId = ModernStyle.CreateTextBox(180, 105);
            card.Controls.Add(txtPractitionerId);

            card.Controls.Add(ModernStyle.CreateLabel("Branch ID", 20, 145));
            txtBranchId = ModernStyle.CreateTextBox(180, 145);
            card.Controls.Add(txtBranchId);

            card.Controls.Add(ModernStyle.CreateLabel("Date & Time", 430, 25));
            dateTimePicker = new DateTimePicker();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker.Location = new Point(590, 25);
            dateTimePicker.Size = new Size(200, 25);
            card.Controls.Add(dateTimePicker);

            card.Controls.Add(ModernStyle.CreateLabel("Status", 430, 65));
            cmbStatus = new ComboBox();
            cmbStatus.Location = new Point(590, 65);
            cmbStatus.Size = new Size(200, 25);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new string[] { "Scheduled", "Completed", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
            card.Controls.Add(cmbStatus);

            Button btnInsert = ModernStyle.CreateSuccessButton("Insert", 430, 115);
            btnInsert.Click += BtnInsert_Click;
            card.Controls.Add(btnInsert);

            Button btnUpdate = ModernStyle.CreateButton("Update Status", 620, 115);
            btnUpdate.Click += BtnUpdate_Click;
            card.Controls.Add(btnUpdate);

            Button btnDelete = ModernStyle.CreateDangerButton("Delete", 430, 160);
            btnDelete.Click += BtnDelete_Click;
            card.Controls.Add(btnDelete);

            Button btnShow = ModernStyle.CreateButton("Show All", 620, 160);
            btnShow.Click += (sender, args) => LoadConsultations();
            card.Controls.Add(btnShow);

            grid = new DataGridView();
            grid.Location = new Point(25, 320);
            grid.Size = new Size(950, 310);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadConsultations()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT * FROM CONSULTATION ORDER BY CONSULTATION_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM CONSULTATION WHERE CONSULTATION_ID = @ID)
                INSERT INTO CONSULTATION 
                (CONSULTATION_ID, PATIENT_ID, PRACTITIONER_ID, FACILITY_BRANCH_ID, SCHEDULED_DATETIME, STATUS)
                VALUES 
                (@ID, @PatientID, @PractitionerID, @BranchID, @DateTime, @Status);
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtConsultationId.Text),
                new SqlParameter("@PatientID", txtPatientId.Text),
                new SqlParameter("@PractitionerID", txtPractitionerId.Text),
                new SqlParameter("@BranchID", txtBranchId.Text),
                new SqlParameter("@DateTime", dateTimePicker.Value),
                new SqlParameter("@Status", cmbStatus.SelectedItem.ToString())
            );

            LoadConsultations();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"
                UPDATE CONSULTATION
                SET STATUS = @Status
                WHERE CONSULTATION_ID = @ID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtConsultationId.Text),
                new SqlParameter("@Status", cmbStatus.SelectedItem.ToString())
            );

            LoadConsultations();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM CONSULTATION WHERE CONSULTATION_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtConsultationId.Text)
            );

            LoadConsultations();
        }
    }
}