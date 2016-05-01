using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Learning
{
    public partial class Form5 : Form
    {
        // Random numbers
        public static Random rand1 = new Random();
        public static int  pos = rand1.Next(0,19);
        public static Random rand2 = new Random();

        // 
        public static int[] arrayOfInt = { 28, 29, 32, 39, 35, 35, 28, 29, 30, 32 ,31,30,33,36,37,28,29,34,36,37,30,33,32,35,36,29,30,31 };
        public static int counter = 1;
        public static bool flag = true;

        public Form5()
        {
            InitializeComponent();

            // Picture trasparent
            pictureBox9.Parent = pictureBox1;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.Parent = pictureBox1;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.Parent = pictureBox1;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox1;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.Parent = pictureBox1;
            pictureBox5.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;


            pictureBox5.Click += new EventHandler(Form5_Load);


        }



        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "أهلا و سهلا بك يا " + Class1.name;

            if (counter < 28)
            {
                while (flag)
                {
                    if (arrayOfInt.Contains(pos))
                    {
                        pos = rand2.Next(0, 27);
                    }
                    else
                    {
                        flag = false;
                    }
                }
                arrayOfInt[counter] = pos;
                counter++;
                flag = true;
                switch (pos)
                {
                    case 0:
                        pictureBox4.Image = Learning.Properties.Resources.L1;
                        break;
                    case 1:
                        pictureBox4.Image = Learning.Properties.Resources.L2;
                        break;
                    case 2:
                        pictureBox4.Image = Learning.Properties.Resources.L3;
                        break;
                    case 3:
                        pictureBox4.Image = Learning.Properties.Resources.L4;
                        break;
                    case 4:
                        pictureBox4.Image = Learning.Properties.Resources.L5;
                        break;
                    case 5:
                        pictureBox4.Image = Learning.Properties.Resources.L6;
                        
                        break;
                    case 6:
                        pictureBox4.Image = Learning.Properties.Resources.L7;
                        break;
                    case 7:
                        pictureBox4.Image = Learning.Properties.Resources.L8;
                        break;
                    case 8:
                        pictureBox4.Image = Learning.Properties.Resources.L9;
                        break;
                    case 9:
                        pictureBox4.Image = Learning.Properties.Resources.L10;
                        break;
                    case 10:
                        pictureBox4.Image = Learning.Properties.Resources.L101;
                        break;
                    case 11:
                        pictureBox4.Image = Learning.Properties.Resources.L11;
                        break;
                    case 12:
                        pictureBox4.Image = Learning.Properties.Resources.L12;
                        break;
                    case 13:
                        pictureBox4.Image = Learning.Properties.Resources.L13;
                        break;
                    case 14:
                        pictureBox4.Image = Learning.Properties.Resources.L14;
                        break;
                    case 15:
                        pictureBox4.Image = Learning.Properties.Resources.L15;
                        
                        break;
                    case 16:
                        pictureBox4.Image = Learning.Properties.Resources.L16;
                        break;
                    case 17:
                        pictureBox4.Image = Learning.Properties.Resources.L17;
                        break;
                    case 18:
                        pictureBox4.Image = Learning.Properties.Resources.L18;
                        break;
                    case 19:
                        pictureBox4.Image = Learning.Properties.Resources.L19;
                        break;
                    case 20:
                        pictureBox4.Image = Learning.Properties.Resources.L20;
                        break;
                    case 21:
                        pictureBox4.Image = Learning.Properties.Resources.L21;
                        break;
                    case 22:
                        pictureBox4.Image = Learning.Properties.Resources.L22;
                        break;
                    case 23:
                        pictureBox4.Image = Learning.Properties.Resources.L23;
                        break;
                    case 24:
                        pictureBox4.Image = Learning.Properties.Resources.L24;
                        break;
                    case 25:
                        pictureBox4.Image = Learning.Properties.Resources.L25;
                        
                        break;
                    case 26:
                        pictureBox4.Image = Learning.Properties.Resources.L26;
                        break;
                    case 27:
                        pictureBox4.Image = Learning.Properties.Resources.L27;
                        break;
                    case 28:
                        pictureBox4.Image = Learning.Properties.Resources.L28;
                        break;

                }
            }
           
           
        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

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
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
