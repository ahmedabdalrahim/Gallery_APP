using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public int i = 1;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("E:\\private\\project\\1.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(i>=1 && i<=9)
            {
                i++;
                pictureBox1.Image = Image.FromFile("E:\\private\\project\\" +i+".jpg" );
            }
            else
            {
                i = 1;
                pictureBox1.Image = Image.FromFile("E:\\private\\project\\" +i+".jpg");
            }
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            if (i >= 2 && i <= 10)
            {
                i--;
                pictureBox1.Image = Image.FromFile("E:\\private\\project\\" + i + ".jpg");
            }
            else
            {
                i = 10;
                pictureBox1.Image = Image.FromFile("E:\\private\\project\\" + i + ".jpg");
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttom_slideshow_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i >= 1 && i <= 9)
            {
                i++;
                pictureBox1.Image = Image.FromFile("E:\\private\\project\\" + i + ".jpg");
            }
            else
            {
                i = 1;
                pictureBox1.Image = Image.FromFile("E:\\private\\project\\" + i + ".jpg");
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
