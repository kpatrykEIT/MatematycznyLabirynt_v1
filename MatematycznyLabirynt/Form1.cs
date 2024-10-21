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
            // Zamyka ca�� aplikacj�, gdy Form1 zostaje zamkni�te
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