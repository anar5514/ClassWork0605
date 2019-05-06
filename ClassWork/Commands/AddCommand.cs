using ClassWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClassWork
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private MainWindowViewModel mainWindow;

        public AddCommand(MainWindowViewModel mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            mainWindow.State = 1;          
                
        }
    }
}
