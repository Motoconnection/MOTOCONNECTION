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


namespace MOTOCONNECTION.MODULOS.Login
{
    public partial class frmInicioSesion : Form
    {
        string NombreU;

        public frmInicioSesion(string Str_Value)
        {
            InitializeComponent();
            NombreU = Str_Value;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void cargar_usuarios()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("validar_Usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre", NombreU));
                cmd.Parameters.Add(new SqlParameter("@Contrasena", txtContrasena.Text));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("El nombre y la contraseña no coinciden, verifique la contraseña e intentelo nuevamente");
                else
                {
                    MenuPrincipal.frmMenuPrincipal formulario = new MenuPrincipal.frmMenuPrincipal();
                    formulario.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cargar_usuarios();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtContrasena.Text += "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContrasena.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text != "")
            {
                string txt = txtContrasena.Text;
                txt = txt.Substring(0, txt.Count() - 1);
                txtContrasena.Text = txt;
            }
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
