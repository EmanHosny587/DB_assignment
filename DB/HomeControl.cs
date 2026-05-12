using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public class HomeControl : UserControl
    {
        public HomeControl()
        {
            BuildGui();
        }

        private void BuildGui()
        {
            Dock = DockStyle.Fill;
            BackColor = ModernStyle.Background;

            Controls.Add(ModernStyle.CreateTitle("Dashboard Overview"));
            Controls.Add(ModernStyle.CreateSubtitle("Connected to the real SQL Server tables in database AA.", 28, 70));

            AddCard("Patients", DatabaseHelper.GetCount("PATIENT"), 25, 120);
            AddCard("Practitioners", DatabaseHelper.GetCount("PRACTITIONER"), 315, 120);
            AddCard("Specialities", DatabaseHelper.GetCount("SPECIALITY"), 605, 120);
            AddCard("Schedules", DatabaseHelper.GetCount("IS_SCHEDULED"), 25, 280);
            AddCard("Medications", DatabaseHelper.GetCount("MEDICATION"), 315, 280);
            AddCard("Prescriptions", DatabaseHelper.GetCount("PRESCRIPTION"), 605, 280);
        }

        private void AddCard(string title, int count, int x, int y)
        {
            Panel card = ModernStyle.CreateCard(x, y, 250, 120);

            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Location = new Point(20, 18);
            titleLabel.Size = new Size(200, 30);
            titleLabel.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            titleLabel.ForeColor = ModernStyle.TextDark;

            Label countLabel = new Label();
            countLabel.Text = count.ToString();
            countLabel.Location = new Point(20, 55);
            countLabel.Size = new Size(200, 45);
            countLabel.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            countLabel.ForeColor = ModernStyle.DarkBlue;

            card.Controls.Add(titleLabel);
            card.Controls.Add(countLabel);
            Controls.Add(card);
        }
    }
}