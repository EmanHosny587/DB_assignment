using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public class Prescriptions : UserControl
    {
        private DataGridView table;
        private Panel topSection;
        private FlowLayoutPanel toolbar;

        public Prescriptions()
        {
            // Main Panel Settings
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(245, 247, 250); // Light professional grey
            this.Padding = new Padding(25);

            // 1. Header Section
            Label headerLabel = new Label();
            headerLabel.Text = "Medical Prescriptions Management";
            headerLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            headerLabel.ForeColor = Color.FromArgb(24, 44, 97);
            headerLabel.AutoSize = true;
            headerLabel.Dock = DockStyle.Left;

            // 2. Toolbar (Buttons)
            toolbar = new FlowLayoutPanel();
            toolbar.FlowDirection = FlowDirection.RightToLeft;
            toolbar.Dock = DockStyle.Right;
            toolbar.Width = 400;

            Button addButton = new Button();
            addButton.Text = "✚ Create Prescription";
            StyleButton(addButton, Color.FromArgb(46, 204, 113)); // Success Green

            Button printButton = new Button();
            printButton.Text = "⎙ Print Selected";
            StyleButton(printButton, Color.FromArgb(52, 152, 219)); // Info Blue

            toolbar.Controls.Add(printButton);
            toolbar.Controls.Add(addButton);

            // 3. Top Section Container
            topSection = new Panel();
            topSection.Dock = DockStyle.Top;
            topSection.Height = 80;
            topSection.Controls.Add(headerLabel);
            topSection.Controls.Add(toolbar);

            // 4. Grid Implementation (Data View)
            table = new DataGridView();
            table.Dock = DockStyle.Fill;
            table.BackgroundColor = Color.White;
            table.BorderStyle = BorderStyle.None;
            table.AllowUserToAddRows = false;
            table.RowHeadersVisible = false;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            // Initialize Columns matching the Database Schema (Project Phase 2)
            table.Columns.Add("PrescID", "Prescription ID");
            table.Columns.Add("Patient", "Patient Name");
            table.Columns.Add("Medication", "Medication Name");
            table.Columns.Add("Dosage", "Dosage");
            table.Columns.Add("Instructions", "Medical Instructions");
            table.Columns.Add("IssueDate", "Date Issued");

            ApplyGridStyling(table);

            // Placeholder Data - To be replaced by SQL Query (e.g., SELECT * FROM Prescriptions)
            table.Rows.Add("RX-1001", "Ahmed Ali", "Panadol Extra", "500mg", "Twice daily after meals", "2026-05-13");
            table.Rows.Add("RX-1002", "Sara Mohamed", "Amoxicillin", "250mg", "Every 8 hours", "2026-05-12");

            // Add Components to UserControl
            this.Controls.Add(table);
            this.Controls.Add(topSection);

            // Events
            addButton.Click += (s, e) => ShowFormMessage("Prescription Intake Form");
            printButton.Click += (s, e) => ShowFormMessage("Print Preview Module");
        }

        private void ApplyGridStyling(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            // Header Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 44, 97);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.EnableHeadersVisualStyles = false;

            // Selection Style
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(24, 44, 97);
            dgv.GridColor = Color.FromArgb(230, 230, 230);
        }

        private void StyleButton(Button btn, Color themeColor)
        {
            btn.BackColor = themeColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Size = new Size(160, 45);
            btn.Margin = new Padding(10, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
        }

        private void ShowFormMessage(string moduleName)
        {
            MessageBox.Show($"{moduleName} is currently being synchronized with the Database.", 
                            "Healthcare System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}