using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOTOCONNECTION.MODULOS.MenuPrincipal
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            ContraerSubMenu();
        }
        private void ContraerSubMenu()
        {
            pnlUsuariosSubMenu.Visible = false;
            pnlClientesSubMenu.Visible = false;
            pnlProveedoresSubMenu.Visible = false;
            pnlProductosSubMenu.Visible = false;
            pnlCotizacionesSubMenu.Visible = false;
            pnlMovimientosSubMenu.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (pnlUsuariosSubMenu.Visible == true)
                pnlUsuariosSubMenu.Visible = false;
            if (pnlClientesSubMenu.Visible == true)
                pnlClientesSubMenu.Visible = false;
            if (pnlProveedoresSubMenu.Visible == true)
                pnlProveedoresSubMenu.Visible = false;
            if (pnlProductosSubMenu.Visible == true)
                pnlProductosSubMenu.Visible = false;
            if (pnlCotizacionesSubMenu.Visible == true)
                pnlCotizacionesSubMenu.Visible = false;
            if (pnlMovimientosSubMenu.Visible == true)
                pnlMovimientosSubMenu.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible==false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlUsuariosSubMenu);
        }
        #region UsuariosSubMenu
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            AbrirModulo(new Usuarios.frmNuevoUsuario());
            //lineas de programacion
            OcultarSubMenu();
        }

        private void btnMostrarUsuario_Click(object sender, EventArgs e)
        {
            AbrirModulo(new Usuarios.frmMostrarUsuarios());
            //lineas de programacion
            OcultarSubMenu();
        }
        #endregion UsuariosSubMenu
        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlClientesSubMenu);
        }
        #region ClienteSubMenu
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }
        #endregion
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlProveedoresSubMenu);
        }
        #region ProveedoresSubMenu
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }

        private void btnMostrarProveedores_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }
        #endregion
        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlProductosSubMenu);
        }
        #region ProductosSubMenu
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }
        #endregion
        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlCotizacionesSubMenu);
        }
        #region CotizacionesSubMenu
        private void btnNuevaCotizacion_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }

        private void btnRecuperarCotizacion_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }
        #endregion
        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlMovimientosSubMenu);
        }
        #region MovimientosSubMenu
        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }

        private void btnRealizarDevolucion_Click(object sender, EventArgs e)
        {
            //lineas de programacion
            OcultarSubMenu();
        }
        #endregion
        private Form ModuloActivo = null;

        private void AbrirModulo(Form Modulo)
        {
            if (ModuloActivo != null)
                ModuloActivo.Close();
            ModuloActivo = Modulo;
            Modulo.TopLevel = false;
            Modulo.FormBorderStyle = FormBorderStyle.None;
            Modulo.Dock = DockStyle.Fill;
            pnlVentanaPrincipal.Controls.Add(Modulo);
            pnlVentanaPrincipal.Tag = Modulo;
            Modulo.BringToFront();
            Modulo.Show();
        }
    }
}
