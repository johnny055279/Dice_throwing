using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_throwing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random random = new Random();

        private Counter counter = new Counter();

        public int caseCount1, caseCount2;

        private int timerCount;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            caseCount1 = random.Next(1, 7);
            caseCount2 = random.Next(1, 7);

            if (timerCount < 10)
            {
                timerCount += 1;
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                timerCount = 0;
                button1.Enabled = true;
                Count();
            }

            switch (caseCount1)
            {
                case 1:
                    pictureBox1.ImageLocation = "img\\1.png";
                    break;

                case 2:
                    pictureBox1.ImageLocation = "img\\2.png";
                    break;

                case 3:
                    pictureBox1.ImageLocation = "img\\3.png";
                    break;

                case 4:
                    pictureBox1.ImageLocation = "img\\4.png";
                    break;

                case 5:
                    pictureBox1.ImageLocation = "img\\5.png";
                    break;

                case 6:
                    pictureBox1.ImageLocation = "img\\6.png";
                    break;
            }

            switch (caseCount2)
            {
                case 1:
                    pictureBox2.ImageLocation = "img\\1.png";
                    break;

                case 2:
                    pictureBox2.ImageLocation = "img\\2.png";
                    break;

                case 3:
                    pictureBox2.ImageLocation = "img\\3.png";
                    break;

                case 4:
                    pictureBox2.ImageLocation = "img\\4.png";
                    break;

                case 5:
                    pictureBox2.ImageLocation = "img\\5.png";
                    break;

                case 6:
                    pictureBox2.ImageLocation = "img\\6.png";
                    break;
            }
        }

        private void Count()
        {
            label1.Text = "擲骰點數為: " + counter.Sum(caseCount1, caseCount2).ToString();
        }
    }
}