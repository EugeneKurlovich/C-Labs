using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class CollectionType <T> where T: Romb
    {
        Queue<T> myQueue = new Queue<T>();

        public CollectionType()
            {
          
            }


        public void Add( T item)
        {
            myQueue.Enqueue(item);
        }



        public T Del()
        {
           return myQueue.Dequeue();
        }

        public void Read()
        {
            T item = myQueue.Peek();
            Console.WriteLine(item.A);                 
        }

        public void WTF(T obj)
        {
            FileStream file = new FileStream("e:\\LR4.txt", FileMode.Create);
            StreamWriter _out = new StreamWriter(file);


            _out.Write("qwe");

            file.Close();
        }
        

        public void Print()
        {
            foreach (T i in myQueue)
            {
                Console.WriteLine(i.A + ", " + i.B + ", " + i.C + ", " + i.D + ", " + i.DI1 + ", " + i.DI2 + ", " + i.SidesAmount );

            }
        }
     
    }
}
