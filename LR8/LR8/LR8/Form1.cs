using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace LR8
{
    public partial class Form1 : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        ToolStripLabel infoLabel1;
        ToolStripLabel ammount;
        Timer timer;

        static int counterObj = 0;

        public Form1()
        {
            InitializeComponent();
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            infoLabel1 = new ToolStripLabel();
            infoLabel1.Text = "Количество объектов:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            ammount = new ToolStripLabel();
    
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            statusStrip1.Items.Add(infoLabel1);
            statusStrip1.Items.Add(ammount);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            ammount.Text = counterObj.ToString();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Library setObj = new Library();
            string CD = "", DVD = "";
            if (checkBox1.Checked)
                CD = "CD";
            else
                CD = "";
            if (checkBox2.Checked)
                DVD = "DVD";
            else
                DVD = "";

            setObj.Set(textBox1.Text, (int) numericUpDown1.Value, textBox2.Text, (int)numericUpDown2.Value, CD, DVD, dateTimePicker1.Text, textBox3.Text, textBox4.Text, (int)numericUpDown3.Value);
            var results = new List<ValidationResult>();
            var context = new ValidationContext(setObj);

            if (!Validator.TryValidateObject(setObj, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
            else
            {
                setObj.addBook(setObj);
                ++counterObj;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Library getObj = new Library();
            List<Library> getList = new List<Library>(); 
            getList = getObj.GiveBook();

            int counter = 1;
            foreach(Library i in getList)
            {
                listBox1.Items.Add("------------------------------");
                listBox1.Items.Add("Книга № " + counter++);
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
            Library getObj = new Library();
            List<Library> getList = new List<Library>();
            getList = getObj.GiveBook();
            XML serializator = new XML();
            serializator.SSerialize(getList);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Library deSerObj = new Library();
            XML deSerializator = new XML();
            deSerializator.DeSerialize( out deSerObj);
            deSerObj.addBook(deSerObj);
        }

        private void издательствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
        }

        private void годВыпускаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
        }

        private void датаПоступленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курлович Евгений ПОИТ 2 4");
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 sort = new Form3();
            sort.Show();
        }

        private void датаПоступленияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 sort = new Form3();
            sort.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
        }

        private void авторToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 Search = new Form3();
            Search.Show();
        }

        private void датаПоступленияToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 Search = new Form3();
            Search.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курлович Евгений ПОИТ 2 4");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void диапазонСтраницToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
        }

        private void регулярныеВыраженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Reg = new Form4();
            Reg.Show();
        }
    }
}
