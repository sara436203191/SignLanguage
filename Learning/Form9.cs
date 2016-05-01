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
using System.Media;

namespace Learning
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            pictureBox9.Parent = pictureBox1;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.Parent = pictureBox1;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox7.Parent = pictureBox1;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox6.Parent = pictureBox1;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox12.Parent = pictureBox1;
            pictureBox12.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;
            label10.Parent = pictureBox1;
            label10.BackColor = Color.Transparent;
            pictureBox3.Click += new EventHandler(AnswerMade);
            pictureBox4.Click += new EventHandler(AnswerMade);
            pictureBox5.Click += new EventHandler(AnswerMade);
            pictureBox8.Click += new EventHandler(AnswerMade);
            pictureBox9.Click += new EventHandler(AnswerMade);
            pictureBox10.Click += new EventHandler(AnswerMade);
            pictureBox11.Click += new EventHandler(AnswerMade);
            
        }
        int Count = 7;
        PictureBox CorrectOne;
        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Text = "أهلا و سهلا بك يا " + Class1.name;
            label9.Visible = false;
            label10.Visible = false;
            String[] pic = { "sat", "sun", "mon", "turs", "wed", "thu", "fri" };
            String[] ques = { "السبت", "الاحد", "الاثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة" };
            PictureBox[] picbox = { pictureBox3, pictureBox4, pictureBox5, pictureBox8, pictureBox9, pictureBox10, pictureBox11 };
            Random RandomClass = new Random();
            int q, CorrectPlace, Place1, Place2, Place3, Place4, Place5, Place6, pic1, pic2, pic3, pic4, pic5, pic6;

            q = RandomClass.Next(ques.Length);
            pic1 = RandomClass.Next(ques.Length);
            pic2 = RandomClass.Next(ques.Length);
            pic3 = RandomClass.Next(ques.Length);
            pic4 = RandomClass.Next(ques.Length);
            pic5 = RandomClass.Next(ques.Length);
            pic6 = RandomClass.Next(ques.Length);
            CorrectPlace = RandomClass.Next(picbox.Length);
            Place1 = RandomClass.Next(picbox.Length);
            Place2 = RandomClass.Next(picbox.Length);
            Place3 = RandomClass.Next(picbox.Length);
            Place4 = RandomClass.Next(picbox.Length);
            Place5 = RandomClass.Next(picbox.Length);
            Place6 = RandomClass.Next(picbox.Length);


            while (Place1 == CorrectPlace || Place1 == Place2 || Place1 == Place3 || Place1 == Place4 || Place1 == Place5 || Place1 == Place6)
            { Place1 = RandomClass.Next(picbox.Length); }
            while (Place2 == CorrectPlace || Place2 == Place1 || Place2 == Place3 || Place2 == Place4 || Place2 == Place5 || Place2 == Place6)
            { Place2 = RandomClass.Next(picbox.Length); }
            while (Place3 == CorrectPlace || Place3 == Place2 || Place3 == Place1 || Place3 == Place4 || Place3 == Place5 || Place3 == Place6)
            { Place3 = RandomClass.Next(picbox.Length); }
            while (Place4 == CorrectPlace || Place4 == Place2 || Place4 == Place3 || Place4 == Place1 || Place4 == Place5 || Place4 == Place6)
            { Place4 = RandomClass.Next(picbox.Length); }
            while (Place5 == CorrectPlace || Place5 == Place2 || Place5 == Place3 || Place5 == Place4 || Place5 == Place1 || Place5 == Place6)
            { Place5 = RandomClass.Next(picbox.Length); }
            while (Place6 == CorrectPlace || Place6 == Place2 || Place6 == Place3 || Place6 == Place4 || Place6 == Place5 || Place6 == Place1)
            { Place6 = RandomClass.Next(picbox.Length); }

            while (pic1 == q || pic1 == pic2 || pic1 == pic3 || pic1 == pic4 || pic1 == pic5 || pic1 == pic6)
            { pic1 = RandomClass.Next(pic.Length); }
            while (pic2 == q || pic2 == pic1 || pic2 == pic3 || pic2 == pic4 || pic2 == pic5 || pic2 == pic6)
            { pic2 = RandomClass.Next(pic.Length); }
            while (pic3 == q || pic3 == pic2 || pic3 == pic1 || pic3 == pic4 || pic3 == pic5 || pic3 == pic6)
            { pic3 = RandomClass.Next(pic.Length); }
            while (pic4 == q || pic4 == pic2 || pic4 == pic3 || pic4 == pic1 || pic4 == pic5 || pic4 == pic6)
            { pic4 = RandomClass.Next(pic.Length); }
            while (pic5 == q || pic5 == pic2 || pic5 == pic3 || pic5 == pic4 || pic5 == pic1 || pic5 == pic6)
            { pic5 = RandomClass.Next(pic.Length); }
            while (pic6 == q || pic6 == pic2 || pic6 == pic3 || pic6 == pic4 || pic6 == pic5 || pic6 == pic1)
            { pic6 = RandomClass.Next(pic.Length); }

            while (pic2 == pic1 || pic2 == pic3 || pic2 == pic4 || pic2 == pic5 || pic2 == pic6)
            { pic2 = RandomClass.Next(pic.Length); }
            while (pic3 == pic1 || pic3 == pic2 || pic3 == pic4 || pic3 == pic5 || pic3 == pic6)
            { pic3 = RandomClass.Next(pic.Length); }
            while (pic4 == pic1 || pic4 == pic2 || pic4 == pic3 || pic4 == pic5 || pic4 == pic6)
            { pic4 = RandomClass.Next(pic.Length); }
            while (pic5 == pic1 || pic5 == pic2 || pic5 == pic3 || pic5 == pic4 || pic5 == pic6)
            { pic5 = RandomClass.Next(pic.Length); }
            while (pic6 == pic1 || pic6 == pic2 || pic6 == pic3 || pic6 == pic4 || pic6 == pic5)
            { pic6 = RandomClass.Next(pic.Length); }


            label3.Text = ques[q];


            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream StreamCorrectImage = myAssembly.GetManifestResourceStream
           ("Learning.Resources." + pic[q] + ".png");
            picbox[CorrectPlace].Image = Image.FromStream(StreamCorrectImage);
            CorrectOne = picbox[CorrectPlace];

            Stream StreamImage1 = myAssembly.GetManifestResourceStream
          ("Learning.Resources." + pic[pic1] + ".png");
            picbox[Place1].Image = Image.FromStream(StreamImage1);

            Stream StreamImage2 = myAssembly.GetManifestResourceStream
         ("Learning.Resources." + pic[pic2] + ".png");
            picbox[Place2].Image = Image.FromStream(StreamImage2);

            Stream StreamImage3 = myAssembly.GetManifestResourceStream
         ("Learning.Resources." + pic[pic3] + ".png");
            picbox[Place3].Image = Image.FromStream(StreamImage3);

            Stream StreamImage4 = myAssembly.GetManifestResourceStream
         ("Learning.Resources." + pic[pic4] + ".png");
            picbox[Place4].Image = Image.FromStream(StreamImage4);

            Stream StreamImage5 = myAssembly.GetManifestResourceStream
         ("Learning.Resources." + pic[pic5] + ".png");
            picbox[Place5].Image = Image.FromStream(StreamImage5);

            Stream StreamImage6 = myAssembly.GetManifestResourceStream
         ("Learning.Resources." + pic[pic6] + ".png");
            picbox[Place6].Image = Image.FromStream(StreamImage6);


        }
        private void AnswerMade(object sender, EventArgs e)
        {

            PictureBox Choosed = (PictureBox)sender;


            if (Choosed == CorrectOne)
            {
                
                label9.Visible = true;
                Game.numOfc++;
                Count--;
                Form9_Load(sender, e);
               
            }

            else
            {

                label10.Visible = true;
                Game.numOfw++;
                
            }
            if (Count == 0)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                pictureBox12.Visible = true;
                label7.Text=Game.numOfw.ToString();
                label8.Text=Game.numOfc.ToString();
                Game.numOfw = 0;
                Game.numOfc = 0;
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

    }
}

