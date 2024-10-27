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
    public partial class MathQuestions : Form
    {



        private Random random = new Random();
        private int correctAnswer;
        private static bool isDivision = true;
        public bool isCorrect;


        public MathQuestions()
        {
            InitializeComponent();
            GenerateMathTask();
        }

        private void GenerateMathTask()
        {

            int num1;   // Pierwsza liczba
            int num2;   // Druga liczba

            if (isDivision)
            {
                // Generowanie pytania z dzielenia
                num2 = random.Next(1, 5); // Licznik nie może być zerem
                correctAnswer = random.Next(1, 10) * num2; // Generowanie liczby podzielnej
                num1 = correctAnswer; // Ustawienie liczby podzielnej
                correctAnswer /= num2; // Obliczenie poprawnej odpowiedzi

                questionLabel.Text = $"Ile to jest {num1} ÷ {num2}?";
            }
            else
            {
                // Generowanie pytania z mnożenia
                num1 = random.Next(1, 10);
                num2 = random.Next(1, 10);
                correctAnswer = num1 * num2;

                questionLabel.Text = $"Ile to jest {num1} × {num2}?";
            }

            // Losowanie przycisków – jeden z poprawną, drugi z błędną odpowiedzią
            if (random.Next(2) == 0)
            {
                btnAnswer1.Text = correctAnswer.ToString();
                btnAnswer2.Text = (correctAnswer + random.Next(1, 10)).ToString(); // Błędna odpowiedź
            }
            else
            {
                btnAnswer2.Text = correctAnswer.ToString();
                btnAnswer1.Text = (correctAnswer + random.Next(1, 10)).ToString(); // Błędna odpowiedź
            }



        }




        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnAnswer1.Text);
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnAnswer2.Text);
        }
        private void CheckAnswer(string answer)
        {
            if (answer == correctAnswer.ToString())
            {
                isCorrect = true;
                MessageBox.Show("Poprawna odpowiedź!", "Brawo");
            }
            else
            {
                isCorrect = false;
                MessageBox.Show("Błędna odpowiedź! Gra zostanie zresetowana", "Spróbuj ponownie");

            }

            isDivision = !isDivision;

            this.Close(); // Zamknięcie okna po udzieleniu odpowiedzi
        }
    }
}
