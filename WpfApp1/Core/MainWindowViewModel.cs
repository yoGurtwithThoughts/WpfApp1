using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace WpfApp1.Core
{
    class MainWindowViewModel: INotifyPropertyChanged
    {
        public ICommand CreateCommand { get {
            return _createCommand  (_createCommand=new RelayCommand(param=>CreateNewCommand()))}
        }
        public event PropertyChagedEventHandler? PropertyChanged;
    }
}
