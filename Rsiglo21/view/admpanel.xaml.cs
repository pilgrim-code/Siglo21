using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rsiglo21.view
{
    /// <summary>
    /// Interaction logic for admpanel.xaml
    /// </summary>
    public partial class admpanel : Window
    {

        public admpanel()
        {
            InitializeComponent();
           // RadioButton rdFinanzas = new RadioButton();
          //  

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void TBShow(object sender, RoutedEventArgs e)
        {
            
        }

        private void TBHide(object sender, RoutedEventArgs e)
        {
           
        }

        private void PMLBDown(object sender, MouseButtonEventArgs e)
        {
            MostrarOcultar.IsChecked = false;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdUsuarios_Click(object sender, RoutedEventArgs e)
        {
            // PagesNavigation.Navigate(new HomePage());

            PagesNavigation.Navigate(new System.Uri("view/Usuarios.xaml", UriKind.RelativeOrAbsolute));
           // rdFinanzas.Visibility = false;
        }

        private void rdCocina_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("view/Cocina.xaml", UriKind.RelativeOrAbsolute));
        }
        private void rdMesas_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("view/Mesa.xaml", UriKind.RelativeOrAbsolute));
        }


        private void rdBodega_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("view/Bodega.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdFinanzas_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("view/Finanzas.xaml", UriKind.RelativeOrAbsolute));
        }

        private void PagesNavigation_Navigated(object sender, NavigationEventArgs e)
        {

        }


        private void PagesNavigation_Navigated_1(object sender, NavigationEventArgs e)
        {

        }
    }
}
