namespace MOTOCONNECTION.MODULOS.Cotizaciones
{
    partial class frmInicioCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioCotizaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNuevaCot = new System.Windows.Forms.Button();
            this.lblRecuperarCot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 127);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Que desea hacer?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNuevaCot
            // 
            this.lblNuevaCot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.lblNuevaCot.FlatAppearance.BorderSize = 0;
            this.lblNuevaCot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevaCot.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblNuevaCot.Location = new System.Drawing.Point(31, 160);
            this.lblNuevaCot.Name = "lblNuevaCot";
            this.lblNuevaCot.Size = new System.Drawing.Size(243, 41);
            this.lblNuevaCot.TabIndex = 5;
            this.lblNuevaCot.Text = "Nueva cotización";
            this.lblNuevaCot.UseVisualStyleBackColor = false;
            this.lblNuevaCot.Click += new System.EventHandler(this.lblNuevaCot_Click);
            // 
            // lblRecuperarCot
            // 
            this.lblRecuperarCot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.lblRecuperarCot.FlatAppearance.BorderSize = 0;
            this.lblRecuperarCot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRecuperarCot.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarCot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblRecuperarCot.Location = new System.Drawing.Point(301, 160);
            this.lblRecuperarCot.Name = "lblRecuperarCot";
            this.lblRecuperarCot.Size = new System.Drawing.Size(243, 41);
            this.lblRecuperarCot.TabIndex = 6;
            this.lblRecuperarCot.Text = "Recuperar Cotización";
            this.lblRecuperarCot.UseVisualStyleBackColor = false;
            this.lblRecuperarCot.Click += new System.EventHandler(this.lblRecuperarCot_Click);
            // 
            // frmInicioCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(571, 244);
            this.Controls.Add(this.lblRecuperarCot);
            this.Controls.Add(this.lblNuevaCot);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicioCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Cotización";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lblNuevaCot;
        private System.Windows.Forms.Button lblRecuperarCot;
    }
}