using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
   public class AviaCompany : INotifyPropertyChanged
    {

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public int number { get; set; }
        public string weekDay { get; set; }
        public string way { get; set; }
        public int ammount { get; set; }

        public AviaCompany(int n, string wd, string w, int a)
        {
            number = n;
            weekDay = wd;
            way = w;
            ammount = a;
        }

        public AviaCompany()
        {

        }
    }
}
