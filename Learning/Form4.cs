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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox9.Parent = pictureBox1;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.Parent = pictureBox1;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.Parent = pictureBox1;
            pictureBox11.BackColor = Color.Transparent;
           label1.Parent = pictureBox1;
           label1.BackColor = Color.Transparent;
           label2.Parent = pictureBox1;
           label2.BackColor = Color.Transparent;
           label3.Parent = pictureBox1;
           label3.BackColor = Color.Transparent;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
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

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "أهلا و سهلا بك يا " + Class1.name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

      /*  private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }*/
    }
}

class Game
{
    public static int numOfc = 0;
    public static int numOfw = 0;
}
