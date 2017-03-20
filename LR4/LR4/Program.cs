using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{ 
    class Program
    {
        delegate bool AmmountZ(int obj, int zerro);
        delegate bool AmmountD(int ind, int start, int end);
        static void Main(string[] args)
        {
            AmmountZ AmmountZero = (obj, zerro) =>
            {
                if (obj == zerro)
                    return true;
                else
                    return false;
            };

           AmmountD AmmountDiapason = (now, start, end) =>
            {
                if (now >= start && now <= end)
                    return true;
                else
                    return false;
            };

            Romb obj1 = new Romb(2,2,2,2,2,3);
            Romb obj2 = new Romb(3,3,3,3,3,3);
            Romb obj3 = new Romb(0, 0, 0, 0, 0, 0);
            Romb obj4 = new Romb(4,4,4,4,4,4);

            CollectionType<Romb> collection = new CollectionType<Romb>();

            collection.Add(obj1);
            collection.Add(obj2);
            collection.Add(obj3);
            collection.Add(obj4);
            collection.Print();
            collection.Del();
            collection.Print();
            collection.WTF(collection);

            int counterZerro = 0;

            for (int i = 0; i < collection.GetMyQueue().Count(); i++)
            {

                if (AmmountZero(collection[i].A, 0))
                    counterZerro++;
            }
            Console.WriteLine("Объекты с 0 (количество): " + counterZerro);


            int counterD = 0;
            for (int i = 0; i < collection.GetMyQueue().Count(); i++)
            {
                if (AmmountDiapason(i, 0, 1))
                    counterD++;
            }
            Console.WriteLine("Количество обьектов из диапазона: " + counterD);

            Queue<String> StrQueue = new Queue<String>();

            StrQueue.Enqueue("qwe");
            StrQueue.Enqueue("nmbn");
            StrQueue.Enqueue("bnf");
            StrQueue.Enqueue("dgfd");

         
            foreach(String i in StrQueue)
            {
                Console.WriteLine(i);
            }

            int counter = 0;
            int n = 3;

            var t = (from i in StrQueue
                     where i.Length == n
                     select i).Count();

            



           
            foreach (String i in StrQueue)
            {
                if (i.Length == n)
                    counter++;
            }

            Console.WriteLine("Количество строк длины "+ n +" = " + counter);

            var sortedUsers = from i in StrQueue
                              orderby i.Length
                              select i;

            Console.WriteLine("Сортированная очередь");
            foreach (String i in sortedUsers)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
