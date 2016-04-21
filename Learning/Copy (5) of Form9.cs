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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox1;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox6.Parent = pictureBox1;
            pictureBox6.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;



        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 page1 = new Form1();
            page1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form10 page4 = new Form10();
            page4.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
