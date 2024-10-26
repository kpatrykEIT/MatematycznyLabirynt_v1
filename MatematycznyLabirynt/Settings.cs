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
            this.Load += SettingsLoad;


        }
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


        private void UpdateBackgroundColor(Control control, Color color)
        {
            if (control is Label label)
            {
                label.BackColor = color;
            }

            else
            {
                control.BackColor = color; // Ustawia kolor tła dla pozostałych kontrolek
            }

            // Rekurencyjnie przechodzimy przez wszystkie podkontrolki
            foreach (Control childControl in control.Controls)
            {
                UpdateBackgroundColor(childControl, color);
            }
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
                    ApplyBackgroundColorToAllOpenForms(SettingsClass.BackgroundColor);
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



    }
}
