using BarcodeLib.BarcodeReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitalizador
{
    public partial class RecortarImagenes : Form
    {
        public RecortarImagenes()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var dlAbrirImagenQR = new OpenFileDialog();
            dlAbrirImagenQR.InitialDirectory = @"C:\Users\" + Environment.UserName.ToString().Trim() + @"\Downloads";
            dlAbrirImagenQR.Filter = "*.bmp;*.gif;*.jpeg;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png";
            dlAbrirImagenQR.RestoreDirectory = true;
            dlAbrirImagenQR.CheckFileExists = true;
            dlAbrirImagenQR.CheckPathExists = true;

            if (dlAbrirImagenQR.ShowDialog() == DialogResult.OK)
            {
                Bitmap source = new Bitmap(dlAbrirImagenQR.FileName.ToString().Trim());
                //Bitmap resizedImage = resizeImage(source, new Size(100, 200));

                textBox1.Text = dlAbrirImagenQR.FileName;
                pictureBox1.Image = source;
                pictureBox1.Refresh();

                // ESTO ES UN COMENTARIO SOLO PARA PROBAR UN PUSH EN GITHUB
            }
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {

            Bitmap source = new Bitmap(textBox1.Text.ToString().Trim());

            ////Seccion para codigo en Acta
            //Rectangle section = new Rectangle(new Point(10, 10), new Size(800, 220));

            ////Seccion para codigo en CVs Publicos
            Rectangle section = new Rectangle(new Point(150, 100), new Size(120, 120));

            //Bitmap resizedImage = resizeImage(source, new Size(200, 200));

            Bitmap CroppedImage = CropImage(source, section);

            //// Guardar la Imagen de barras
            //CroppedImage.Save(@"C:\Users\Ericardo\Downloads\barras1.jpg");

            //// Guardar la Imagen de QR
            CroppedImage.Save(@"C:\Users\Ericardo\Downloads\qr1.jpg");

            pictureBox1.Image = CroppedImage;
            pictureBox1.Refresh();

            if (cmbTipoCodigo.SelectedItem != null && cmbTipoCodigo.SelectedItem.ToString().Trim() != "")
            {
                switch (cmbTipoCodigo.SelectedItem.ToString().Trim())
                {
                    case "BARRAS":
                        btnLeerCodigoBarras_Click(null, null);
                        break;
                    case "QR":
                        btnLeerCodigoQR_Click(null, null);
                        break;
                }
            }


        }

        public static Bitmap resizeImage(Image imgToResize, Size size)
        {
            return (Bitmap)(new Bitmap(imgToResize, size));
        }

        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
        }

        private void btnLeerCodigoBarras_Click(object sender, EventArgs e)
        {
            string[] arr;
            arr = ReadBarCode(@"C:\Users\Ericardo\Downloads\barras1.jpg");
            string cadenaObtenida = "";
            for (int x = 0; x < arr.Length; x++)
            {
                cadenaObtenida = cadenaObtenida + arr[x].ToString().Trim();
            }

            textBox2.Text = cadenaObtenida;
        }

        private string[] ReadBarCode(string imgFile)
        {
            var reader = new BarcodeReader();
            string filename = imgFile;

            string[] results = BarcodeReader.read(filename, BarcodeReader.CODE39);
            if (results != null)
            {
                return results;
            }
            else
            {
                return new string[0];
            }

        }

        private void btnLeerCodigoQR_Click(object sender, EventArgs e)
        {
            string[] arr;
            arr = ReadQRCode(@"C:\Users\Ericardo\Downloads\qr1.jpg");
            string cadenaObtenida = "";
            for (int x = 0; x < arr.Length; x++)
            {
                cadenaObtenida = cadenaObtenida + arr[x].ToString().Trim();
            }

            textBox2.Text = cadenaObtenida;
        }

        private string[] ReadQRCode(string imgFile)
        {
            var reader = new BarcodeReader();
            string filename = imgFile;

            string[] results = BarcodeReader.read(filename, BarcodeReader.QRCODE);
            if (results != null)
            {
                return results;
            }
            else
            {
                return new string[0];
            }

        }

        public void ubicarCodigoQR()
        {
            // Crear bitmap la imagen seleccionada
            Bitmap source = new Bitmap(@"C:\Users\Ericardo\Downloads\scan_qr.jpg");
            string cadenaObtenida = "";

            for (int x = 1; x <= 5; x++)
            {
                if (cadenaObtenida == "")
                {
                    for (int y = 1; y <= 8; y++)
                    {
                        if (cadenaObtenida == "")
                        {
                            int a = 50, b = 33;
                            a = a * x;
                            b = b * y;

                            // Crear seccion a recortar
                            Rectangle section = new Rectangle(new Point(a, b), new Size(120, 120));

                            // Recortar seccion de la imagen
                            Bitmap CroppedImage = CropImage(source, section);

                            //// Guardar la Imagen de QR
                            CroppedImage.Save(@"C:\Users\Ericardo\Downloads\qrs\qr_" + a.ToString().Trim() + "_" + b.ToString().Trim() + ".jpg");

                            // Lee la imagen actual para ver si puede leer un codigo qr
                            string[] arr;
                            arr = ReadQRCode(@"C:\Users\Ericardo\Downloads\qrs\qr_" + a.ToString().Trim() + "_" + b.ToString().Trim() + ".jpg");

                            for (int z = 0; z < arr.Length; z++)
                            {
                                cadenaObtenida = cadenaObtenida + arr[z].ToString().Trim();
                            }
                            if (arr != null && arr.Length != 0)
                            {
                                textBox2.Text += cadenaObtenida;

                                break;
                            }
                        }
                    }
                }
            }
        }

        public void ubicarCodigoBarras()
        {
            // Crear bitmap la imagen seleccionada
            Bitmap source = new Bitmap(@"C:\Users\Ericardo\Downloads\0570B_A (1).jpg");
            string cadenaObtenida = "";

            for (int x = 1; x <= 5; x++)
            {
                if (cadenaObtenida == "")
                {
                    for (int y = 1; y <= 16; y++)
                    {
                        if (cadenaObtenida == "")
                        {
                            int a = 200, b = 55;
                            a = a * x;
                            b = b * y;

                            // Crear seccion a recortar
                            Rectangle section = new Rectangle(new Point(a, b), new Size(650, 200));

                            // Recortar seccion de la imagen
                            Bitmap CroppedImage = CropImage(source, section);

                            //// Guardar la Imagen de QR
                            CroppedImage.Save(@"C:\Users\Ericardo\Downloads\barras\barra_" + a.ToString().Trim() + "_" + b.ToString().Trim() + ".jpg");

                            // Lee la imagen actual para ver si puede leer un codigo qr
                            string[] arr;
                            arr = ReadBarCode(@"C:\Users\Ericardo\Downloads\barras\barra_" + a.ToString().Trim() + "_" + b.ToString().Trim() + ".jpg");

                            for (int z = 0; z < arr.Length; z++)
                            {
                                cadenaObtenida = cadenaObtenida + arr[z].ToString().Trim();
                            }
                            if (arr != null && arr.Length != 0)
                            {
                                textBox2.Text += cadenaObtenida;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btnUbicarCodigo_Click(object sender, EventArgs e)
        {
            ubicarCodigoQR();
            ubicarCodigoBarras();
        }
    }
}
