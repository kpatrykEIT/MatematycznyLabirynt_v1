﻿using System;
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
// Formularz zawierający zasady gry
// i sterowania.
//
// Rules.cs
//
// ***********************************



namespace MatematycznyLabirynt
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        // Obsługa zdarzenia kliknięcia przycisku związanym z powrotem do głównego menu.

        private void btnHomeForm_Click(object sender, EventArgs e)
        {
            MainMenu form1 = new MainMenu();
            form1.Show();
            this.Close();
        }


    }
}
