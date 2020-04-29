namespace MOTOCONNECTION.MODULOS.Clientes
{
    partial class frmMostrarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.Eliminar_Usuario = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.panelBusueda = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBusquedaCliente = new System.Windows.Forms.TextBox();
            this.panelEditarClientes = new System.Windows.Forms.Panel();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtNumeroC2 = new System.Windows.Forms.TextBox();
            this.txtNombreC2 = new System.Windows.Forms.TextBox();
            this.txtNumeroC1 = new System.Windows.Forms.TextBox();
            this.lblNumeroC2 = new System.Windows.Forms.Label();
            this.lblNombreC2 = new System.Windows.Forms.Label();
            this.lblNumeroC1 = new System.Windows.Forms.Label();
            this.txtNombreC1 = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblNombreC1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.panelBusueda.SuspendLayout();
            this.panelEditarClientes.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 79);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(242, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 79);
            this.label2.TabIndex = 8;
            this.label2.Text = "Editar clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(463, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar_Usuario});
            this.dtgClientes.Location = new System.Drawing.Point(42, 143);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(602, 347);
            this.dtgClientes.TabIndex = 11;
            this.dtgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellDoubleClick);
            // 
            // Eliminar_Usuario
            // 
            this.Eliminar_Usuario.HeaderText = "";
            this.Eliminar_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar_Usuario.Image")));
            this.Eliminar_Usuario.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar_Usuario.Name = "Eliminar_Usuario";
            this.Eliminar_Usuario.ReadOnly = true;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnEditarCliente.Location = new System.Drawing.Point(485, 512);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(186, 39);
            this.btnEditarCliente.TabIndex = 12;
            this.btnEditarCliente.Text = "Editar cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // panelBusueda
            // 
            this.panelBusueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelBusueda.Controls.Add(this.btnBuscarCliente);
            this.panelBusueda.Controls.Add(this.txtBusquedaCliente);
            this.panelBusueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusueda.Location = new System.Drawing.Point(0, 79);
            this.panelBusueda.Name = "panelBusueda";
            this.panelBusueda.Size = new System.Drawing.Size(684, 40);
            this.panelBusueda.TabIndex = 13;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnBuscarCliente.Location = new System.Drawing.Point(546, 8);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(117, 24);
            this.btnBuscarCliente.TabIndex = 13;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBusquedaCliente
            // 
            this.txtBusquedaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtBusquedaCliente.Location = new System.Drawing.Point(63, 8);
            this.txtBusquedaCliente.Name = "txtBusquedaCliente";
            this.txtBusquedaCliente.Size = new System.Drawing.Size(459, 24);
            this.txtBusquedaCliente.TabIndex = 0;
            this.txtBusquedaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusquedaCliente_KeyPress);
            // 
            // panelEditarClientes
            // 
            this.panelEditarClientes.Controls.Add(this.btnGuardarCambios);
            this.panelEditarClientes.Controls.Add(this.panel4);
            this.panelEditarClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditarClientes.Location = new System.Drawing.Point(0, 119);
            this.panelEditarClientes.Name = "panelEditarClientes";
            this.panelEditarClientes.Size = new System.Drawing.Size(684, 442);
            this.panelEditarClientes.TabIndex = 14;
            this.panelEditarClientes.Visible = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnGuardarCambios.Location = new System.Drawing.Point(510, 376);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(161, 58);
            this.btnGuardarCambios.TabIndex = 12;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtComentarios);
            this.panel4.Controls.Add(this.lblComentarios);
            this.panel4.Controls.Add(this.txtNumeroC2);
            this.panel4.Controls.Add(this.txtNombreC2);
            this.panel4.Controls.Add(this.txtNumeroC1);
            this.panel4.Controls.Add(this.lblNumeroC2);
            this.panel4.Controls.Add(this.lblNombreC2);
            this.panel4.Controls.Add(this.lblNumeroC1);
            this.panel4.Controls.Add(this.txtNombreC1);
            this.panel4.Controls.Add(this.txtCodigo);
            this.panel4.Controls.Add(this.txtCiudad);
            this.panel4.Controls.Add(this.lblNombreC1);
            this.panel4.Controls.Add(this.lblCodigo);
            this.panel4.Controls.Add(this.lblCiudad);
            this.panel4.Controls.Add(this.txtPais);
            this.panel4.Controls.Add(this.txtPorcentaje);
            this.panel4.Controls.Add(this.txtDireccion);
            this.panel4.Controls.Add(this.lblPais);
            this.panel4.Controls.Add(this.lblPorcentaje);
            this.panel4.Controls.Add(this.lblDireccion);
            this.panel4.Controls.Add(this.txtTelefono);
            this.panel4.Controls.Add(this.txtCorreo);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.lblTelefono);
            this.panel4.Controls.Add(this.lblCorreo);
            this.panel4.Controls.Add(this.lblNombre);
            this.panel4.Location = new System.Drawing.Point(13, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 438);
            this.panel4.TabIndex = 11;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(187, 401);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(257, 24);
            this.txtComentarios.TabIndex = 23;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.Location = new System.Drawing.Point(79, 404);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(100, 19);
            this.lblComentarios.TabIndex = 22;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // txtNumeroC2
            // 
            this.txtNumeroC2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroC2.Location = new System.Drawing.Point(187, 369);
            this.txtNumeroC2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroC2.Name = "txtNumeroC2";
            this.txtNumeroC2.Size = new System.Drawing.Size(257, 24);
            this.txtNumeroC2.TabIndex = 21;
            // 
            // txtNombreC2
            // 
            this.txtNombreC2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreC2.Location = new System.Drawing.Point(187, 337);
            this.txtNombreC2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreC2.Name = "txtNombreC2";
            this.txtNombreC2.Size = new System.Drawing.Size(257, 24);
            this.txtNombreC2.TabIndex = 20;
            // 
            // txtNumeroC1
            // 
            this.txtNumeroC1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroC1.Location = new System.Drawing.Point(187, 305);
            this.txtNumeroC1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroC1.Name = "txtNumeroC1";
            this.txtNumeroC1.Size = new System.Drawing.Size(257, 24);
            this.txtNumeroC1.TabIndex = 19;
            // 
            // lblNumeroC2
            // 
            this.lblNumeroC2.AutoSize = true;
            this.lblNumeroC2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroC2.Location = new System.Drawing.Point(8, 372);
            this.lblNumeroC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroC2.Name = "lblNumeroC2";
            this.lblNumeroC2.Size = new System.Drawing.Size(171, 19);
            this.lblNumeroC2.TabIndex = 16;
            this.lblNumeroC2.Text = "Numero de contacto 2:";
            // 
            // lblNombreC2
            // 
            this.lblNombreC2.AutoSize = true;
            this.lblNombreC2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC2.Location = new System.Drawing.Point(8, 340);
            this.lblNombreC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreC2.Name = "lblNombreC2";
            this.lblNombreC2.Size = new System.Drawing.Size(172, 19);
            this.lblNombreC2.TabIndex = 17;
            this.lblNombreC2.Text = "Nombre de contacto 2:";
            // 
            // lblNumeroC1
            // 
            this.lblNumeroC1.AutoSize = true;
            this.lblNumeroC1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroC1.Location = new System.Drawing.Point(9, 308);
            this.lblNumeroC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroC1.Name = "lblNumeroC1";
            this.lblNumeroC1.Size = new System.Drawing.Size(171, 19);
            this.lblNumeroC1.TabIndex = 18;
            this.lblNumeroC1.Text = "Numero de contacto 1:";
            // 
            // txtNombreC1
            // 
            this.txtNombreC1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreC1.Location = new System.Drawing.Point(187, 273);
            this.txtNombreC1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreC1.Name = "txtNombreC1";
            this.txtNombreC1.Size = new System.Drawing.Size(257, 24);
            this.txtNombreC1.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(187, 241);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(257, 24);
            this.txtCodigo.TabIndex = 14;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(187, 209);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(257, 24);
            this.txtCiudad.TabIndex = 13;
            // 
            // lblNombreC1
            // 
            this.lblNombreC1.AutoSize = true;
            this.lblNombreC1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC1.Location = new System.Drawing.Point(8, 276);
            this.lblNombreC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreC1.Name = "lblNombreC1";
            this.lblNombreC1.Size = new System.Drawing.Size(172, 19);
            this.lblNombreC1.TabIndex = 10;
            this.lblNombreC1.Text = "Nombre de contacto 1:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(69, 244);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(110, 19);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo postal:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(113, 212);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(66, 19);
            this.lblCiudad.TabIndex = 12;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(187, 177);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(257, 24);
            this.txtPais.TabIndex = 9;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentaje.Location = new System.Drawing.Point(187, 145);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(257, 24);
            this.txtPorcentaje.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(187, 113);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(257, 24);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(140, 180);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 19);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "Pais:";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(92, 148);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(88, 19);
            this.lblPorcentaje.TabIndex = 5;
            this.lblPorcentaje.Text = "Porcentaje:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(102, 116);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 19);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(187, 81);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(257, 24);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(187, 49);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(257, 24);
            this.txtCorreo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(187, 17);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(257, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(109, 84);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 19);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(39, 52);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(141, 19);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(38, 22);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(142, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de cliente:";
            // 
            // frmMostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panelEditarClientes);
            this.Controls.Add(this.panelBusueda);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMostrarClientes";
            this.Text = "frmMostrarClientes";
            this.Load += new System.EventHandler(this.frmMostrarClientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.panelBusueda.ResumeLayout(false);
            this.panelBusueda.PerformLayout();
            this.panelEditarClientes.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar_Usuario;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Panel panelBusueda;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBusquedaCliente;
        private System.Windows.Forms.Panel panelEditarClientes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.TextBox txtNumeroC2;
        private System.Windows.Forms.TextBox txtNombreC2;
        private System.Windows.Forms.TextBox txtNumeroC1;
        private System.Windows.Forms.Label lblNumeroC2;
        private System.Windows.Forms.Label lblNombreC2;
        private System.Windows.Forms.Label lblNumeroC1;
        private System.Windows.Forms.TextBox txtNombreC1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblNombreC1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label label2;
    }
}