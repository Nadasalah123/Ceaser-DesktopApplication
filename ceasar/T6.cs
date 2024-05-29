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
    public partial class T6 : Form
    {
        public T6()
        {
            InitializeComponent();
        }

        private void T6_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puzzels pz = new puzzels();
            pz.Show();
            this.Hide();
        }
    }
}
