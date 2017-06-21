using System;
using System.IO;


namespace LR3
{
  public class StudentZaochnik : AbstractSluzh, InterfaceLearn, WTF
   {
    public  string a;
    private string Surname { set; get; }
    private string age { set; get; }
    private string Zadolzhennosti { set; get; }
    private string srBal { set; get; }


          public string A
            {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
            }


        public StudentZaochnik(string N, string S, string a, string z, string sr)
        {
            this.name = N;
            this.Surname = S;
            this.age = a;
            this.Zadolzhennosti = z;
            this.srBal = sr;
        }

        public StudentZaochnik()
        {

        }

        public void SrUp()
        {
            double result1;
            Double.TryParse(srBal, out result1);
            result1++;
            string res;
            res = result1.ToString();
            srBal = res;
        }

        public Memento SaveState()
        {
            Console.WriteLine("Сохранение среднего бала: Средний бал: {0}", srBal);
            return new Memento(srBal);
        }

        public void RestoreState(Memento obj)
        {
            this.srBal = obj.sr;
             Console.WriteLine("Восстановление среднего бала. Средний бал: {0}" ,srBal);
        }


        public string getAge()
        {
            return age;
        }


        //public static double operator +(StudentZaochnik obj1, StudentZaochnik obj2)
        //{
        //    double res = 0;
        //    double rez1,rez2;
        //    double.TryParse(obj1.getAge(), out rez1);
        //    double.TryParse(obj2.getAge(), out rez2);
        //    res = rez1 + rez2; 
        //    return res;
        //}

        //public static double operator *(StudentZaochnik obj1, StudentZaochnik obj2)
        //{
        //    double res = 0;
        //    double rez1, rez2;
        //    double.TryParse(obj1.getAge(), out rez1);
        //    double.TryParse(obj2.getAge(), out rez2);
        //    res = rez1 * rez2;
        //    return res;
        //}

        //public static double operator - (StudentZaochnik obj1, StudentZaochnik obj2)
        //{
        //    double res = 0;
        //    double rez1, rez2;
        //    double.TryParse(obj1.getAge(), out rez1);
        //    double.TryParse(obj2.getAge(), out rez2);
        //    res = rez1 - rez2;
        //    return res;
        //}

        //public static double operator /(StudentZaochnik obj1, StudentZaochnik obj2)
        //{
        //    double res = 0;
        //    double rez1, rez2;
        //    double.TryParse(obj1.getAge(), out rez1);
        //    double.TryParse(obj2.getAge(), out rez2);
        //    res = rez1 / rez2;
        //    return res;
        //}

        //public static string operator <(StudentZaochnik obj1, StudentZaochnik obj2)
        //{
        //    double rez1, rez2;
        //    double.TryParse(obj1.getAge(), out rez1);
        //    double.TryParse(obj2.getAge(), out rez2);
        //    if (rez1 < rez2)
        //        return "Первый меньше второго";
        //    else
        //        return "Второй меньше первого";
        //}

        //public static string operator >(StudentZaochnik obj1, StudentZaochnik obj2)
        //{
        //    double rez1, rez2;
        //    double.TryParse(obj1.getAge(), out rez1);
        //    double.TryParse(obj2.getAge(), out rez2);
        //    if (rez1 > rez2)
        //        return "Первый больше второго";
        //    else
        //        return "Второй больше первого";
        //}


        //public static string operator !=(StudentZaochnik obj1, StudentZaochnik obj2)
        //{
        //    double rez1, rez2;
        //    double.TryParse(obj1.getAge(), out rez1);
        //    double.TryParse(obj2.getAge(), out rez2);
        //    if (rez1 != rez2)
        //        return "Не равны";
        //    else
        //        return "Равны";
        //}


        //public static string operator ==(StudentZaochnik obj1, StudentZaochnik obj2)
        //{
        //    double rez1, rez2;
        //    double.TryParse(obj1.getAge(), out rez1);
        //    double.TryParse(obj2.getAge(), out rez2);
        //    if (rez1 == rez2)
        //        return "Равны";
        //    else
        //        return "Не равны";
        //}


         public void test(object a)
        {
            a = 2;


            Console.WriteLine(a);
            Console.WriteLine("Метод вызван!");
        }

        public static Tuple<string, string, string, string,string> Cortege(StudentZaochnik obj)
        {
            return Tuple.Create<string, string, string, string,string>(obj.name, obj.Surname, obj.age, obj.Zadolzhennosti, obj.srBal);
        }

        public string CheckSrbal ()
        {
            string result ;

            double rez;
            double.TryParse(srBal, out rez);
            if (rez>= 7.0)
            {
                result = "Вы молодец продолжайте в том же духе";
            }
            else
            {
                result = "Вам следует больше стараться";
            }
                
                
            return result;    
        }

 public string CheckZ()
        {
            double rez;
            double.TryParse(Zadolzhennosti, out rez);
            if (rez == 0)
                return "Задолженности отсутствуют!";
            else
                return "У вас " + rez + " задолженностей, ликвидируйте пожалуйста!!!";
        }


        public void UpAverageMark()
        {
            Console.WriteLine("--------- Событие повышения среднего бала ----------");
            int result;
            Int32.TryParse(this.srBal, out result);
            result++;
            this.srBal = result.ToString();
        }

        public void DownAverageMark()
        {
            Console.WriteLine("--------- Событие понижения среднего бала ----------");
            int result;
            Int32.TryParse(this.srBal, out result);
            result--;
            this.srBal = result.ToString();
        }

    

       public override  void SetInfo()
        {
            Console.Write("Введите имя: "); name = Console.ReadLine();
            Console.Write("Введите фамилию: "); Surname = Console.ReadLine();
            Console.Write("Введите возраст: "); age = Console.ReadLine();
            Console.Write("Введите количество задолженностей: "); Zadolzhennosti = Console.ReadLine();
            Console.Write("Введите средний бал: "); srBal = Console.ReadLine();
        }

        public  override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("-------------Информация о Студенте--------------");
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Количество задолженностей: " + Zadolzhennosti);
            Console.WriteLine("Средний бал: " + srBal);
            Console.WriteLine("------------------------------------------------");
        }

        public void  WriteToFile()
        {
           
                FileStream file = new FileStream("d:\\test.txt", FileMode.Create);
                StreamWriter _out = new StreamWriter(file);

                _out.Write("Имя : " + this.name + "\nФамилия: " + this.Surname);
                _out.Write("\n Возраст : " + this.age + "\nЗадолженности: " + this.Zadolzhennosti);
                _out.Write("\n Средний бал : " + this.srBal);

               file.Close();
          

         }
    

    }
}
