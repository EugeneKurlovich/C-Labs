using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVM.View_Models
{
    class AviaCompanyViewModel :  INotifyPropertyChanged
    {
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;


        Models.AviaCompany AviaCompany = new Models.AviaCompany();

        public AviaCompanyViewModel (Models.AviaCompany obj)
        {
            this.AviaCompany = obj;
        }
    
        public int number
        {
            get { return AviaCompany.number; }
            set
            {
                AviaCompany.number = value;
                OnPropertyChanged("number");
            }
       
        }

        public string weekDay
        {
            get { return AviaCompany.weekDay; }
            set
            {
                AviaCompany.weekDay = value;
                OnPropertyChanged("weekDay");
            }
        }
        public int ammount
        {
            get { return AviaCompany.ammount; }
            set
            {
                AviaCompany.ammount = value;
                OnPropertyChanged("ammount");
            }
        }
        public string way
        {
            get { return AviaCompany.way; }
            set
            {
                AviaCompany.way = value;
                OnPropertyChanged("way");
            }
        }
    }
}
