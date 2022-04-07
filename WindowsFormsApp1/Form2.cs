using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int upgrades = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // first box
            pictureBox1.BackgroundImage = Properties.Resources.bebcae4035dd853fea00368f46538ec1;
            upgrades = upgrades + 10;
            if(upgrades ==1)
            {
                MessageBox.Show("You have found the first weapon! +10 Points, your Weapon is level one, find more to level up!");
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            // second box
            pictureBox2.BackgroundImage = Properties.Resources.enemy1;
        }
    }
}
