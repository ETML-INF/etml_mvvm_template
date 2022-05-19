/**********************************************************************************
* Nom de la classe : MainWindow.xaml.cs
* Auteur : Bulle SecDevOps
* Date de création : 19.05.2022
* Description de la classe :
* Ce fichier est le "code behind", c'est-à-dire le code derrière le fichier
* XAML correspondant (MainWindow.xaml).
* Il est responsable de charger la fenêtre principale et de charger la page 
* principale.
*
* Des "events handlers" existent déjà et permettent des traiter des événements de
* la GUI (par exemple changement de sélection dans le NavigationView).
*
**********************************************************************************/
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace $safeprojectname$
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {

        /**********************************************************************************
        * Constructeur : initialise la fenêtre et navigue vers la page principale.
        **********************************************************************************/
        public MainWindow()
        {
            this.InitializeComponent();

            // Propre au modèle MVVM ETML, lorsque la fenêtre est initialisée, l'on affiche
            // la page principale.
            mainFrame.Navigate(typeof(V_Views.MainPage));
        }

        /**********************************************************************************
        * Methode (Event Handlers) :
        * Un event handler est une méthode déclenchée lorsqu'un événement se produit.
        * Les arg-in de la méthode sont porteurs des informations de l'événement.
        **********************************************************************************/
        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem item;
            item = args.SelectedItemContainer as NavigationViewItem;

            // "guard clause", on quitte la fonction prématurément.
            if (item == null || item.Tag == null)
            {
                return;
            }

            // Utilise les informations de l'événement pour changer de page.
            mainFrame.Navigate(Type.GetType(item.Tag.ToString()), item.Content);
            NavigationView.Header = item.Content;
            NavigationView.SelectedItem = item;
        }

        /**********************************************************************************
        * Un autre event handler 
        **********************************************************************************/
        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(V_Views.MainPage));
        }
    }
}
