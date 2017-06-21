using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LR8
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "qwe          asd             cxzxc";
            string b = " ";
            string c = @"\s+"; 
            Regex reg = new Regex(c);
            MessageBox.Show(a);
            string result = reg.Replace(a,b);
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]{3}-[0-9]{3}-[0-9]{4}");
            string str = "123-345-1234";
           if(reg.IsMatch(str))
            {
                MessageBox.Show("Проверка пройдена");
            }
           else
            {
                MessageBox.Show("Проверка не пройдена");
            }
        }
    }
}
