using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataBase_11_Lab
{
    public class Shop
    {
        public static List<Shop> myShop = new List<Shop>();
        public string name { get;}
        public int price { get; }
        public int ammount { get; }
        public Byte[] photo;
        public BitmapImage img { get; }





    public Shop(string n, int p, int a, Byte [] ph)
        {
            name = n;
            price = p;
            ammount = a;
            photo = ph;
        }


        public Shop(string n, int p, int a, BitmapImage ph)
        {
            name = n;
            price = p;
            ammount = a;
            img = ph;
        }


    }
}
