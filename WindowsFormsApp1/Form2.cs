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
        int weaponsfound = 0;
        int armourfound = 10;
        int lives = 3;

        public Form2()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // first box 1ST WEAPON
            pictureBox1.Image = Properties.Resources.bebcae4035dd853fea00368f46538ec1;
            weaponsfound = weaponsfound + 1;
            if (weaponsfound == 1)
            {
                MessageBox.Show("You have found your first weapon! You obtained a Swift Slayer +10 Points. This is an essential weapon, find 3 more to level up your overall!");
            }
            else if (weaponsfound == 2)
            {
                MessageBox.Show("You have found your second weapon! You obtained a Swift Slayer +10 Points. This is an essential weapon, find 2 more to level up your overall!");
            }
            else if (weaponsfound == 3)
            {
                MessageBox.Show("You have found your third weapon! You obtained a Swift Slayer +10 Points. This is an essential weapon, find 1 more to level up your overall!");
            }
            else if (weaponsfound == 4)
            {
                MessageBox.Show("W! Congrats, you are now an equipped Assassin! You obtained a Swift Slayer. This is an essential weapon for battles, that's why their is no designated level for it. Hope to See you on the field soon Assassin!");
                Application.Exit();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            // second box ENEEMY
            pictureBox2.Image = Properties.Resources.brute;
            pictureBox10.Visible = false;
            lives = lives - 1;
            if (pictureBox10.Visible == false && lives ==2)
            {
                MessageBox.Show("You have hit a brute enemey! - 1 Life... BE CAREFUL YOUNG ASSASSIN, you have two more lives...");
            }
            else if (pictureBox10.Visible == false && lives == 1)
            {
                MessageBox.Show("You have hit a brute enemey! - 1 Life... HANG IN THERE! You have one more life left...");
            }
            else if (pictureBox10.Visible == false && lives == 0)
            {
                MessageBox.Show("You have hit a brute enemey! You Lost... You failed me young assassin...");
                Application.Exit();
            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // third box 2ND WEAPON
            pictureBox3.Image = Properties.Resources._956786e336963eb14405e52bf535408b;
            weaponsfound = weaponsfound + 1;
            if (weaponsfound == 1)
            {
                MessageBox.Show("You have found your very first weapon! You have obtained Nikolaos's Sword! +10 Points, your Weapon is level 10, find 3 more to level up your overall!");
            }
            else if (weaponsfound == 2)
            {
                MessageBox.Show("You have found your second weapon! You have obtained Nikolaos's Sword! +10 Points, your Weapon is level 10, find 2 more to level up your overall!");
            }
            else if (weaponsfound == 3)
            {
                MessageBox.Show("You have found your third weapon! You have obtained Nikolaos's Sword! +10 Points, your Weapon is level 10, find 1 more to level up your overall!");
            }
            else if (weaponsfound == 4)
            {
                MessageBox.Show("W! Congrats, you are now an equipped Assassin! You obtained Nikolaos's Sword. This Sword can do a lot of damage to enemies (+275%)! Hope to See you on the field soon Assassin!");
                Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // fourth box THIRD WEAPON
            pictureBox4.Image = Properties.Resources._83e24cdf4e16d78ab312689945e0922c;
            weaponsfound = weaponsfound + 1;
            if (weaponsfound == 1)
            {
                MessageBox.Show("You have found your very first weapon! You have obtained the Legendary Drinker of Light! +23 Points, your Weapon is level 23, find 3 more to level up your overall!");
            }
            else if (weaponsfound == 2)
            {
                MessageBox.Show("You have found your second weapon! You have obtained the Legendary Drinker of Light! +23 Points, your Weapon is level 23, find 2 more to level up your overall!");
            }
            else if (weaponsfound == 3)
            {
                MessageBox.Show("You have found your third weapon! You have obtained the Legendary Drinker of Light! +23 Points, your Weapon is level 23, find 1 more to level up your overall!");
            }
            else if (weaponsfound == 4)
            {
                MessageBox.Show("W! Congrats, you are now an equipped Assassin! You obtained The Legendary Drinker of Light. This is a heavy bladed weapon that Assassins like you need! Hope to See you on the field soon Assassin!");
                Application.Exit();
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            // fifth box FOURTH WEAPON
            pictureBox5.Image = Properties.Resources._99f9eeafd86b05c597a1ef3ee61d3c21__1_;
            weaponsfound = weaponsfound + 1;
            if (weaponsfound == 1)
            {
                MessageBox.Show("You have found your very first weapon! You have obtained the Worship Sword! +26 Points, your Weapon is level 26, find 3 more to level up your overall!");
            }
            else if (weaponsfound == 2)
            {
                MessageBox.Show("You have found your second weapon! You have obtained the Worship Sword! +26 Points, your Weapon is level 26, find 2 more to level up your overall!");
            }
            else if (weaponsfound == 3)
            {
                MessageBox.Show("You have found your third weapon! You have obtained the Worship Sword! +26 Points, your Weapon is level 26, find 1 more to level up your overall!");
            }
            else if (weaponsfound == 4)
            {
                MessageBox.Show("W! Congrats, you are now an equipped Assassin! You the Worship Sword! +26 Points, your Weapon is level 26. This Sword can conquer all of the world! Hope to See you on the field soon Assassin!");
                Application.Exit();
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            // 6ixth box 1ST ARMOUR
            pictureBox6.Image = Properties.Resources.bbd22d3eed8a78e10c683ebc79eb317c;
            armourfound = armourfound + 1;
            if (armourfound == 11)
            {
                MessageBox.Show("You have found your very first piece of armour! You have obtained the The Wolf's Helm! +10 Points, your Armour is level 10, find more to level up! One More to go!");
            }
            else if (armourfound == 12)
            {
                MessageBox.Show("You have obtained The rare Wolf's Helm! You have found all the armour!");
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // 7th box HOT ENEMY
            pictureBox7.Image = Properties.Resources.cleopatra;
            pictureBox11.Visible = false;
            lives = lives - 1;
            if (pictureBox11.Visible == false && lives == 2)
            {
                MessageBox.Show("You have attacked Queen Nefertiti! -1 Life, stay strong young Assassin. You have two more lives...");
            }
            else if (pictureBox11.Visible == false && lives == 1)
            {
                MessageBox.Show("You have attacked Queen Nefertiti! -1 Life, Hang in there Young Assassin. You have one more life left... ");
            }
            else if (pictureBox11.Visible == false && lives == 0)
            {
                MessageBox.Show("You have attacked Queen Nefertiti! You Lost... You failed me young assassin...");
                Application.Exit();

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // 8th box LAST PIECE OF ARMOUR
            pictureBox8.Image = Properties.Resources.eaaf917e116f1058aefe5ce3f7e4f8cb;
            armourfound = armourfound + 1;
            if (armourfound == 11)
            {
                MessageBox.Show("You have found your very first piece of armour! You have obtained the The Mercenary Hood! +24 Points, your Armour is level 24, The next Armour piece is level 10, one more to find!");
            }
            else if (armourfound == 12)
            {
                MessageBox.Show("You have obtained The Mercenary Hood!! You have found all the armour!");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // 9th box LAST ENEMEY
            pictureBox9.Image = Properties.Resources._484066907_preview_Seeker;
            pictureBox12.Visible = false;
            lives = lives - 1;
            if (pictureBox12.Visible == false && lives == 2)
            {
                MessageBox.Show("You have attacked a Gate Keeper Guard! -1 Life, stay strong young Assassin. You have two more lives...");
            }
            else if (pictureBox12.Visible == false && lives == 1)
            {
                MessageBox.Show("You have attacked a Gate Keeper Guard! -1 Life, Hang in there Young Assassin. You have one more life left... ");
            }
            else if (pictureBox12.Visible == false && lives == 0)
            {
                MessageBox.Show("You have attacked a Gate Keeper Guard! You Lost... You failed me young assassin...");
                Application.Exit();
            }
        }
        }
    }
    
 

