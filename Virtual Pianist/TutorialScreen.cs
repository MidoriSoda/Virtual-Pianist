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
    public partial class TutorialScreen : Form
    {

        // this will initialize the program
        public TutorialScreen()
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
        // the image will show the c note
        private void keyC_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C.wav");
            pB1.Image = Properties.Resources.c;
        }

        // if the user clicks the d key, the d note will play
        // the image will show the c note
        private void keyD_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\D.wav");
            pB1.Image = Properties.Resources.d;
        }

        // if the user clicks the E key, the E note will play
        // the image will show the e note
        private void keyE_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\E.wav");
            pB1.Image = Properties.Resources.e;
        }

        // if the user clicks the F key, the F note will play
        // the image will show the F note
        private void keyF_Click(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\F.wav");
            pB1.Image = Properties.Resources.f;
        }
        // if the user clicks the G key, the G note will play
        // the image will show the G note
        private void keyG_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\G.wav");
            pB1.Image = Properties.Resources.g;
        }

        // if the user clicks the A key, the A note will play
        // the image will show the A note

        private void keyA_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\A.wav");
            pB1.Image = Properties.Resources.a;
        }

        // if the user clicks the B key, the B note will play
        // the image will show the B note
        private void keyB_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\B.wav");
            pB1.Image = Properties.Resources.b;
        }

        // if the user clicks the C1 key, the C1 note will play
        // the image will show the C1 note
        private void keyC1_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C1.wav");
            pB1.Image = Properties.Resources.c1;
        }
        // if the user clicks the D1 key, the D1 note will play
        // the image will show the D1 note
        private void keyD1_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\D1.wav");
            pB1.Image = Properties.Resources.d1;
        }

        // if the user clicks the E1 key, the E1 note will play
        // the image will show the E1 note
        private void keyE1_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\E1.wav");
            pB1.Image = Properties.Resources.e1;
        }

        // if the user clicks the F1 key, the F1 note will play
        // the image will show the F1 note
        private void keyF1_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\F1.wav");
            pB1.Image = Properties.Resources.f1;
        }

        // if the user clicks the C# key, the C# note will play
        // the image will show the C# note
        private void keyCsharp_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s.wav");
            pB1.Image = Properties.Resources.cs;
        }
        // if the user clicks the D# key, the D# note will play
        // the image will show the D# note
        private void keyDsharp_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\D_s.wav");
            pB1.Image = Properties.Resources.ds;
        }

        // if the user clicks the F# key, the F# note will play
        // the image will show the F# note
        private void keyFsharp_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\F_s.wav");
            pB1.Image = Properties.Resources.fs;
        }
        // if the user clicks the G# key, the G# note will play
        // the image will show the G# note
        private void keyGsharp_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\G_s.wav");
            pB1.Image = Properties.Resources.gs;
        }
        // if the user clicks the Bb key, the Bb note will play
        // the image will show the Bb note
        private void keyBb_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\Bb.wav");
            pB1.Image = Properties.Resources.bb;
        }
        // if the user clicks the C#1 key, the C#1 note will play
        // the image will show the C#1 note
        private void keyCsharp1_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s1.wav");
            pB1.Image = Properties.Resources.cs1;
        }

        // if the user clicks the D#1 key, the D#1 note will play
        // the image will show the D#1 note
        private void keyDsharp1_Click_1(object sender, EventArgs e)
        {
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\D_s1.wav");
            pB1.Image = Properties.Resources.ds1;
        }
        // this button will show the main menu screen
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainM = new MainMenu();
            this.Hide();
            mainM.Show();
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s1.wav");
        }

        // this button will show the standard mode screen
        private void button2_Click(object sender, EventArgs e)
        {
            VirtualPianist stndrdScreen = new VirtualPianist();
            this.Hide();
            stndrdScreen.Show();
            Play(@"C:\Users\Andrei\Downloads\Virtual Pianist\Virtual Pianist\C_s1.wav");
        }
    }
}
