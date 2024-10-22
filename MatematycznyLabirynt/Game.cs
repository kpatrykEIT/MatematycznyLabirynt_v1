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
    public partial class Game : Form
    {


        bool goup, godown, goleft, goright, isGameOver;
        int playerSpeed;
        Point previousPosition;

        public Game()
        {
            InitializeComponent();

            resetGame();
        }

        private void gameWon()
        {
            timer1.Stop(); // Zatrzymaj grę
            MessageBox.Show("Gratulacje! Wygrałeś!");
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
                }
            }

        }

        private void resetGame()
        {
            
            player.Left = 167;
            player.Top = 769;
            playerSpeed = 30;

            timer1.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;

                }
            }
        }

        private void gameOver()
        {

        }
    }
}
