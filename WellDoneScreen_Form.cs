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
    public partial class WellDoneScreen_Form : Form
    {

        SoundPlayer soundPlayer = new SoundPlayer();

        public WellDoneScreen_Form()
        {
            InitializeComponent();
        }

        private void WellDoneScreen_Form_Load(object sender, EventArgs e)
        {
            soundPlayer.Stream = Resources.Well_done_music;
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

        private void BackButtonPlayerDetails_Click(object sender, EventArgs e)
        {
            PlayerDetailsPanel.Visible = false;
        }

        private void SubmitButtonPlayerDetails_Click(object sender, EventArgs e)
        {
            if (NameSurnameTextBox.Text == "")
            {
                errorProvider1.SetError(NameSurnameTextBox, "Please Fill!");
            }
            else
            {
                errorProvider1.Clear();
                MessageBox.Show("Information Submitted Succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PlayerDetailsButton_Click(object sender, EventArgs e)
        {
            PlayerDetailsPanel.Visible = true;
        }
    }
}
