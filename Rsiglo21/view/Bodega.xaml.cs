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
using System.Globalization;
using OracleInternal.SqlAndPlsqlParser;
using Oracle.ManagedDataAccess.Types;

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
            

        }

        public void conexion()
        {
            OracleConnection ora = new OracleConnection(con);
            ora.Open();

            ora.Close();

        }
        
        //Se añaden productos a la bbdd
        private void btn_Insertar_Click(object sender, RoutedEventArgs e)
        {
            string fecha_nueva = dt_fecha.SelectedDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            OracleConnection ora = new OracleConnection(con);
            ora.Open();
            OracleCommand cmd = new OracleCommand("INSERTAR_BODEGA", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(":idproducto", OracleDbType.Int64, Int32.Parse(txt_idproducto.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":nombreproducto", OracleDbType.Varchar2, txt_nombreproducto.Text, ParameterDirection.Input);
            cmd.Parameters.Add(":kilos", OracleDbType.Double, Double.Parse(txt_kg.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":litros", OracleDbType.Double, Double.Parse(txt_lt.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":stock", OracleDbType.Int64, Int64.Parse(txt_stock.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":fecha", OracleDbType.Date, DateTime.Parse(dt_fecha.SelectedDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)), ParameterDirection.Input);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Producto añadido");
            ora.Close();
        }




            private void btn_Actualizar_Click(object sender, RoutedEventArgs e)
        {
            string fecha_nueva = dt_fecha.SelectedDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            OracleConnection ora = new OracleConnection(con);

            ora.Open();
            OracleCommand cmd = new OracleCommand("ACTUALIZAR_BODEGA", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(":idproducto", OracleDbType.Int64, Int32.Parse(txt_idproducto.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":nombreproducto", OracleDbType.Varchar2, txt_nombreproducto.Text, ParameterDirection.Input);
            cmd.Parameters.Add(":kilos", OracleDbType.Double, Double.Parse(txt_kg.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":litros", OracleDbType.Double, Double.Parse(txt_lt.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":stock", OracleDbType.Int64, Int64.Parse(txt_stock.Text), ParameterDirection.Input);
            cmd.Parameters.Add(":fecha", OracleDbType.Date, DateTime.Parse(dt_fecha.SelectedDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)), ParameterDirection.Input);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Producto actualizado");
            ora.Close();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Listar_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection ora = new OracleConnection(con);

            ora.Open();
            OracleCommand cmd = new OracleCommand("LISTAR_BODEGA", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("id_producto", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_bodega.ItemsSource = tabla.AsDataView();

            ora.Close();
        }

        private void btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection ora = new OracleConnection(con);

            ora.Open();
            OracleCommand cmd = new OracleCommand("ELIMINAR_BODEGA", ora);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("id_producto", OracleDbType.Int64, Int64.Parse(txt_idproducto.Text), ParameterDirection.Input);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Producto eliminado");
            ora.Close();
        }

    }
}
