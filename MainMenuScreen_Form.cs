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
using Trivia_Star;
using System.Resources;

namespace Trivia_Star
{
    public partial class MainMenuScreen_Form : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer();

        public MainMenuScreen_Form()
        {
            InitializeComponent();
        }

        private void MainMenuScreen_Form_Load(object sender, EventArgs e)
        {
            soundPlayer.Stream = Resources.IntroScreenmusic;
        }

        private void BackButtonInstructions_Click(object sender, EventArgs e)
        {
            InstructionsPanel.Visible = false;
        }

        private void ExitButtonInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye, have a nice day!", "Goodbye!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void InstsructionsButton_Click(object sender, EventArgs e)
        {
            InstructionsPanel.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye, have a nice day!", "Goodbye!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            WelcomeScreen_Form.soundPlayer.Stop();
            PlayScree_Form playScree_Form = new PlayScree_Form();
            this.Hide();
            playScree_Form.Show();
        }
    }
}
