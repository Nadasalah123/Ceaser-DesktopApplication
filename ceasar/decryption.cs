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
    public partial class decryption : Form
    {
        public decryption()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = textBox1.Text;
            textBox2.Text = c.decrypt(msg);
        }

        private void decryption_Load(object sender, EventArgs e)
        {

        }

        
    }

    public class c
    {
        public static string decrypt(string txt)
        {
            string result = " ";
            for (int i = 0; i < txt.Length; i++)
            {
                if (char.IsUpper(txt[i]))
                {
                    result += Convert.ToChar(Convert.ToInt32(txt[i] - 3 - 65) % 26 + 65);

                }
                else
                {
                    result += Convert.ToChar(Convert.ToInt32(txt[i] - 3 - 97) % 26 + 97);
                }

            }
            return result;
        }


    }
}
