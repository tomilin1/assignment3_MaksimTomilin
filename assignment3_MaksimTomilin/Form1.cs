using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3_MaksimTomilin
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double underweight_score = 18.5;
            const double overweight_score = 25;
            double weight, height, BMI;
            weight = double.Parse(textBox1.Text);
            height = double.Parse(textBox2.Text);

            BMI = weight / (height * height) * 703;
            BMI = Math.Round(BMI, 2);

            if (BMI < underweight_score)
            {
                textBox3.Text = "BMI: " + BMI + "\r" + "\n" + "Status: underweight";
            }

            else if (BMI > overweight_score)
            {
                textBox3.Text = "BMI: " + BMI + "\r" + "\n" + "Status: overweight";
            }

            else if (BMI >= underweight_score && BMI <= overweight_score)
            {
                textBox3.Text = "BMI: " + BMI + "\r" + "\n" + "Status: normal weight";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
