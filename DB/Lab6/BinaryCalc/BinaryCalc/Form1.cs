using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = 0;
            int value2 = 0;
            int result = 0;

            try
            {
                value1 = Convert.ToInt32(textBox1.Text);
                value2 = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Проверьте исходные данные !!!");
            }
            result = value1 & value2;
            textBox3.Text = Convert.ToString(result, 2);
            textBox4.Text = Convert.ToString(result, 8);
            textBox5.Text = Convert.ToString(result, 10);
            textBox6.Text = Convert.ToString(result, 16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value1 = 0;
            int value2 = 0;
            int result = 0;

            try
            {
                value1 = Convert.ToInt32(textBox1.Text);
                value2 = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Проверьте исходные данные !!!");
            }

            result = value1 | value2;
            textBox3.Text = Convert.ToString(result, 2);
            textBox4.Text = Convert.ToString(result, 8);
            textBox5.Text = Convert.ToString(result, 10);
            textBox6.Text = Convert.ToString(result, 16);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value1 = 0;
            int value2 = 0;
            int result = 0;

            try
            {
                value1 = Convert.ToInt32(textBox1.Text);
                value2 = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Проверьте исходные данные !!!");
            }
            result = value1 ^ value2;
            textBox3.Text = Convert.ToString(result, 2);
            textBox4.Text = Convert.ToString(result, 8);
            textBox5.Text = Convert.ToString(result, 10);
            textBox6.Text = Convert.ToString(result, 16);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value1 = 0;

            try
            {
                value1 = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Проверьте исходные данные !!!");
            }
            textBox3.Text = Convert.ToString(~value1, 2);
            textBox4.Text = Convert.ToString(~value1, 8);
            textBox5.Text = Convert.ToString(~value1, 10);
            textBox6.Text = Convert.ToString(~value1, 16);
        }
    }
}
