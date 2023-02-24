using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_converter
{
    public partial class Measurement : Form
    {
        public Measurement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Select Unit" || comboBox1.Text == "Select Unit")
            {
                MessageBox.Show("Please select Unit for conversion");
            }
            else
            {
                if(comboBox2.SelectedItem == "Kilometer" && comboBox1.SelectedItem == "Meter")
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1000);
                }
                if (comboBox2.SelectedItem == "Meter" && comboBox1.SelectedItem == "Kilometer")
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * .001);
                }
                if (comboBox2.SelectedItem == "Kilometer" && comboBox1.SelectedItem == "Centimeter")
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 100000);
                }
                if (comboBox2.SelectedItem == "Centimeter" && comboBox1.SelectedItem == "Kilometer")
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * .0001);
                }
                if (comboBox2.SelectedItem == "Centimeter" && comboBox1.SelectedItem == "Meter")
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * .001);
                }
                if (comboBox2.SelectedItem == "Meter" && comboBox1.SelectedItem == "Centimeter")
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 100);
                }
            }
        }
    }
}
