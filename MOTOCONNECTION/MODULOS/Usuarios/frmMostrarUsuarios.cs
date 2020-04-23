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
    public partial class frmMostrarUsuarios : Form
    {
        public frmMostrarUsuarios()
        {
            InitializeComponent();
        }
        String IdUsuario;
        private void frmMostrarUsuarios_Load(object sender, EventArgs e)
        {
            mostrar_usuarios();
        }

        private void mostrar_usuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
                con.Open();
                da = new SqlDataAdapter("mostrar_usuarios", con);
                da.Fill(dt);
                dtgUsuarios.DataSource = dt;
                con.Close();
                dtgUsuarios.Columns[1].Visible = false;
                dtgUsuarios.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CONEXIONES.TamañoAutomaticoDeDatabase.Multilinea(ref dtgUsuarios);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            IdUsuario = dtgUsuarios.SelectedCells[1].Value.ToString();
            panelEditarUsuarios.Visible = true;
            lblMostrar.Visible = false;
            lblEditar.Visible = true;
            txtNombre.Text = dtgUsuarios.SelectedCells[2].Value.ToString();
            txtContrasena.Text = dtgUsuarios.SelectedCells[3].Value.ToString();

            pctICONO.BackgroundImage = null;
            byte[] b = (Byte[])dtgUsuarios.SelectedCells[4].Value;
            MemoryStream ms = new MemoryStream(b);
            pctICONO.Image = Image.FromStream(ms);


            txtCorreo.Text = dtgUsuarios.SelectedCells[5].Value.ToString();
            cmbRol.Text = dtgUsuarios.SelectedCells[6].Value.ToString();
            panel4.Visible = true;
            btnGuardarCambios.Visible = true;
        }

        private void dtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            IdUsuario=dtgUsuarios.SelectedCells[1].Value.ToString();
            panelEditarUsuarios.Visible = true;
            lblMostrar.Visible = false;
            lblEditar.Visible = true;
            txtNombre.Text = dtgUsuarios.SelectedCells[2].Value.ToString();
            txtContrasena.Text = dtgUsuarios.SelectedCells[3].Value.ToString();

            pctICONO.BackgroundImage = null;
            byte[] b = (Byte[])dtgUsuarios.SelectedCells[4].Value;
            MemoryStream ms = new MemoryStream(b);
            pctICONO.Image = Image.FromStream(ms);


            txtCorreo.Text = dtgUsuarios.SelectedCells[5].Value.ToString();
            cmbRol.Text = dtgUsuarios.SelectedCells[6].Value.ToString();
            panel4.Visible = true;
            btnGuardarCambios.Visible = true;
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dtgUsuarios.Columns["Eliminar_Usuario"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente desea eliminar este usuario?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("1");
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in dtgUsuarios.SelectedRows)
                        {
                            MessageBox.Show("2");

                            int onekey = Convert.ToInt32(row.Cells["idUsuario"].Value);
                            string Nombre = Convert.ToString(row.Cells["Nombre"].Value);
                            try
                            {
                                try
                                {
                                    MessageBox.Show("3");

                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_usuario", con);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("IdUsuario", onekey);
                                    cmd.Parameters.AddWithValue("Nombre", Nombre);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        mostrar_usuarios();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
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
                    cmd.Parameters.AddWithValue("@idUsuario", Convert.ToInt32(IdUsuario));
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Rol", cmbRol.Text);

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pctICONO.Image.Save(ms, pctICONO.Image.RawFormat);
                    cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer());

                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrar_usuarios();
                    panelEditarUsuarios.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox4.Image;
            flwpnlICONOS.Visible = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox5.Image;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox6.Image;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox7.Image;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox8.Image;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox9.Image;
            flwpnlICONOS.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pctICONO.Image = pictureBox10.Image;
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
                flwpnlICONOS.Visible = false;

            }
        }

        private void pctICONO_Click(object sender, EventArgs e)
        {
            flwpnlICONOS.Visible = true;
        }
    }
}
