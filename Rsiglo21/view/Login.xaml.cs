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
using System.Windows.Shapes;
using System.Data.OracleClient;
using Oracle;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using Oracle.ManagedDataAccess;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Rsiglo21.view
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary> 
   
    public partial class Login : Window
    {
        public string con = "DATA SOURCE = (DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(Host=localhost)(Port=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl))); " +
           "PASSWORD=admin; USER ID= admi;";
        public Login()
        {
            InitializeComponent();
            conexion();
        }
        
        public void conexion()
        {
            OracleConnection ora = new OracleConnection(con);
            ora.Open();

            ora.Close();

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void bntMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void bntClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection ora = new OracleConnection(con);      
            string contra = txtPass.Password.ToString();
            ora.Open();
            OracleCommand cmd = new OracleCommand("Select * from usuario where nombre = :usuario and password = :contra", ora);
            cmd.Parameters.Add(":usuario", txtUser.Text);
            cmd.Parameters.Add(":contra", txtPass.Password.ToString());

            OracleDataReader lector = cmd.ExecuteReader();

            if (lector.Read())
            {
                MainWindow main = new MainWindow();
                ora.Close();
                main.Owner = this;
                
                main.Show();
                
                this.Visibility = Visibility.Collapsed;

            }
            else
            {
                MessageBox.Show("error");
            }
            
        }
    }
}
