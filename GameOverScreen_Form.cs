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
    public partial class GameOverScreen_Form : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer();

        public GameOverScreen_Form()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Form_Load(object sender, EventArgs e)
        {
            soundPlayer.Stream = Resources.Gameovermusic;
            soundPlayer.Play();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            WelcomeScreen_Form welcomeScreen_Form = new WelcomeScreen_Form();
            this.Hide();
            welcomeScreen_Form.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
