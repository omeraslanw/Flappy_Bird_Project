using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int score = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            scoreLbl.Text = "Score: " + score;
            birdPic.Top += 5;
            bottomPic.Left -= 8;
            topPic2.Left -= 8;
            topPic1.Left -= 8;
            groundPic.Left -= 8;
            //it changes the objects positions as long as the timer continues to working.

            if (bottomPic.Right < 0)
            {
                bottomPic.Left = 1050;
                score += 1;
            }
            if (topPic2.Right < 0)
            {
                topPic2.Left = 1050;
                score += 1;
            }
            if (topPic1.Right < 0)
            {
                topPic1.Left = 1050;
                score += 1;
            }
            if (groundPic.Left < 400)
            {
                groundPic.Left = 0;
            }
            //the ground and pipes moves frequently and score changes

            if (birdPic.Bounds.IntersectsWith(bottomPic.Bounds) || birdPic.Bounds.IntersectsWith(topPic1.Bounds)
                || birdPic.Bounds.IntersectsWith(topPic2.Bounds) || birdPic.Bounds.IntersectsWith(groundPic.Bounds)
                || birdPic.Top < 0)
            {
                timer1.Stop();
                panel1.Visible = true;
                scoreBoardLbl.Text = "Score: " + score;
            }
            //the game stops when the bird crashs the pipes, ground or top of the screen 

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                birdPic.Top -= 40;
            }
        }
        //vertical position of the bird rises by 40 units

        private void restartLbl_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Visible = false;
            score = 0;
            birdPic.Location = new Point(100, 200);
            topPic1.Left = 300;
            topPic2.Left = 815;
            bottomPic.Left = 615;
        }
        //the game starts from the begenning
    }
}

