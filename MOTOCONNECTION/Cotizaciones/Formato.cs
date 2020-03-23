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
                DataList.DataSource = dt;
                con.Close();

                DataList.Columns[1].Visible = false;
                DataList.Columns[5].Visible = false;
                DataList.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Conexion.TamañoAutomaticoDeDatabase.Multilinea(ref DataList);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar_Item();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataList.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataList.Visible = false;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in DataList.Rows)
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
            DataList.Visible = true;       
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cotizaciones.Cotizaciones frm = new Cotizaciones.Cotizaciones();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

    }
}
