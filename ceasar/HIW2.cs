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
    public partial class HIW2 : Form
    {
        public HIW2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HowItWork form = new HowItWork();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
