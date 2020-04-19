using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOTOCONNECTION.Cotizaciones
{
    public partial class Cotizaciones : Form
    {
        public Cotizaciones()
        {
            InitializeComponent();
        }

        private void lblNueva_Click(object sender, EventArgs e)
        {            
            Busqueda frm = new Busqueda();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void lblRecuperar_Click(object sender, EventArgs e)
        {
            ConsultaCotizaciones frm = new ConsultaCotizaciones();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
