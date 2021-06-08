using System;
using System.Windows.Input;

namespace HomeWork.Core
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action executeAction;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeAction();
        }
        public RelayCommand(Action executeAction)
        {
            this.executeAction = executeAction;
        }
    }
}
