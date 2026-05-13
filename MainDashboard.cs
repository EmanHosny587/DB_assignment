using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public class MainDashboard : Form
    {
        private Panel sidebar;
        private Panel contentPanel;
        private Panel activeHeaderPanel;
        private Label headerTitle;

        // Page Instances
        private Patients patients;
        private Practitioners practitioners;
        private Appointments appointments;
        private Prescriptions prescriptions;
        private Search search;
        private Reports reports;

        public MainDashboard()
        {
            // 1. MAIN FORM SETTINGS
            this.Text = "Multi-Specialty Healthcare Network - Admin Dashboard";
            this.Size = new Size(1280, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 247, 250);

            // 2. SIDEBAR NAVIGATION
            sidebar = new Panel();
            sidebar.BackColor = Color.FromArgb(24, 44, 97); // Primary Theme Color
            sidebar.Width = 260;
            sidebar.Dock = DockStyle.Left;

            // Application Branding
            Label brandLabel = new Label();
            brandLabel.Text = "⚕️ HealthNet";
            brandLabel.ForeColor = Color.White;
            brandLabel.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            brandLabel.Location = new Point(20, 30);
            brandLabel.Size = new Size(220, 60);
            sidebar.Controls.Add(brandLabel);

            InitializeSidebarMenu();

            // 3. TOP HEADER PANEL
            activeHeaderPanel = new Panel();
            activeHeaderPanel.Dock = DockStyle.Top;
            activeHeaderPanel.Height = 80;
            activeHeaderPanel.BackColor = Color.White;

            headerTitle = new Label();
            headerTitle.Text = "Dashboard Overview";
            headerTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            headerTitle.ForeColor = Color.FromArgb(44, 62, 80);
            headerTitle.Location = new Point(25, 20);
            headerTitle.AutoSize = true;
            activeHeaderPanel.Controls.Add(headerTitle);

            // 4. MAIN CONTENT AREA
            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.FromArgb(245, 247, 250);

            // Initialize Page Objects
            patients = new Patients();
            practitioners = new Practitioners();
            appointments = new Appointments();
            prescriptions = new Prescriptions();
            search = new Search();
            reports = new Reports();

            // Add Components to Form
            this.Controls.Add(contentPanel);
            this.Controls.Add(activeHeaderPanel);
            this.Controls.Add(sidebar);

            // Set Default View
            ShowDashboardHome();
        }

        private void InitializeSidebarMenu()
        {
            int startTop = 120;
            int spacing = 55;

            sidebar.Controls.Add(CreateMenuButton("Dashboard", startTop, (s, e) => ShowDashboardHome()));
            sidebar.Controls.Add(CreateMenuButton("Patients", startTop + spacing, (s, e) => LoadPage("Patients Registry", patients)));
            sidebar.Controls.Add(CreateMenuButton("Practitioners", startTop + (spacing * 2), (s, e) => LoadPage("Medical Staff", practitioners)));
            sidebar.Controls.Add(CreateMenuButton("Appointments", startTop + (spacing * 3), (s, e) => LoadPage("Consultation Schedule", appointments)));
            sidebar.Controls.Add(CreateMenuButton("Prescriptions", startTop + (spacing * 4), (s, e) => LoadPage("Medical Prescriptions", prescriptions)));
            sidebar.Controls.Add(CreateMenuButton("Search", startTop + (spacing * 5), (s, e) => LoadPage("System Inquiry", search)));
            sidebar.Controls.Add(CreateMenuButton("Reports", startTop + (spacing * 6), (s, e) => LoadPage("Analytical Insights", reports)));

            // Logout at the bottom
            Button logoutBtn = CreateMenuButton("Logout", this.Height - 150, (s, e) => Application.Exit());
            logoutBtn.ForeColor = Color.FromArgb(255, 120, 120); // Soft Red
            sidebar.Controls.Add(logoutBtn);
        }

        private void LoadPage(string titleText, UserControl page)
        {
            headerTitle.Text = titleText;
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }

        private void ShowDashboardHome()
        {
            headerTitle.Text = "Network Overview";
            contentPanel.Controls.Clear();

            FlowLayoutPanel cardsContainer = new FlowLayoutPanel();
            cardsContainer.Dock = DockStyle.Fill;
            cardsContainer.Padding = new Padding(20);

            // Stats from Project Phase 2 Context
            cardsContainer.Controls.Add(CreateStatCard("Active Patients", "1,240", Color.FromArgb(46, 204, 113)));
            cardsContainer.Controls.Add(CreateStatCard("Total Practitioners", "86", Color.FromArgb(52, 152, 219)));
            cardsContainer.Controls.Add(CreateStatCard("Today's Consultations", "42", Color.FromArgb(155, 89, 182)));
            cardsContainer.Controls.Add(CreateStatCard("Branches Managed", "12", Color.FromArgb(241, 196, 15)));

            contentPanel.Controls.Add(cardsContainer);
        }

        private Button CreateMenuButton(string text, int top, EventHandler clickEvent)
        {
            Button btn = new Button();
            btn.Text = "  " + text;
            btn.Size = new Size(230, 45);
            btn.Location = new Point(15, top);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Cursor = Cursors.Hand;
            btn.Click += clickEvent;
            return btn;
        }

        private Panel CreateStatCard(string title, string value, Color accentColor)
        {
            Panel card = new Panel();
            card.Size = new Size(280, 140);
            card.BackColor = Color.White;
            card.Margin = new Padding(15);

            // Accent Line
            Panel accent = new Panel();
            accent.BackColor = accentColor;
            accent.Width = 6;
            accent.Dock = DockStyle.Left;
            card.Controls.Add(accent);

            Label titleLbl = new Label();
            titleLbl.Text = title;
            titleLbl.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            titleLbl.ForeColor = Color.DimGray;
            titleLbl.Location = new Point(20, 25);
            titleLbl.AutoSize = true;

            Label valLbl = new Label();
            valLbl.Text = value;
            valLbl.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            valLbl.ForeColor = Color.FromArgb(44, 62, 80);
            valLbl.Location = new Point(20, 60);
            valLbl.AutoSize = true;

            card.Controls.Add(titleLbl);
            card.Controls.Add(valLbl);
            return card;
        }
    }

    // UPDATED TEMP CLASSES
    public class Patients : UserControl { public Patients() { this.BackColor = Color.White; } }
    public class Practitioners : UserControl { public Practitioners() { this.BackColor = Color.White; } }
    public class Appointments : UserControl { public Appointments() { this.BackColor = Color.White; } }
}