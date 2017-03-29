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

            string className = "LR3.StudentZaochnik";
            string methodName = "test";
            Reflector.MethodF(className, methodName);
            StudentZaochnik student1 = new StudentZaochnik("Ivan", "Ivanov", "19", "0", "9");
            StudentZaochnik student2 = new StudentZaochnik("Petr", "Mikhaylov", "35", "2", "5");

            Reflector.AllInfoInFile<StudentZaochnik>(student2);

         

            Turner turner1 = new Turner("Eugene", "4", "10");
            Turner turner2 = new Turner("Zhenya", "5", "20");


            Director event1 = new Director();
            Director event2 = new Director();

            event1.UpRankAndAverageBalEvent += turner1.UpRank;
            event1.UpRankAndAverageBalEvent += turner2.UpRank;
            event1.UpRankAndAverageBalEvent += student2.UpAverageMark;

            event2.DownRankAndAverageBalEvent += turner1.DownRank;
            event2.DownRankAndAverageBalEvent += turner2.DownRank;

            student1.PrintInfo();
            student2.PrintInfo();
            turner1.OutToConsole();
            turner2.OutToConsole();

            event1.UseUpRankAndAverageBalEvent();

            turner1.OutToConsole();
            turner2.OutToConsole();
            student2.PrintInfo();

            event2.UseDownRankAndAverageBalEvent();
            turner1.OutToConsole();
            turner2.OutToConsole();
  

            Console.ReadKey();
        }
    }
}
