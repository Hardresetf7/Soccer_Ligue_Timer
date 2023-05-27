using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taraftar_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int second = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\gs.MP3";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second = Convert.ToInt32(label1.Text);
            second++;
            label1.Text = second.ToString();

            if (checkBox1.Checked == true)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\gs.PNG";
                if (second % 10 == 0)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Red;
                }

                if (second % 10 == 5)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Yellow;
                }

            }

            if (checkBox2.Checked == true)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\fb.JPG";
                if (second % 10 ==0)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Blue;
                }

                if (second % 10 ==5)
                {
                    button1.BackColor = Color.Blue;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Blue;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Blue;
                    button8.BackColor = Color.Yellow;
                }
            }

            if (checkBox3.Checked == true)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\bjk.PNG";
                if (second % 10 ==0)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.White;
                    button6.BackColor = Color.Black;
                    button7.BackColor = Color.White;
                    button8.BackColor = Color.Black;
                }

                if (second % 10 == 5)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.Black;
                    button8.BackColor = Color.White;
                }

            }

            if (checkBox4.Checked == true)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\ts.PNG";
                if (second % 10 == 0)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Blue;
                }

                if (second % 10 == 5)
                {
                    button1.BackColor = Color.Blue;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Blue;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Blue;
                    button8.BackColor = Color.Red;
                }

            }
        
        
        
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\fb.MP3";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox4.Enabled = false;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\bjk.MP3";

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\ts.MP3";
        }
    }
}
