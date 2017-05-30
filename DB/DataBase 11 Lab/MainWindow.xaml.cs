using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;



namespace DataBase_11_Lab
{

    public partial class MainWindow : Window
    {
       
     

        public MainWindow()
        {
            InitializeComponent();
        }


        private void DataGridd1_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridd1.ItemsSource = Shop.myShop;

        }

        private void DataGridd_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridd1.ItemsSource = Shop.myShop;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
          

            Shop goods = new Shop(textBox.Text, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Data );
            DB db = new DB();
            db.insertQuery(goods,Data);

            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            image.Source = null;
            Shop.myShop.Clear();

        }

        Byte [] Data;
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog img = new Microsoft.Win32.OpenFileDialog();

            BitmapImage bm1 = new BitmapImage();
            img.ShowDialog();
            FileStream fs = new FileStream(img.FileName, FileMode.Open);
            Data = new Byte[fs.Length];
            int read = (int)fs.Length;
            fs.Read(Data, 0, read);
            fs.Close();



            bm1.BeginInit();
            bm1.UriSource = new Uri(img.FileName, UriKind.Relative);
            bm1.CacheOption = BitmapCacheOption.OnLoad;
            bm1.EndInit();

            image.Source = bm1;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            DB db = new DB();
            db.selectQuery();

            DataGridd1.ItemsSource = null;
            DataGridd1.ItemsSource = Shop.myShop;


        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            db.deleteQuery();

            Shop.myShop.Clear();


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            db.updateQuery();

            Shop.myShop.Clear();

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            db.deleteAllQuery();

            Shop.myShop.Clear();

        }
    }
}
