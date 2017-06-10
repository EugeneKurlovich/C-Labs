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

namespace Lab12_1
{
    public partial class MainWindow : Window
    {
        SQLCustomerRepository customerRepository;
        CQLOrderRepository orderRepository;
        public MainWindow()
        {
            InitializeComponent();
            customerRepository = new SQLCustomerRepository();
            orderRepository = new CQLOrderRepository();
        }

        private void AddToDB(object sender, RoutedEventArgs e)
        {
            buyer b = new buyer();
            b.Name = name.Text;
 
            customerRepository.Create(b);
            customerRepository.Save();
        }

        private void UpdateCustomer(object sender, RoutedEventArgs e)
        {
            buyer b = new buyer();
            b.Name = name.Text;
            b.buyerId = Convert.ToInt32(custID.Text);

            customerRepository.Update(b);
            customerRepository.Save();
        }

        private void DeleteCustomer(object sender, RoutedEventArgs e)
        {
            customerRepository.Delete(Convert.ToInt32(custID.Text));
            customerRepository.Save();
        }

        private void GetAllCustomers(object sender, RoutedEventArgs e)
        {
            customers.Items.Clear();
            List<buyer> list = customerRepository.GetList().ToList();
            foreach (buyer c in list)
                customers.Items.Add(c.ToString());
        }

        private void GetCustomerByID(object sender, RoutedEventArgs e)
        {
            custByID.Text= customerRepository.GetItem(Convert.ToInt32(custID.Text)).ToString();
        }

        private void AddOrder(object sender, RoutedEventArgs e)
        {
            Goods g = new Goods();
            g.ProductName = prName.Text;
            g.Quantity = Convert.ToInt32(qua.Text);
            g.Customer = Convert.ToInt32(cID.Text);

            orderRepository.Create(g);
            orderRepository.Save();
        }

        private void UpdOrder(object sender, RoutedEventArgs e)
        {
            Goods g = new Goods();
            g.ProductName = prName.Text;
            g.Quantity = Convert.ToInt32(qua.Text);
            g.Customer = Convert.ToInt32(cID.Text);
            g.GoodsId = Convert.ToInt32(oID.Text);

            orderRepository.Update(g);
            orderRepository.Save();
        }

        private void DeleteOrder(object sender, RoutedEventArgs e)
        {
            orderRepository.Delete(Convert.ToInt32(oID.Text));
            orderRepository.Save();
        }

        private void GetAllOrders(object sender, RoutedEventArgs e)
        {
            orders.Items.Clear();
            List<Goods> list = orderRepository.GetList().ToList();
            foreach (Goods o in list)
                orders.Items.Add(o.ToString());
        }

        private void GetOrderById(object sender, RoutedEventArgs e)
        {
            ordById.Text = orderRepository.GetItem(Convert.ToInt32(oID.Text)).ToString();
        }

        private void custByID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void prName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
