using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GUI
{
    public class Search : UserControl
    {
        private TextBox searchField;
        private ComboBox filterCategory;
        private DataGridView resultsGrid;
        private Button searchBtn;

        public Search()
        {
            // Main Control Settings
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(245, 247, 250); // Light professional background
            this.Padding = new Padding(25);

            // 1. Header Section
            Label titleLabel = new Label();
            titleLabel.Text = "Healthcare Network Search";
            titleLabel.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(24, 44, 97);
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Height = 50;

            // 2. Search Bar Panel
            Panel topPanel = new Panel();
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 100;
            topPanel.Padding = new Padding(0, 15, 0, 15);

            // Search Field Input
            searchField = new TextBox();
            searchField.PlaceholderText = "Search for patients, practitioners, or branches...";
            searchField.Font = new Font("Segoe UI", 12);
            searchField.Size = new Size(350, 35);
            searchField.Location = new Point(0, 25);

            // Filter Dropdown (Supports Specialty/Branch filtering)
            filterCategory = new ComboBox();
            filterCategory.Items.AddRange(new string[] { "All Categories", "Patients", "Practitioners", "Branches", "Prescriptions" });
            filterCategory.SelectedIndex = 0;
            filterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            filterCategory.Font = new Font("Segoe UI", 12);
            filterCategory.Size = new Size(150, 35);
            filterCategory.Location = new Point(365, 25);

            // Modern Search Button
            searchBtn = new Button();
            searchBtn.Text = "🔍 Search";
            StyleSearchButton(searchBtn);
            searchBtn.Location = new Point(530, 22);
            searchBtn.Click += HandleSearch;

            topPanel.Controls.AddRange(new Control[] { searchField, filterCategory, searchBtn });

            // 3. Results DataGridView
            resultsGrid = new DataGridView();
            resultsGrid.Dock = DockStyle.Fill;
            resultsGrid.BackgroundColor = Color.White;
            resultsGrid.BorderStyle = BorderStyle.None;
            resultsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // Grid Header Styling
            resultsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 44, 97);
            resultsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            resultsGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            resultsGrid.EnableHeadersVisualStyles = false;
            
            resultsGrid.ReadOnly = true;
            resultsGrid.RowHeadersVisible = false;
            resultsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add Components to the UserControl
            this.Controls.Add(resultsGrid);
            this.Controls.Add(topPanel);
            this.Controls.Add(titleLabel);
        }

        private void StyleSearchButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(24, 44, 97);
            btn.ForeColor = Color.White;
            btn.Size = new Size(130, 42);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        private void HandleSearch(object sender, EventArgs e)
        {
            // This section links to the database based on Inquiry Requirements (e.g., RQ003)
            string category = filterCategory.SelectedItem.ToString();
            string query = searchField.Text;

            // Log search action (To be replaced with actual SQL Query Logic)
            MessageBox.Show($"Searching in {category} for: \"{query}\"\nResults will be populated in the grid.", 
                            "System Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // TODO: Bind the resultsGrid.DataSource to the database query result
        }
    }
}