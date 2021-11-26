
namespace Digitalizador
{
    partial class Hilos
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
            this.etHora = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.numCargaCPU = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCargaCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // etHora
            // 
            this.etHora.AutoSize = true;
            this.etHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etHora.Location = new System.Drawing.Point(12, 9);
            this.etHora.Name = "etHora";
            this.etHora.Size = new System.Drawing.Size(120, 31);
            this.etHora.TabIndex = 0;
            this.etHora.Text = "00:00:00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 62);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(293, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(121, 91);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carga CPU";
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // numCargaCPU
            // 
            this.numCargaCPU.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCargaCPU.Location = new System.Drawing.Point(186, 146);
            this.numCargaCPU.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCargaCPU.Minimum = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            this.numCargaCPU.Name = "numCargaCPU";
            this.numCargaCPU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numCargaCPU.Size = new System.Drawing.Size(120, 20);
            this.numCargaCPU.TabIndex = 5;
            this.numCargaCPU.Value = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            // 
            // Hilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 178);
            this.Controls.Add(this.numCargaCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.etHora);
            this.Name = "Hilos";
            this.Text = "Hilos";
            ((System.ComponentModel.ISupportInitialize)(this.numCargaCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etHora;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.NumericUpDown numCargaCPU;
    }
}