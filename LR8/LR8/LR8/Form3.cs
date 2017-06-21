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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sort authorName = new Sort();
            listBox1.Items.Add("Сортировка по имени автора");
            foreach(Library i in authorName.SortList())
            {

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sort authorName = new Sort();
            listBox1.Items.Add("Сортировка по году");
            foreach (Library i in authorName.SortDate())
            {

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XML serializer = new XML();
            Sort forSave = new Sort();
            
            serializer.saveResultSort(forSave.SortList());
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XML serializer = new XML();
            Sort forSave = new Sort();

            serializer.saveResultSort(forSave.SortDate());
        }
    }
}
