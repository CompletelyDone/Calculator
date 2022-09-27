﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        string display = "Doroy";
        public string Display
        {
            get => display;
            set
            {
                display = value;
                OnPropertyChanged("Display");
            }
        }
    }
}