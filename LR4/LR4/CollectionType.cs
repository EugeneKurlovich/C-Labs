using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
   
    class CollectionType <T>  where T: Romb 
    {
        Queue<T> myQueue = new Queue<T>();
        public CollectionType()
            {
          
            }
        public void Add( T item)
        {
            myQueue.Enqueue(item);
        }
        public void Del()
        {
            try
            {
               myQueue.Dequeue();
            }
            catch(InvalidOperationException e)

            {
               Console.WriteLine( e.Message);
            }
      
        finally
            {
                Console.WriteLine("Исключение обработано!");
            }
        }
        public void Read()
        {
            try
            {
                Console.WriteLine("Считывание первого элемента (без удаления): ");
                T item = myQueue.Peek();
                Console.WriteLine("Сторона А: " + item.A);
                Console.WriteLine("Сторона B: " + item.B);
                Console.WriteLine("Сторона C: " + item.C);
                Console.WriteLine("Сторона D: " + item.D);
                Console.WriteLine("Диогональ1: " + item.DI1);
                Console.WriteLine("Диогональ2: " + item.DI2);
                Console.WriteLine("Количество сторон: " + item.SidesAmount);
            }

            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Исключение обработано!!!");
            }
        }

        public Queue<T> GetMyQueue()
        {
            return myQueue;
        }

        public T this[int index = 0]
        {
            get
            {
                return myQueue.ElementAt<T>(index);
            }
        }

        public void WTF(CollectionType<T> obj)
        {
            FileStream file1 = new FileStream("e:\\LR4.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.WriteLine("Коллекия Ромбов!"); //записываем в файл

            foreach (T i in myQueue)
            {
                writer.WriteLine("Сторона А: " + i.A);
                writer.WriteLine("Сторона B: " + i.B);
                writer.WriteLine("Сторона C: " + i.C);
                writer.WriteLine("Сторона D: " + i.D);
                writer.WriteLine("Диогональ1: " + i.DI1);
                writer.WriteLine("Диогональ2: " + i.DI2);
                writer.WriteLine("Количество сторон: " + i.SidesAmount);

            }

            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        }
        public void Print()
        {
            try
            {
                foreach (T i in myQueue)
                {
                    Console.WriteLine("Сторона А: " + i.A);
                    Console.WriteLine("Сторона B: " + i.B);
                    Console.WriteLine("Сторона C: " + i.C);
                    Console.WriteLine("Сторона D: " + i.D);
                    Console.WriteLine("Диогональ1: " + i.DI1);
                    Console.WriteLine("Диогональ2: " + i.DI2);
                    Console.WriteLine("Количество сторон: " + i.SidesAmount);

                }
            }

            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }   

    }
}
