namespace MatematycznyLabirynt
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Zamyka ca³¹ aplikacjê, gdy Form1 zostaje zamkniête
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
    }
}