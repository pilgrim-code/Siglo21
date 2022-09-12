using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
using System.Data.OracleClient;
using Oracle;


namespace Rsiglo21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string con = "DATA SOURCE = (DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(Host=localhost)(Port=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl))); " +
           "PASSWORD=jleal; USER ID= galletaleal;";
        public MainWindow()
        {
            InitializeComponent();
            conexion();
            cargarDT();
        }

        public void conexion()
        {
            OracleConnection ora = new OracleConnection(con);
            ora.Open();

            ora.Close();

        }
        private void cargarDT()
        {
            OracleConnection ora = new OracleConnection(con);
           // OracleCommand cmd = new OracleCommand("select * from cliente", ora);
            //ora.Open();            
            //cmd.CommandType = CommandType.Text;

          
            OracleCommand cmd = new OracleCommand("cargadatos", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

             OracleDataAdapter adaptador = new OracleDataAdapter();
             adaptador.SelectCommand = cmd;
             DataTable tabla = new DataTable();
             adaptador.Fill(tabla);

            dgclientes.ItemsSource = tabla.AsDataView();


            ora.Close();
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgclientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
