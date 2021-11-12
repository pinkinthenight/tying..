using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            panel2.Hide();
            btnSi.TabStop = false;
            btnNO.TabStop = false;  
        }
        public void moverboton()
        {
           Random r = new Random();
            int x = r.Next(0, this.Width - btnNO.Width);
            int y = r.Next(0, this.Height - btnNO.Height);
            btnNO.Location = new Point(x, y);
;        }

        private void btnNO_MouseMove(object sender, MouseEventArgs e)
        {
            moverboton();
            if (btnNO.Location == btnSi.Location || btnNO.Location == label1.Location);
            {
                moverboton();
            }
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNO_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

