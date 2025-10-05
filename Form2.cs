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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1.Text + "" + maskedTextBox2.Text);
        }
    }
}
