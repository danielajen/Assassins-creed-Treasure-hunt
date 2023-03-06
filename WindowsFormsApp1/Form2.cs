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
        int points = 0;
        string[] newpics = { "Win", "Win", "Win", "Lose", "Lose", "Lose", "Lose", "Lose", "Lose", "Lose", "Lose", "Lose", "Lose", "Lose", "Lose", "Lose" };
        string[] mix = new string[16];
        int ctr = 0;
        Random box = new Random();
        public Form2()
        {
            InitializeComponent();
            ;
        }

        void allweaponsfound()
        {
            weaponsfound = weaponsfound + 1;
            points = points + 10;
            if (weaponsfound == 1 && points == 10)
            {
                MessageBox.Show("You have found your very first weapon! You have obtained the Legendary Drinker of Light! Your points are at 10! Your Weapon is level 23, find 3 more to level up your overall!");
                label2.Text = points.ToString();
            }
            else if (weaponsfound == 2 && points == 20)
            {
                MessageBox.Show("You have found your second weapon! You have obtained the Legendary Drinker of Light! Your points are now at 20! your Weapon is level 23, find 2 more to level up your overall!");
                label2.Text = points.ToString();
            }
            else if (weaponsfound == 3 && points == 30)
            {
                MessageBox.Show("You have found your third weapon! You have obtained the Legendary Drinker of Light! Your points are now at 30! your Weapon is level 23, find 1 more to level up your overall!");
                label2.Text = points.ToString();
            }
            else if (weaponsfound == 4 && points == 40)
            {
                MessageBox.Show("W! Congrats, you are now an equipped Assassin! You obtained The Legendary Drinker of Light. This is a heavy bladed weapon that Assassins like you need! Hope to See you on the field soon Assassin!");
                Application.Exit();
            }
        }

        void allenemy()
        {
            lives = lives - 1;
            if (p10.Visible == false && lives ==2)
            {
                MessageBox.Show("You have hit a brute enemey! - 1 Life... BE CAREFUL YOUNG ASSASSIN, you have two more lives...");
            }
            else if (p11.Visible == false && lives == 1)
            {
                MessageBox.Show("You have hit a brute enemey! - 1 Life... HANG IN THERE! You have one more life left...");
            }
            else if (p12.Visible == false && lives == 0)
            {
                MessageBox.Show("You have hit a brute enemey! You Lost... You failed me young assassin...");
                Application.Exit();
            }
        }



        void armour()
        {
            // 8th box LAST PIECE OF ARMOUR
            p08.Image = Properties.Resources.eaaf917e116f1058aefe5ce3f7e4f8cb;
            armourfound = armourfound + 1;
            if (armourfound == 11)
            {
                MessageBox.Show("You have found your very first piece of armour! You have obtained the The Mercenary Hood! Your Armour is level 24, The next Armour piece is level 10, find the last piece to level up your armour!");
                label2.Text = points.ToString();
            }
            else if (armourfound == 12)
            {
                MessageBox.Show("You have obtained The Mercenary Hood!! You have now found all the armour!");
                label2.Text = points.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Form2_Load_1(object sender, EventArgs e)
        { 
            while (ctr < mix.Length)
            {
                int num = box.Next(0, mix.Length);

                if (newpics[num] != "gone")
                {
                    mix[ctr] = newpics[num];
                    newpics[num] = "gone";
                    ctr++;
                }
            }
        }

        private void changestuff(object sender, EventArgs e)
        {
            PictureBox picked = (PictureBox)sender;
            char[] pic_name = picked.Name.ToCharArray();
            int num_in_name = int.Parse(pic_name[1].ToString() + pic_name[2]);
            switch (mix[num_in_name])
            {
                case "Lose":
                    picked.BackgroundImage = Properties.Resources.enemy1;
                    allenemy();
                    break;

                case "Win":
                    picked.BackgroundImage = Properties.Resources._83e24cdf4e16d78ab312689945e0922c;
                    allweaponsfound();
                    break;
                case "Armour":
                    picked.BackgroundImage = Properties.Resources.eaaf917e116f1058aefe5ce3f7e4f8cb;
                    armour();
                    break;

            }
        }
    }
    }
    
 

