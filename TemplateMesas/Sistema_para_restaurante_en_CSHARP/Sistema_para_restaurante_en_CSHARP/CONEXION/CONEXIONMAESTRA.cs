using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_para_restaurante_en_CSHARP_codigo369.CONEXION
{
    class CONEXIONMAESTRA
    {
        public static string conexion = Convert.ToString(LIBRERIAS.Desencryptacion.checkServer());
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();



            }

        }


        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();

            }

        }




    }

    


}
