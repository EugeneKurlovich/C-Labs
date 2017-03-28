using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Objects
{
    class Romb : IComparable
    {
        int aLength; // длина строны а
        int bLength; //длина стороны б
        int cLength; //длина стороны с
        int dLength; // длина стороны д

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Romb otherRomb = obj as Romb;
            if (otherRomb != null)
                return aLength.CompareTo(otherRomb.aLength);
            else
                throw new ArgumentException("Объект не РОМБ!");
        }

        public int A
        {
            set
            {
                aLength = value;
            }

            get
            {
                return aLength;
            }
        }

        public int B
        {
            set
            {
                bLength = value;
            }

            get
            {
                return bLength;
            }
        }

        public int C
        {
            set
            {
                cLength = value;
            }

            get
            {
                return cLength;
            }
        }

        public int D
        {
            set
            {
                dLength = value;
            }

            get
            {
                return dLength;
            }
        }

        // Constructor with param
        public Romb(int a, int b, int c, int d, int di1, int di2)
        {
            if (a == b && a == c && a == d)
            {

                Console.WriteLine("Все стороны равны, ромб существует!");
                aLength = a;
                bLength = b;
                cLength = c;
                dLength = d;
            }
            else
            {
            repeat:
                Console.WriteLine("Фигура с данными размерами сторон не является ромбом,все стороны должны быть равны!");
                Console.WriteLine("Изменение размеров сторон :");
                Console.Write("Введите а: ");
                string aa = Console.ReadLine();
                aLength = int.Parse(aa);
                Console.Write("\n");
                Console.Write("Введите b: ");
                aa = Console.ReadLine();
                bLength = int.Parse(aa);
                Console.Write("\n");
                Console.Write("Введите c: ");
                aa = Console.ReadLine();
                cLength = int.Parse(aa);
                Console.Write("\n");
                Console.Write("Введите d: ");
                aa = Console.ReadLine();
                dLength = int.Parse(aa);
                Console.Write("\n");
                if (aLength == bLength && aLength == cLength && aLength == dLength)
                {
                    Console.WriteLine("Все стороны равны, ромб существует!");
                    aLength = a;
                    bLength = b;
                    cLength = c;
                    dLength = d;
                }
                else
                {
                    goto repeat;
                }

            }
        }

        // Constructor without param
        public Romb()
        {
            aLength = 0;
            bLength = 0;
            cLength = 0;
            dLength = 0;
        }

        // Methods

        public static void printInfo(Romb obj) // статический метод для вывода информации о Классе и об объекте
        {
            Console.WriteLine("Информация о классе");

            Console.WriteLine("Длина стороны а : {0} ", obj.aLength);
            Console.WriteLine("Длина стороны b : {0}", obj.bLength);
            Console.WriteLine("Длина стороны c : {0}", obj.cLength);
            Console.WriteLine("Длина стороны d : {0}", obj.D);
        }

        public override bool Equals(Object obj1)    // переопределённый Equals для сравнения двух ромбов 
        {
            Romb obj = obj1 as Romb;
            if (this.A == obj.A && this.B == obj.B && this.C == obj.C && this.D == obj.D)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int hashCode;
            hashCode = A + B + C + D;
            return hashCode;
        }  
    }
}
