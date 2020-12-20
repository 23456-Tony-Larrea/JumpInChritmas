using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; 
        int gravity = 15; 
        int score = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flapyBird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            covid1.Left -= pipeSpeed;
            covid2.Left -= pipeSpeed;
            covid3.Left -= pipeSpeed;
            covid4.Left -= pipeSpeed;
            Score.Text = "Puntaje : "+ score; 
            
            if (pipeDown.Left < -50)
            {
                pipeDown.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }
            if (covid1.Left < -180)
            {
                covid1.Left = 950;
                score++;
            }
            if (covid2.Left < -50)
            {
                covid2.Left = 800;
                score++;
            }
            if (covid3.Left < -180)
            {
                covid3.Left = 950;
                score++;
            }
            if (covid4.Left < -50)
            {
                covid4.Left = 800;
                score++;
            }
            if (flapyBird.Bounds.IntersectsWith(pipeDown.Bounds)|| flapyBird.Bounds.IntersectsWith(pipeTop.Bounds)|| flapyBird.Bounds.IntersectsWith(ground.Bounds)|| 
                flapyBird.Bounds.IntersectsWith(covid1.Bounds)|| flapyBird.Bounds.IntersectsWith(covid2.Bounds)|| flapyBird.Bounds.IntersectsWith(covid3.Bounds) || flapyBird.Bounds.IntersectsWith(covid4.Bounds) || flapyBird.Top < -25)
            {
                endGame();        
            }
            if (score >5)
            {
                pipeSpeed = 15;
            }
            
        }
        
        private void gamekeyisdown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Space)
            {
             
                gravity = - 15;
            }

        }

        private void gamekeyisup(object sender, KeyPressEventArgs e)
        {

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Space)
                {
                    
                    gravity = 15;
                }
            }
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }
        
        private void endGame()
        {
            gameTimer.Stop();
            Form5 juego4 = new Form5();
            juego4.Show();
            Score.Text += ","+"Perdiste !"; 
        }

      
    }
}
