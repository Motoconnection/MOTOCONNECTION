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

namespace MOTOCONNECTION.MODULOS.Login
{
    public partial class Login : Form
    {
        string Nombre;
        public Login()
        {
            InitializeComponent();
        }

        public void DIBUJARusuarios()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CONEXIONES.ConexionMaestra.conexiones;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("select * from T_Usuario WHERE Estado = 'Activo'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Label b = new Label();
                Panel p1 = new Panel();
                PictureBox I1 = new PictureBox();

                b.Text = rdr["Nombre"].ToString();
                b.Name = rdr["IdUsuario"].ToString();
                b.Size = new System.Drawing.Size(175, 25);
                b.Font = new System.Drawing.Font("Century Gothic", 13);
                b.BackColor = Color.FromArgb(32,32,32);
                b.ForeColor = Color.White;
                b.Dock = DockStyle.Bottom;
                b.TextAlign = ContentAlignment.MiddleCenter;
                b.Cursor = Cursors.Hand;

                p1.Size = new System.Drawing.Size(155, 167);
                p1.BorderStyle = BorderStyle.None;
                p1.BackColor = Color.FromArgb(32, 32, 32);


                I1.Size = new System.Drawing.Size(175, 132);
                I1.Dock = DockStyle.Top;
                I1.BackgroundImage = null;
                byte[] bi = (Byte[])rdr["Icono"];
                MemoryStream ms = new MemoryStream(bi);
                I1.Image = Image.FromStream(ms);
                I1.SizeMode = PictureBoxSizeMode.Zoom;
                I1.Tag = rdr["Nombre"].ToString();
                I1.Cursor = Cursors.Hand;

                p1.Controls.Add(b);
                p1.Controls.Add(I1);
                b.BringToFront();
                flpUsuarios.Controls.Add(p1);

                b.Click += new EventHandler(mieventoLabel);
                I1.Click += new EventHandler(miEventoImagen);
            }
            con.Close();
        }
        private void miEventoImagen(System.Object sender, EventArgs e)
        {
            Nombre = ((PictureBox)sender).Tag.ToString();
            frmInicioSesion frmInicioSesion = new frmInicioSesion(Nombre);
            frmInicioSesion.ShowDialog();
            this.Hide();

        }

        private void mieventoLabel(System.Object sender, EventArgs e)
        {
    
            Nombre = ((Label)sender).Text;
            frmInicioSesion frmInicioSesion = new frmInicioSesion(Nombre);
            frmInicioSesion.ShowDialog();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DIBUJARusuarios();
        }
    }
}
