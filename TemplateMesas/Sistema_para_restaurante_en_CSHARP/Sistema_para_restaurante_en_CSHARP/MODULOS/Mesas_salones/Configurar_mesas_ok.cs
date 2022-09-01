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
    public partial class Configurar_mesas_ok : Form
    {
        int id_salon;
        string estado;

        public Configurar_mesas_ok()
        {
            InitializeComponent();
        }

        private void Configurar_mesas_ok_Load(object sender, EventArgs e)
        {
            PanelBienvenida.Dock = DockStyle.Fill;
            dibujarSalones();
        }
        private void dibujarSalones()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                CONEXION.CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("mostrar_SALON",CONEXION.CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", txtSalon.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    Button b = new Button();
                    Panel panelC1 = new Panel();
                    b.Text = rdr["Salon"].ToString();
                    b.Name = rdr["Id_salon"].ToString();
                    b.Dock = DockStyle.Fill;
                    b.BackColor = Color.Transparent;
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                    b.FlatAppearance.MouseDownBackColor = Color.FromArgb(43, 43, 43);
                    b.TextAlign = ContentAlignment.MiddleLeft;
                    b.Tag = rdr["Estado"].ToString();

                    panelC1.Size = new System.Drawing.Size(290, 58);
                    panelC1.Name = rdr["Id_salon"].ToString();
                    string estado;
                    estado = rdr["Estado"].ToString();

                    if (estado == "ELIMINADO")
                    {
                        b.Text = rdr["Salon"].ToString() + " - Eliminado";
                        b.ForeColor = Color.FromArgb(231, 63, 67);

                    }
                    else
                    {
                        b.ForeColor = Color.White;
                    }
                    panelC1.Controls.Add(b);
                    flowLayoutPanel1.Controls.Add(panelC1);
                    b.Click += new EventHandler(miEvento_salon_button);

                }
                CONEXION.CONEXIONMAESTRA.Cerrar();

            }
            catch (Exception ex)
            {
                CONEXION.CONEXIONMAESTRA.Cerrar();
                MessageBox.Show(ex.StackTrace);

            }
        }

        private void dibujarMesas()
        {

           
            try
            {
                PanelMesas.Controls.Clear();
                CONEXION.CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("mostrar_mesas_por_salon", CONEXION.CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_salon", id_salon);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Button b = new Button();
                    Panel panel = new Panel();
                    int alto = Convert.ToInt32(rdr["y"].ToString());
                    int ancho = Convert.ToInt32(rdr["x"].ToString());
                    int tamanio_letra = Convert.ToInt32(rdr["Tamanio_letra"].ToString());
                    Point tamanio = new Point(ancho, alto);
                    panel.BackgroundImage = Properties.Resources.mesa_vacia;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    panel.Cursor = Cursors.Hand;
                    panel.Tag = rdr["Id_mesa"].ToString();

                    b.Text = rdr["Mesa"].ToString();
                    b.Name = rdr["Id_mesa"].ToString();

                    if(b.Text != "NULO")
                    {

                        b.Size = new System.Drawing.Size(tamanio);
                        b.BackColor = Color.FromArgb(5, 179, 90);
                        b.Font = new System.Drawing.Font("Microsoft Sans Serif", tamanio_letra);
                        b.FlatStyle = FlatStyle.Flat;
                        b.ForeColor = Color.White;
                        PanelMesas.Controls.Add(b);



                    }
                    else
                    {
                        PanelMesas.Controls.Add(panel);
                    }


                }

                CONEXION.CONEXIONMAESTRA.Cerrar();

            }
            catch (Exception e)
            {
                CONEXION.CONEXIONMAESTRA.Cerrar();
                MessageBox.Show(e.StackTrace);
                
            }

        }

        private void miEvento_salon_button(System.Object sender , EventArgs e)
        {
            PanelBienvenida.Visible = false;
            PanelBienvenida.Dock = DockStyle.None;
            PanelMesas.Dock = DockStyle.Fill;
            id_salon = Convert.ToInt32(((Button)sender).Name);
            estado = Convert.ToString(((Button)sender).Tag);
            dibujarMesas();
            foreach (Panel PanelC1 in flowLayoutPanel1.Controls)
            {

                if(PanelC1 is Panel)
                {
                    foreach (Button boton in PanelC1.Controls)
                    {
                        if(boton is Button)
                        {
                            boton.BackColor = Color.Transparent;
                            break;
                        }

                    }
                }

            }

            string NOMBRE = Convert.ToString(((Button)sender).Name);
            foreach (Panel PanelC1 in flowLayoutPanel1.Controls)
            {
                if(PanelC1 is Panel)
                {
                    foreach (Button boton in PanelC1.Controls)
                    {
                        if(boton is Button)
                        {
                            if(boton.Name == NOMBRE)
                            {
                                boton.BackColor = Color.OrangeRed;
                                break;

                            }
                        }

                    }


                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MODULOS.Mesas_salones.Salones frm = new MODULOS.Mesas_salones.Salones();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.ShowDialog();
        }
        void frm_FormClosed(Object sender,FormClosedEventArgs e)
        {
            dibujarSalones();
        }

        private void Configurar_mesas_ok_FormClosed(object sender,FormClosedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

}
