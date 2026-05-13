using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public class Reports : UserControl
    {
        public Reports()
        {
            // Main Control Settings
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.Padding = new Padding(30);

            // 1. Header Section
            Label title = new Label();
            title.Text = "System Analytical Insights";
            title.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(24, 44, 97);
            title.AutoSize = true;
            title.Dock = DockStyle.Top;
            title.Padding = new Padding(0, 0, 0, 20);

            this.Controls.Add(title);

            // 2. Grid Layout for Report Cards
            TableLayoutPanel grid = new TableLayoutPanel();
            grid.RowCount = 2;
            grid.ColumnCount = 3;
            grid.Dock = DockStyle.Fill;
            grid.BackColor = Color.Transparent;

            // Define Responsive Column and Row Styles
            for (int i = 0; i < 3; i++) grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            for (int i = 0; i < 2; i++) grid.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));

            // 3. Adding Cards based on Project Phase 2 Requirements
            // Inquiry: Top medications prescribed last month
            grid.Controls.Add(CreateReportCard(
                "Medication Demand",
                "Analysis of the top prescribed medicines across all network branches.",
                "📊 Generate Data"
            ), 0, 0);

            // Inquiry: Branches with zero visits
            grid.Controls.Add(CreateReportCard(
                "Inactive Branches",
                "Identify medical facilities with no recorded patient visits last month.",
                "🔍 Locate Branches"
            ), 1, 0);

            // Inquiry: Diagnosis details per branch
            grid.Controls.Add(CreateReportCard(
                "Branch Diagnosis",
                "Detailed diagnostic trends and consultation history per facility.",
                "📝 View Details"
            ), 2, 0);

            // Inquiry: Full patient profile with prescription count
            grid.Controls.Add(CreateReportCard(
                "Patient Profiles",
                "Comprehensive patient history including total issued prescriptions.",
                "👤 Export Profiles"
            ), 0, 1);

            // Inquiry: Most demanded medical skills/specialties
            grid.Controls.Add(CreateReportCard(
                "Specialty Demand",
                "Statistics on the most requested medical expertise and skills.",
                "📈 View Stats"
            ), 1, 1);

            // Inquiry: Consultations/Projects status tracking
            grid.Controls.Add(CreateReportCard(
                "Consultation Flow",
                "Monitoring sessions and scheduled medical appointments status.",
                "🕒 Check Status"
            ), 2, 1);

            this.Controls.Add(grid);
        }

        private Panel CreateReportCard(string title, string desc, string btnText)
        {
            Panel card = new Panel();
            card.BackColor = Color.White;
            card.Margin = new Padding(12);
            card.Dock = DockStyle.Fill;
            card.Cursor = Cursors.Default;

            // Title Label
            Label t = new Label();
            t.Text = title;
            t.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            t.ForeColor = Color.FromArgb(44, 62, 80);
            t.Location = new Point(20, 20);
            t.AutoSize = true;

            // Description Label
            Label d = new Label();
            d.Text = desc;
            d.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            d.ForeColor = Color.DimGray;
            d.Location = new Point(20, 65);
            d.Size = new Size(240, 60);

            // Modern Styled Button
            Button actionBtn = new Button();
            actionBtn.Text = btnText;
            actionBtn.BackColor = Color.FromArgb(24, 44, 97);
            actionBtn.ForeColor = Color.White;
            actionBtn.FlatStyle = FlatStyle.Flat;
            actionBtn.FlatAppearance.BorderSize = 0;
            actionBtn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            actionBtn.Size = new Size(160, 45);
            actionBtn.Location = new Point(20, 135);
            actionBtn.Cursor = Cursors.Hand;

            // Simple click event for reporting
            actionBtn.Click += (s, e) => {
                MessageBox.Show($"Generating analytical report for: {title}\nThis may take a few seconds...", 
                                "Reporting Module", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // Add Controls to Card
            card.Controls.Add(t);
            card.Controls.Add(d);
            card.Controls.Add(actionBtn);

            // UI Enhancement: Add a border effect via a bottom-border panel
            Panel borderLine = new Panel();
            borderLine.BackColor = Color.FromArgb(24, 44, 97);
            borderLine.Height = 4;
            borderLine.Dock = DockStyle.Bottom;
            card.Controls.Add(borderLine);

            return card;
        }
    }
}