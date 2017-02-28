using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShoeStoreMvvm.Commands
{
    public class RelayCommand:ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;
        public RelayCommand(Action<object> _execute,Predicate<object> _canExecute)
        {
            if (_execute == null)
            {
                throw new ArgumentException("execute");
            }
            this._execute = _execute;
            this._canExecute = _canExecute;
        }
        public RelayCommand(Action<object> _execute)
            : this(_execute, null)
        {

        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
