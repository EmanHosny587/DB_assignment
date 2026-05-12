using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class MainDashboard : Form
    {
        private Panel sidebar;
        private Panel contentPanel;

        private HomeControl homeControl;
        private PatientsControl patientsControl;
        private SpecialitiesControl specialitiesControl;
        private PractitionersControl practitionersControl;
        private SchedulesControl schedulesControl;
        private MedicationsControl medicationsControl;
        private ReportsControl reportsControl;

        public MainDashboard()
        {
            BuildDashboard();
        }

        private void BuildDashboard()
        {
            Text = "Hospital Database System";
            Size = new Size(1250, 750);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = ModernStyle.Background;

            homeControl = new HomeControl();
            patientsControl = new PatientsControl();
            specialitiesControl = new SpecialitiesControl();
            practitionersControl = new PractitionersControl();
            schedulesControl = new SchedulesControl();
            medicationsControl = new MedicationsControl();
            reportsControl = new ReportsControl();

            sidebar = new Panel();
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 240;
            sidebar.BackColor = ModernStyle.DarkBlue;

            Label logo = new Label();
            logo.Text = "Hospital";
            logo.ForeColor = Color.White;
            logo.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            logo.Location = new Point(25, 25);
            logo.Size = new Size(190, 50);
            sidebar.Controls.Add(logo);

            Label subtitle = new Label();
            subtitle.Text = "Database System";
            subtitle.ForeColor = Color.LightGray;
            subtitle.Font = new Font("Segoe UI", 10);
            subtitle.Location = new Point(28, 72);
            subtitle.Size = new Size(180, 25);
            sidebar.Controls.Add(subtitle);

            AddMenuButton("Dashboard", 125, homeControl);
            AddMenuButton("Patients", 180, patientsControl);
            AddMenuButton("Specialities", 235, specialitiesControl);
            AddMenuButton("Practitioners", 290, practitionersControl);
            AddMenuButton("Schedules", 345, schedulesControl);
            AddMenuButton("Medications", 400, medicationsControl);
            AddMenuButton("Reports / Join", 455, reportsControl);

            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = ModernStyle.Background;

            Controls.Add(contentPanel);
            Controls.Add(sidebar);

            ShowControl(homeControl);
        }

        private void AddMenuButton(string text, int y, Control control)
        {
            Button button = new Button();
            button.Text = "   " + text;
            button.Location = new Point(18, y);
            button.Size = new Size(205, 45);
            button.BackColor = ModernStyle.DarkBlue;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Cursor = Cursors.Hand;

            button.MouseEnter += (sender, args) => { button.BackColor = ModernStyle.HoverBlue; };
            button.MouseLeave += (sender, args) => { button.BackColor = ModernStyle.DarkBlue; };

            button.Click += (sender, args) => { ShowControl(control); };

            sidebar.Controls.Add(button);
        }

        private void ShowControl(Control control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }
    }
}