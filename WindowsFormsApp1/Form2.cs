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
            pictureBox1.Image = Properties.Resources.bebcae4035dd853fea00368f46538ec1;
            upgrades = upgrades + 10;
            if (upgrades == 10)
            {
                MessageBox.Show("You have found the first weapon! You obtained a Swift Slayer +10 Points, your Weapon is level one, find more to level up!");
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            // second box
            pictureBox2.Image = Properties.Resources.enemy1;
            upgrades = upgrades - 10;
            if (upgrades <= 0)
            {
                MessageBox.Show("You have hit a crossbowman enemey! -10 Points, It takes time to be an Assassin, you have two more lives...");
            }
        }

 

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // third box
            pictureBox3.Image = Properties.Resources._956786e336963eb14405e52bf535408b;
            upgrades = upgrades + 10;
            if (upgrades >= 0)
            {
                MessageBox.Show("You have found the second weapon! You have obtained Nikolaos's Sword! +10 Points, your Weapon is level 10, find more to level up!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // fourth box
            pictureBox4.Image = Properties.Resources._83e24cdf4e16d78ab312689945e0922c;
            upgrades = upgrades + 10;
            if (upgrades >= -50)
            {
                MessageBox.Show("You have found the third weapon! You have obtained the Legendary Drinker of Light! +23 Points, your Weapon is level 23, find more to level up!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // fifth box
            pictureBox5.Image = Properties.Resources._99f9eeafd86b05c597a1ef3ee61d3c21__1_1;
            upgrades = upgrades + 10;
            if (upgrades >= -50)
            {
                MessageBox.Show("You have found the fourth weapon! You have obtained the Worship Sword! +23 Points, your Weapon is level 23, find more to level up!");
            }
        }
    }
    }
 

