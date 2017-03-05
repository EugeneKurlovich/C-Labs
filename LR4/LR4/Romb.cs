using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class Romb 
    {
       

        //Data        
        readonly int sidesAmount = 4; // количество сторон
        int aLength; // длина строны а
        int bLength; //длина стороны б
        int cLength; //длина стороны с
        int dLength; // длина стороны д
        int diogonal1; // длина диогонали1
        int diogonal2; // длина диогонали2
        const int diogonalsAmount = 2; // константа количество диогоналей
        static int objects; // статическая переменная (количество объектов)

        //Properties
        public int SidesAmount
        {
            get
            {
                return sidesAmount;
            }
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

        public int DI1
        {
            set
            {
                diogonal1 = value;
            }

            get
            {
                return diogonal1;
            }
        }

        public int DI2
        {
            set
            {
                diogonal2 = value;
            }

            get
            {
                return diogonal2;
            }
        }

        //Static constructor
        static Romb()
        {
            objects = 0;
            Console.WriteLine("Статический конструктор");
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
                diogonal1 = di1;
                diogonal2 = di2;
                objects++;
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
                    diogonal1 = di1;
                    diogonal2 = di2;
                    objects++;
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
            sidesAmount = 4;
            aLength = 0;
            bLength = 0;
            cLength = 0;
            dLength = 0;
            objects++;
        }

        // Methods
        public double Area(ref int d1, out int d2)  //Вычисляет площадь ромба
        {
            double area;
            d2 = d1 + 2;
            d1++;
            area = 0.5 * d1 * d2;
            return area;
        }

        public static void printInfo(Romb obj) // статический метод для вывода информации о Классе и об объекте
        {
            Console.WriteLine("Информация о классе");
            Console.WriteLine("Количество объектов : {0}", Romb.objects);
            Console.WriteLine("Количество диогоналей : {0}", Romb.diogonalsAmount);

            Console.WriteLine("Длина стороны а : {0} ", obj.aLength);
            Console.WriteLine("Длина стороны b : {0}", obj.bLength);
            Console.WriteLine("Длина стороны c : {0}", obj.cLength);
            Console.WriteLine("Длина стороны d : {0}", obj.D);
            Console.WriteLine("Длина диогонали 1 : {0}", obj.diogonal1);
            Console.WriteLine("Длина диогонали 2 : {0}", obj.diogonal2);
            Console.WriteLine("Количество сторон : {0}", obj.SidesAmount);
            Console.WriteLine("Площадь : {0}", obj.Area(ref obj.diogonal1, out obj.diogonal2));
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
            hashCode = (SidesAmount * (A + B + C + D)) / (diogonalsAmount * (DI1 + DI2));
            return hashCode;
        }   // вычисление хэш-кода
    }
}
