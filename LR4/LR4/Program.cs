using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class Program
    {
        static void Main(string[] args)
        {
            Romb obj1 = new Romb(2,2,2,2,2,2);
            Romb obj2 = new Romb(3,3,3,3,3,3);
            Romb obj3 = new Romb(4,4,4,4,4,4);

            CollectionType<Romb> collection = new CollectionType<Romb>();

            collection.Add(obj1);
            collection.Add(obj2);
            collection.Add(obj3);
            collection.Print();
            collection.Read();
            collection.Del();
            collection.Read();
            collection.Del();
            collection.Read();




            Console.ReadKey();
        }
    }
}
