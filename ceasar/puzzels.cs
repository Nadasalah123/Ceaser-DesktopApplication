using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceasar
{
    public partial class puzzels : Form
    {
        public puzzels()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p5 p15 = new p5();
            p15.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            p2 p12 = new p2();
            p12.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p4 p14 = new p4();
            p14.Show();
            this.Hide();
        }

        private void puzzels_Load(object sender, EventArgs e)
        {

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1 p11 = new p1();
            p11.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            p3 p13 = new p3();
            p13.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p6 p16 = new p6();
            p16.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
