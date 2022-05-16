/**********************************************************************************
* Nom de la classe : MainViewModelBase
* Auteur : Bulle DevOps
* Date de création : 16.05.2022
* Description de la classe :
* Cette classe abstraite permet l'implémentation de l'événement "OnPropertyChanged"
**********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.VM_ViewModels
{
    public abstract class MainViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
