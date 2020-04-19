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

namespace MOTOCONNECTION.MODULOS.Cotizaciones
{
    public partial class frmCotizacion : Form
    {
        int cantidad = 0;
        decimal PrecioDistribuidor = 0;
        decimal precio_total = 0;
        decimal total_factura = 0;
        int sw = 1;

        public frmCotizacion()
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
                con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
                con.Open();

                da = new SqlDataAdapter("buscar_producto", con);
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
            CONEXIONES.TamañoAutomaticoDeDatabase.Multilinea(ref dtgAgregar);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgAgregar.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Add"].Value);
                if (isSelected)
                {
                    for (int i = 0; i < dtgACotizar.Rows.Count; i++)
                    {
                        if (dtgACotizar.Rows[i].Cells[1].Value.Equals(row.Cells[2].Value.ToString()))
                        {
                            sw = 0;
                        }
                    }
                    if (sw == 1)
                    {
                        int n = dtgACotizar.Rows.Add();
                        dtgACotizar.Rows[n].Cells[0].Value = row.Cells[1].Value.ToString();
                        dtgACotizar.Rows[n].Cells[1].Value = row.Cells[2].Value.ToString();
                        dtgACotizar.Rows[n].Cells[2].Value = row.Cells[3].Value.ToString();
                        dtgACotizar.Rows[n].Cells[3].Value = row.Cells[4].Value.ToString();
                        dtgACotizar.Rows[n].Cells[4].Value = row.Cells[5].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El articulo seleccionado ya esta en la lista del pedido");
                    }
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                Buscar_Item();
            }
            else
            {
                dtgAgregar.DataSource = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cotizaciones.frmInicioCotizaciones frm = new Cotizaciones.frmInicioCotizaciones();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void dtgACotizar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cantidad = int.Parse(dtgACotizar.Rows[e.RowIndex].Cells[5].Value.ToString());
            PrecioDistribuidor = decimal.Parse(dtgACotizar.Rows[e.RowIndex].Cells[4].Value.ToString());
            precio_total = cantidad * PrecioDistribuidor;
            dtgACotizar.Rows[e.RowIndex].Cells[6].Value = precio_total;
            CalcularTotal();
        }

        void CalcularTotal()
        {
            total_factura = 0;
            for (int i = 0; i < dtgACotizar.Rows.Count; i++)
            {
                total_factura += decimal.Parse(dtgACotizar.Rows[i].Cells[6].Value.ToString());
                lblTotal.Text = Convert.ToString(total_factura);
            }
        }

        private void dtgACotizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dtgACotizar.CurrentCell.ColumnIndex == 5)
            {
                if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void dtgACotizar_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgACotizar.CurrentCell.ColumnIndex == 5)
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dtgACotizar_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dtgACotizar_KeyPress);
                }
            }
            if (dtgACotizar.CurrentCell.ColumnIndex == 6)
            {
                MessageBox.Show("s");
            }
        }
    }
}
