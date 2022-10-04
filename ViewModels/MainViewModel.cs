using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        string display = "0";
        public string Display
        {
            get => display;
            set
            {
                display = value;
                OnPropertyChanged("Display");
            }
        }
        public string Dot => CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        public Command <string> DigitPress { get; }
        public MainViewModel()
        {
            DigitPress = new Command<string>(digitPress);
        }

        private void digitPress(string obj)
        {
            if (Display == "0" || Display == "-0")
            {
                Display = Display.Trim('0') + obj;
            }
            else
            {
                Display = Display + obj;
            }
        }
    }
}
