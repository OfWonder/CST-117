using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Programming_Exercise_2
{
    public partial class Form1 : Form
    {
        string selectedShape;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShape = listBox1.Items[listBox1.SelectedIndex].ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex == -1)
                {
                    throw new Exception();
                }

                label4.Text = selectedShape;

                if (checkBox1.Checked)
                    label4.Visible = true;
                else
                    label4.Visible = false;

                if (checkBox2.Checked)
                    label5.Visible = true;
                else
                    label5.Visible = false;

                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        if (radioButton1.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Circle_Filled.png";
                        else if (radioButton2.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Circle_Outlined.png";
                        else
                            throw new Exception();
                        break;

                    case 1:
                        if (radioButton1.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Triangle_Filled.png";
                        else if (radioButton2.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Triangle_Outlined.png";
                        else
                            throw new Exception();
                        break;

                    case 2:
                        if (radioButton1.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Rectangle_Filled.png";
                        else if (radioButton2.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Rectangle_Outlined.png";
                        else
                            throw new Exception();
                        break;

                    case 3:
                        if (radioButton1.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Pentagon_Filled.png";
                        else if (radioButton2.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Pentagon_Outlined.png";
                        else
                            throw new Exception();
                        break;

                    case 4:
                        if (radioButton1.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Hexagon_Filled.png";
                        else if (radioButton2.Checked)
                            pictureBox1.ImageLocation = @"..\shapes\Hexagon_Outlined.png";
                        else
                            throw new Exception();
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please select all required options");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label5.Text = DateTime.Today.ToString("D");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            label4.Visible = false;
            label5.Visible = false;

        }
    }
}
