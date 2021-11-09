using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using Microsoft.VisualBasic;
using ThoughtWorks.QRCode.Codec.Data;
using BarcodeLib.BarcodeReader;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;

namespace Digitalizador
{
    public partial class LeerQR : Form
    {
        public LeerQR()
        {
            InitializeComponent();
        }

        private void btSelImagenQR_Click(object sender, EventArgs e)
        {
            var dlAbrirImagenQR = new OpenFileDialog();
            dlAbrirImagenQR.InitialDirectory = @"C:\Users\" + Environment.UserName.ToString().Trim() + @"\Downloads";
            dlAbrirImagenQR.Filter = "*.bmp;*.gif;*.jpg;*.jpeg;*.png|*.bmp;*.gif;*.jpg;*.png";
            dlAbrirImagenQR.RestoreDirectory = true;
            dlAbrirImagenQR.CheckFileExists = true;
            dlAbrirImagenQR.CheckPathExists = true;

            if (dlAbrirImagenQR.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlAbrirImagenQR.FileName;
                pictureBox1.ImageLocation = textBox1.Text;
            }
        }

        private void btDecodificarImagenQR_Click(object sender, EventArgs e)
        {
            if (Information.IsNothing(pictureBox1.Image))
            {
                MessageBox.Show("Antes de decodificar una imagen QR a su texto correspondiente QR Code debe seleccionar la imagen.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btSelImagenQR.Focus();
            }
            else
            {
                try
                {
                    var decoder = new QRCodeDecoder();
                    if (checkBox1.Checked)
                    {
                        textBox2.Text = decoder.decode(new QRCodeBitmapImage(new Bitmap(pictureBox1.Image)), Encoding.UTF8);
                    }
                    else
                    {
                        textBox2.Text = decoder.decode(new QRCodeBitmapImage(new Bitmap(pictureBox1.Image)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLeerCodigoBarras_Click(object sender, EventArgs e)
        {
            string[] arr;
            arr = ReadBarCode(textBox1.Text.ToString().Trim());
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

        #region METODOS DEL APP CONFIG
        private static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        private static void SetSetting(string key, string value)
        {
            Configuration configuration =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "fecha de acopio: " + GetSetting("nombreAplicacion").ToString().Trim();
            string fecha = System.DateTime.Now.Year.ToString().Trim() + "-"
                                + System.DateTime.Now.Month.ToString().Trim() + "-"
                                + System.DateTime.Now.Day.ToString().Trim()
                                + " "
                                + System.DateTime.Now.Hour.ToString().Trim() + ":"
                                + System.DateTime.Now.Minute.ToString().Trim() + ":"
                                + System.DateTime.Now.Second.ToString().Trim();

            string mensaje = texto + "\n" + fecha;

            PointF firstLocation = new PointF(10f, 10f);
            PointF secondLocation = new PointF(10f, 50f);

            string imageFilePath = @"C:\Users\Ericardo\Downloads\codigoBarrasActaPNG_chido2.png";

            /////////////// NO FUNCIONA
            //Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);//load the image file
            //using (Graphics graphics = Graphics.FromImage(bitmap))
            //{
            //    using (Font arialFont = new Font("Arial", 10))
            //    {
            //        graphics.DrawString(firstText, arialFont, Brushes.Blue, firstLocation);
            //        graphics.DrawString(secondText, arialFont, Brushes.Red, secondLocation);
            //    }
            //}
            //bitmap.Save(imageFilePath.Replace(".webp", "_2.webp"));//save the image file
            /////////////////////////

            //NO FUNCIONA
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    bitmap.Save(stream, ImageFormat.Png);
            //    //stream.WriteTo(context.Response.OutputStream);
            //}
            ///////////////

            ////FUNCIONA CON PNG
            //using (FileStream fs = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            //{
            //    using (Image original = Image.FromStream(fs))
            //    {
            //        using (Graphics graphics = Graphics.FromImage(original))
            //        {
            //            using (Font arialFont = new Font("Arial", 10))
            //            {
            //                graphics.DrawString(firstText, arialFont, Brushes.Blue, firstLocation);
            //                graphics.DrawString(secondText, arialFont, Brushes.Red, secondLocation);
            //            }
            //        }
            //        original.Save(imageFilePath.Replace(".png", "_2.png"));//save the image file
            //    }
            //}
            ///////////////////



            ////NO FUNCIONA CON JPEG
            //using (FileStream fs = new FileStream(imageFilePath, FileMode.Open, FileAccess.ReadWrite))
            //{
            //    using (Image original = Image.FromStream(fs,false,true))
            //    {
            //        using (Graphics graphics = Graphics.FromImage(original))
            //        {
            //            using (Font arialFont = new Font("Arial", 10))
            //            {
            //                graphics.DrawString(firstText, arialFont, Brushes.Blue, firstLocation);
            //                graphics.DrawString(secondText, arialFont, Brushes.Red, secondLocation);
            //            }
            //        }
            //        original.Save(imageFilePath.Replace(".jpeg", "_2.jpeg"));//save the image file
            //    }
            //}
            ///////////////////
            ///

            
                    Bitmap bmp = new Bitmap(imageFilePath);
                    Graphics gra = Graphics.FromImage(bmp);
                   // string text = "Hello\nWorld";

                    gra.DrawString(mensaje, new Font("Verdana", 24), Brushes.Red, new PointF(100, 40));
                    bmp.Save(imageFilePath.Replace(".png", "_2.png"));
            

        }
    }
}
