using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Author
    {
        public string Name;
        public string Surname;
        public int yearsOld;

        public Author()
        {

        }

        public void setData(string N, string S, int Y)
        {
            Name = N;
            Surname = S;
            yearsOld = Y;
        }

        public string getName()
        {
            return Name;
        }
        public string getSurname()
        {
            return Surname;
        }
        public int getYears()
        {
            return yearsOld;
        }

    }
}
