using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generate_Objects
{
    public partial class Form1 : Form
    {
        List<Romb> myList = new List<Romb>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Romb obj = new Romb();

            try
            {
                obj.A = Convert.ToInt32(textBox1.Text);
                obj.B = Convert.ToInt32(textBox2.Text);
                obj.C = Convert.ToInt32(textBox3.Text);
                obj.D = Convert.ToInt32(textBox4.Text);

                if (obj.A != obj.B && obj.A != obj.C && obj.B != obj.D)
                    MessageBox.Show("Ромба с такими сторонами не существует!!!");
                else
                {
                    myList.Add(obj);
                    MessageBox.Show("Элемент добавлен успешно.");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте введённые значения");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Коллекция Ромбов");
            int counter = 0;
            foreach (Romb i in myList)
            {
                listBox1.Items.Add("-------------");
                listBox1.Items.Add("Ромб № " + ++counter);
                listBox1.Items.Add("Сторона А = " + i.A);
                listBox1.Items.Add("Сторона B = " + i.B);
                listBox1.Items.Add("Сторона C = " + i.C);
                listBox1.Items.Add("Сторона D = " + i.D);
            }
            listBox1.Items.Add("-------------");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add("Запрос: Длина стороны = 2");
            var result = from i in myList
                         where i.A == 2
                         select i;

            listBox1.Items.Add("Результаты: ");

            int counter = 0;
            foreach (Romb i in result)
            {
                listBox1.Items.Add("-------------");
                listBox1.Items.Add("Ромб № " + ++counter);
                listBox1.Items.Add("Сторона А = " + i.A);
                listBox1.Items.Add("Сторона B = " + i.B);
                listBox1.Items.Add("Сторона C = " + i.C);
                listBox1.Items.Add("Сторона D = " + i.D);
            }
            listBox1.Items.Add("-------------");
            listBox1.Items.Add("Запрос завершён.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var upSort = from i in myList
                                 orderby i.A
                                 select i;

            listBox1.Items.Add("Cортировка по возрастанию : ");
            int counter = 0;
            foreach (Romb i in upSort)
            {
                listBox1.Items.Add("-------------");
                listBox1.Items.Add("Ромб № " + ++counter);
                listBox1.Items.Add("Сторона А = " + i.A);
                listBox1.Items.Add("Сторона B = " + i.B);
                listBox1.Items.Add("Сторона C = " + i.C);
                listBox1.Items.Add("Сторона D = " + i.D);
            }
            listBox1.Items.Add("-------------");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var downSort = from i in myList
                         orderby i.A descending
                         select i;

            listBox1.Items.Add("Cортировка по убыванию : ");
            int counter = 0;
            foreach (Romb i in downSort)
            {
                listBox1.Items.Add("-------------");
                listBox1.Items.Add("Ромб № " + ++counter);
                listBox1.Items.Add("Сторона А = " + i.A);
                listBox1.Items.Add("Сторона B = " + i.B);
                listBox1.Items.Add("Сторона C = " + i.C);
                listBox1.Items.Add("Сторона D = " + i.D);
            }
            listBox1.Items.Add("-------------");
        }
    }
}
