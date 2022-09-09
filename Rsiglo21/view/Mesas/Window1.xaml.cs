using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Rsiglo21.view.Mesas
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string con = "DATA SOURCE = (DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(Host=localhost)(Port=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl))); " +
          "PASSWORD=admin; USER ID= pilgrim;";

        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection ora = new OracleConnection(con);

            ora.Open();
            OracleCommand cmd = new OracleCommand("agregar_mesa", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("mesa", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
           
            ora.Close();


        }
        private void dibujarMesas()
        {
            OracleConnection ora = new OracleConnection(con);

            ora.Open();
            OracleCommand cmd = new OracleCommand("listarMesas", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("mesa", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            PanelMesas.ItemsSource = tabla.AsDataView();




            ora.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
