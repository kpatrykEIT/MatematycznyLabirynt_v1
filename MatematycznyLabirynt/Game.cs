﻿using System;
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
    public partial class Game : Form
    {


        bool goup, godown, goleft, goright;
        int playerSpeed;
        Point previousPosition;

        private bool questionDisplayed = false;


        private void DisablePlayerMovement()
        {
            goup = godown = goleft = goright = false; // Wyłącz możliwość poruszania się
        }
        private void EnablePlayerMovement()
        {
            // Ruch zostanie przywrócony po odpowiedzi na pytanie
            // Można też dostosować do potrzeb (jeśli np. mają być inne warunki poruszania się)
        }


        private void resetGame()
        {

            player.Left = 167;
            player.Top = 769;
            playerSpeed = 10;
            EnablePlayerMovement();
            questionTimer.Start();
            timer1.Start();
            SettingsClass.score = 0;
            labelScore.Text = "Wynik: 0";


        }

        public Game()
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
                        //MessageBox.Show("Odpowiedź poprawna! Możesz grać dalej.");
                        EnablePlayerMovement();
                        //player.Location = previousPosition;

                        SettingsClass.score += 5;
                        labelScore.Text = "Wynik: " + SettingsClass.score;
                    }
                    else
                    {
                        // Odpowiedź błędna, resetuj grę
                        resetGame();
                        // MessageBox.Show("Błędna odpowiedź! Gra zostanie zresetowana.");


                    }
                }
                questionTimer.Start();
                questionDisplayed = false; // Resetuj flagę po zamknięciu okna pytania
            }

        }









        private void gameWon()
        {
            timer1.Stop(); // Zatrzymaj grę
            MessageBox.Show("Gratulacje! Twój wynik z poziomu 1 to: " + SettingsClass.score + " punktów.");
            resetGame();
            this.Close();
            Game2 game2 = new Game2();
            game2.Show();

        }

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



        private void mainGameTimer(object sender, EventArgs e)
        {

            if (questionDisplayed) return;


            previousPosition = player.Location;

            if (goleft)
            {
                player.Left -= playerSpeed;
            }
            if (goright)
            {
                player.Left += playerSpeed;
            }
            if (goup)
            {
                player.Top -= playerSpeed;
            }
            if (godown)
            {
                player.Top += playerSpeed;
            }





            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "wall")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            player.Location = previousPosition;
                            break;

                        }
                    }
                    if ((string)x.Tag == "winningSpot")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameWon();

                        }
                    }

                    /*
                    if ((string)x.Tag == "question" && player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (!questionDisplayed)
                        {

                            questionDisplayed = true;
                            currentQuestionBox = (PictureBox)x; // Przypisz aktualny PictureBox z pytaniem


                            MathQuestions mathQuestions = new MathQuestions();
                            
                            if(mathQuestions.ShowDialog() == DialogResult.OK)
                            {
                                if (!mathQuestions.isCorrect)
                                {
                                    MessageBox.Show("Gra zostanie zrestartowana!", "Przegrana");
                                    resetGame();

                                }
                                else if (mathQuestions.isCorrect)
                                {
                                    currentQuestionBox.Enabled = false;

                                }

                            }

                            questionDisplayed = false;

                            //player.Location = previousPosition;

                            // Resetuj flagę pytania

                        } 




                    }
                    */

                }

            }


        }



        private void gameOver()
        {

        }


    }
}
