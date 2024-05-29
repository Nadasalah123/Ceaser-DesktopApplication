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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            history form = new history();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HowItWork H = new HowItWork();
            H.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning: Caesar Cipher does not accept spaces between words. To get the most accurate results, enter the message to be encrypted without any spaces.");
            encryption E = new encryption();
            E.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning: Caesar Cipher does not accept spaces between words. To get the most accurate results, enter the message to be decrypted without any spaces.");
            decryption D = new decryption();
            D.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            puzzels PU = new puzzels();
            PU.Show();
            this.Hide();
        }
    }
}
