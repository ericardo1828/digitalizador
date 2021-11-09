
namespace Digitalizador
{
    partial class frmConfiguracion
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
            this.lblscaner = new System.Windows.Forms.Label();
            this.lstEscaner = new System.Windows.Forms.ListBox();
            this.panelHardware = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblHardware = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnAgregarDir = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridRutasDir = new System.Windows.Forms.DataGridView();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabConfiguraciones = new System.Windows.Forms.TabControl();
            this.tabPageHardware = new System.Windows.Forms.TabPage();
            this.tabPageDirectorios = new System.Windows.Forms.TabPage();
            this.tabPageApariencia = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTemas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarApariencia = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.txtNombreAplicacion = new System.Windows.Forms.TextBox();
            this.txtRutaLogo = new System.Windows.Forms.TextBox();
            this.tabPageConfigXY = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMensaje_Y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarConfigXY = new System.Windows.Forms.Button();
            this.txtMensaje_X = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Codigo_Ancho = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigo_XY_Inicio = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTipoCodigo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnPropiedadesFont = new System.Windows.Forms.Button();
            this.chkAgregarFecha = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelHardware.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRutasDir)).BeginInit();
            this.tabConfiguraciones.SuspendLayout();
            this.tabPageHardware.SuspendLayout();
            this.tabPageDirectorios.SuspendLayout();
            this.tabPageApariencia.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageConfigXY.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblscaner
            // 
            this.lblscaner.AutoSize = true;
            this.lblscaner.Location = new System.Drawing.Point(4, 65);
            this.lblscaner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblscaner.Name = "lblscaner";
            this.lblscaner.Size = new System.Drawing.Size(117, 17);
            this.lblscaner.TabIndex = 0;
            this.lblscaner.Text = "Escaner a utilizar";
            // 
            // lstEscaner
            // 
            this.lstEscaner.FormattingEnabled = true;
            this.lstEscaner.ItemHeight = 16;
            this.lstEscaner.Location = new System.Drawing.Point(143, 65);
            this.lstEscaner.Margin = new System.Windows.Forms.Padding(4);
            this.lstEscaner.Name = "lstEscaner";
            this.lstEscaner.Size = new System.Drawing.Size(379, 100);
            this.lstEscaner.TabIndex = 1;
            // 
            // panelHardware
            // 
            this.panelHardware.Controls.Add(this.btnGuardar);
            this.panelHardware.Controls.Add(this.lblscaner);
            this.panelHardware.Controls.Add(this.lstEscaner);
            this.panelHardware.Controls.Add(this.lblHardware);
            this.panelHardware.Location = new System.Drawing.Point(8, 7);
            this.panelHardware.Margin = new System.Windows.Forms.Padding(4);
            this.panelHardware.Name = "panelHardware";
            this.panelHardware.Size = new System.Drawing.Size(1383, 666);
            this.panelHardware.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1201, 620);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 28);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardware.Location = new System.Drawing.Point(372, 14);
            this.lblHardware.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(143, 28);
            this.lblHardware.TabIndex = 2;
            this.lblHardware.Text = "HARDWARE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picRefresh);
            this.panel1.Controls.Add(this.btnSelectDir);
            this.panel1.Controls.Add(this.cmbTipoDocumento);
            this.panel1.Controls.Add(this.btnAgregarDir);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gridRutasDir);
            this.panel1.Controls.Add(this.lblTipoDoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 706);
            this.panel1.TabIndex = 5;
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::Digitalizador.Properties.Resources.refresh_icon;
            this.picRefresh.Location = new System.Drawing.Point(797, 169);
            this.picRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(32, 30);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 10;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(32, 102);
            this.btnSelectDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(189, 28);
            this.btnSelectDir.TabIndex = 3;
            this.btnSelectDir.Text = "Seleccionar Directorio";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(151, 65);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(677, 24);
            this.cmbTipoDocumento.TabIndex = 9;
            // 
            // btnAgregarDir
            // 
            this.btnAgregarDir.Location = new System.Drawing.Point(23, 156);
            this.btnAgregarDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDir.Name = "btnAgregarDir";
            this.btnAgregarDir.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarDir.TabIndex = 8;
            this.btnAgregarDir.Text = "Agregar";
            this.btnAgregarDir.UseVisualStyleBackColor = true;
            this.btnAgregarDir.Click += new System.EventHandler(this.btnAgregarDir_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(229, 105);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(599, 22);
            this.txtRuta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 6;
            // 
            // gridRutasDir
            // 
            this.gridRutasDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRutasDir.Location = new System.Drawing.Point(23, 203);
            this.gridRutasDir.Margin = new System.Windows.Forms.Padding(4);
            this.gridRutasDir.Name = "gridRutasDir";
            this.gridRutasDir.RowHeadersWidth = 51;
            this.gridRutasDir.Size = new System.Drawing.Size(807, 283);
            this.gridRutasDir.TabIndex = 5;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(28, 69);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(112, 17);
            this.lblTipoDoc.TabIndex = 0;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "DIRECTORIOS";
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.Controls.Add(this.tabPageHardware);
            this.tabConfiguraciones.Controls.Add(this.tabPageDirectorios);
            this.tabConfiguraciones.Controls.Add(this.tabPageApariencia);
            this.tabConfiguraciones.Controls.Add(this.tabPageConfigXY);
            this.tabConfiguraciones.Location = new System.Drawing.Point(16, 15);
            this.tabConfiguraciones.Margin = new System.Windows.Forms.Padding(4);
            this.tabConfiguraciones.Name = "tabConfiguraciones";
            this.tabConfiguraciones.SelectedIndex = 0;
            this.tabConfiguraciones.Size = new System.Drawing.Size(1409, 746);
            this.tabConfiguraciones.TabIndex = 2;
            // 
            // tabPageHardware
            // 
            this.tabPageHardware.Controls.Add(this.panelHardware);
            this.tabPageHardware.Location = new System.Drawing.Point(4, 25);
            this.tabPageHardware.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageHardware.Name = "tabPageHardware";
            this.tabPageHardware.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageHardware.Size = new System.Drawing.Size(1401, 717);
            this.tabPageHardware.TabIndex = 0;
            this.tabPageHardware.Text = "Hardware";
            this.tabPageHardware.UseVisualStyleBackColor = true;
            // 
            // tabPageDirectorios
            // 
            this.tabPageDirectorios.Controls.Add(this.panel1);
            this.tabPageDirectorios.Location = new System.Drawing.Point(4, 25);
            this.tabPageDirectorios.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDirectorios.Name = "tabPageDirectorios";
            this.tabPageDirectorios.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageDirectorios.Size = new System.Drawing.Size(1401, 717);
            this.tabPageDirectorios.TabIndex = 1;
            this.tabPageDirectorios.Text = "Directorios";
            this.tabPageDirectorios.UseVisualStyleBackColor = true;
            // 
            // tabPageApariencia
            // 
            this.tabPageApariencia.Controls.Add(this.panel2);
            this.tabPageApariencia.Location = new System.Drawing.Point(4, 25);
            this.tabPageApariencia.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageApariencia.Name = "tabPageApariencia";
            this.tabPageApariencia.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageApariencia.Size = new System.Drawing.Size(1401, 717);
            this.tabPageApariencia.TabIndex = 2;
            this.tabPageApariencia.Text = "Apariencia";
            this.tabPageApariencia.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTemas);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnGuardarApariencia);
            this.panel2.Controls.Add(this.btnLogo);
            this.panel2.Controls.Add(this.txtNombreAplicacion);
            this.panel2.Controls.Add(this.txtRutaLogo);
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1383, 666);
            this.panel2.TabIndex = 6;
            // 
            // cmbTemas
            // 
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.Items.AddRange(new object[] {
            "SIGE",
            "BLUE",
            "DARK"});
            this.cmbTemas.Location = new System.Drawing.Point(179, 113);
            this.cmbTemas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(431, 24);
            this.cmbTemas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Aplicacion";
            // 
            // btnGuardarApariencia
            // 
            this.btnGuardarApariencia.Location = new System.Drawing.Point(1219, 617);
            this.btnGuardarApariencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarApariencia.Name = "btnGuardarApariencia";
            this.btnGuardarApariencia.Size = new System.Drawing.Size(144, 28);
            this.btnGuardarApariencia.TabIndex = 5;
            this.btnGuardarApariencia.Text = "Guardar";
            this.btnGuardarApariencia.UseVisualStyleBackColor = true;
            this.btnGuardarApariencia.Click += new System.EventHandler(this.btnGuardarApariencia_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.Location = new System.Drawing.Point(28, 64);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(124, 28);
            this.btnLogo.TabIndex = 1;
            this.btnLogo.Text = "Logo";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // txtNombreAplicacion
            // 
            this.txtNombreAplicacion.Location = new System.Drawing.Point(179, 17);
            this.txtNombreAplicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreAplicacion.Name = "txtNombreAplicacion";
            this.txtNombreAplicacion.Size = new System.Drawing.Size(431, 22);
            this.txtNombreAplicacion.TabIndex = 4;
            // 
            // txtRutaLogo
            // 
            this.txtRutaLogo.Location = new System.Drawing.Point(179, 68);
            this.txtRutaLogo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaLogo.Name = "txtRutaLogo";
            this.txtRutaLogo.Size = new System.Drawing.Size(431, 22);
            this.txtRutaLogo.TabIndex = 2;
            // 
            // tabPageConfigXY
            // 
            this.tabPageConfigXY.Controls.Add(this.panel3);
            this.tabPageConfigXY.Location = new System.Drawing.Point(4, 25);
            this.tabPageConfigXY.Name = "tabPageConfigXY";
            this.tabPageConfigXY.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigXY.Size = new System.Drawing.Size(1401, 717);
            this.tabPageConfigXY.TabIndex = 3;
            this.tabPageConfigXY.Text = "Config XY";
            this.tabPageConfigXY.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(9, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1383, 701);
            this.panel3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mensaje";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(151, 64);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(441, 146);
            this.txtMensaje.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mensaje en Actas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Coordenada Y";
            // 
            // txtMensaje_Y
            // 
            this.txtMensaje_Y.Location = new System.Drawing.Point(151, 350);
            this.txtMensaje_Y.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensaje_Y.Name = "txtMensaje_Y";
            this.txtMensaje_Y.Size = new System.Drawing.Size(441, 22);
            this.txtMensaje_Y.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Coordenada X";
            // 
            // btnGuardarConfigXY
            // 
            this.btnGuardarConfigXY.Location = new System.Drawing.Point(1185, 631);
            this.btnGuardarConfigXY.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarConfigXY.Name = "btnGuardarConfigXY";
            this.btnGuardarConfigXY.Size = new System.Drawing.Size(144, 28);
            this.btnGuardarConfigXY.TabIndex = 5;
            this.btnGuardarConfigXY.Text = "Guardar";
            this.btnGuardarConfigXY.UseVisualStyleBackColor = true;
            this.btnGuardarConfigXY.Click += new System.EventHandler(this.btnGuardarConfigXY_Click);
            // 
            // txtMensaje_X
            // 
            this.txtMensaje_X.Location = new System.Drawing.Point(151, 320);
            this.txtMensaje_X.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensaje_X.Name = "txtMensaje_X";
            this.txtMensaje_X.Size = new System.Drawing.Size(441, 22);
            this.txtMensaje_X.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(757, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ubicacion en XY de Codigos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(824, 159);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ancho";
            
            // 
            // txt_Codigo_Ancho
            // 
            this.txt_Codigo_Ancho.Location = new System.Drawing.Point(888, 159);
            this.txt_Codigo_Ancho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo_Ancho.Name = "txt_Codigo_Ancho";
            this.txt_Codigo_Ancho.Size = new System.Drawing.Size(169, 22);
            this.txt_Codigo_Ancho.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(724, 129);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Coordenada X,Y Inicio";
            // 
            // txtCodigo_XY_Inicio
            // 
            this.txtCodigo_XY_Inicio.Location = new System.Drawing.Point(888, 129);
            this.txtCodigo_XY_Inicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo_XY_Inicio.Name = "txtCodigo_XY_Inicio";
            this.txtCodigo_XY_Inicio.Size = new System.Drawing.Size(441, 22);
            this.txtCodigo_XY_Inicio.TabIndex = 12;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "CVs PUBLICOS",
            "DOCs GENERALES",
            "ACTAS"});
            this.cmbTipoDoc.Location = new System.Drawing.Point(888, 61);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(441, 24);
            this.cmbTipoDoc.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(760, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo Documento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(788, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tipo Codigo";
            // 
            // cmbTipoCodigo
            // 
            this.cmbTipoCodigo.FormattingEnabled = true;
            this.cmbTipoCodigo.Items.AddRange(new object[] {
            "BARRAS",
            "QR"});
            this.cmbTipoCodigo.Location = new System.Drawing.Point(888, 91);
            this.cmbTipoCodigo.Name = "cmbTipoCodigo";
            this.cmbTipoCodigo.Size = new System.Drawing.Size(441, 24);
            this.cmbTipoCodigo.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(727, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 171);
            this.dataGridView1.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.chkAgregarFecha);
            this.panel4.Controls.Add(this.btnGuardarConfigXY);
            this.panel4.Controls.Add(this.btnPropiedadesFont);
            this.panel4.Controls.Add(this.txtMensaje);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.txtMensaje_X);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cmbTipoCodigo);
            this.panel4.Controls.Add(this.txtMensaje_Y);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbTipoDoc);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtCodigo_XY_Inicio);
            this.panel4.Controls.Add(this.txt_Codigo_Ancho);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(13, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1355, 672);
            this.panel4.TabIndex = 8;
            // 
            // btnPropiedadesFont
            // 
            this.btnPropiedadesFont.Location = new System.Drawing.Point(488, 30);
            this.btnPropiedadesFont.Name = "btnPropiedadesFont";
            this.btnPropiedadesFont.Size = new System.Drawing.Size(104, 28);
            this.btnPropiedadesFont.TabIndex = 3;
            this.btnPropiedadesFont.Text = "propiedades";
            this.btnPropiedadesFont.UseVisualStyleBackColor = true;
            this.btnPropiedadesFont.Click += new System.EventHandler(this.btnPropiedadesFont_Click);
            // 
            // chkAgregarFecha
            // 
            this.chkAgregarFecha.AutoSize = true;
            this.chkAgregarFecha.Location = new System.Drawing.Point(151, 226);
            this.chkAgregarFecha.Name = "chkAgregarFecha";
            this.chkAgregarFecha.Size = new System.Drawing.Size(173, 21);
            this.chkAgregarFecha.TabIndex = 22;
            this.chkAgregarFecha.Text = "Agregar Fecha al texto";
            this.chkAgregarFecha.UseVisualStyleBackColor = true;
            this.chkAgregarFecha.CheckedChanged += new System.EventHandler(this.chkAgregarFecha_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1089, 159);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 21);
            this.label14.TabIndex = 23;
            this.label14.Text = "Altura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1153, 159);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 24;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 785);
            this.Controls.Add(this.tabConfiguraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.panelHardware.ResumeLayout(false);
            this.panelHardware.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRutasDir)).EndInit();
            this.tabConfiguraciones.ResumeLayout(false);
            this.tabPageHardware.ResumeLayout(false);
            this.tabPageDirectorios.ResumeLayout(false);
            this.tabPageApariencia.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageConfigXY.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblscaner;
        private System.Windows.Forms.ListBox lstEscaner;
        private System.Windows.Forms.Panel panelHardware;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.DataGridView gridRutasDir;
        private System.Windows.Forms.TabControl tabConfiguraciones;
        private System.Windows.Forms.TabPage tabPageHardware;
        private System.Windows.Forms.TabPage tabPageDirectorios;
        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarDir;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.TabPage tabPageApariencia;
        private System.Windows.Forms.TextBox txtNombreAplicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRutaLogo;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardarApariencia;
        private System.Windows.Forms.ComboBox cmbTemas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.TabPage tabPageConfigXY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMensaje_Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarConfigXY;
        private System.Windows.Forms.TextBox txtMensaje_X;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTipoCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Codigo_Ancho;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigo_XY_Inicio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnPropiedadesFont;
        private System.Windows.Forms.CheckBox chkAgregarFecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
    }
}