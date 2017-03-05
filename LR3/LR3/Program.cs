using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentZaochnik stud1 = new StudentZaochnik();
            StudentZaochnik stud2 = new StudentZaochnik();
            stud1.SetInfo();
            stud2.SetInfo();
            stud1.PrintInfo();
            Console.WriteLine(stud1.CheckSrbal());
            BesplodnTok bbb = BesplodnTok.getTokar();
            InterfaceLearn a = bbb as InterfaceLearn;
            stud1.WriteToFile();


            Console.WriteLine(a.SetInfo());  

            var cortege = StudentZaochnik.Cortege(stud1);
            Console.WriteLine(" {0} \n {1} \n {2} \n {3} \n {4} \n", cortege.Item1, cortege.Item2, cortege.Item3, cortege.Item4, cortege.Item5);
            BesplodnTok tokar1 = BesplodnTok.getTokar();

            Console.WriteLine(tokar1.ToString());
            Console.WriteLine(tokar1.GetType());
            Console.WriteLine(tokar1.GetHashCode());


            try
            {
                int variable1 = 10;
                int variable2 = 300000000;
                checked
                {
                    variable1 *= variable2;
                }

            }
            catch (OverflowException i)
            {
                Console.WriteLine(i.Message);
            }

            BesplodnTok tokar2 = null;
            try
            {

                if (tokar2.ToString() == null)
                {
                    throw new System.NullReferenceException();
                }
            }

            catch (System.NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Блок выполнился!!!");
            }


    
            Console.WriteLine(stud1 + stud2);
            Console.WriteLine(stud1 - stud2);
            Console.WriteLine(stud1 * stud2);
            Console.WriteLine(stud1 / stud2);
            Console.WriteLine(stud1 > stud2);
            Console.WriteLine(stud1 < stud2);
            Console.WriteLine(stud1 == stud2);
            Console.WriteLine(stud1 != stud2);


            SaveState save = new SaveState();

            StudentZaochnik studMemento = new StudentZaochnik();
            studMemento.SetInfo();
            save.History.Push(studMemento.SaveState());
            studMemento.PrintInfo();
            studMemento.SrUp();
            studMemento.PrintInfo();
            studMemento.RestoreState(save.History.Pop());

            
            Object obj = studMemento as Object;

            if (studMemento is StudentZaochnik)
            {
                Console.WriteLine("studmemento is StudentZaochnik");
            }


            Console.ReadKey();
        }
    }
}
