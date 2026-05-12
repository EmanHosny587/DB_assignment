using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class AppointmentsControl : UserControl
    {
        private TextBox txtAppointmentId;
        private TextBox txtPatientId;
        private TextBox txtPractitionerId;
        private DateTimePicker datePicker;
        private TextBox txtTime;
        private ComboBox cmbStatus;
        private DataGridView grid;

        public AppointmentsControl()
        {
            BuildGui();
            LoadAppointments();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Appointments Management"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 210);
            Controls.Add(card);

            card.Controls.Add(ModernStyle.CreateLabel("Appointment ID", 20, 25));
            txtAppointmentId = ModernStyle.CreateTextBox(180, 25);
            card.Controls.Add(txtAppointmentId);

            card.Controls.Add(ModernStyle.CreateLabel("Patient ID", 20, 65));
            txtPatientId = ModernStyle.CreateTextBox(180, 65);
            card.Controls.Add(txtPatientId);

            card.Controls.Add(ModernStyle.CreateLabel("Practitioner ID", 20, 105));
            txtPractitionerId = ModernStyle.CreateTextBox(180, 105);
            card.Controls.Add(txtPractitionerId);

            card.Controls.Add(ModernStyle.CreateLabel("Date", 20, 145));
            datePicker = new DateTimePicker();
            datePicker.Location = new Point(180, 145);
            datePicker.Size = new Size(200, 25);
            card.Controls.Add(datePicker);

            card.Controls.Add(ModernStyle.CreateLabel("Time", 430, 25));
            txtTime = ModernStyle.CreateTextBox(590, 25);
            card.Controls.Add(txtTime);

            card.Controls.Add(ModernStyle.CreateLabel("Status", 430, 65));
            cmbStatus = new ComboBox();
            cmbStatus.Location = new Point(590, 65);
            cmbStatus.Size = new Size(200, 25);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new string[] { "Pending", "Completed", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
            card.Controls.Add(cmbStatus);

            Button btnInsert = ModernStyle.CreateButton("Insert", 430, 115);
            btnInsert.Click += BtnInsert_Click;
            card.Controls.Add(btnInsert);

            Button btnUpdate = ModernStyle.CreateButton("Update Status", 620, 115);
            btnUpdate.Click += BtnUpdate_Click;
            card.Controls.Add(btnUpdate);

            Button btnDelete = ModernStyle.CreateButton("Delete", 430, 160);
            btnDelete.Click += BtnDelete_Click;
            card.Controls.Add(btnDelete);

            Button btnShow = ModernStyle.CreateButton("Show", 620, 160);
            btnShow.Click += (sender, args) => LoadAppointments();
            card.Controls.Add(btnShow);

            grid = new DataGridView();
            grid.Location = new Point(25, 320);
            grid.Size = new Size(950, 310);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void LoadAppointments()
        {
            grid.DataSource = DatabaseHelper.GetData("SELECT * FROM APPOINTMENT ORDER BY APPOINTMENT_ID");
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM APPOINTMENT WHERE APPOINTMENT_ID = @ID)
                INSERT INTO APPOINTMENT
                (APPOINTMENT_ID, PATIENT_ID, PRACTITIONER_ID, APPOINTMENT_DATE, APPOINTMENT_TIME, STATUS)
                VALUES
                (@ID, @PatientID, @PractitionerID, @Date, @Time, @Status);
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtAppointmentId.Text),
                new SqlParameter("@PatientID", txtPatientId.Text),
                new SqlParameter("@PractitionerID", txtPractitionerId.Text),
                new SqlParameter("@Date", datePicker.Value.Date),
                new SqlParameter("@Time", txtTime.Text),
                new SqlParameter("@Status", cmbStatus.SelectedItem.ToString())
            );

            LoadAppointments();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = @"
                UPDATE APPOINTMENT
                SET STATUS = @Status
                WHERE APPOINTMENT_ID = @ID;
            ";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtAppointmentId.Text),
                new SqlParameter("@Status", cmbStatus.SelectedItem.ToString())
            );

            LoadAppointments();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM APPOINTMENT WHERE APPOINTMENT_ID = @ID;";

            DatabaseHelper.ExecuteQuery(
                query,
                new SqlParameter("@ID", txtAppointmentId.Text)
            );

            LoadAppointments();
        }
    }
}