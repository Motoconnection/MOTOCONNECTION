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

namespace MOTOCONNECTION
{
    public partial class Busqueda : Form
    {
        int cantidad = 0;
        decimal PrecioDistribuidor = 0;
        decimal precio_total = 0;
        decimal total_factura = 0;

        public Busqueda()
        {
            InitializeComponent();
        }
        private void Buscar_Item()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("BuscarItem", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtBuscar.Text);
                da.Fill(dt);
                dtgAgregar.DataSource = dt;
                con.Close();

                dtgAgregar.Columns[1].Visible = false;
                dtgAgregar.Columns[5].Visible = false;
                dtgAgregar.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Conexion.TamañoAutomaticoDeDatabase.Multilinea(ref dtgAgregar);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                Buscar_Item();
            }
            else
            {
                dtgAgregar.DataSource="";
            }
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dtgAgregar.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Add"].Value);
                if (isSelected)
                {
                    int n = dataGridViewC.Rows.Add();
                    dataGridViewC.Rows[n].Cells[0].Value = row.Cells[1].Value.ToString();
                    dataGridViewC.Rows[n].Cells[1].Value = row.Cells[2].Value.ToString();
                    dataGridViewC.Rows[n].Cells[2].Value = row.Cells[3].Value.ToString();
                    dataGridViewC.Rows[n].Cells[3].Value = row.Cells[4].Value.ToString();
                    dataGridViewC.Rows[n].Cells[4].Value = row.Cells[5].Value.ToString();
                }                  
            }         
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cotizaciones.Cotizaciones frm = new Cotizaciones.Cotizaciones();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void dataGridViewC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {            
                cantidad = int.Parse(dataGridViewC.Rows[e.RowIndex].Cells[5].Value.ToString());
                PrecioDistribuidor = decimal.Parse(dataGridViewC.Rows[e.RowIndex].Cells[4].Value.ToString());
                precio_total = cantidad * PrecioDistribuidor;
                dataGridViewC.Rows[e.RowIndex].Cells[6].Value = precio_total;          
        }
        
        void CalcularTotal ()
        {
            for (int i=0;i<dataGridViewC.Rows.Count-1;i++)
            {
                total_factura += decimal.Parse(dataGridViewC.Rows[i].Cells[6].Value.ToString());
                lblTotal.Text = Convert.ToString(total_factura);
            }
        }
    }
}
