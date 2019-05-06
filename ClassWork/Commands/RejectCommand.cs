using ClassWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClassWork.Commands
{
    public class RejectCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private MainWindowViewModel mainWindowViewModel;

        public RejectCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainWindowViewModel.State = 2;
        }
    }
}
