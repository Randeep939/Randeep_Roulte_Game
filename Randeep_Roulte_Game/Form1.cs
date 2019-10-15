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
        int load = 0,sht=0,x=0,z=0,xx=0;
        setting obj = null;
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
            button2.Enabled = true;
            button1.Enabled = false;
            button6.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            load = 0; sht = 0; x = 0; z = 0; xx = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // spin the bullet 
            load++;
            if (load==1){
                button5.Enabled = true;
                button2.Enabled = false;
                pbphoto.Image = Randeep_Roulte_Game.Properties.Resources.r3;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // task to perform the shot away button 
            z++;
            if (z==1) {
                xx=obj.gen2();     
            }
            if (xx==z) {
                obj.sound();
            }
            if (z==6) {
                button3.Enabled = false;
                MessageBox.Show("Game is Over ");
                button6.Visible = true;
                button6.Enabled = true;

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // task to perform the following the task 
            load++;
            if (load==2) {
                pbphoto.Image = Randeep_Roulte_Game.Properties.Resources.maxresdefault;
                button3.Enabled = true;
                button4.Enabled = true;

                button5.Enabled = false;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // shoot button to work the following task 
            sht++;

            if (sht==1) {
                x = obj.gen();
            }

            if (x==sht) {
                obj.sound();
            }

            if (sht==6) {

                MessageBox.Show("first chance  is Over ");
                button4.Enabled = false;

            }


        }
    }
}
