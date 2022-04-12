using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_hack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                MessageBox.Show("Spin 0 Activated!");
            }
            if (textBox1.Text == "1")
            {
                MessageBox.Show("Spin 1 Activated!");
            }
            if (textBox1.Text == "2")
            {
                MessageBox.Show("Spin 2 Activated!");
            }
            if (textBox1.Text == "3")
            {
                MessageBox.Show("Spin 3 Activated!");
            }
            if (textBox1.Text == "4")
            {
                MessageBox.Show("Spin 4 Activated!");
            }
            if (textBox1.Text == "5")
            {
                MessageBox.Show("Spin 5 Activated!");
            }
            if (textBox1.Text == "6")
            {
                MessageBox.Show("Spin 6 Activated!");
            }
            if (textBox1.Text == "7")
            {
                MessageBox.Show("Spin 7 Activated!");
            }
            if (textBox1.Text == "8")
            {
                MessageBox.Show("Spin 8 Activated!");
            }
            if (textBox1.Text == "9")
            {
                MessageBox.Show("Spin 9 Activated!");
            }
            if (textBox1.Text == "10")
            {
                MessageBox.Show("Spin 10 Activated!");
            }
            if (textBox1.Text == "11")
            {
                MessageBox.Show("Spin 11 Activated!");
            }
            if (textBox1.Text == "12")
            {
                MessageBox.Show("Spin 12 Activated!");
            }
            if (textBox1.Text == "13")
            {
                MessageBox.Show("Spin 13 Activated!");
            }
            if (textBox1.Text == "14")
            {
                MessageBox.Show("Spin 14 Activated!");
            }
            if (textBox1.Text == "15")
            {
                MessageBox.Show("Spin 15 Activated!");
            }
            if (textBox1.Text == "16")
            {
                MessageBox.Show("Spin 16 Activated!");
            }
            if (textBox1.Text == "17")
            {
                MessageBox.Show("Spin 17 Activated!");
            }
            if (textBox1.Text == "18")
            {
                MessageBox.Show("Spin 18 Activated!");
            }
            if (textBox1.Text == "19")
            {
                MessageBox.Show("Spin 19 Activated!");
            }
            if (textBox1.Text == "20")
            {
                MessageBox.Show("Spin 20 Activated!");
            }
            if (textBox1.Text == "21")
            {
                MessageBox.Show("Spin 21 Activated!");
            }
            if (textBox1.Text == "22")
            {
                MessageBox.Show("Spin 22 Activated!");
            }
            if (textBox1.Text == "23")
            {
                MessageBox.Show("Spin 23 Activated!");
            }
            if (textBox1.Text == "24")
            {
                MessageBox.Show("Spin 24 Activated!");
            }
            if (textBox1.Text == "25")
            {
                MessageBox.Show("Spin 25 Activated!");
            }
            if (textBox1.Text == "26")
            {
                MessageBox.Show("Spin 26 Activated!");
            }
            if (textBox1.Text == "27")
            {
                MessageBox.Show("Spin 27 Activated!");
            }
            if (textBox1.Text == "28")
            {
                MessageBox.Show("Spin 28 Activated!");
            }
            if (textBox1.Text == "29")
            {
                MessageBox.Show("Spin 29 Activated!");
            }
            if (textBox1.Text == "30")
            {
                MessageBox.Show("Spin 30 Activated!");
            }
            if (textBox1.Text == "31")
            {
                MessageBox.Show("Spin 31 Activated!");
            }
            if (textBox1.Text == "32")
            {
                MessageBox.Show("Spin 32 Activated!");
            }
            if (textBox1.Text == "33")
            {
                MessageBox.Show("Spin 33 Activated!");
            }
            if (textBox1.Text == "34")
            {
                MessageBox.Show("Spin 34 Activated!");
            }
            if (textBox1.Text == "35")
            {
                MessageBox.Show("Spin 35 Activated!");
            }
            if (textBox1.Text == "36")
            {
                MessageBox.Show("Spin 36 Activated!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
