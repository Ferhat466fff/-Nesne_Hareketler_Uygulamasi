using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Hareketler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 75;
            if (pictureBox1.Top <= 23)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 75;
            if (pictureBox1.Left >= 1108)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 75;
            if (pictureBox1.Top >= 617)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 50;
            if (pictureBox1.Left <= 305)
            {
                timer4.Stop();
                timer5.Start();


            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 30;
            if (pictureBox1.Top <= 121)
            {
                timer5.Stop();
                timer6.Start();


            }
        }
      
    private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 75;
            if (pictureBox1.Left >= 917)
            {
                timer6.Stop();
                timer7.Start();


            }
        }
      
    private void timer7_Tick(object sender, EventArgs e)
        {
            //pictureBox1.Top += 30;
            //if (pictureBox1.Top >= 917)
            //{
            //    timer7.Stop();
            //    timer8.Start();
            //}

            pictureBox1.Top += 75;
            if (pictureBox1.Top >= 488)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 50; // Bu satırı pictureBox1.Left += 30; olarak değiştirin
        }

    }
}
