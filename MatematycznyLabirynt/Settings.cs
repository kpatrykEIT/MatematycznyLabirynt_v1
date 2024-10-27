using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// ***********************************
//
// Formularz zawierający opcję
// zmiany koloru tła wszystkich
// formularzy w projekcie.
//
// Settings.cs
//
// ***********************************

namespace MatematycznyLabirynt
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.Load += SettingsLoad;
        }

        // Załaduj wybrany kolor tła formularzy.
        private void ApplyBackgroundColorToAllOpenForms(Color color)
        {
            foreach (Form form in Application.OpenForms)
            {
                UpdateBackgroundColor(form, color);
            }
        }

        private void SettingsLoad(object? sender, EventArgs e)
        {
            UpdateBackgroundColor(this, SettingsClass.BackgroundColor);

        }

        // Przejście przez wszystkie elementy formularza.

        private void UpdateBackgroundColor(Control control, Color color)
        {
            if (control is Label label)
            {
                label.BackColor = color;
            }

            else
            {
                // Ustawia kolor tła dla elementów w formularzu.

                control.BackColor = color; 
            }

            // Rekurencja wykorzystana, aby przejść przez pozostałe elementy w formularzu.

            foreach (Control childControl in control.Controls)
            {
                UpdateBackgroundColor(childControl, color);
            }
        }


        // Obsługa zdarzenia kliknięcia przycisku związanego ze zmianą koloru.

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
                    ApplyBackgroundColorToAllOpenForms(SettingsClass.BackgroundColor);
                }
            }
        }

        // Zmiana koloru tła w formularzach.
        private void UpdateAllFormsBackgroundColor()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = SettingsClass.BackgroundColor;
            }
        }
        
        // Obsługa zdarzenia kliknięcia przycisku związanym z powrotem do głównego menu.
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();
        }



    }
}
