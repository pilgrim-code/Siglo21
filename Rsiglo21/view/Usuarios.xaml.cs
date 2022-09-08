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

namespace Rsiglo21.view
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Page
    {
        public string con = "DATA SOURCE = (DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(Host=localhost)(Port=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl))); " +
           "PASSWORD=admin; USER ID= pilgrim;";

        public Usuarios()
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
       
            ora.Open();
            OracleCommand cmd = new OracleCommand("selectusuario", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg.ItemsSource = tabla.AsDataView();

           

            ora.Close();
        }
    }
}
