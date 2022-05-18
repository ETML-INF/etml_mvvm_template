
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

// La classe DelegateCommand doit implémenter les méthodes prévues par l'interface "ICommand"

namespace $safeprojectname$.VM_ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class DelegateCommand : ICommand
    {
        private SimpleEventHandler _handler;
        private bool _isEnabled = true;

        public event EventHandler CanExecuteChanged;

        public delegate void SimpleEventHandler();

        // Constructeurs
        public DelegateCommand(SimpleEventHandler hFunction)
        {
            _handler = hFunction;
        }

        // Propriétés
        public bool IsEnabled
        {
            get 
            { 
                return _isEnabled; 
            }

            // no setter
        }

        public void Execute(object parameter)
        {
            _handler();
        }


        // Retourne vrai si la commande peut être exécutée.
        public bool CanExecute(object parameter)
        {
            return this.IsEnabled;
        }

        
        public void OnCanExecuteChanged()
        {
            if (CanExecuteChanged != null) 
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
        

    }
}
