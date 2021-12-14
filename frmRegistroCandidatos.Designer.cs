
namespace Digitalizador
{
    partial class frmRegistroCandidatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCandidatos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridMonitoreoArchivos = new System.Windows.Forms.DataGridView();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.gridEnvioArchivos = new System.Windows.Forms.DataGridView();
            this.btnEnviarArchivoManual = new System.Windows.Forms.Button();
            this.visorPDF = new AxAcroPDFLib.AxAcroPDF();
            this.chkMonitorearAuto = new System.Windows.Forms.CheckBox();
            this.chkEnviarAuto = new System.Windows.Forms.CheckBox();
            this.lblMonitoreados = new System.Windows.Forms.Label();
            this.lblEnviados = new System.Windows.Forms.Label();
            this.timerMonitoreoRC = new System.Windows.Forms.Timer(this.components);
            this.timerEnvioRC = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMonitoreoArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvioArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE CANDIDATOS";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.Controls.Add(this.gridMonitoreoArchivos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMonitoreados, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblVistaPrevia, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblEnviados, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.gridEnvioArchivos, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEnviarArchivoManual, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.visorPDF, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkMonitorearAuto, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkEnviarAuto, 4, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1050, 558);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // gridMonitoreoArchivos
            // 
            this.gridMonitoreoArchivos.AllowUserToAddRows = false;
            this.gridMonitoreoArchivos.AllowUserToDeleteRows = false;
            this.gridMonitoreoArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMonitoreoArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.file});
            this.gridMonitoreoArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMonitoreoArchivos.Location = new System.Drawing.Point(3, 29);
            this.gridMonitoreoArchivos.MultiSelect = false;
            this.gridMonitoreoArchivos.Name = "gridMonitoreoArchivos";
            this.gridMonitoreoArchivos.ReadOnly = true;
            this.gridMonitoreoArchivos.Size = new System.Drawing.Size(288, 505);
            this.gridMonitoreoArchivos.TabIndex = 0;
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
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVistaPrevia.AutoSize = true;
            this.lblVistaPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrevia.Location = new System.Drawing.Point(456, 4);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(95, 17);
            this.lblVistaPrevia.TabIndex = 4;
            this.lblVistaPrevia.Text = "Vista Previa";
            // 
            // gridEnvioArchivos
            // 
            this.gridEnvioArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEnvioArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEnvioArchivos.Location = new System.Drawing.Point(758, 29);
            this.gridEnvioArchivos.Name = "gridEnvioArchivos";
            this.gridEnvioArchivos.Size = new System.Drawing.Size(289, 505);
            this.gridEnvioArchivos.TabIndex = 1;
            // 
            // btnEnviarArchivoManual
            // 
            this.btnEnviarArchivoManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviarArchivoManual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnviarArchivoManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarArchivoManual.ForeColor = System.Drawing.Color.Blue;
            this.btnEnviarArchivoManual.Location = new System.Drawing.Point(706, 270);
            this.btnEnviarArchivoManual.Name = "btnEnviarArchivoManual";
            this.btnEnviarArchivoManual.Size = new System.Drawing.Size(46, 23);
            this.btnEnviarArchivoManual.TabIndex = 5;
            this.btnEnviarArchivoManual.Text = "-->>";
            this.btnEnviarArchivoManual.UseVisualStyleBackColor = false;
            this.btnEnviarArchivoManual.Click += new System.EventHandler(this.btnEnviarArchivoManual_Click);
            // 
            // visorPDF
            // 
            this.visorPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visorPDF.Enabled = true;
            this.visorPDF.Location = new System.Drawing.Point(307, 29);
            this.visorPDF.Name = "visorPDF";
            this.visorPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visorPDF.OcxState")));
            this.visorPDF.Size = new System.Drawing.Size(393, 505);
            this.visorPDF.TabIndex = 6;
            // 
            // chkMonitorearAuto
            // 
            this.chkMonitorearAuto.AutoSize = true;
            this.chkMonitorearAuto.Checked = true;
            this.chkMonitorearAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonitorearAuto.Location = new System.Drawing.Point(3, 540);
            this.chkMonitorearAuto.Name = "chkMonitorearAuto";
            this.chkMonitorearAuto.Size = new System.Drawing.Size(161, 15);
            this.chkMonitorearAuto.TabIndex = 7;
            this.chkMonitorearAuto.Text = "Monitorear Automaticamente";
            this.chkMonitorearAuto.UseVisualStyleBackColor = true;
            // 
            // chkEnviarAuto
            // 
            this.chkEnviarAuto.AutoSize = true;
            this.chkEnviarAuto.Checked = true;
            this.chkEnviarAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnviarAuto.Location = new System.Drawing.Point(758, 540);
            this.chkEnviarAuto.Name = "chkEnviarAuto";
            this.chkEnviarAuto.Size = new System.Drawing.Size(141, 15);
            this.chkEnviarAuto.TabIndex = 8;
            this.chkEnviarAuto.Text = "Enviar Automaticamente";
            this.chkEnviarAuto.UseVisualStyleBackColor = true;
            // 
            // lblMonitoreados
            // 
            this.lblMonitoreados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonitoreados.AutoSize = true;
            this.lblMonitoreados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitoreados.Location = new System.Drawing.Point(94, 4);
            this.lblMonitoreados.Name = "lblMonitoreados";
            this.lblMonitoreados.Size = new System.Drawing.Size(106, 17);
            this.lblMonitoreados.TabIndex = 2;
            this.lblMonitoreados.Text = "Monitoreados";
            // 
            // lblEnviados
            // 
            this.lblEnviados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnviados.AutoSize = true;
            this.lblEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviados.Location = new System.Drawing.Point(865, 4);
            this.lblEnviados.Name = "lblEnviados";
            this.lblEnviados.Size = new System.Drawing.Size(74, 17);
            this.lblEnviados.TabIndex = 3;
            this.lblEnviados.Text = "Enviados";
            // 
            // timerMonitoreoRC
            // 
            this.timerMonitoreoRC.Interval = 5000;
            this.timerMonitoreoRC.Tick += new System.EventHandler(this.timerMonitoreoRC_Tick);
            // 
            // timerEnvioRC
            // 
            this.timerEnvioRC.Interval = 1500;
            this.timerEnvioRC.Tick += new System.EventHandler(this.timerEnvioRC_Tick);
            // 
            // frmRegistroCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 638);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroCandidatos";
            this.Text = "frmRegistroCandidatos";
            this.Load += new System.EventHandler(this.frmRegistroCandidatos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMonitoreoArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvioArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView gridMonitoreoArchivos;
        private System.Windows.Forms.DataGridView gridEnvioArchivos;
        private System.Windows.Forms.Label lblMonitoreados;
        private System.Windows.Forms.Label lblEnviados;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.Button btnEnviarArchivoManual;
        private AxAcroPDFLib.AxAcroPDF visorPDF;
        private System.Windows.Forms.Timer timerMonitoreoRC;
        private System.Windows.Forms.Timer timerEnvioRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.CheckBox chkMonitorearAuto;
        private System.Windows.Forms.CheckBox chkEnviarAuto;
    }
}