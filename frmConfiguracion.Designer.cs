
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkAgregarFecha = new System.Windows.Forms.CheckBox();
            this.btnGuardarConfigXY = new System.Windows.Forms.Button();
            this.btnPropiedadesFont = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMensaje_X = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoCodigo = new System.Windows.Forms.ComboBox();
            this.txtMensaje_Y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigo_XY_Inicio = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Ancho = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.tabTimers = new System.Windows.Forms.TabPage();
            this.chkMonitoreoRC = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRC_pageTimers = new System.Windows.Forms.Label();
            this.chkEnvioRC = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkEnvioActasPrep = new System.Windows.Forms.CheckBox();
            this.lblActasPrep = new System.Windows.Forms.Label();
            this.chkMonitoreoActas = new System.Windows.Forms.CheckBox();
            this.btnGuardarTabTimers = new System.Windows.Forms.Button();
            this.panelHardware.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRutasDir)).BeginInit();
            this.tabConfiguraciones.SuspendLayout();
            this.tabPageHardware.SuspendLayout();
            this.tabPageDirectorios.SuspendLayout();
            this.tabPageApariencia.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageConfigXY.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.tabTimers.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblscaner
            // 
            this.lblscaner.AutoSize = true;
            this.lblscaner.Location = new System.Drawing.Point(3, 53);
            this.lblscaner.Name = "lblscaner";
            this.lblscaner.Size = new System.Drawing.Size(87, 13);
            this.lblscaner.TabIndex = 0;
            this.lblscaner.Text = "Escaner a utilizar";
            // 
            // lstEscaner
            // 
            this.lstEscaner.FormattingEnabled = true;
            this.lstEscaner.Location = new System.Drawing.Point(107, 53);
            this.lstEscaner.Name = "lstEscaner";
            this.lstEscaner.Size = new System.Drawing.Size(285, 82);
            this.lstEscaner.TabIndex = 1;
            // 
            // panelHardware
            // 
            this.panelHardware.Controls.Add(this.btnGuardar);
            this.panelHardware.Controls.Add(this.lblscaner);
            this.panelHardware.Controls.Add(this.lstEscaner);
            this.panelHardware.Controls.Add(this.lblHardware);
            this.panelHardware.Location = new System.Drawing.Point(6, 6);
            this.panelHardware.Name = "panelHardware";
            this.panelHardware.Size = new System.Drawing.Size(1037, 541);
            this.panelHardware.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(901, 504);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardware.Location = new System.Drawing.Point(279, 11);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(113, 23);
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
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 574);
            this.panel1.TabIndex = 5;
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(24, 83);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(142, 23);
            this.btnSelectDir.TabIndex = 3;
            this.btnSelectDir.Text = "Seleccionar Directorio";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(113, 53);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(509, 21);
            this.cmbTipoDocumento.TabIndex = 9;
            // 
            // btnAgregarDir
            // 
            this.btnAgregarDir.Location = new System.Drawing.Point(17, 127);
            this.btnAgregarDir.Name = "btnAgregarDir";
            this.btnAgregarDir.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDir.TabIndex = 8;
            this.btnAgregarDir.Text = "Agregar";
            this.btnAgregarDir.UseVisualStyleBackColor = true;
            this.btnAgregarDir.Click += new System.EventHandler(this.btnAgregarDir_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(172, 85);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(450, 20);
            this.txtRuta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // gridRutasDir
            // 
            this.gridRutasDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRutasDir.Location = new System.Drawing.Point(17, 165);
            this.gridRutasDir.Name = "gridRutasDir";
            this.gridRutasDir.RowHeadersWidth = 51;
            this.gridRutasDir.Size = new System.Drawing.Size(605, 230);
            this.gridRutasDir.TabIndex = 5;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(21, 56);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDoc.TabIndex = 0;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "DIRECTORIOS";
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.Controls.Add(this.tabPageHardware);
            this.tabConfiguraciones.Controls.Add(this.tabPageDirectorios);
            this.tabConfiguraciones.Controls.Add(this.tabPageApariencia);
            this.tabConfiguraciones.Controls.Add(this.tabPageConfigXY);
            this.tabConfiguraciones.Controls.Add(this.tabTimers);
            this.tabConfiguraciones.Location = new System.Drawing.Point(12, 12);
            this.tabConfiguraciones.Name = "tabConfiguraciones";
            this.tabConfiguraciones.SelectedIndex = 0;
            this.tabConfiguraciones.Size = new System.Drawing.Size(1057, 606);
            this.tabConfiguraciones.TabIndex = 2;
            // 
            // tabPageHardware
            // 
            this.tabPageHardware.Controls.Add(this.panelHardware);
            this.tabPageHardware.Location = new System.Drawing.Point(4, 22);
            this.tabPageHardware.Name = "tabPageHardware";
            this.tabPageHardware.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHardware.Size = new System.Drawing.Size(1049, 580);
            this.tabPageHardware.TabIndex = 0;
            this.tabPageHardware.Text = "Hardware";
            this.tabPageHardware.UseVisualStyleBackColor = true;
            // 
            // tabPageDirectorios
            // 
            this.tabPageDirectorios.Controls.Add(this.panel1);
            this.tabPageDirectorios.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirectorios.Name = "tabPageDirectorios";
            this.tabPageDirectorios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirectorios.Size = new System.Drawing.Size(1049, 580);
            this.tabPageDirectorios.TabIndex = 1;
            this.tabPageDirectorios.Text = "Directorios";
            this.tabPageDirectorios.UseVisualStyleBackColor = true;
            // 
            // tabPageApariencia
            // 
            this.tabPageApariencia.Controls.Add(this.panel2);
            this.tabPageApariencia.Location = new System.Drawing.Point(4, 22);
            this.tabPageApariencia.Name = "tabPageApariencia";
            this.tabPageApariencia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApariencia.Size = new System.Drawing.Size(1049, 580);
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
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 541);
            this.panel2.TabIndex = 6;
            // 
            // cmbTemas
            // 
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.Items.AddRange(new object[] {
            "SIGE",
            "BLUE",
            "DARK"});
            this.cmbTemas.Location = new System.Drawing.Point(134, 92);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(324, 21);
            this.cmbTemas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Aplicacion";
            // 
            // btnGuardarApariencia
            // 
            this.btnGuardarApariencia.Location = new System.Drawing.Point(914, 501);
            this.btnGuardarApariencia.Name = "btnGuardarApariencia";
            this.btnGuardarApariencia.Size = new System.Drawing.Size(108, 23);
            this.btnGuardarApariencia.TabIndex = 5;
            this.btnGuardarApariencia.Text = "Guardar";
            this.btnGuardarApariencia.UseVisualStyleBackColor = true;
            this.btnGuardarApariencia.Click += new System.EventHandler(this.btnGuardarApariencia_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.Location = new System.Drawing.Point(21, 52);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(93, 23);
            this.btnLogo.TabIndex = 1;
            this.btnLogo.Text = "Logo";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // txtNombreAplicacion
            // 
            this.txtNombreAplicacion.Location = new System.Drawing.Point(134, 14);
            this.txtNombreAplicacion.Name = "txtNombreAplicacion";
            this.txtNombreAplicacion.Size = new System.Drawing.Size(324, 20);
            this.txtNombreAplicacion.TabIndex = 4;
            // 
            // txtRutaLogo
            // 
            this.txtRutaLogo.Location = new System.Drawing.Point(134, 55);
            this.txtRutaLogo.Name = "txtRutaLogo";
            this.txtRutaLogo.Size = new System.Drawing.Size(324, 20);
            this.txtRutaLogo.TabIndex = 2;
            // 
            // tabPageConfigXY
            // 
            this.tabPageConfigXY.Controls.Add(this.panel3);
            this.tabPageConfigXY.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfigXY.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageConfigXY.Name = "tabPageConfigXY";
            this.tabPageConfigXY.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageConfigXY.Size = new System.Drawing.Size(1049, 580);
            this.tabPageConfigXY.TabIndex = 3;
            this.tabPageConfigXY.Text = "Config XY";
            this.tabPageConfigXY.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 570);
            this.panel3.TabIndex = 7;
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
            this.panel4.Location = new System.Drawing.Point(10, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 546);
            this.panel4.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(817, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Altura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(865, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 24;
            // 
            // chkAgregarFecha
            // 
            this.chkAgregarFecha.AutoSize = true;
            this.chkAgregarFecha.Location = new System.Drawing.Point(113, 184);
            this.chkAgregarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.chkAgregarFecha.Name = "chkAgregarFecha";
            this.chkAgregarFecha.Size = new System.Drawing.Size(133, 17);
            this.chkAgregarFecha.TabIndex = 22;
            this.chkAgregarFecha.Text = "Agregar Fecha al texto";
            this.chkAgregarFecha.UseVisualStyleBackColor = true;
            this.chkAgregarFecha.CheckedChanged += new System.EventHandler(this.chkAgregarFecha_CheckedChanged);
            // 
            // btnGuardarConfigXY
            // 
            this.btnGuardarConfigXY.Location = new System.Drawing.Point(889, 513);
            this.btnGuardarConfigXY.Name = "btnGuardarConfigXY";
            this.btnGuardarConfigXY.Size = new System.Drawing.Size(108, 23);
            this.btnGuardarConfigXY.TabIndex = 5;
            this.btnGuardarConfigXY.Text = "Guardar";
            this.btnGuardarConfigXY.UseVisualStyleBackColor = true;
            this.btnGuardarConfigXY.Click += new System.EventHandler(this.btnGuardarConfigXY_Click);
            // 
            // btnPropiedadesFont
            // 
            this.btnPropiedadesFont.Location = new System.Drawing.Point(366, 24);
            this.btnPropiedadesFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnPropiedadesFont.Name = "btnPropiedadesFont";
            this.btnPropiedadesFont.Size = new System.Drawing.Size(78, 23);
            this.btnPropiedadesFont.TabIndex = 3;
            this.btnPropiedadesFont.Text = "propiedades";
            this.btnPropiedadesFont.UseVisualStyleBackColor = true;
            this.btnPropiedadesFont.Click += new System.EventHandler(this.btnPropiedadesFont_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(113, 52);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(2);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(332, 119);
            this.txtMensaje.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(545, 163);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 139);
            this.dataGridView1.TabIndex = 20;
            // 
            // txtMensaje_X
            // 
            this.txtMensaje_X.Location = new System.Drawing.Point(113, 260);
            this.txtMensaje_X.Name = "txtMensaje_X";
            this.txtMensaje_X.Size = new System.Drawing.Size(332, 20);
            this.txtMensaje_X.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(591, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tipo Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Coordenada X";
            // 
            // cmbTipoCodigo
            // 
            this.cmbTipoCodigo.FormattingEnabled = true;
            this.cmbTipoCodigo.Items.AddRange(new object[] {
            "BARRAS",
            "QR"});
            this.cmbTipoCodigo.Location = new System.Drawing.Point(666, 74);
            this.cmbTipoCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoCodigo.Name = "cmbTipoCodigo";
            this.cmbTipoCodigo.Size = new System.Drawing.Size(332, 21);
            this.cmbTipoCodigo.TabIndex = 18;
            // 
            // txtMensaje_Y
            // 
            this.txtMensaje_Y.Location = new System.Drawing.Point(113, 284);
            this.txtMensaje_Y.Name = "txtMensaje_Y";
            this.txtMensaje_Y.Size = new System.Drawing.Size(332, 20);
            this.txtMensaje_Y.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(570, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Coordenada Y";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "CVs PUBLICOS",
            "DOCs GENERALES",
            "ACTAS"});
            this.cmbTipoDoc.Location = new System.Drawing.Point(666, 50);
            this.cmbTipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(332, 21);
            this.cmbTipoDoc.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mensaje en Actas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(568, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ubicacion en XY de Codigos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mensaje";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(618, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ancho";
            // 
            // txtCodigo_XY_Inicio
            // 
            this.txtCodigo_XY_Inicio.Location = new System.Drawing.Point(666, 105);
            this.txtCodigo_XY_Inicio.Name = "txtCodigo_XY_Inicio";
            this.txtCodigo_XY_Inicio.Size = new System.Drawing.Size(332, 20);
            this.txtCodigo_XY_Inicio.TabIndex = 12;
            // 
            // txt_Codigo_Ancho
            // 
            this.txt_Codigo_Ancho.Location = new System.Drawing.Point(666, 129);
            this.txt_Codigo_Ancho.Name = "txt_Codigo_Ancho";
            this.txt_Codigo_Ancho.Size = new System.Drawing.Size(128, 20);
            this.txt_Codigo_Ancho.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(543, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Coordenada X,Y Inicio";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::Digitalizador.Properties.Resources.refresh_icon;
            this.picRefresh.Location = new System.Drawing.Point(598, 137);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(24, 24);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 10;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // tabTimers
            // 
            this.tabTimers.Controls.Add(this.btnGuardarTabTimers);
            this.tabTimers.Controls.Add(this.panel6);
            this.tabTimers.Controls.Add(this.panel5);
            this.tabTimers.Location = new System.Drawing.Point(4, 22);
            this.tabTimers.Name = "tabTimers";
            this.tabTimers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimers.Size = new System.Drawing.Size(1049, 580);
            this.tabTimers.TabIndex = 4;
            this.tabTimers.Text = "Timers";
            this.tabTimers.UseVisualStyleBackColor = true;
            // 
            // chkMonitoreoRC
            // 
            this.chkMonitoreoRC.AutoSize = true;
            this.chkMonitoreoRC.Location = new System.Drawing.Point(16, 52);
            this.chkMonitoreoRC.Name = "chkMonitoreoRC";
            this.chkMonitoreoRC.Size = new System.Drawing.Size(114, 17);
            this.chkMonitoreoRC.TabIndex = 0;
            this.chkMonitoreoRC.Text = "Habilitar Monitoreo";
            this.chkMonitoreoRC.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.chkEnvioRC);
            this.panel5.Controls.Add(this.lblRC_pageTimers);
            this.panel5.Controls.Add(this.chkMonitoreoRC);
            this.panel5.Location = new System.Drawing.Point(19, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 93);
            this.panel5.TabIndex = 1;
            // 
            // lblRC_pageTimers
            // 
            this.lblRC_pageTimers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRC_pageTimers.AutoSize = true;
            this.lblRC_pageTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRC_pageTimers.Location = new System.Drawing.Point(90, 13);
            this.lblRC_pageTimers.Name = "lblRC_pageTimers";
            this.lblRC_pageTimers.Size = new System.Drawing.Size(173, 20);
            this.lblRC_pageTimers.TabIndex = 1;
            this.lblRC_pageTimers.Text = "Registro Candidatos";
            // 
            // chkEnvioRC
            // 
            this.chkEnvioRC.AutoSize = true;
            this.chkEnvioRC.Location = new System.Drawing.Point(165, 52);
            this.chkEnvioRC.Name = "chkEnvioRC";
            this.chkEnvioRC.Size = new System.Drawing.Size(150, 17);
            this.chkEnvioRC.TabIndex = 2;
            this.chkEnvioRC.Text = "Habilitar Envio Automatico";
            this.chkEnvioRC.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.chkEnvioActasPrep);
            this.panel6.Controls.Add(this.lblActasPrep);
            this.panel6.Controls.Add(this.chkMonitoreoActas);
            this.panel6.Location = new System.Drawing.Point(19, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 91);
            this.panel6.TabIndex = 3;
            // 
            // chkEnvioActasPrep
            // 
            this.chkEnvioActasPrep.AutoSize = true;
            this.chkEnvioActasPrep.Location = new System.Drawing.Point(165, 50);
            this.chkEnvioActasPrep.Name = "chkEnvioActasPrep";
            this.chkEnvioActasPrep.Size = new System.Drawing.Size(150, 17);
            this.chkEnvioActasPrep.TabIndex = 2;
            this.chkEnvioActasPrep.Text = "Habilitar Envio Automatico";
            this.chkEnvioActasPrep.UseVisualStyleBackColor = true;
            // 
            // lblActasPrep
            // 
            this.lblActasPrep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActasPrep.AutoSize = true;
            this.lblActasPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActasPrep.Location = new System.Drawing.Point(90, 13);
            this.lblActasPrep.Name = "lblActasPrep";
            this.lblActasPrep.Size = new System.Drawing.Size(97, 20);
            this.lblActasPrep.TabIndex = 1;
            this.lblActasPrep.Text = "Actas Prep";
            // 
            // chkMonitoreoActas
            // 
            this.chkMonitoreoActas.AutoSize = true;
            this.chkMonitoreoActas.Location = new System.Drawing.Point(16, 50);
            this.chkMonitoreoActas.Name = "chkMonitoreoActas";
            this.chkMonitoreoActas.Size = new System.Drawing.Size(114, 17);
            this.chkMonitoreoActas.TabIndex = 0;
            this.chkMonitoreoActas.Text = "Habilitar Monitoreo";
            this.chkMonitoreoActas.UseVisualStyleBackColor = true;
            // 
            // btnGuardarTabTimers
            // 
            this.btnGuardarTabTimers.Location = new System.Drawing.Point(915, 525);
            this.btnGuardarTabTimers.Name = "btnGuardarTabTimers";
            this.btnGuardarTabTimers.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTabTimers.TabIndex = 4;
            this.btnGuardarTabTimers.Text = "Guardar";
            this.btnGuardarTabTimers.UseVisualStyleBackColor = true;
            this.btnGuardarTabTimers.Click += new System.EventHandler(this.btnGuardarTabTimers_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 638);
            this.Controls.Add(this.tabConfiguraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.panelHardware.ResumeLayout(false);
            this.panelHardware.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRutasDir)).EndInit();
            this.tabConfiguraciones.ResumeLayout(false);
            this.tabPageHardware.ResumeLayout(false);
            this.tabPageDirectorios.ResumeLayout(false);
            this.tabPageApariencia.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageConfigXY.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.tabTimers.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.TabPage tabTimers;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkEnvioRC;
        private System.Windows.Forms.Label lblRC_pageTimers;
        private System.Windows.Forms.CheckBox chkMonitoreoRC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox chkEnvioActasPrep;
        private System.Windows.Forms.Label lblActasPrep;
        private System.Windows.Forms.CheckBox chkMonitoreoActas;
        private System.Windows.Forms.Button btnGuardarTabTimers;
    }
}