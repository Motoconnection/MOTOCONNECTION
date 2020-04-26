using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace MOTOCONNECTION.MODULOS.Productos
{
    public partial class FormNuevoProducto : Form
    {
        public FormNuevoProducto()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (txtBarcode.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("nuevo_usuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtCod_part.Text);
                    cmd.Parameters.AddWithValue("@Correo", txtNombreP.Text);
                    //cmd.Parameters.AddWithValue("@Rol", cmbRol.Text);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                   
                    cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer());
                    cmd.Parameters.AddWithValue("@Estado", "Activo");
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }

        
    }
}
