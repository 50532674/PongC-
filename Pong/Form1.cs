using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Pong : Form
    {

        // Location Varibles
        int cpuDirection = 5;
        int ballXcoordinate = 5;
        int ballYcoordinate = 5;

        // Score Variables
        int playerScore = 0;
        int cpuScore = 0;

        //Size Variables 
        int bottomBondary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        // Detection Variables
        bool playerDetectedup;
        bool playerDetecteddown;

        // Special Keys
        int spaceBarClicked = 0;

        public Pong()
        {
            InitializeComponent();
            bottomBondary = ClientSize.Height - player1.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;

        }


        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            // Adjust where the ball is
            pongBall.Top -= ballYcoordinate;
            pongBall.Left -= ballXcoordinate;
            // Make the CPU move
            cpuPlayer.Top += cpuDirection;
            // Check if cpu has reached the top or the bottom
            if (cpuPlayer.Top < 0 || cpuPlayer.Top > bottomBondary)
            {
                cpuDirection = -cpuDirection;
            }
            // Check if the ball has exited the left side of the screen
            if (pongBall.Left < 0)
            {
                pongBall.Left = xMidpoint;
                pongBall.Top = newSpot;
                ballXcoordinate = -ballXcoordinate;
                cpuScore++;
                cpuScoreLabel.Text = cpuScore.ToString();
            }

            // Check if the ball has exited the right side of the screen
            if (pongBall.Left + pongBall.Width > ClientSize.Width)
            {
                pongBall.Left = xMidpoint;
                pongBall.Top = newSpot;
                ballXcoordinate = -ballXcoordinate;
                playerScore++;
                playerScore_Label.Text = playerScore.ToString();


            }
            // Ensure the ball is within the boundaries of the screen

            if (pongBall.Top < 0 || pongBall.Top + pongBall.Height > ClientSize.Height)
            {
                ballYcoordinate = -ballYcoordinate;
            }

            // Check if the ball hits the player or CPU paddle
            if (pongBall.Bounds.IntersectsWith(player1.Bounds) || pongBall.Bounds.IntersectsWith(cpuPlayer.Bounds))
            {
                // Send ball opposite direction
                ballXcoordinate = -ballXcoordinate;
            }


            // Move player up
            if (playerDetectedup == true && player1.Top > 0) 
            { 
                player1.Top -= 10; 
            }
            // Move player down
            if (playerDetecteddown == true && player1.Top < bottomBondary) 
            {
                player1.Top += 10;
            }
            // Check for winner
            if (playerScore >= 10) 
            { 
                pongTimer.Stop(); 
            }

        }

        private void playerScoreLabel_Click(object sender, EventArgs e)
        {


        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Up) 
            {
                playerDetectedup = true;
            }
            // If player presses the down arrow, move paddle downwards
            if (e.KeyCode == Keys.Down) 
            { 
                playerDetecteddown = true; 
            }

            // if player presses spacebar then pause game. 
            if (e.KeyCode == Keys.Space)
            {
                if(spaceBarClicked % 2 == 0)
                {
                    pongTimer.Stop();
                }
                else
                    pongTimer.Start();
            }

            spaceBarClicked++;
        }
        
        

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            // if player presses the up arrow move paddle upwards
            {
                if (e.KeyCode == Keys.Up) { playerDetectedup = false; }
                if (e.KeyCode == Keys.Down) { playerDetecteddown = false; }
            }

        }
    }
}
