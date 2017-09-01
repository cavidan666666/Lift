using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label6.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label5.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Start();
            label4.BackColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer4.Start();
            label3.BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer5.Start();
            label2.BackColor = Color.Yellow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top > 429)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top < 348)
            {
                pictureBox1.Top += 5;

                if (pictureBox1.Top > 348)
                {
                    timer2.Stop();
                }
            }
            if (pictureBox1.Top >= 348)
            {
                pictureBox1.Top -= 5;
                if (pictureBox1.Top <= 352)
                {
                    timer2.Stop();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Top < 255)
            {
                pictureBox1.Top += 5;
                if(pictureBox1.Top > 255)
                {
                    timer3.Stop();
                }
            }

             if(pictureBox1.Top >= 255)

               {
                pictureBox1.Top -= 5;
                
                if(pictureBox1.Top <= 255)
                {
                    timer3.Stop();
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Top < 173)
            {
                pictureBox1.Top += 5;

                if(pictureBox1.Top > 173)
                {
                    timer4.Stop();
                }
            }
            if (pictureBox1.Top >= 173)
            {
                pictureBox1.Top -= 5;
                if(pictureBox1.Top <= 173)
                {
                    timer4.Stop();
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Top < 73)
            {
                pictureBox1.Top += 5;
                if(pictureBox1.Top > 73)
                {
                    timer5.Stop();
                }
            }
            if(pictureBox1.Top >= 73)
            {
                pictureBox1.Top -= 5;
                if(pictureBox1.Top <= 73)
                {
                    timer5.Stop();
                }
            }
        }
    }
}
