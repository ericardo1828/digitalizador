
namespace Digitalizador
{
    partial class RecortarImagenes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoCodigo = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnRecortar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Codigo_Altura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigo_XY_Inicio = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Ancho = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUbicarCodigo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUbicarCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbTipoCodigo);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnRecortar);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_Codigo_Altura);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCodigo_XY_Inicio);
            this.panel1.Controls.Add(this.txt_Codigo_Ancho);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 181);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tipo Codigo";
            // 
            // cmbTipoCodigo
            // 
            this.cmbTipoCodigo.FormattingEnabled = true;
            this.cmbTipoCodigo.Items.AddRange(new object[] {
            "BARRAS",
            "QR"});
            this.cmbTipoCodigo.Location = new System.Drawing.Point(379, 32);
            this.cmbTipoCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoCodigo.Name = "cmbTipoCodigo";
            this.cmbTipoCodigo.Size = new System.Drawing.Size(213, 21);
            this.cmbTipoCodigo.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(195, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(397, 111);
            this.textBox2.TabIndex = 32;
            // 
            // btnRecortar
            // 
            this.btnRecortar.Location = new System.Drawing.Point(127, 60);
            this.btnRecortar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecortar.Name = "btnRecortar";
            this.btnRecortar.Size = new System.Drawing.Size(64, 67);
            this.btnRecortar.TabIndex = 31;
            this.btnRecortar.Text = "Recortar";
            this.btnRecortar.UseVisualStyleBackColor = true;
            this.btnRecortar.Click += new System.EventHandler(this.btnRecortar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Altura";
            // 
            // txt_Codigo_Altura
            // 
            this.txt_Codigo_Altura.Location = new System.Drawing.Point(59, 109);
            this.txt_Codigo_Altura.Name = "txt_Codigo_Altura";
            this.txt_Codigo_Altura.Size = new System.Drawing.Size(63, 20);
            this.txt_Codigo_Altura.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ancho";
            // 
            // txtCodigo_XY_Inicio
            // 
            this.txtCodigo_XY_Inicio.Location = new System.Drawing.Point(59, 60);
            this.txtCodigo_XY_Inicio.Name = "txtCodigo_XY_Inicio";
            this.txtCodigo_XY_Inicio.Size = new System.Drawing.Size(63, 20);
            this.txtCodigo_XY_Inicio.TabIndex = 26;
            // 
            // txt_Codigo_Ancho
            // 
            this.txt_Codigo_Ancho.Location = new System.Drawing.Point(59, 84);
            this.txt_Codigo_Ancho.Name = "txt_Codigo_Ancho";
            this.txt_Codigo_Ancho.Size = new System.Drawing.Size(63, 20);
            this.txt_Codigo_Ancho.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "X,Y";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seleccionar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 185);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 454);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUbicarCodigo
            // 
            this.btnUbicarCodigo.Location = new System.Drawing.Point(9, 148);
            this.btnUbicarCodigo.Name = "btnUbicarCodigo";
            this.btnUbicarCodigo.Size = new System.Drawing.Size(93, 23);
            this.btnUbicarCodigo.TabIndex = 3;
            this.btnUbicarCodigo.Text = "Ubicar Codigo";
            this.btnUbicarCodigo.UseVisualStyleBackColor = true;
            this.btnUbicarCodigo.Click += new System.EventHandler(this.btnUbicarCodigo_Click);
            // 
            // RecortarImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RecortarImagenes";
            this.Text = "RecortarImagenes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRecortar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Codigo_Altura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigo_XY_Inicio;
        private System.Windows.Forms.TextBox txt_Codigo_Ancho;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoCodigo;
        private System.Windows.Forms.Button btnUbicarCodigo;
    }
}