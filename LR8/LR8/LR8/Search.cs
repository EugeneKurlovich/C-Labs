using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LR8
{
    class Search
    {
      static List<Library> SearchList = new List<Library>();

        public List<Library> L
        {
            get
            {
                return SearchList;
            }
        }


        public void firstSearch(string PH)
        {
            Regex regex = new Regex(PH);
            Library getL = new Library();
            List<Library> getList = new List<Library>();
            getList = getL.GiveBook();

            foreach (Library i in getList)
            {
                if (regex.IsMatch(i.PH))
                {
                    SearchList.Add(i);
                }
            }
        }

        public void secondSearch(int year)
        {
            Regex regex = new Regex(year.ToString());
            Library getL = new Library();
            List<Library> getList = new List<Library>();
            getList = getL.GiveBook();

            foreach (Library i in getList)
            {
                if (regex.IsMatch(i.Y.ToString()))
                {
                    SearchList.Add(i);
                }
            }
        }

        public void thirdSearch(string date)
        {
            Regex regex = new Regex(date);
            Library getL = new Library();
            List<Library> getList = new List<Library>();
            getList = getL.GiveBook();
                      
            foreach (Library i in getList)
            {
                if (regex.IsMatch(i.D))
                {
                    SearchList.Add(i);
                }
            }

        }

        public void fourthSearch(int start, int end)
        {
            Library getL = new Library();
            List<Library> getList = new List<Library>();
            getList = getL.GiveBook();


            foreach (Library i in getList)
            {
                if (i.P > start && i.P < end)
                {
                    SearchList.Add(i);
                }
            }

        }

    }
}
