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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
                main.Show();
                this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find & Build Your Own Weapons as an Assassin, Upgrade them by Clicking The Hidden Weapons and Armour. But Watch Out for the Enemies! They'll decrease your lives. YOU ONLY HAVE THREE LIVES! Be Wise Young Assassin. Everything is Permited...");
        }
    }
}
