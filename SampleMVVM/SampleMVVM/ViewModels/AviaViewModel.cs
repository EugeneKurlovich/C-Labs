using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleMVVM.Models;
using SampleMVVM.Commands;
using System.Windows.Input;

namespace SampleMVVM.ViewModels
{
    class AviaViewModel : ViewModelBase
    {
        public Avia reis;

        public AviaViewModel(Avia r)
        {
            this.reis = r;
        }

        public int number
        {
            get { return reis.number; }
            set 
            {
                reis.number = value;
                OnPropertyChanged("number");
            }
        }

        public string weekDay
        {
            get { return reis.weekDay; }
            set
            {
                reis.weekDay = value;
                OnPropertyChanged("weekDay");
            }
        }

        public string way
        {
            get { return reis.way; }
            set
            {
                reis.way = value;
                OnPropertyChanged("way");
            }
        }

        public int Count
        {
            get { return reis.Count; }
            set
            {
                reis.Count = value;
                OnPropertyChanged("Count");
            }
        }


        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem);
                }
                return getItemCommand;
            }
        }

        private void GetItem()
        {
            Count++;
        }


        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);
                }
                return giveItemCommand;
            }
        }

        private void GiveItem()
        {
            Count--;
        }

        private bool CanGiveItem()
        {
            return Count > 0;
        }

    }
}
