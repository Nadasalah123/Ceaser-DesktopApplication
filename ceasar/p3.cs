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
    public partial class p3 : Form
    {
        public p3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            T3 t = new T3();
            t.Show();
            this.Hide();
        }

        private void p3_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F3 f = new F3();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            puzzels pz = new puzzels();
            pz.Show();
            this.Hide();
        }
    }
}
