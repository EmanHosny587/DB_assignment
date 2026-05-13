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
        private AppointmentsControl appointmentsControl;
        private MedicationsControl medicationsControl;
        private ReportsControl reportsControl;
        private ClinicalSummaryControl clinicalSummaryControl;
        private BranchManagementControl branchControl;
        public MainDashboard()
        {
            BuildDashboard();
        }

        private void BuildDashboard()
        {
            Text = "Healthcare Network Management System";
            Size = new Size(1250, 750);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = ModernStyle.Background;

            // Initialize Controls
            homeControl = new HomeControl();
            patientsControl = new PatientsControl();
            specialitiesControl = new SpecialitiesControl();
            practitionersControl = new PractitionersControl();
            appointmentsControl = new AppointmentsControl();
            medicationsControl = new MedicationsControl();
            reportsControl = new ReportsControl();
            clinicalSummaryControl = new ClinicalSummaryControl();
            branchControl = new BranchManagementControl();
            // Sidebar Setup
            sidebar = new Panel();
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 240;
            sidebar.BackColor = ModernStyle.DarkBlue;

            Label logo = new Label();
            logo.Text = "Healthcare";
            logo.ForeColor = Color.White;
            logo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            logo.Location = new Point(25, 25);
            logo.Size = new Size(190, 50);
            sidebar.Controls.Add(logo);

            Label subtitle = new Label();
            subtitle.Text = "Network System";
            subtitle.ForeColor = Color.LightGray;
            subtitle.Font = new Font("Segoe UI", 10);
            subtitle.Location = new Point(28, 72);
            subtitle.Size = new Size(180, 25);
            sidebar.Controls.Add(subtitle);

            // Menu Buttons
            AddMenuButton("Dashboard", 125, homeControl);
            AddMenuButton("Patients", 180, patientsControl);
            AddMenuButton("Specialities", 235, specialitiesControl);
            AddMenuButton("Practitioners", 290, practitionersControl);
            AddMenuButton("Consultations", 345, appointmentsControl);
            AddMenuButton("Medications", 400, medicationsControl);
            AddMenuButton("Reports & Analysis", 455, reportsControl);
            AddMenuButton("Clinical Summary", 510, clinicalSummaryControl);
            AddMenuButton("Branch Management", 565, branchControl);

            // Main Content Panel
            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = ModernStyle.Background;

            Controls.Add(contentPanel);
            Controls.Add(sidebar);

            // Set Initial View
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