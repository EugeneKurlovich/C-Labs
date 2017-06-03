using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleMVVM.Models
{
    class Avia
    {
        public int number { get; set; }
        public string way { get; set; }
        public string weekDay { get; set; }
        public int Count { get; set; }

        public Avia(int n, string w, string wd ,int c)
        {
            number = n;
            way = w;
            weekDay = wd;
            Count = c;
        }
    }
}
