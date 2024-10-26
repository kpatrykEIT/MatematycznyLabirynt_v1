using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematycznyLabirynt
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            numericUpDownFontSize.Value = (decimal)SettingsClass.FontSize; // Ustaw początkową wartość
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Zapisz wybrany kolor w ustawieniach
                    SettingsClass.BackgroundColor = colorDialog.Color;

                    // Zaktualizuj kolor w otwartych formularzach
                    UpdateAllFormsBackgroundColor();
                }
            }
        }

        private void UpdateAllFormsBackgroundColor()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = SettingsClass.BackgroundColor;
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();
        }


        private void btnChangeFontSize_Click(object sender, EventArgs e)
        {
            SettingsClass.FontSize = (float)numericUpDownFontSize.Value;
            UpdateAllFormsFontSize();
        }
        private void UpdateAllFormsFontSize()
        {
            foreach (Form form in Application.OpenForms)
            {
                UpdateFormFont(form, SettingsClass.FontSize);
            }
        }

        private void UpdateFormFont(Form form, float fontSize)
        {
            // Rekurencyjnie zmienia rozmiar czcionki wszystkich kontrolek na formularzu
            foreach (Control control in form.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, fontSize);
            }
        }
    }
}
