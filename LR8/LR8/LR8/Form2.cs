using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string search = textBox1.Text;
            Search obj = new Search();
            obj.firstSearch(search);
            foreach (Library i in obj.L)
            {
                listBox1.Items.Add("------------------------");
                listBox1.Items.Add("Название книги : " + i.BN);
                listBox1.Items.Add("Количество страниц : " + i.P);
                listBox1.Items.Add("Издательство : " + i.PH);
                listBox1.Items.Add("Год выпуска : " + i.Y);
                listBox1.Items.Add("Электронная версия : " + i.EV);
                listBox1.Items.Add("Дата поступления : " + i.D);
                listBox1.Items.Add("Имя автора : " + i.AN);
                listBox1.Items.Add("Фамилия автора : " + i.AS);
                listBox1.Items.Add("Возраст автора : " + i.AYO);
            }

            obj.L.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int search = (int)numericUpDown1.Value;
            Search obj = new Search();
            obj.secondSearch(search);

            foreach (Library i in obj.L)
            {
                listBox1.Items.Add("------------------------");
                listBox1.Items.Add("Название книги : " + i.BN);
                listBox1.Items.Add("Количество страниц : " + i.P);
                listBox1.Items.Add("Издательство : " + i.PH);
                listBox1.Items.Add("Год выпуска : " + i.Y);
                listBox1.Items.Add("Электронная версия : " + i.EV);
                listBox1.Items.Add("Дата поступления : " + i.D);
                listBox1.Items.Add("Имя автора : " + i.AN);
                listBox1.Items.Add("Фамилия автора : " + i.AS);
                listBox1.Items.Add("Возраст автора : " + i.AYO);
            }

            obj.L.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string search = dateTimePicker1.Text.ToString();
            Search obj = new Search();
            obj.thirdSearch(search);
            foreach (Library i in obj.L)
            {
                listBox1.Items.Add("------------------------");
                listBox1.Items.Add("Название книги : " + i.BN);
                listBox1.Items.Add("Количество страниц : " + i.P);
                listBox1.Items.Add("Издательство : " + i.PH);
                listBox1.Items.Add("Год выпуска : " + i.Y);
                listBox1.Items.Add("Электронная версия : " + i.EV);
                listBox1.Items.Add("Дата поступления : " + i.D);
                listBox1.Items.Add("Имя автора : " + i.AN);
                listBox1.Items.Add("Фамилия автора : " + i.AS);
                listBox1.Items.Add("Возраст автора : " + i.AYO);
            }

            obj.L.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int start = (int)numericUpDown2.Value;
            int end = (int)numericUpDown3.Value;
            Search obj = new Search();
            obj.fourthSearch(start,end);
            foreach (Library i in obj.L)
            {
                listBox1.Items.Add("------------------------");
                listBox1.Items.Add("Название книги : " + i.BN);
                listBox1.Items.Add("Количество страниц : " + i.P);
                listBox1.Items.Add("Издательство : " + i.PH);
                listBox1.Items.Add("Год выпуска : " + i.Y);
                listBox1.Items.Add("Электронная версия : " + i.EV);
                listBox1.Items.Add("Дата поступления : " + i.D);
                listBox1.Items.Add("Имя автора : " + i.AN);
                listBox1.Items.Add("Фамилия автора : " + i.AS);
                listBox1.Items.Add("Возраст автора : " + i.AYO);
            }

            obj.L.Clear();
        }
    }
}
