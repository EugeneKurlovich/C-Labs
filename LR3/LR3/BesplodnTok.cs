using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    delegate int del(int i);

    public sealed class BesplodnTok: Object
    {
        private BesplodnTok()
        {           
            Console.WriteLine("Tokar is one");
            name = "Singelton";
            razryad = "1";
            stazh = "1"; 
        }

        public static BesplodnTok getTokar()
        {
            if (Check == null)
            {
                Check = new BesplodnTok();
            }
            return Check;
        }
        static BesplodnTok Check;
        string name { set; get; }
        string razryad { set; get; }
        string stazh { set; get; }

        public override string ToString()
        {
            del myDelegate = x => x * x - x;
            int j = myDelegate(7);

            return j.ToString();
        }
        
        public override bool Equals(Object obj1)
        {
            BesplodnTok obj = obj1 as BesplodnTok;
            if (this.name == obj.name && this.razryad == obj.razryad && this.stazh == obj.stazh)
                return true;
            else return false;
        }
        
        public override int GetHashCode()
        {
            int result1;
            Int32.TryParse(stazh, out result1);
            int result2;
            Int32.TryParse(razryad, out result2);

            return (result1 * result2) & name.GetHashCode();
        }

    }
}
