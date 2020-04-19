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

namespace MOTOCONNECTION.MODULOS.Usuarios
{
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }
        public bool Validar_Mail(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar_Mail(txtCorreo.Text) == false)
            {
                MessageBox.Show("Dirección de correo no valida, el correo debe tener el formato: nombre@dominio.com," + "Por favor escriba un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                txtCorreo.SelectAll();
            }
            if (txtNombre.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("nuevo_usuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Rol", cmbRol.Text);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pctICONO.Image.Save(ms, pctICONO.Image.RawFormat);
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

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("editar_usuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", lblID_Usuario.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Rol", cmbRol.Text);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pctICONO.Image.Save(ms, pctICONO.Image.RawFormat);
                    cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer());
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox4.Image;
            lblIcono.Visible = false;
            flwpnlICONOS.Visible = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox5.Image;
            lblIcono.Visible = false;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox6.Image;
            lblIcono.Visible = false;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox7.Image;
            lblIcono.Visible = false;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox8.Image;
            lblIcono.Visible = false;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox9.Image;
            lblIcono.Visible = false;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox10.Image;
            lblIcono.Visible = false;
            flwpnlICONOS.Visible = false;
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pctICONO.BackgroundImage = null;
                pctICONO.Image = new Bitmap(dlg.FileName);
                pctICONO.SizeMode = PictureBoxSizeMode.Zoom;
                lblIcono.Visible = false;
                flwpnlICONOS.Visible = false;

            }
        }
        
        private void lblIcono_Click(object sender, EventArgs e)
        {
            flwpnlICONOS.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

