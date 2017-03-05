using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1_2
{
    class Romb
    {
        const string name = "Ромб";
        readonly int storoni = 4;
        double square;
        int length1;
        int length2;
        public static int objects { get; set; }


        public int Length1
        {
            set
            {
                length1 = value;
            }

            get
            {
                return length1;
            }
        }

        public int Length2
        {
            set
            {
                length2 = value;
            }

            get
            {
                return length2;
            }
        }

        public double Square
        {
            set
            {
                square = length1 * length2;
            }

            get
            {
                return length1*length2;
            }
        }

        public Romb()
        {
            square = 0;
            length1 = 0;
            length2 = 0;
            objects++;
        }

        public Romb (int l1, int l2)
        {
          
            length1 = l1;
            length2 = l2;
            objects++;
        }
        
        static Romb()
        {
            objects = 0;
        }

        public int perimetr(ref int a, out int b)
        {
            
           b = a;
            return length1 * 2 + length2 * 2;
        }

    public static void print(Romb obj)
        {
            Console.WriteLine("Количество объектов : {0}", Romb.objects);
            Console.WriteLine("Площадь : {0}", obj.square);
            Console.WriteLine("Длина стороны 1 и 3 : {0}", obj.length1);
            Console.WriteLine("Длина стороны 2 и 4 : {0}", obj.length2);
            Console.WriteLine("Количество сторон : {0}", obj.storoni);
            Console.WriteLine("Константа имя фигуры : {0}", Romb.name);
        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {

            Romb obj1 = new ЛР1_2.Romb(2,4);
            Romb obj2 = new ЛР1_2.Romb(3,5);

       
            int a, b;
            a = 5; b = 10;
            Console.WriteLine(obj1.perimetr(ref a, out b));
            Console.WriteLine("a = {0},b={1}",a,b);
            Romb.print(obj1);
            Console.ReadKey();
          
        }
    }
}
