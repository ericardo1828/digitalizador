
namespace Digitalizador
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPanelDeControl = new System.Windows.Forms.Button();
            this.btnActas = new System.Windows.Forms.Button();
            this.btnRC = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblEntorno = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1200, 750);
            this.panelContenedor.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMenu.Controls.Add(this.btnPanelDeControl);
            this.panelMenu.Controls.Add(this.btnActas);
            this.panelMenu.Controls.Add(this.btnRC);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 63);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(93, 687);
            this.panelMenu.TabIndex = 2;
            // 
            // btnPanelDeControl
            // 
            this.btnPanelDeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnPanelDeControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelDeControl.FlatAppearance.BorderSize = 0;
            this.btnPanelDeControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelDeControl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelDeControl.ForeColor = System.Drawing.Color.White;
            this.btnPanelDeControl.Location = new System.Drawing.Point(3, 3);
            this.btnPanelDeControl.Margin = new System.Windows.Forms.Padding(0);
            this.btnPanelDeControl.Name = "btnPanelDeControl";
            this.btnPanelDeControl.Size = new System.Drawing.Size(85, 45);
            this.btnPanelDeControl.TabIndex = 2;
            this.btnPanelDeControl.Text = "Panel de Control";
            this.btnPanelDeControl.UseVisualStyleBackColor = false;
            this.btnPanelDeControl.Click += new System.EventHandler(this.btnPanelDeControl_Click);
            // 
            // btnActas
            // 
            this.btnActas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnActas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActas.FlatAppearance.BorderSize = 0;
            this.btnActas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActas.ForeColor = System.Drawing.Color.White;
            this.btnActas.Location = new System.Drawing.Point(12, 102);
            this.btnActas.Name = "btnActas";
            this.btnActas.Size = new System.Drawing.Size(64, 45);
            this.btnActas.TabIndex = 1;
            this.btnActas.Text = "Actas";
            this.btnActas.UseVisualStyleBackColor = false;
            this.btnActas.Click += new System.EventHandler(this.btnActas_Click);
            // 
            // btnRC
            // 
            this.btnRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRC.FlatAppearance.BorderSize = 0;
            this.btnRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRC.ForeColor = System.Drawing.Color.White;
            this.btnRC.Location = new System.Drawing.Point(3, 51);
            this.btnRC.Name = "btnRC";
            this.btnRC.Size = new System.Drawing.Size(88, 45);
            this.btnRC.TabIndex = 0;
            this.btnRC.Text = "Registro Candidatos";
            this.btnRC.UseVisualStyleBackColor = false;
            this.btnRC.Click += new System.EventHandler(this.btnRC_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(49)))), ((int)(((byte)(167)))));
            this.panelTitulo.Controls.Add(this.btnRestaurar);
            this.panelTitulo.Controls.Add(this.picLogo);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1200, 63);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseMove);
            this.panelTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(518, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 40);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Digitalizador";
            // 
            // panelFormularios
            // 
            this.panelFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormularios.BackColor = System.Drawing.Color.White;
            this.panelFormularios.BackgroundImage = global::Digitalizador.Properties.Resources.Grafico_Digitalizador;
            this.panelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFormularios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormularios.Controls.Add(this.panelFooter);
            this.panelFormularios.Location = new System.Drawing.Point(93, 63);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1107, 687);
            this.panelFormularios.TabIndex = 3;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(49)))), ((int)(((byte)(167)))));
            this.panelFooter.Controls.Add(this.lblVersion);
            this.panelFooter.Controls.Add(this.lblEntorno);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 662);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1105, 23);
            this.panelFooter.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(1105, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 1;
            // 
            // lblEntorno
            // 
            this.lblEntorno.AutoSize = true;
            this.lblEntorno.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEntorno.ForeColor = System.Drawing.Color.White;
            this.lblEntorno.Location = new System.Drawing.Point(0, 0);
            this.lblEntorno.Name = "lblEntorno";
            this.lblEntorno.Size = new System.Drawing.Size(0, 13);
            this.lblEntorno.TabIndex = 1;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestaurar.Image = global::Digitalizador.Properties.Resources.restaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(1084, 0);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(29, 63);
            this.btnRestaurar.TabIndex = 9;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Digitalizador.Properties.Resources.Logo_IEPC;
            this.picLogo.Location = new System.Drawing.Point(12, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(147, 53);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.Image = global::Digitalizador.Properties.Resources.maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(1113, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 63);
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = global::Digitalizador.Properties.Resources._;
            this.btnMinimizar.Location = new System.Drawing.Point(1142, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 63);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::Digitalizador.Properties.Resources.X;
            this.btnCerrar.Location = new System.Drawing.Point(1171, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 63);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelFormularios.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblEntorno;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnActas;
        private System.Windows.Forms.Button btnRC;
        private System.Windows.Forms.Button btnPanelDeControl;
    }
}

