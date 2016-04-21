using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Learning
{
    public partial class Form0 : Form
    {
        

        public Form0()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox6.Parent = pictureBox1;
            pictureBox6.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            
         
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 page1 = new Form2();
            page1.Show();
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Class1.name = textBox1.Text;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
   
    }
}
