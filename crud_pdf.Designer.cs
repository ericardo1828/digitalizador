
namespace Digitalizador
{
    partial class crud_pdf
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
            this.btnLeerPDF = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLeerImagen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeerPDF
            // 
            this.btnLeerPDF.Location = new System.Drawing.Point(12, 12);
            this.btnLeerPDF.Name = "btnLeerPDF";
            this.btnLeerPDF.Size = new System.Drawing.Size(257, 23);
            this.btnLeerPDF.TabIndex = 0;
            this.btnLeerPDF.Text = "Leer PDF";
            this.btnLeerPDF.UseVisualStyleBackColor = true;
            this.btnLeerPDF.Click += new System.EventHandler(this.btnLeerPDF_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 316);
            this.textBox1.TabIndex = 1;
            // 
            // btnLeerImagen
            // 
            this.btnLeerImagen.Location = new System.Drawing.Point(13, 42);
            this.btnLeerImagen.Name = "btnLeerImagen";
            this.btnLeerImagen.Size = new System.Drawing.Size(256, 23);
            this.btnLeerImagen.TabIndex = 2;
            this.btnLeerImagen.Text = "Leer Imagen";
            this.btnLeerImagen.UseVisualStyleBackColor = true;
            this.btnLeerImagen.Click += new System.EventHandler(this.btnLeerImagen_Click);
            // 
            // crud_pdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.btnLeerImagen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLeerPDF);
            this.Name = "crud_pdf";
            this.Text = "crud_pdf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeerPDF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLeerImagen;
    }
}