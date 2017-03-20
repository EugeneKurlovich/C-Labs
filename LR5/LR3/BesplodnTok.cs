using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    delegate int del(int i);

    public class Turner: Object
    {
        public Turner(string n, string r, string s)
        {
            this.name = n;
            this.razryad = r;
            this.stazh = s;
        }
        string name { set; get; }
        string razryad { set; get; }
        string stazh { set; get; }

        public void UpRank()
        {
            Console.WriteLine("--------- Событие повышения разряда ----------");
            int result;
            Int32.TryParse(this.razryad, out result);
            result++;
            this.razryad = result.ToString();
        }

        public void DownRank()
        {
            Console.WriteLine("--------- Событие понижения разряда ----------");
            int result;
            Int32.TryParse(this.razryad, out result);
            result--;
            this.razryad = result.ToString();
        }

        public void OutToConsole()
        {
            Console.WriteLine("--------------Информация о токаре---------------");
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Разряд: " + razryad);
            Console.WriteLine("Стаж: " + stazh);
            Console.WriteLine("------------------------------------------------");
        }

    }
}
