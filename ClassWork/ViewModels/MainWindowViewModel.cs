using ClassWork.Commands;
using ClassWork.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.ViewModels
{
    public class MainWindowViewModel : BaseWindowViewModel
    {
        public AddCommand AddCommand => new AddCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);
        public RejectCommand RejectCommand => new RejectCommand(this);

        private int state = 0;

        public int State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(State)));
            }
        }
    }
}
