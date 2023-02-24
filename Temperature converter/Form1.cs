using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Temperature_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, f, k;

            if (radioButton1.Checked == true)
            {
                c = double.Parse(textBox2.Text);
                f = (c + 9 / 5) + 32;
                textBox1.Text = Convert.ToString(f);

            }
            if (radioButton2.Checked == true)
            {
                f = double.Parse(textBox2.Text);
                c = (f - 32) + 5 / 9;
                textBox1.Text = Convert.ToString(c);

            }
            if (radioButton4.Checked == true)
            {
                c = double.Parse(textBox2.Text);
                k = c + 273;
                textBox1.Text = Convert.ToString(k);

            }
            if (radioButton4.Checked == true)
            {
                k = double.Parse(textBox2.Text);
                c = k - 273;
                textBox1.Text = Convert.ToString(c);
            }
        }

            private void button2_Click(object sender, EventArgs e)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }

            private void button3_Click(object sender, EventArgs e)
            {
            MessageBox.Show("Thank You");
                Application.Exit();
            }
        }
    }



