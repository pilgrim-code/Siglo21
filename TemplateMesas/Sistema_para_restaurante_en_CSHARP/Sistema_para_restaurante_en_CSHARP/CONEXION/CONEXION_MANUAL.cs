using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;


namespace Sistema_para_restaurante_en_CSHARP_codigo369.CONEXION
{
    public partial class CONEXION_MANUAL : Form
    {
        private LIBRERIAS.AES aes = new LIBRERIAS.AES();
        int idtabla;
        public CONEXION_MANUAL()
        {
            InitializeComponent();
        }
        public void SavetoXML(Object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        string dbcnString;
        public void ReadfromXML()
        {
            try
            {

                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txtCnString.Text = (aes.Decrypt(dbcnString, LIBRERIAS.Desencryptacion.appPwdUnique, int.Parse("256")));
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {

            }
        }
        private void CONEXION_MANUAL_Load(object sender, EventArgs e)
        {
            ReadfromXML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comprobar_conexion();
        }
        private void comprobar_conexion()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                
                con.ConnectionString = txtCnString.Text;
                SqlCommand com = new SqlCommand("select * from SALON", con);
                con.Open();
                idtabla = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
                SavetoXML(aes.Encrypt(txtCnString.Text, LIBRERIAS.Desencryptacion.appPwdUnique, int.Parse("256")));
                MessageBox.Show("Conexion Exitosa!", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay conexion");
                con.Close();

            }
        
        }


    }
}
