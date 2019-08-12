using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Exercise_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "You Clicked Label 1";
            updateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
     
                label1.Text = "You pressed button 1 AND checkbox 1 is checked";
            else
                label1.Text = "You pressed button 1";

            updateList();
        }

        private void updateList()
        {
            listBox1.Items.Add(label1.Text);
            listBox1.Update();
        }
    }
}
