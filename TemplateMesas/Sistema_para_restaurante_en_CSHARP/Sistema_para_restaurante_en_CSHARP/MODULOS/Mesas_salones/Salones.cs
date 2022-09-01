using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_para_restaurante_en_CSHARP_codigo369.MODULOS.Mesas_salones
{
    public partial class Salones : Form
    {
        int idsalon;
        public Salones()
        {
            InitializeComponent();
        }

        private void Salones_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            txtSalonedicion.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertar_salon();
        }
        private void insertar_mesas_vacias()
        {
            for (int i = 1; i < 80; i++)
            {
                try
                {
                    CONEXION.CONEXIONMAESTRA.abrir();
                    SqlCommand cmd = new SqlCommand("insertar_mesa", CONEXION.CONEXIONMAESTRA.conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mesa", "NULO");
                    cmd.Parameters.AddWithValue("@idsalon", idsalon);
                    cmd.ExecuteNonQuery();
                    CONEXION.CONEXIONMAESTRA.Cerrar();
                }
                catch (Exception e)
                {
                    CONEXION.CONEXIONMAESTRA.Cerrar();
                    MessageBox.Show(e.StackTrace);
                }
            }

        }

        private void mostrar_id_salon_recien_ingresado()
        {
            SqlCommand com = new SqlCommand("mostrar_id_salon_recien_ingresado", CONEXION.CONEXIONMAESTRA.conectar);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Salon",txtSalonedicion.Text);

            try
            {
                CONEXION.CONEXIONMAESTRA.abrir();
                idsalon = Convert.ToInt32(com.ExecuteScalar());
                CONEXION.CONEXIONMAESTRA.Cerrar();

            }
            catch (Exception ex)
            {
                CONEXION.CONEXIONMAESTRA.Cerrar();
                MessageBox.Show(ex.StackTrace);

            }


        }


        private void txtSalonedicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertar_salon()
        {
            try
            {

                CONEXION.CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("inserta_Salon",CONEXION.CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Salon",txtSalonedicion.Text);
                cmd.ExecuteNonQuery();
                CONEXION.CONEXIONMAESTRA.Cerrar();
                mostrar_id_salon_recien_ingresado();
                insertar_mesas_vacias();
                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CONEXION.CONEXIONMAESTRA.conectar.Close();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
