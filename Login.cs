using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public class Login : Form
    {
        private TextBox userField;
        private TextBox passField;

        public Login()
        {
            // Form Configuration
            this.Text = "Healthcare Network - Authentication";
            this.Size = new Size(450, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            // Main Container (FlowLayoutPanel for vertical stacking)
            FlowLayoutPanel container = new FlowLayoutPanel();
            container.Dock = DockStyle.Fill;
            container.FlowDirection = FlowDirection.TopDown;
            container.WrapContents = false;
            container.Padding = new Padding(50, 60, 50, 50);
            container.BackColor = Color.White;

            // 1. Logo or Header Icon Placeholder
            Label logoLabel = new Label();
            logoLabel.Text = "⚕️"; // Medical Icon
            logoLabel.Font = new Font("Segoe UI", 48);
            logoLabel.ForeColor = Color.FromArgb(24, 44, 97);
            logoLabel.TextAlign = ContentAlignment.MiddleCenter;
            logoLabel.Size = new Size(340, 80);

            // 2. Welcome Title
            Label titleLabel = new Label();
            titleLabel.Text = "Healthcare Login";
            titleLabel.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(44, 62, 80);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Size = new Size(340, 50);
            titleLabel.Margin = new Padding(0, 0, 0, 30);

            // 3. Username Section
            userField = new TextBox();
            userField.PlaceholderText = "Enter your username";
            StyleField(userField);
            Panel userPanel = CreateFieldPanel("Username", userField);

            // 4. Password Section
            passField = new TextBox();
            passField.PlaceholderText = "Enter your password";
            passField.UseSystemPasswordChar = true;
            StyleField(passField);
            Panel passPanel = CreateFieldPanel("Password", passField);

            // 5. Login Button
            Button loginButton = new Button();
            loginButton.Text = "SIGN IN";
            StyleLoginButton(loginButton);
            loginButton.Click += HandleLogin;

            // Add Controls to Container
            container.Controls.Add(logoLabel);
            container.Controls.Add(titleLabel);
            container.Controls.Add(userPanel);
            container.Controls.Add(passPanel);
            container.Controls.Add(loginButton);

            this.Controls.Add(container);
        }

        private void HandleLogin(object sender, EventArgs e)
        {
            // Simple validation before proceeding to Dashboard
            if (string.IsNullOrWhiteSpace(userField.Text) || string.IsNullOrWhiteSpace(passField.Text))
            {
                MessageBox.Show("Please provide valid credentials to access the system.", 
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Navigate to the Main Dashboard (Requirement RQ003/RQ006 access)
                MainDashboard dashboard = new MainDashboard();
                dashboard.Show();
                this.Hide(); 
            }
        }

        private Panel CreateFieldPanel(string labelText, Control field)
        {
            Panel panel = new Panel();
            panel.Size = new Size(340, 90);

            Label lbl = new Label();
            lbl.Text = labelText;
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lbl.ForeColor = Color.Gray;
            lbl.Location = new Point(0, 5);
            lbl.AutoSize = true;

            field.Location = new Point(0, 30);

            panel.Controls.Add(lbl);
            panel.Controls.Add(field);
            return panel;
        }

        private void StyleField(TextBox field)
        {
            field.Size = new Size(340, 40);
            field.Font = new Font("Segoe UI", 12);
            field.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StyleLoginButton(Button btn)
        {
            btn.Size = new Size(340, 55);
            btn.BackColor = Color.FromArgb(24, 44, 97); // Primary Theme Color
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Margin = new Padding(0, 20, 0, 0);
        }
    }
}