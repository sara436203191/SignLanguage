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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            pictureBox9.Parent = pictureBox1;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.Parent = pictureBox1;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.Parent = pictureBox1;
            pictureBox11.BackColor = Color.Transparent;
          
            pictureBox5.Parent = pictureBox1;
            pictureBox5.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form5 page2 = new Form5();
            page2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "أهلا و سهلا بك يا " + Class1.name;
        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
