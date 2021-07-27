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
    public partial class WelcomeScreen_Form : Form
    {
        public static SoundPlayer soundPlayer = new SoundPlayer();

        public WelcomeScreen_Form()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Form_Load(object sender, EventArgs e)
        {
            soundPlayer.Stream = Resources.IntroScreenmusic;
            soundPlayer.Play();
        }

        private void WelcomeScreen_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            MainMenuScreen_Form mainMenuScreen_Form = new MainMenuScreen_Form();
            this.Hide();
            mainMenuScreen_Form.Show();
        }
    }
}
