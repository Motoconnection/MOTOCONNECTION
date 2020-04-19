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

        }

        private void dtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MODULOS.Usuarios.frmNuevoUsuario frm = new MODULOS.Usuarios.frmNuevoUsuario();
            frm.Show();
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
    }
}
