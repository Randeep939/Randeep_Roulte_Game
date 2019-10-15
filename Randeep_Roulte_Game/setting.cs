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
    public partial class setting : Form
    {
        Random rd = new Random();

        public setting()
        {
            InitializeComponent();
        }
        // method to generate the shoot 
        public int gen() {
            return rd.Next(1, 4);
        }
        //method to generate the shoot away trigger 
        public int gen2()
        {
            return rd.Next(3, 6);
        }
        //method to generate the sound 
        public void sound() {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Randeep_Roulte_Game.Properties.Resources.rfire);
            obj.Play();
        }

        private void setting_Load(object sender, EventArgs e)
        {

        }
    }
}
