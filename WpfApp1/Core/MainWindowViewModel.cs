using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Input;


namespace WpfApp1.Core
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private RelayCommand? _createCommand;

        public ICommand CreateCommand
        {
            get
            {
                return _createCommand ?? (_createCommand = new RelayCommand(param => CreateNewCommand()));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void CreateNewCommand()
        {
        }
    }
}
