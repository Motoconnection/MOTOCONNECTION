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
                    cmd = new SqlCommand("nuevo_Producto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@Code_Product", txtCod_part.Text);
                    cmd.Parameters.AddWithValue("@Name_Product", txtNombreP.Text);
                    cmd.Parameters.AddWithValue("@Weight", textWeight.Text);
                    //cmd.Parameters.AddWithValue("@Rol", cmbRol.Text);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    cmd.Parameters.AddWithValue("@Price_Distributor", Price_cost.Text);
                    cmd.Parameters.AddWithValue("@Price_Dealer", Price_Dealer.Text);
                    cmd.Parameters.AddWithValue("@Price_Retail", Price_Retail.Text);
                    cmd.Parameters.AddWithValue("@Availability", TextB_Availability.Text);
                    cmd.Parameters.AddWithValue("@Stock", TextB_Stock.Text);
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

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
