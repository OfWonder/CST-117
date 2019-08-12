using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Exercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                decimal input = Decimal.Parse(textBox1.Text);
                textBox2.Text = (input + 5).ToString("#.000");
                textBox2.Visible = true;
                label2.Visible = true;
                button1.Text = "Re-Calculate!";
            }
            catch(FormatException)
            {
                textBox2.Visible = true;
                textBox2.Text = "Please enter a number.";
            }
        }
    }
}
