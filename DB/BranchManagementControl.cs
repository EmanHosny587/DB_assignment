using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class BranchManagementControl : UserControl
    {
        private TextBox txtBranchId;
        private TextBox txtAddress;
        private TextBox txtContact;
        private ComboBox cmbRegions;
        private DataGridView grid;

        public BranchManagementControl()
        {
            BuildGui();
            LoadRegions();
            LoadBranches();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Medical Facility & Branch Management"));

            Panel card = ModernStyle.CreateCard(25, 85, 950, 220);
            Controls.Add(card);

            // Column 1: Identification
            card.Controls.Add(ModernStyle.CreateLabel("Branch ID", 20, 20));
            txtBranchId = ModernStyle.CreateTextBox(160, 20);
            card.Controls.Add(txtBranchId);

            card.Controls.Add(ModernStyle.CreateLabel("Regional Provider", 20, 65));
            cmbRegions = new ComboBox();
            cmbRegions.Location = new Point(160, 65);
            cmbRegions.Size = new Size(200, 28);
            cmbRegions.DropDownStyle = ComboBoxStyle.DropDownList;
            card.Controls.Add(cmbRegions);

            // Column 2: Details
            card.Controls.Add(ModernStyle.CreateLabel("Physical Address", 400, 20));
            txtAddress = ModernStyle.CreateTextBox(550, 20, 350);
            card.Controls.Add(txtAddress);

            card.Controls.Add(ModernStyle.CreateLabel("Contact Details", 400, 65));
            txtContact = ModernStyle.CreateTextBox(550, 65, 350);
            card.Controls.Add(txtContact);

            // Action Buttons
            Button btnInsert = ModernStyle.CreateSuccessButton("Register Branch", 400, 130, 160);
            btnInsert.Click += BtnInsert_Click;
            card.Controls.Add(btnInsert);

            Button btnUpdate = ModernStyle.CreateButton("Update Details", 570, 130, 160);
            btnUpdate.Click += BtnUpdate_Click;
            card.Controls.Add(btnUpdate);

            Button btnDelete = ModernStyle.CreateDangerButton("Remove Branch", 740, 130, 160);
            btnDelete.Click += BtnDelete_Click;
            card.Controls.Add(btnDelete);

            // Data Grid
            grid = new DataGridView();
            ModernStyle.StyleGrid(grid);
            grid.Location = new Point(25, 320);
            grid.Size = new Size(950, 350);
            Controls.Add(grid);
        }

        private void LoadRegions()
        {
            string query = "SELECT REGION_ID, REGION_NAME FROM REGIONAL_HEALTHCARE_PROVIDER";
            DataTable dt = DatabaseHelper.GetData(query);
            cmbRegions.DataSource = dt;
            cmbRegions.DisplayMember = "REGION_NAME";
            cmbRegions.ValueMember = "REGION_ID";
        }

        private void LoadBranches()
        {
            string query = @"
                SELECT B.FACILITY_BRANCH_ID, R.REGION_NAME, B.PHYSICAL_ADDRESS, B.CONTACT_DETAILS
                FROM MEDICAL_FACILITY_BRANCH B
                JOIN REGIONAL_HEALTHCARE_PROVIDER R ON B.REGION_ID = R.REGION_ID";
            grid.DataSource = DatabaseHelper.GetData(query);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBranchId.Text) || cmbRegions.SelectedValue == null) return;

            string query = @"
                IF NOT EXISTS (SELECT 1 FROM MEDICAL_FACILITY_BRANCH WHERE FACILITY_BRANCH_ID = @ID)
                INSERT INTO MEDICAL_FACILITY_BRANCH (FACILITY_BRANCH_ID, REGION_ID, PHYSICAL_ADDRESS, CONTACT_DETAILS)
                VALUES (@ID, @RegionID, @Address, @Contact);
            ";

            DatabaseHelper.ExecuteQuery(query,
                new SqlParameter("@ID", txtBranchId.Text),
                new SqlParameter("@RegionID", cmbRegions.SelectedValue),
                new SqlParameter("@Address", txtAddress.Text),
                new SqlParameter("@Contact", txtContact.Text)
            );

            LoadBranches();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBranchId.Text)) return;

            string query = @"
                UPDATE MEDICAL_FACILITY_BRANCH
                SET REGION_ID = @RegionID,
                    PHYSICAL_ADDRESS = @Address,
                    CONTACT_DETAILS = @Contact
                WHERE FACILITY_BRANCH_ID = @ID;
            ";

            DatabaseHelper.ExecuteQuery(query,
                new SqlParameter("@ID", txtBranchId.Text),
                new SqlParameter("@RegionID", cmbRegions.SelectedValue),
                new SqlParameter("@Address", txtAddress.Text),
                new SqlParameter("@Contact", txtContact.Text)
            );

            LoadBranches();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBranchId.Text)) return;

            string query = "DELETE FROM MEDICAL_FACILITY_BRANCH WHERE FACILITY_BRANCH_ID = @ID;";
            DatabaseHelper.ExecuteQuery(query, new SqlParameter("@ID", txtBranchId.Text));

            LoadBranches();
        }
    }
}