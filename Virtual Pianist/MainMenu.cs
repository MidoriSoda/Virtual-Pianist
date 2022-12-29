using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Pianist
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // this will create the play method
        public void Play(string notePath)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(notePath);
            player.Play();

        }

        // this button will show the tutorial mode screen
        private void button2_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s1.wav");
            TutorialScreen tutScreen = new TutorialScreen();
            this.Hide();
            tutScreen.Show();
        }

        // this button will show the standard mode screen
        private void button1_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s1.wav");
            VirtualPianist stndrdScreen = new VirtualPianist();
            this.Hide();
            stndrdScreen.Show();
        }

        // this button will exit the program
        private void button3_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s1.wav");
            this.Hide();
        }
    }
}
