using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Usages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Hakka";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Hakka";
            label7.Text = "Halmiev";
            label8.Text = ".Net Developer";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Hakka Halmiev .Net Developer";
            label9.Text = textBox1.Text;
        }
    }
}
