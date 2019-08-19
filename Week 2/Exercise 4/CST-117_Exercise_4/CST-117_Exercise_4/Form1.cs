using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Exercise_4
{
    public partial class Form1 : Form
    {
        bool darkMode = true;
        Color backGroundDark = Color.FromArgb(36, 34, 34);
        Color buttonDark = Color.FromArgb(48, 48, 48);
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void activateDarkMode()
        {
            BackColor = backGroundDark;
            button1.BackColor = buttonDark;
            button1.ForeColor = Color.White;
            textBox1.BackColor = buttonDark;
            label1.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;
            darkMode = true;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
        }

        private void activateNormalMode()
        {
            BackColor = Color.White;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            textBox1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
            darkMode = true;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (darkMode)
            {
                activateNormalMode();
                darkMode = false;
            }
            else
            {
                activateDarkMode();
                darkMode = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            activateDarkMode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal input = Decimal.Parse(textBox1.Text);

                if (input < 0)
                {
                    throw new FormatException();
                }
                else if (input < 60)
                {
                    label2.Text = input.ToString("0.##");
                    label3.Text = "Second(s)";
                }
                else if (input < 3600)
                {
                    label2.Text = (input / 60).ToString("0.##");
                    label3.Text = "Minute(s)";
                }
                else if (input < 86400)
                {
                    label2.Text = (input / 3600).ToString("0.##");
                    label3.Text = "Hour(s)";
                }
                else
                {
                    label2.Text = (input / 86400).ToString("0.##");
                    label3.Text = "Day(s)";
                }

                button1.Text = "Re-Calculate!";
                Font normal = new Font("Arial", 24, FontStyle.Bold);
                label2.Font = normal;
                label3.Font = normal;

                label2.Visible = true;
                label3.Visible = true;
            }
            catch (FormatException)
            {
                label2.Font = new Font("Arial", 12, FontStyle.Bold);
                label2.Text = "Please enter a positive number.";
                label2.Visible = true;
            }
        }
    }
}
