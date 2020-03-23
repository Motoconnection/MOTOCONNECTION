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
    public partial class ConsultaCotizaciones : Form
    {
        public ConsultaCotizaciones()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cotizaciones frm = new Cotizaciones();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
