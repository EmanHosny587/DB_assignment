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

            Controls.Add(ModernStyle.CreateTitle("Search"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 120);
            Controls.Add(card);

            card.Controls.Add(ModernStyle.CreateLabel("Table", 20, 25));
            cmbTable = new ComboBox();
            cmbTable.Location = new Point(120, 25);
            cmbTable.Size = new Size(200, 25);
            cmbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTable.Items.AddRange(new string[] { "PATIENT", "PRACTITIONER", "SPECIALITY", "APPOINTMENT" });
            cmbTable.SelectedIndex = 0;
            card.Controls.Add(cmbTable);

            card.Controls.Add(ModernStyle.CreateLabel("Search Text", 350, 25));
            txtSearch = ModernStyle.CreateTextBox(480, 25, 220);
            card.Controls.Add(txtSearch);

            Button btnSearch = ModernStyle.CreateButton("Search", 730, 20);
            btnSearch.Click += BtnSearch_Click;
            card.Controls.Add(btnSearch);

            grid = new DataGridView();
            grid.Location = new Point(25, 230);
            grid.Size = new Size(950, 400);
            ModernStyle.StyleGrid(grid);
            Controls.Add(grid);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string table = cmbTable.SelectedItem.ToString();
            string keyword = "%" + txtSearch.Text + "%";
            string query;

            if (table == "PATIENT")
            {
                query = @"
                    SELECT *
                    FROM PATIENT
                    WHERE CAST(PATIENT_ID AS VARCHAR) LIKE @Keyword
                       OR CONTACT_HISTORY LIKE @Keyword
                       OR DEMOGRAPHIC LIKE @Keyword;
                ";
            }
            else if (table == "PRACTITIONER")
            {
                query = @"
                    SELECT *
                    FROM PRACTITIONER
                    WHERE CAST(PRACTITIONER_ID AS VARCHAR) LIKE @Keyword
                       OR CAST(SPECIALITY_ID AS VARCHAR) LIKE @Keyword
                       OR MEDICAL_EXPERTISE LIKE @Keyword;
                ";
            }
            else if (table == "SPECIALITY")
            {
                query = @"
                    SELECT *
                    FROM SPECIALITY
                    WHERE CAST(SPECIALITY_ID AS VARCHAR) LIKE @Keyword
                       OR SPECIALITY_NAME LIKE @Keyword;
                ";
            }
            else
            {
                query = @"
                    SELECT *
                    FROM APPOINTMENT
                    WHERE CAST(APPOINTMENT_ID AS VARCHAR) LIKE @Keyword
                       OR CAST(PATIENT_ID AS VARCHAR) LIKE @Keyword
                       OR CAST(PRACTITIONER_ID AS VARCHAR) LIKE @Keyword
                       OR STATUS LIKE @Keyword;
                ";
            }

            grid.DataSource = DatabaseHelper.GetData(
                query,
                new SqlParameter("@Keyword", keyword)
            );
        }
    }
}