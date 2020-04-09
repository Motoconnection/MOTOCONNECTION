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
    public partial class frmInicioCotizaciones : Form
    {
        public frmInicioCotizaciones()
        {
            InitializeComponent();
        }

        private void lblNuevaCot_Click(object sender, EventArgs e)
        {
            frmCotizacion frm = new frmCotizacion();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void lblRecuperarCot_Click(object sender, EventArgs e)
        {
            frmConsultarCotizaciones frm = new frmConsultarCotizaciones();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
