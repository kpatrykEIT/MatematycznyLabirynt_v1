namespace MatematycznyLabirynt
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}