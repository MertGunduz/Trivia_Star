using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Trivia_Star.Properties;

namespace Trivia_Star
{
    public partial class PlayScree_Form : Form
    {

        SoundPlayer soundPlayer = new SoundPlayer();
        int timerInteger = 30;
        int points = 0;
        int question = 1;

        public PlayScree_Form()
        {
            InitializeComponent();
        }

        private void PlayScree_Form_Load(object sender, EventArgs e)
        {
            soundPlayer.Stream = Resources.playScreen_music;
            soundPlayer.Play();
        }

        private void StartButtonPanel_Click(object sender, EventArgs e)
        {
            ReadyToStartPanel.Visible = false;
            timer60Counter.Start();
            Questions(question, BlueButton, GreenButton, RedButton, YellowButton, pictureBox1, QuestionLabel);
        }

        private void BackButtonPanel_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            WelcomeScreen_Form welcomeScreen_Form = new WelcomeScreen_Form();
            this.Hide();
            welcomeScreen_Form.Show();
        }

        private void timer60Counter_Tick(object sender, EventArgs e)
        {
            timerInteger--;
            TimerLabel.Text = timerInteger.ToString();

            if (timerInteger == 0 || points == 100)
            {
                timer60Counter.Stop();

                if (points == 100)
                {
                    MessageBox.Show("Game Finished!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    soundPlayer.Stop();
                    WellDoneScreen_Form wellDoneScreen_Form = new WellDoneScreen_Form();
                    this.Hide();
                    wellDoneScreen_Form.Show();
                }
                else
                {
                    MessageBox.Show("Time Up!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    soundPlayer.Stop();
                    GameOverScreen_Form gameOverScreen_Form = new GameOverScreen_Form();
                    this.Hide();
                    gameOverScreen_Form.Show();
                }
            }
        }

        private void RedButton_Click(object sender, EventArgs e)
        {

            if (question == 4 || question == 7 || question == 8)
            {
                points = points + 10;
                PointsLabel.Text = points.ToString();
                LabelAnswer.Text = "Correct!";
            }
            else
            {
                LabelAnswer.Text = "Incorrect";
            }

            question++;
            Questions(question, BlueButton, GreenButton, RedButton, YellowButton, pictureBox1, QuestionLabel);

        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            if (question == 1 || question == 7)
            {
                points = points + 10;
                PointsLabel.Text = points.ToString();
                LabelAnswer.Text = "Correct!";
            }
            else
            {
                LabelAnswer.Text = "Incorrect";
            }

            question++;
            Questions(question, BlueButton, GreenButton, RedButton, YellowButton, pictureBox1, QuestionLabel);
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            if (question == 2 || question == 5 || question == 9)
            {
                points = points + 10;
                PointsLabel.Text = points.ToString();
                LabelAnswer.Text = "Correct!";
            }
            else
            {
                LabelAnswer.Text = "Incorrect";
            }

            question++;
            Questions(question, BlueButton, GreenButton, RedButton, YellowButton, pictureBox1, QuestionLabel);
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            if (question == 3 || question == 6 || question == 10)
            {
                points = points + 10;
                PointsLabel.Text = points.ToString();
                LabelAnswer.Text = "Correct!";
            }
            else
            {
                LabelAnswer.Text = "Incorrect";
            }

            question++;
            Questions(question, BlueButton, GreenButton, RedButton, YellowButton, pictureBox1, QuestionLabel);
        }

        private void Questions(int questionNumber, Button firstButton, Button secondButton, Button thirdButton, Button fourthButton, PictureBox questionPictureBox, Label questionLabel)
        {
            switch (questionNumber)
            {
                case 1:
                    questionPictureBox.Image = Resources.question1;
                    questionLabel.Text = "What country won the very first \nFIFA World Cup in 1930?";
                    firstButton.Text = "Uruguay";
                    secondButton.Text = "Brazil";
                    thirdButton.Text = "France";
                    fourthButton.Text = "Germany";
                    break;
                case 2:
                    questionPictureBox.Image = Resources.question2;
                    questionLabel.Text = "What does “HTTP” stand for?";
                    firstButton.Text = "HyperTransmission Text Protocol";
                    secondButton.Text = "HyperTransfer Text Proxy";
                    thirdButton.Text = "HyperText Transmission Proxy";
                    fourthButton.Text = "HyperText Transfer Protocol";
                    break;
                case 3:
                    questionPictureBox.Image = Resources.question3;
                    questionLabel.Text = "What is often seen as the smallest\n unit of memory?";
                    firstButton.Text = "Megabyte";
                    secondButton.Text = "Kilobyte";
                    thirdButton.Text = "Terabyte";
                    fourthButton.Text = "Gigabyte";
                    break;
                case 4:
                    questionPictureBox.Image = Resources.question4;
                    questionLabel.Text = "Who discovered penicillin?";
                    firstButton.Text = "Nelson Mandela";
                    secondButton.Text = "Albert Einstein";
                    thirdButton.Text = "Alexander Fleming";
                    fourthButton.Text = "Marie Curie";
                    break;
                case 5:
                    questionPictureBox.Image = Resources.question5;
                    questionLabel.Text = "Which planet is the hottest in\n the solar system?";
                    firstButton.Text = "Jupiter";
                    secondButton.Text = "Neptune";
                    thirdButton.Text = "Mars";
                    fourthButton.Text = "Venus";
                    break;
                case 6:
                    questionPictureBox.Image = Resources.question6;
                    questionLabel.Text = "Which animal can be seen on\n the Porsche logo?";
                    firstButton.Text = "Kangaroo";
                    secondButton.Text = "Horse";
                    thirdButton.Text = "Cheetah";
                    fourthButton.Text = "Lion";
                    break;
                case 7:
                    questionPictureBox.Image = Resources.question7;
                    questionLabel.Text = "What’s the primary ingredient\n in hummus?";
                    firstButton.Text = "Chickpeas";
                    secondButton.Text = "Basil";
                    thirdButton.Text = "Cashews";
                    fourthButton.Text = "Mushrooms";
                    break;
                case 8:
                    questionPictureBox.Image = Resources.question8;
                    questionLabel.Text = "Which country produces the most\n coffee in the world?";
                    firstButton.Text = "South America";
                    secondButton.Text = "Columbia";
                    thirdButton.Text = "Brazil";
                    fourthButton.Text = "India";
                    break;
                case 9:
                    questionPictureBox.Image = Resources.question9;
                    questionLabel.Text = "Which human organ has \nfour chambers?";
                    firstButton.Text = "Kidney";
                    secondButton.Text = "Lungs";
                    thirdButton.Text = "Stomach";
                    fourthButton.Text = "Heart";
                    break;
                case 10:
                    questionPictureBox.Image = Resources.question10;
                    questionLabel.Text = "What percentage of our bodies is\n made up of water?";
                    firstButton.Text = "40 – 45%";
                    secondButton.Text = "60 – 65%";
                    thirdButton.Text = "80 – 85%";
                    fourthButton.Text = "90% +";
                    break;
            }
        }
    }
}
