using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Pianist
{
    public partial class VirtualPianist : Form
    {

        // this will initialize the program
        public VirtualPianist()
        {
            InitializeComponent();
        }

        // this will create play method
        public void Play(string notePath)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(notePath);
            player.Play();

                }

        // if the user clicks the c key, the c note will play
        private void keyC_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C.wav");

        }

        // if the user clicks the d key, the d note will play
        private void keyD_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\D.wav");
        }

        // if the user clicks the E key, the E note will play
        private void keyE_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\E.wav");
        }

        // if the user clicks the F key, the F note will play
        private void keyF_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\F.wav");
        }

        // if the user clicks the G key, the G note will play
        private void keyG_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\G.wav");
        }

        // if the user clicks the A key, the A note will play
        private void keyA_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\A.wav");
        }

        // if the user clicks the B key, the B note will play
        private void keyB_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\B.wav");
        }


        // if the user clicks the c1 key, the c1 note will play
        private void keyC1_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C1.wav");
        }

        // if the user clicks the D1 key, the D1 note will play
        private void keyD1_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\D1.wav");
        }

        // if the user clicks the E1 key, the E1 note will play
        private void keyE1_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\E1.wav");
        }

        // if the user clicks the F1 key, the F1 note will play
        private void keyF1_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\F1.wav");
        }

        // if the user clicks the c# key, the c# note will play
        private void keyCsharp_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s.wav");
        }
        // if the user clicks the D# key, the D# note will play
        private void keyDsharp_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\D_s.wav");
        }

        // if the user clicks the F# key, the f# note will play
        private void keyFsharp_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\F_s.wav");
        }

        // if the user clicks the G# key, the G# note will play
        private void keyGsharp_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\G_s.wav");
        }

        // if the user clicks the Bb key, the Bb note will play
        private void keyBb_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\Bb.wav");
        }

        // if the user clicks the c#1 key, the c#1 note will play
        private void keyCsharp1_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s1.wav");
        }

        // if the user clicks the d#1 key, the d#1 note will play
        private void keyDsharp1_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\D_s1.wav");
        }

        // this button will show the tutorial mode screen
        private void button2_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s1.wav");
            TutorialScreen tutScreen = new TutorialScreen();
            this.Hide();
            tutScreen.Show();
        }

        // this button will show the main menu screen
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainM = new MainMenu();
            this.Hide();
            mainM.Show();
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s1.wav");
        }
    }

}
