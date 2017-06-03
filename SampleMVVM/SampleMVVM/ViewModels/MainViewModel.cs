using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

using SampleMVVM.Commands;
using System.Collections.ObjectModel;
using SampleMVVM.Models;

namespace SampleMVVM.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<AviaViewModel> AviaList { get; set; } 


        public MainViewModel(List<Avia> reis)
        {
            AviaList = new ObservableCollection<AviaViewModel>(reis.Select(b => new AviaViewModel(b)));
        }

  
    }
}
