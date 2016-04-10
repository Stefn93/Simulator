using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GridExample.ViewModel
{
    public class DynamicGrid : INotifyPropertyChanged
    {
        public DynamicGrid()
        {
            //EditSelectedItemCommand = new RelayCommand(ExecuteEditCommand, CanExecuteEditCommand);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int rows = 50;
        public int Rows
        {
            get { return rows; }
            set { rows = value; NotifyPropertyChanged("Rows"); }
        }

        private int columns = 100;
        public int Columns
        {
            get { return columns; }
            set { columns = value; NotifyPropertyChanged("Columns"); }
        }

        //#region Edit Command Execution
        //public ICommand EditSelectedItemCommand { get; set; }

        //private bool CanExecuteEditCommand(object obj)
        //{
        //    //return SelectedItem != null ? true : false;
        //    return true;
        //}

        //private void ExecuteEditCommand(object obj)
        //{
        //    Columns += 1;
        //    Rows += 1;
        //}
        //#endregion

    }
}
