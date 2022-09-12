using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
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
using System.Data.OracleClient;
using Oracle;
namespace Rsiglo21.view
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Bodega : Page
    {
        public string con = "DATA SOURCE = (DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(Host=localhost)(Port=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl))); " +
        "PASSWORD=galletaleal; USER ID= jleal;";

        public Bodega()
        {
            InitializeComponent();
            conexion();
            ListarBodega();
        }

        public void conexion()
        {
            OracleConnection ora = new OracleConnection(con);
            ora.Open();

            ora.Close();

        }

        private void ListarBodega()
        {
            OracleConnection ora = new OracleConnection(con);

            ora.Open();
            OracleCommand cmd = new OracleCommand("LISTAR_BODEGA", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("bodega", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_bodega.ItemsSource = tabla.AsDataView();

            ora.Close();
        }

        private void btn_Insertar_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection ora = new OracleConnection(con);
            try
            {
                ora.Open();
                OracleCommand cmd = new OracleCommand("INSERTAR_BODEGA", ora);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int64).Value = txt_idproducto.Text;
                cmd.Parameters.Add("nom", OracleDbType.Varchar2).Value = txt_idproducto.Text;
                cmd.Parameters.Add("kilos", OracleDbType.Varchar2).Value = txt_idproducto.Text;
                cmd.Parameters.Add("litros", OracleDbType.Varchar2).Value = txt_idproducto.Text;
                cmd.Parameters.Add("stock", OracleDbType.Varchar2).Value = txt_idproducto.Text;
                cmd.Parameters.Add("fecha", OracleDbType.Varchar2).Value = txt_idproducto.Text;
                cmd.ExecuteNonQuery(); ;
                MessageBox.Show("Producto insertado");
            }
            catch
            {
                MessageBox.Show("Algo fallo");
            }

            ora.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }


    }
}
