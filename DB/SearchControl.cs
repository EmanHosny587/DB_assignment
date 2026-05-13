using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class SearchControl : UserControl
    {
        private ComboBox cmbTable;
        private TextBox txtSearch;
        private DataGridView grid;

        public SearchControl()
        {
            BuildGui();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Global Network Search"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 120);
            Controls.Add(card);

            // Table Selection
            card.Controls.Add(ModernStyle.CreateLabel("Select Category", 20, 25));
            cmbTable = new ComboBox();
            cmbTable.Location = new Point(150, 25);
            cmbTable.Size = new Size(180, 28);
            cmbTable.Font = new Font("Segoe UI", 10);
            cmbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTable.Items.AddRange(new string[] { "Patients", "Practitioners", "Specialities", "Consultations" });
            cmbTable.SelectedIndex = 0;
            card.Controls.Add(cmbTable);

            // Search Box
            card.Controls.Add(ModernStyle.CreateLabel("Keyword", 360, 25));
            txtSearch = ModernStyle.CreateTextBox(450, 25, 250);
            card.Controls.Add(txtSearch);

            // Search Button
            Button btnSearch = ModernStyle.CreateButton("Execute Search", 730, 20, 180);
            btnSearch.Click += BtnSearch_Click;
            card.Controls.Add(btnSearch);

            // Results Grid
            grid = new DataGridView();
            grid.Location = new Point(25, 230);
            grid.Size = new Size(950, 420);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string category = cmbTable.SelectedItem.ToString();
            string keyword = "%" + txtSearch.Text + "%";
            string query = "";

            switch (category)
            {
                case "Patients":
                    query = @"SELECT PATIENT_ID, PATIENT_NAME, DATE_OF_BIRTH, CONTACT_HISTORY 
                              FROM PATIENT 
                              WHERE PATIENT_NAME LIKE @Keyword 
                              OR CAST(PATIENT_ID AS VARCHAR) LIKE @Keyword 
                              OR DEMOGRAPHIC LIKE @Keyword";
                    break;

                case "Practitioners":
                    query = @"SELECT PRACTITIONER_ID, PRACTITIONER_NAME, MEDICAL_EXPERTISE 
                              FROM PRACTITIONER 
                              WHERE PRACTITIONER_NAME LIKE @Keyword 
                              OR MEDICAL_EXPERTISE LIKE @Keyword";
                    break;

                case "Specialities":
                    query = @"SELECT * FROM SPECIALITY 
                              WHERE SPECIALITY_NAME LIKE @Keyword 
                              OR CAST(SPECIALITY_ID AS VARCHAR) LIKE @Keyword";
                    break;

                case "Consultations":
                    query = @"SELECT CONSULTATION_ID, PATIENT_ID, PRACTITIONER_ID, SCHEDULED_DATE_TIME 
                              FROM CONSULTATION 
                              WHERE CAST(CONSULTATION_ID AS VARCHAR) LIKE @Keyword 
                              OR CAST(PATIENT_ID AS VARCHAR) LIKE @Keyword";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                grid.DataSource = DatabaseHelper.GetData(query, new SqlParameter("@Keyword", keyword));
            }
        }
    }
}