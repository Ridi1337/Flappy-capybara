using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {

        int PipeSpeed = 8;
        int Gravity = 15;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEven(object sender, EventArgs e)
        {
            Capybara.Top += Gravity;
            PipeBottom.Left -= PipeSpeed;
            PipeTop.Left -= PipeSpeed;
            ScoreText.Text = "Score: " + score;

            if(PipeBottom.Left < -85)
            {
                PipeBottom.Left = 775;
                score++;
            }
            if(PipeTop.Left < -80)
            {
                PipeTop.Left = 850;
                score++;
            }

            if (Capybara.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                    Capybara.Bounds.IntersectsWith(PipeTop.Bounds) ||
                    Capybara.Bounds.IntersectsWith(Ground.Bounds) || Capybara.Top < -25
                )
            {
                endGame();
            }    
        }

        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = -15;
            }
        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = 15;
            }
        }

        private void endGame()
        {
            GameTimer.Stop();
            ScoreText.Text += "Game over.";
        }
    }
}
