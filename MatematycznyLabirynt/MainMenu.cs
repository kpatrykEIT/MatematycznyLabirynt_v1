namespace MatematycznyLabirynt
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.ActiveControl = null;
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            this.Load += MainFormLoad;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // Ustaw kolor t³a na podstawie globalnych ustawieñ
            this.BackColor = SettingsClass.BackgroundColor;
            UpdateBackgroundColor(this, SettingsClass.BackgroundColor);
        }
        private void UpdateBackgroundColor(Control control, Color color)
        {
            // Zmieñ t³o, jeœli kontrolka jest typu Label lub dla ca³ego formularza
            if (control is Label label)
            {
                label.BackColor = color;
            }
            else
            {
                control.BackColor = color;
            }

            // Rekurencyjnie zmieniamy t³o dla podkontrolek
            foreach (Control childControl in control.Controls)
            {
                UpdateBackgroundColor(childControl, color);
            }
        }
        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Zamyka ca³¹ aplikacjê, gdy MainMenu zostaje zamkniête
            Application.Exit();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            Rules form2 = new Rules();
            form2.Show();
            this.Hide();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show();
        }
    }
}