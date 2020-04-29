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


namespace MOTOCONNECTION.MODULOS.Clientes
{
    public partial class frmMostrarClientes : Form
    {
        String IdCliente;

        public frmMostrarClientes()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mostrar_clientes()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
                con.Open();
                da = new SqlDataAdapter("mostrar_clientes", con);
                da.Fill(dt);
                dtgClientes.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CONEXIONES.TamañoAutomaticoDeDatabase.Multilinea(ref dtgClientes);

        }

        private void frmMostrarClientes_Load(object sender, EventArgs e)
        {
            mostrar_clientes();
        }
        private void buscar_cliente()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
            con.Open();

            da = new SqlDataAdapter("buscar_cliente", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@letra", txtBusquedaCliente.Text);
            da.Fill(dt);
            if (dt.Rows.Count!=0)
            {
                dtgClientes.DataSource = dt;
            }

            con.Close();          
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtBusquedaCliente.Text != "")
            {
                buscar_cliente();
            }
        }

        private void dtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCliente= dtgClientes.SelectedCells[1].Value.ToString();
            txtNombre.Text = dtgClientes.SelectedCells[2].Value.ToString();
            txtCorreo.Text = dtgClientes.SelectedCells[3].Value.ToString();
            txtTelefono.Text = dtgClientes.SelectedCells[4].Value.ToString();
            txtDireccion.Text = dtgClientes.SelectedCells[5].Value.ToString();
            txtPorcentaje.Text = dtgClientes.SelectedCells[6].Value.ToString();
            txtPais.Text = dtgClientes.SelectedCells[7].Value.ToString();
            txtCiudad.Text = dtgClientes.SelectedCells[8].Value.ToString();
            txtCodigo.Text = dtgClientes.SelectedCells[9].Value.ToString();
            txtNombreC1.Text = dtgClientes.SelectedCells[10].Value.ToString();
            txtNumeroC1.Text = dtgClientes.SelectedCells[11].Value.ToString();
            txtNombreC2.Text = dtgClientes.SelectedCells[12].Value.ToString();
            txtNumeroC2.Text = dtgClientes.SelectedCells[13].Value.ToString();
            txtComentarios.Text = dtgClientes.SelectedCells[14].Value.ToString();
            panelEditarClientes.Visible = true;
            panelBusueda.Visible = false;
            label1.Visible = false;  
            label2.Visible = true;
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
                    cmd = new SqlCommand("editar_cliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdClientes",Convert.ToInt32(IdCliente));
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Correo_electronico", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Porcentaje", txtPorcentaje.Text);
                    cmd.Parameters.AddWithValue("@Pais", txtPais.Text);
                    cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                    cmd.Parameters.AddWithValue("@Codigo_Postal", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@Nombre_contacto1", txtNombreC1.Text);
                    cmd.Parameters.AddWithValue("@Numero_contacto1", txtNumeroC1.Text);
                    cmd.Parameters.AddWithValue("@Nombre_contacto2", txtNombreC2.Text);
                    cmd.Parameters.AddWithValue("@Numero_contacto2", txtNumeroC2.Text);
                    cmd.Parameters.AddWithValue("@Comentarios", txtComentarios.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrar_clientes();
                    panelEditarClientes.Visible = false;
                    label1.Visible = true;
                    label2.Visible = false;
                    panelBusueda.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void txtBusquedaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscar_cliente();
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            IdCliente = dtgClientes.SelectedCells[1].Value.ToString();
            txtNombre.Text = dtgClientes.SelectedCells[2].Value.ToString();
            txtCorreo.Text = dtgClientes.SelectedCells[3].Value.ToString();
            txtTelefono.Text = dtgClientes.SelectedCells[4].Value.ToString();
            txtDireccion.Text = dtgClientes.SelectedCells[5].Value.ToString();
            txtPorcentaje.Text = dtgClientes.SelectedCells[6].Value.ToString();
            txtPais.Text = dtgClientes.SelectedCells[7].Value.ToString();
            txtCiudad.Text = dtgClientes.SelectedCells[8].Value.ToString();
            txtCodigo.Text = dtgClientes.SelectedCells[9].Value.ToString();
            txtNombreC1.Text = dtgClientes.SelectedCells[10].Value.ToString();
            txtNumeroC1.Text = dtgClientes.SelectedCells[11].Value.ToString();
            txtNombreC2.Text = dtgClientes.SelectedCells[12].Value.ToString();
            txtNumeroC2.Text = dtgClientes.SelectedCells[13].Value.ToString();
            txtComentarios.Text = dtgClientes.SelectedCells[14].Value.ToString();
            panelEditarClientes.Visible = true;
            panelBusueda.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
        }
    }
}
