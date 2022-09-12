using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Game_
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer beep = new SoundPlayer(Properties.Resources.A_Tone_His_Self_1266414414);
            SoundPlayer start = new SoundPlayer(Properties.Resources.Windows_95_Startup_Microsoft_2077254053);
            beep.Play();
            startButton1.FlatStyle = FlatStyle.Flat;
            startButton1.Visible = false;
            this.BackColor = Color.Blue;
            countDown1.Text = "3";
            Refresh();
            Thread.Sleep(1000);
            beep.Play();
            this.BackColor = Color.Red;
            countDown1.Text = "2";
            Refresh();
            Thread.Sleep(1000);
            beep.Play();
            this.BackColor = Color.Blue;
            countDown1.Text = "1";
            Refresh();
            Thread.Sleep(1000);
            this.BackColor = Color.Green;
            start.Play();
            countDown1.Text = "Go!";
            Refresh();
        }
    }
}
