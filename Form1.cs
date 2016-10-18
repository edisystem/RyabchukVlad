using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox3.Text);
            c = a + b;
           
            textBox2.Text = c.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox6.Text);
            b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = (a + b).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox9.Text);
            textBox8.Text= (a+Convert.ToDouble(textBox7.Text)).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox11.Text= (Convert.ToDouble(textBox12.Text)+(Convert.ToDouble(textBox10.Text))).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox3.Text);
            c = a + b;

            textBox2.Text = c.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox3.Text);
            c = a - b;

            textBox2.Text = c.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox3.Text);
            c = a * b;

            textBox2.Text = c.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox3.Text);
            c = a / b;

            textBox2.Text = c.ToString();
        }
    }
}
