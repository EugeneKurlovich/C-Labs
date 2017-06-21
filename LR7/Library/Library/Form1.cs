using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Library
{
    public partial class Form1 : Form
    {
       public  List<Book> libraryBook = new List<Book>();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("E:\\image.jpg");
            pictureBox1.Show();
        }

        public string getTextBox1()
        {
          string resultNameBook = textBox1.Text.ToString();
            return resultNameBook;
        }

        public int getNumericUpDowwn1()
        {
            return (int) numericUpDown1.Value;
        }

        public string getTextBox2()
        {
            return textBox2.Text;
        }

        public bool getDisk()
        {
            if (radioButton1.Checked || radioButton2.Checked)
                return true;
            else
                return false;
        }

        public int getYear()
        {
            return Convert.ToInt32(numericUpDown2.Value);
        }

        public string getDate()
        {
            string resultDate;
            string day = Convert.ToString(numericUpDown3.Value);
            string month = numericUpDown4.Value.ToString();
            string year = numericUpDown5.Value.ToString();
            

            resultDate = day + "." + month + "." + year;

            return resultDate;
        }
            
        public string getAuthorName()
        {
            return textBox3.Text;
        }

        public string getAuthorSurname()
        {
            return textBox4.Text;
        }


        public int getYearsOld()
        {
            return (int)numericUpDown6.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            foreach (Book i in libraryBook)
            {
                progressBar2.Value = 0;
                progressBar2.Maximum = 1;
                progressBar2.Step = 1;
                listBox1.Items.Add("Название книги : " +i.getNameBook());
                listBox1.Items.Add("Количество страниц : " + i.getAmmountSheets());
                listBox1.Items.Add("Издательство : " + i.getPublishingHouse());
                listBox1.Items.Add("Дата поступления : " + i.getDateComming());
                listBox1.Items.Add("Электронная версия : " + i.getCdOrDvd());
                listBox1.Items.Add("Год выпуска книги : " + i.getYearBook());
                listBox1.Items.Add("Имя автора : " + i.getNameAuthor());
                listBox1.Items.Add("Фамилия автора : " + i.getSurnameAuthor());
                listBox1.Items.Add("Возраст автора : " + i.getYearsOldAuthor());
                progressBar2.PerformStep();
                progressBar1.Value = 0;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.SetInfo(textBox1.Text.ToString(),getNumericUpDowwn1(),getTextBox2(),getYear(),
                getDisk(),getDate(),getAuthorName(),getAuthorSurname(),getYearsOld());
            if (checkBox1.Checked)
            {
                progressBar2.Value = 0;
                progressBar1.Value = 0;
                progressBar1.Maximum = 1;
                progressBar1.Step = 1;
                libraryBook.Add(book);
                progressBar1.PerformStep();
            }
            else
                MessageBox.Show("Для продолжения потвердите готовность!");


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Author newObj = new Author();
            XmlSer ser = new XmlSer();
            ser.DeSerialize( out newObj);
            MessageBox.Show("Имя : " + newObj.Name + " " + "Фамилия : " + newObj.Surname + " " + "Возраст : " +newObj.yearsOld);
        }
        
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlSer ser = new XmlSer();
            Author a = new Author();
            a.setData("Eugene", "Kurlovich", 18);
            ser.Serialize(a);
            MessageBox.Show("Обьект записан в XML файл");
        }
    }
}
