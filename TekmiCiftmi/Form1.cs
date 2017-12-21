using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekmiCiftmi
{
    public partial class teklikCiftlik : Form
    {
        public teklikCiftlik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if (x % 2 == 0)
            {
                textBox2.Text = Convert.ToString(x) + " Cifttir";
            }
            else
            {
                textBox2.Text = Convert.ToString(x) + " Tektir";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
