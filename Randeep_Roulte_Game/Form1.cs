using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randeep_Roulte_Game
{
    
    public partial class Form1 : Form
    {
        int fire = 0;
        int firewy = 0;
        int bullet = 0;
        int shoot = 0;
        setting obj = null;
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Randeep_Roulte_Game.Properties.Resources.bg;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //first button to start the game 
            pbphoto.Image = Randeep_Roulte_Game.Properties.Resources.r2;
            obj = new setting();
            obj.Visible=true;
            bullet = obj.gen();
            button2.Enabled = true;
            button1.Enabled = false;
            button6.Visible = false;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // spin the bullet 
                button5.Enabled = true;
                button2.Enabled = false;
                pbphoto.Image = Randeep_Roulte_Game.Properties.Resources.r3;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firewy++;
            shoot++;
            
            if(firewy == 2)
            {
                MessageBox.Show("you are going to die");
                button3.Enabled = false;
                button4.Enabled = false;

                button6.Visible = true;
                button6.Enabled = true;
            }
            else if (shoot==bullet) {
                MessageBox.Show("You Suvived");
                button3.Enabled =false;
                button4.Enabled = false;
               
                button6.Visible = true;
                button6.Enabled = true;

            }
            else
            {
                MessageBox.Show("try again");
            }

        }

        private void frstchance()
        {
            throw new NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // task to perform the following the task 
            
            pbphoto.Image = Randeep_Roulte_Game.Properties.Resources.maxresdefault;
            button3.Enabled = true;
            button4.Enabled = true;

            button5.Enabled = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // shoot button to work the following task 
            fire++;
            shoot++;
            obj.sound();

            if (fire == 4)
            {
                MessageBox.Show("you survived");
                button3.Enabled = false;
                button4.Enabled = false;

                button6.Visible = true;
                button6.Enabled = true;
            }
            else if (shoot == bullet)
            {
                MessageBox.Show("You die");
                button3.Enabled = false;
                button4.Enabled = false;

                button6.Visible = true;
                button6.Enabled = true;

            }
            else
            {
                MessageBox.Show("try again");
            }


        }
    }
}
