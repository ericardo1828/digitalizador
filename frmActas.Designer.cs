
namespace Digitalizador
{
    partial class frmActas
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picActa = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMonitoreoActas = new System.Windows.Forms.CheckBox();
            this.chkEnvioActas = new System.Windows.Forms.CheckBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnEnviarManualmente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridMonitoreoArchivos = new System.Windows.Forms.DataGridView();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridEnvioArchivos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerMonitoreoActas = new System.Windows.Forms.Timer(this.components);
            this.timerEnvioActas = new System.Windows.Forms.Timer(this.components);
            this.timerChecaTimers = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picActa)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMonitoreoArchivos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvioArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACTAS PREP";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkMonitoreoActas, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.chkEnvioActas, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.pnlBotones, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEnviarManualmente, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1050, 586);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.picActa);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 287);
            this.panel1.TabIndex = 0;
            // 
            // picActa
            // 
            this.picActa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picActa.Location = new System.Drawing.Point(3, 3);
            this.picActa.Name = "picActa";
            this.picActa.Size = new System.Drawing.Size(984, 281);
            this.picActa.TabIndex = 0;
            this.picActa.TabStop = false;
            this.picActa.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picActa_LoadCompleted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monitoreados";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enviados";
            // 
            // chkMonitoreoActas
            // 
            this.chkMonitoreoActas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkMonitoreoActas.AutoSize = true;
            this.chkMonitoreoActas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonitoreoActas.Location = new System.Drawing.Point(3, 562);
            this.chkMonitoreoActas.Name = "chkMonitoreoActas";
            this.chkMonitoreoActas.Size = new System.Drawing.Size(149, 17);
            this.chkMonitoreoActas.TabIndex = 3;
            this.chkMonitoreoActas.Text = "Monitoreo Automatico";
            this.chkMonitoreoActas.UseVisualStyleBackColor = true;
            // 
            // chkEnvioActas
            // 
            this.chkEnvioActas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkEnvioActas.AutoSize = true;
            this.chkEnvioActas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnvioActas.Location = new System.Drawing.Point(527, 562);
            this.chkEnvioActas.Name = "chkEnvioActas";
            this.chkEnvioActas.Size = new System.Drawing.Size(125, 17);
            this.chkEnvioActas.TabIndex = 4;
            this.chkEnvioActas.Text = "Envio Automatico";
            this.chkEnvioActas.UseVisualStyleBackColor = true;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlBotones.Controls.Add(this.btnMenos);
            this.pnlBotones.Controls.Add(this.btnMas);
            this.pnlBotones.Location = new System.Drawing.Point(999, 3);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(48, 287);
            this.pnlBotones.TabIndex = 6;
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImage = global::Digitalizador.Properties.Resources.menos;
            this.btnMenos.Image = global::Digitalizador.Properties.Resources.menos;
            this.btnMenos.Location = new System.Drawing.Point(-3, 56);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(51, 50);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.BackgroundImage = global::Digitalizador.Properties.Resources.mas;
            this.btnMas.Image = global::Digitalizador.Properties.Resources.mas;
            this.btnMas.Location = new System.Drawing.Point(-3, 0);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(51, 50);
            this.btnMas.TabIndex = 5;
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnEnviarManualmente
            // 
            this.btnEnviarManualmente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviarManualmente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnviarManualmente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarManualmente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarManualmente.Location = new System.Drawing.Point(475, 427);
            this.btnEnviarManualmente.Name = "btnEnviarManualmente";
            this.btnEnviarManualmente.Size = new System.Drawing.Size(46, 23);
            this.btnEnviarManualmente.TabIndex = 7;
            this.btnEnviarManualmente.Text = "=>";
            this.btnEnviarManualmente.UseVisualStyleBackColor = false;
            this.btnEnviarManualmente.Click += new System.EventHandler(this.btnEnviarManualmente_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.gridMonitoreoArchivos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 228);
            this.panel2.TabIndex = 8;
            // 
            // gridMonitoreoArchivos
            // 
            this.gridMonitoreoArchivos.AllowUserToAddRows = false;
            this.gridMonitoreoArchivos.AllowUserToDeleteRows = false;
            this.gridMonitoreoArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMonitoreoArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.file});
            this.gridMonitoreoArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMonitoreoArchivos.Location = new System.Drawing.Point(0, 0);
            this.gridMonitoreoArchivos.MultiSelect = false;
            this.gridMonitoreoArchivos.Name = "gridMonitoreoArchivos";
            this.gridMonitoreoArchivos.ReadOnly = true;
            this.gridMonitoreoArchivos.Size = new System.Drawing.Size(466, 228);
            this.gridMonitoreoArchivos.TabIndex = 1;
            this.gridMonitoreoArchivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMonitoreoArchivos_CellClick);
            // 
            // file
            // 
            this.file.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.file.DataPropertyName = "file";
            this.file.HeaderText = "file";
            this.file.Name = "file";
            this.file.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.gridEnvioArchivos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(527, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 228);
            this.panel3.TabIndex = 9;
            // 
            // gridEnvioArchivos
            // 
            this.gridEnvioArchivos.AllowUserToAddRows = false;
            this.gridEnvioArchivos.AllowUserToDeleteRows = false;
            this.gridEnvioArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEnvioArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gridEnvioArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEnvioArchivos.Location = new System.Drawing.Point(0, 0);
            this.gridEnvioArchivos.MultiSelect = false;
            this.gridEnvioArchivos.Name = "gridEnvioArchivos";
            this.gridEnvioArchivos.ReadOnly = true;
            this.gridEnvioArchivos.Size = new System.Drawing.Size(466, 228);
            this.gridEnvioArchivos.TabIndex = 2;
            this.gridEnvioArchivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEnvioArchivos_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "file";
            this.Column1.HeaderText = "file";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // timerMonitoreoActas
            // 
            this.timerMonitoreoActas.Interval = 5000;
            this.timerMonitoreoActas.Tick += new System.EventHandler(this.timerMonitoreoActas_Tick);
            // 
            // timerEnvioActas
            // 
            this.timerEnvioActas.Interval = 5000;
            this.timerEnvioActas.Tick += new System.EventHandler(this.timerEnvioActas_Tick);
            // 
            // timerChecaTimers
            // 
            this.timerChecaTimers.Enabled = true;
            this.timerChecaTimers.Interval = 10000;
            this.timerChecaTimers.Tick += new System.EventHandler(this.timerChecaTimers_Tick);
            // 
            // frmActas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 638);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActas";
            this.Text = "frmActas";
            this.Load += new System.EventHandler(this.frmActas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picActa)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMonitoreoArchivos)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvioArchivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picActa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMonitoreoActas;
        private System.Windows.Forms.CheckBox chkEnvioActas;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnEnviarManualmente;
        private System.Windows.Forms.Timer timerMonitoreoActas;
        private System.Windows.Forms.Timer timerEnvioActas;
        private System.Windows.Forms.Timer timerChecaTimers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridMonitoreoArchivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.DataGridView gridEnvioArchivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}