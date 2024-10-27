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
// Formularz zawierający poziom trzeci
// gry.
//
// Game3.cs
//
// ***********************************


namespace MatematycznyLabirynt
{
    public partial class Game3 : Form
    {

        // Zmienne wykorzystywane w formularzu.

        bool goup, godown, goleft, goright;
        int playerSpeed;
        Point previousPosition;
        private bool questionDisplayed = false;

        // Wyłącz możliwość poruszania się
        private void DisablePlayerMovement()
        {
            goup = godown = goleft = goright = false; // Wyłącz możliwość poruszania się
        }
        
        // Zresetuj stan gry.

        private void resetGame()
        {

            player3.Left = 620;
            player3.Top = 160;
            playerSpeed = 10;
            questionTimer.Start();
            timer1.Start();
            SettingsClass.score = 0;
            labelScore.Text = "Wynik: 0";



        }

        public Game3()
        {
            InitializeComponent();
            resetGame();
            this.Load += GameLoad;
            questionTimer.Start(); // Rozpoczęcie timera


        }

        private void GameLoad(object sender, EventArgs e)
        {
            // Ustaw kolor tła na podstawie globalnych ustawień
            this.BackColor = SettingsClass.BackgroundColor;

        }

        // Losuj pytanie co każde przepełnienie licznika.

        private void ShowMathQuestion(object sender, EventArgs e)
        {

            if (!questionDisplayed)
            {

                questionDisplayed = true; // Ustaw flagę na true, aby blokować wyświetlanie kolejnych pytań
                DisablePlayerMovement();
                // Tworzenie okna pytania
                questionTimer.Stop();
                MathQuestions mathQuestions = new MathQuestions();
                DialogResult result = mathQuestions.ShowDialog(); // Pokaż okno dialogowe

                if (true) // Jeśli gracz odpowiedział
                {
                    if (mathQuestions.isCorrect) // Sprawdzenie poprawności odpowiedzi
                    {
                        // Odpowiedź poprawna, pozwól grać dalej
                      
                        SettingsClass.score += 5;
                        labelScore.Text = "Wynik: " + SettingsClass.score;
                    }
                    else
                    {
                        // Odpowiedź błędna, resetuj grę
                        resetGame();


                    }
                }
                questionTimer.Start();
                questionDisplayed = false; // Resetuj flagę po zamknięciu okna pytania
            }

        }

        // Funkcja związana z przejściem poziomu.
        private void gameWon()
        {
            timer1.Stop(); // Zatrzymaj grę
            MessageBox.Show("Gratulacje! Twój wynik z poziomu 3 to: " + SettingsClass.score + " punktów.");
            resetGame();
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();


        }

        // Obsługa zdarzenia KeyDown

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        // Obsługa zdarzenia KeyUp

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        // Główny licznik gry.

        private void mainGameTimer(object sender, EventArgs e)
        {

            if (questionDisplayed) return;


            previousPosition = player3.Location;

            if (goleft)
            {
                player3.Left -= playerSpeed;
            }
            if (goright)
            {
                player3.Left += playerSpeed;
            }
            if (goup)
            {
                player3.Top -= playerSpeed;
            }
            if (godown)
            {
                player3.Top += playerSpeed;
            }


            // Sprawdz elementy formularza.

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "wall")
                    {
                        if (player3.Bounds.IntersectsWith(x.Bounds))
                        {
                            player3.Location = previousPosition;
                            break;

                        }
                    }
                    if ((string)x.Tag == "winningSpot")
                    {
                        if (player3.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameWon();

                        }
                    }

                }

            }


        }

    }
}
