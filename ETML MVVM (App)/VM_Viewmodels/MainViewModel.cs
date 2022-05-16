/**********************************************************************************
* Nom de la classe :
* Auteur :
* Date de création :
* Description de la classe :
*
**********************************************************************************/

/* La classe ViewModel doit avoir accès aux namespaces du modèle et de la vue 
   (le namespace M_Models est à décommenter une fois votre première classe Modèle créee)*/
/*using $safeprojectname$.M_Models;*/
using $safeprojectname$.V_Views;

/* Quelques namespaces utiles */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Text.RegularExpressions;
using Microsoft.UI.Xaml.Controls;
using System.Windows;

namespace $safeprojectname$.VM_ViewModels
{
	
	/* Tous les "ViewModel" hérite de la classe MainViewModelBase */
    public class MainViewModel : MainViewModelBase
    {
        
		/**********************************************************************************
		* Attributs :
		* Doivent avoir une visibilité "private"
		* Doivent commencer par "_" (par exemple : _counter)	
		**********************************************************************************/
		/* A décommenter */
		/* private int _counter; */
		
		
		/**********************************************************************************
		* Propriétés :
		* Ajoute une couche d'abstraction et permet de définir une interface avec la classe
		* sans toucher à la logique interne.
		* Doivent porter le nom de l'attribut et commencer par une lettre majuscule 
		*   (par exemple : Counter)
		*
		* De plus, la propriété notifie un changement et transmets son nom.
		*
		**********************************************************************************/
		/* A décommenter */
		/*public int Counter 
		{
			set 
			{
				_counter = value;
				OnPropertyChanged("Counter");
			}
			
			get
			{
				return _counter;
			}
		}
		*/
		
		
		/**********************************************************************************
		* Constructeur :
		* Initialise l'instance de la classe lorsque le mot clé "new" est utilisé
		**********************************************************************************/
        public MainViewModel()
		{
			/* A décommenter */
			/* 
			Counter = 0;
			*/
		}
		
        /**********************************************************************************
        * Binding avec les commandes. 
        * Cette portition du code permet d'attacher une commande (ICommand) avec la vue.
		* DelegateCommand permet d'associer une fonction (par exemple IncrementCounter) avec 
		* la commande.
        **********************************************************************************/        
		
		/* Exemple */
		/* A décommenter		
		public ICommand OKButtonClicked
        {
            get
            {
                return new DelegateCommand(IncrementCounter);
            }

        }
		*/

        /**********************************************************************************
        * Fonctions associées aux commandes
        * 
        **********************************************************************************/
        /* Exemple */
		/* A décommenter
		public void IncrementCounter()
        {
            Counter++;
        }
		*/
    }
} /* End of file - eof */
