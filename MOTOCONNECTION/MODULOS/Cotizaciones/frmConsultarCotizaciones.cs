using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOTOCONNECTION.MODULOS.Cotizaciones
{
    public partial class frmConsultarCotizaciones : Form
    {
        public frmConsultarCotizaciones()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInicioCotizaciones frm = new frmInicioCotizaciones();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
