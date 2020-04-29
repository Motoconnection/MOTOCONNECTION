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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        private void mostrar_Productos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
                con.Open();
                da = new SqlDataAdapter("mostrar_Productos", con);
                da.Fill(dt);
                dtgProductos.DataSource = dt;
                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CONEXIONES.TamañoAutomaticoDeDatabase.Multilinea(ref dtgProductos);

        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            mostrar_Productos();
        }
    }
}
