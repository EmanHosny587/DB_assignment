using System.Drawing;
using System.Windows.Forms;

namespace DB
{
    public static class ModernStyle
    {
        public static Color DarkBlue = Color.FromArgb(24, 44, 97);
        public static Color HoverBlue = Color.FromArgb(35, 65, 145);
        public static Color Background = Color.FromArgb(245, 247, 250);
        public static Color TextDark = Color.FromArgb(30, 45, 80);
        public static Color TextMuted = Color.FromArgb(110, 118, 130);
        public static Color Danger = Color.FromArgb(210, 67, 67);
        public static Color DangerHover = Color.FromArgb(185, 45, 45);
        public static Color Success = Color.FromArgb(35, 150, 95);
        public static Color SuccessHover = Color.FromArgb(28, 125, 78);

        public static Label CreateTitle(string text)
        {
            Label title = new Label();
            title.Text = text;
            title.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            title.ForeColor = TextDark;
            title.Location = new Point(25, 20);
            title.Size = new Size(820, 50);
            title.TextAlign = ContentAlignment.MiddleLeft;
            return title;
        }

        public static Label CreateSubtitle(string text, int x, int y, int width = 780)
        {
            Label subtitle = new Label();
            subtitle.Text = text;
            subtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            subtitle.ForeColor = TextMuted;
            subtitle.Location = new Point(x, y);
            subtitle.Size = new Size(width, 25);
            return subtitle;
        }

        public static Label CreateLabel(string text, int x, int y, int width = 150)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.Size = new Size(width, 25);
            label.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            label.ForeColor = TextMuted;
            label.TextAlign = ContentAlignment.MiddleLeft;
            return label;
        }

        public static TextBox CreateTextBox(int x, int y, int width = 200)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(x, y);
            textBox.Size = new Size(width, 28);
            textBox.Font = new Font("Segoe UI", 10);
            textBox.BackColor = Color.White;
            textBox.ForeColor = TextDark;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            return textBox;
        }

        public static Button CreateButton(string text, int x, int y, int width = 170)
        {
            return CreateStyledButton(text, x, y, width, DarkBlue, HoverBlue);
        }

        public static Button CreateSuccessButton(string text, int x, int y, int width = 170)
        {
            return CreateStyledButton(text, x, y, width, Success, SuccessHover);
        }

        public static Button CreateDangerButton(string text, int x, int y, int width = 170)
        {
            return CreateStyledButton(text, x, y, width, Danger, DangerHover);
        }

        private static Button CreateStyledButton(string text, int x, int y, int width, Color normalColor, Color hoverColor)
        {
            Button button = new Button();
            button.Text = text;
            button.Location = new Point(x, y);
            button.Size = new Size(width, 42);
            button.BackColor = normalColor;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = hoverColor;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.UseVisualStyleBackColor = false;

            button.MouseEnter += (sender, args) => { button.BackColor = hoverColor; };
            button.MouseLeave += (sender, args) => { button.BackColor = normalColor; };

            return button;
        }

        public static Panel CreateCard(int x, int y, int width, int height)
        {
            Panel panel = new Panel();
            panel.Location = new Point(x, y);
            panel.Size = new Size(width, height);
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Padding = new Padding(15);
            return panel;
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowTemplate.Height = 34;
            grid.RowHeadersVisible = false;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersHeight = 42;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            grid.ColumnHeadersDefaultCellStyle.BackColor = DarkBlue;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            grid.DefaultCellStyle.ForeColor = TextDark;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 230, 250);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.DefaultCellStyle.Padding = new Padding(5);

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.GridColor = Color.FromArgb(230, 235, 240);
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }
    }
}