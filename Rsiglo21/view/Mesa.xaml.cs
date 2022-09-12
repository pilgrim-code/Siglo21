﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rsiglo21.view
{
    /// <summary>
    /// Lógica de interacción para Mesa.xaml
    /// </summary>
    public partial class Mesa : Page
    {
        public string con = "DATA SOURCE = (DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(Host=localhost)(Port=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl))); " +
          "PASSWORD=admin; USER ID= pilgrim;";
        public Mesa()
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
            OracleCommand cmd = new OracleCommand("id_mesa", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("mesa", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgMesas.ItemsSource = tabla.AsDataView();

            ora.Close();
        }

        private void AgregarMesa(object sender, RoutedEventArgs e)
        {
            OracleConnection ora = new OracleConnection(con);

            try
            {
                ora.Open();


                OracleCommand cmd = new OracleCommand("agregar_mesa", ora);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (idM.Text.Length >= 1 && cPersonas.Text.Length >= 1)
                {
                    cmd.Parameters.Add("id_m", OracleType.Number).Value = Convert.ToInt32(idM.Text);
                    cmd.Parameters.Add("cant_p", OracleType.Number).Value = Convert.ToInt32(cPersonas.Text);
                    MessageBox.Show("Mesa añadida");
                }
                else
                {
                    MessageBox.Show("Ingrese ID  Y cantidad de personas");
                }



            }
            catch (Exception)
            {

                MessageBox.Show("Error");

            }
            ora.Close();
        }

        private void actualizarMesa(object sender, RoutedEventArgs e)
        {
            cargarDT();
        }

        private void EliminarM(object sender, RoutedEventArgs e)
        {
            OracleConnection ora = new OracleConnection(con);
            ora.Open();


            OracleCommand cmd = new OracleCommand("eliminar_mesa", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (idM.Text.Length >= 1)
            {
                cmd.Parameters.Add("id_m", OracleType.Number).Value = Convert.ToInt32(idM.Text);
                MessageBox.Show("Mesa Eliminada");
                ora.Close();
            }
            else
            {
                MessageBox.Show("Ingrese ID Valido");
                ora.Close();
            }


        }
    }
}
