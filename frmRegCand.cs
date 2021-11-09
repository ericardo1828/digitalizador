using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using WIA;
using MessageBox = System.Windows.Forms.MessageBox;
//using Spire.Pdf;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Configuration;
using BarcodeLib.BarcodeReader;
using ThoughtWorks.QRCode.Codec;
using Microsoft.VisualBasic;
using ThoughtWorks.QRCode.Codec.Data;

namespace Digitalizador
{
    public partial class frmRegCand : Form
    {
        //Font myFont = new Font("Arial", 16);
        //int pageNum = 0;
        PrintPreviewControl prtprw;

        public frmRegCand()
        {
            InitializeComponent();
        }

        #region EVENTOS CONTROLES FORMULARIO
        private void frmRegCand_Load(object sender, EventArgs e)
        {
            //temporal
            btnScan.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            pictureBox1.Visible = false;
            listBox1.Visible = false;
            ////////

            LlenarListBoxScanners();
            llenaComboRutasDir();


            //para visualizar un pdf en el prevewcontrol
            //printPreviewControl1_Click(null, null);

            axAcroPDF1.Visible = false;


        }
        #endregion

        #region METODOS PROPIOS
        PdfDocument pdf = new PdfDocument();

        public void llenaComboRutasDir()
        {
            try
            {
                Conexion con = new Conexion();
                string query = "";

                //Obtener las rutas y mostrarlas en el grid
                query = "select cd.pkDocumento, cd.documento  from Common.CS_Documentos cd inner join Common.CT_RutasArchivosDigitalizador rad on cd.pkDocumento = rad.fkDocumento";
                DataTable odt = con.RetSqlDataTable(GetSetting("entorno").ToString().Trim(), query);

                cmbRutasDir.DataSource = odt;
                cmbRutasDir.DisplayMember = "documento";
                cmbRutasDir.ValueMember = "pkDocumento";
                cmbRutasDir.Refresh();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void LlenarListBoxScanners()
        {
            listBox1.Items.Clear();
            var deviceManager = new DeviceManager();
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    return;
                }
                listBox1.Items.Add(new Scanner(deviceManager.DeviceInfos[i]));
            }
        }

        public void leerCodigoQR(PictureBox picQR, string imgFile)
        {
            picQR.Image = ConvertToBitmap(imgFile);
            Bitmap imagen = new Bitmap(picQR.Image);
            BarcodeReader lectura = new BarcodeReader();
            //Result resultado = lectura.Decode(imagen);

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
        public Bitmap ConvertToBitmap(string fileName)
        {
            Bitmap bitmap;
            using (Stream bmpStream = System.IO.File.Open(fileName, System.IO.FileMode.Open))
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(bmpStream);
                bitmap = new Bitmap(image);
            }
            return bitmap;
        }



        private void btnEscanearyCreaPDF_Click(object sender, EventArgs e)
        {
            btnEscanearyCreaPDF.Enabled = false;

            //var device = listBox1.SelectedItem as Scanner;
            //if (device == null)
            //{
            //    btnEscanearyCreaPDF.Enabled = true;
            //    System.Windows.Forms.MessageBox.Show("Please select a device.", "Warning", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
            //    return;
            //}

            //obtener el dispositivo scanner configurado por defecto en configuracion
            string ScannerConfiguradoDefault = GetSetting("scannerDefault");
            listBox1.SetSelected(listBox1.FindString(ScannerConfiguradoDefault), true);
            var device = listBox1.SelectedItem as Scanner;

            Document doc = new Document();
            string rutaGuardarPDF = "";
            try
            {
                Conexion con = new Conexion();
                string tipoDoc = cmbRutasDir.SelectedValue.ToString().Trim();
                string dir = "";
                string query = "select rutaDir from Common.CT_RutasArchivosDigitalizador where fkDocumento = '" + tipoDoc + "'";

                DataTable odt = con.RetSqlDataTable(GetSetting("entorno").ToString().Trim(), query);
                if (odt != null && odt.Rows.Count > 0)
                {
                    dir = odt.Rows[0]["rutaDir"].ToString().Trim() + @"\";
                }

                ///////  ASIGNAR NOMBRE TEMPORAL AL ARCHIVO - ESTE SE TOMARA BIEN YA CUANDO SE LEA EL CODIGO QR Y SE OBTENGA EL FOLIO DEL CANDIDATO
                string nombrePDF_Temp = "Folio_" +
                                System.DateTime.Now.Year.ToString().Trim() + "-" +
                                System.DateTime.Now.Month.ToString().Trim() + "-" +
                                System.DateTime.Now.Day.ToString().Trim() + " _" +
                                System.DateTime.Now.Hour.ToString().Trim() + "-" +
                                System.DateTime.Now.Minute.ToString().Trim() + "-" +
                                System.DateTime.Now.Second.ToString().Trim();

                ///////////////////////////////////////////////////////////////////


                rutaGuardarPDF = @"" + dir + nombrePDF_Temp + ".pdf";
                PdfWriter.GetInstance(doc, new FileStream(rutaGuardarPDF, FileMode.Create));
                doc.Open();

                Paragraph title = new Paragraph();
                //title.Font = FontFactory.GetFont(FontFactory.TIMES, 20f, BaseColor.MAGENTA);
                //title.Add("Agregar una Imagen en un PDF con iTextSharp en C# .NET");
                //doc.Add(title);

                for (int x = 1; x <= 500; x++)
                {
                    var image = device.Scan();
                    var path = @"c:\scanner\scan_" +
                                System.DateTime.Now.Year.ToString().Trim() + "-" +
                                System.DateTime.Now.Month.ToString().Trim() + "-" +
                                System.DateTime.Now.Day.ToString().Trim() + " _" +
                                System.DateTime.Now.Hour.ToString().Trim() + "-" +
                                System.DateTime.Now.Minute.ToString().Trim() + "-" +
                                System.DateTime.Now.Second.ToString().Trim() +
                                ".jpeg";
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    //// leer el codigo QR en la imagen actual
                    //ReadQRCode(path);

                    image.SaveFile(path);

                    iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance(path);

                    image1.ScalePercent(30f);
                    //image1.ScaleAbsoluteWidth(480);
                    //image1.ScaleAbsoluteHeight(270);

                    doc.Add(image1);

                    //File.Delete(path);
                }

                doc.Close();

                axAcroPDF1.Visible = true;
                axAcroPDF1.src = rutaGuardarPDF;

                btnEscanearyCreaPDF.Enabled = true;
            }
            catch (Exception)
            {
                doc.Close();
                btnEscanearyCreaPDF.Enabled = true;
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                axAcroPDF1.Visible = true;
                axAcroPDF1.src = rutaGuardarPDF;

                btnEscanearyCreaPDF.Enabled = true;
            }
        }
        #endregion

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




        //private const int WM_MOUSEWHEEL = 0x20A;
        //private const int WM_VSCROLL = 0x115;
        //private const int SB_LINEUP = 0;
        //private const int SB_LINEDOWN = 1;
        //private const int SB_PAGEUP = 2;
        //private const int SB_PAGEDOWN = 3;
        //private const int SB_ENDSCROLL = 8;
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        //protected override void WndProc(ref System.Windows.Forms.Message m)
        //{
        //    Debug.Print(m.ToString());
        //    if (m.Msg == WM_MOUSEWHEEL)
        //    {
        //        int dist = (int)m.WParam >> 16;
        //        if (dist < 0)
        //            SendMessage(this.printPreviewControl1.Handle, WM_VSCROLL, (IntPtr)SB_PAGEDOWN, IntPtr.Zero);
        //        else
        //            SendMessage(this.printPreviewControl1.Handle, WM_VSCROLL, (IntPtr)SB_PAGEUP, IntPtr.Zero);
        //        SendMessage(this.printPreviewControl1.Handle, WM_VSCROLL, (IntPtr)SB_ENDSCROLL, IntPtr.Zero);
        //    }
        //    base.WndProc(ref m);
        //}

        #region EVENTOS ANTERIORES EN PRUEBAS
        private void btnScan_Click(object sender, EventArgs e)
        {
            var device = listBox1.SelectedItem as Scanner;
            if (device == null)
            {
                System.Windows.Forms.MessageBox.Show("Please select a device.", "Warning", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            var image = device.Scan();
            var path = @"c:\scanner\scan_" +
                        System.DateTime.Now.Year.ToString().Trim() + "-" +
                        System.DateTime.Now.Month.ToString().Trim() + "-" +
                        System.DateTime.Now.Day.ToString().Trim() + " _" +
                        System.DateTime.Now.Hour.ToString().Trim() + "-" +
                        System.DateTime.Now.Minute.ToString().Trim() + "-" +
                        System.DateTime.Now.Second.ToString().Trim() +
                        ".jpeg";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            try
            {



                image.SaveFile(path);

                var imagen = System.Drawing.Image.FromFile(path);
                BitmapImage BImage = new BitmapImage(new Uri(path, UriKind.Absolute));
                pictureBox1.Image = imagen;


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

            ////Load PDF file
            //PdfDocument pdf = new PdfDocument();
            //pdf.LoadFromFile(@"c:\scanner\MARIA ELENA GOMEZ GAMBOA  KIA 2020.pdf");

            ////Set the PrintPreviewControl.Rows and PrintPreviewControl.Columns properties to show multiple pages
            ////this.printPreviewControl1.Rows = 3;
            ////this.printPreviewControl1.Columns = 1;

            //panel2.Visible = true;
            //int y = 10;
            ////for (int i = 0; i < 3; i++)
            ////{
            //    prtprw = new PrintPreviewControl();
            //    //printDocument1.DocumentName = @"c:\scanner\MARIA ELENA GOMEZ GAMBOA  KIA 2020.pdf";
            //    //prtprw.Document = printDocument1;
            //    prtprw.StartPage = 1;
            //    prtprw.Left = 10;
            //    prtprw.Height = 600;
            //    prtprw.Width = panel2.Width - 40;
            //    prtprw.Top = y;
            //    panel2.Controls.Add(prtprw);
            //    y = y + (prtprw.Height + 10);

            ////}
            // pdf.Preview(this.prtprw);


            //Preview the pdf file
            //pdf.Preview(this.printPreviewControl1); 


        }
        private void printPreviewControl1_Click_1(object sender, EventArgs e)
        {
            //WndProc();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int y = 10;
            for (int i = 0; i < 3; i++)
            {
                prtprw = new PrintPreviewControl();
                prtprw.Document = printDocument1;
                prtprw.StartPage = i;
                prtprw.Left = 10;
                prtprw.Height = 600;
                prtprw.Width = panel1.Width - 40;
                prtprw.Top = y;
                panel1.Controls.Add(prtprw);
                y = y + (prtprw.Height + 10);

            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //    if (pageNum == 0)
            //    {
            //        e.Graphics.DrawString("Page 0", myFont, Brushes.Black, 100, 100);
            //        e.HasMorePages = true;
            //        pageNum = 1;

            //    }
            //    else if (pageNum == 1)
            //    {
            //        e.Graphics.DrawString("Page 1", myFont, Brushes.Black, 100, 100);
            //        e.HasMorePages = true;
            //        pageNum = 2;
            //    }
            //    else if (pageNum == 2)
            //    {
            //        e.Graphics.DrawString("Page 2", myFont, Brushes.Black, 100, 100);
            //        e.HasMorePages = false;
            //        pageNum = 0;
            //    }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ////Load PDF file
            //PdfDocument pdf = new PdfDocument();
            //pdf.LoadFromFile(@"c:\scanner\MARIA ELENA GOMEZ GAMBOA  KIA 2020.pdf");

            ////Set the PrintPreviewControl.Rows and PrintPreviewControl.Columns properties to show multiple pages
            ////this.printPreviewControl1.Rows = 3;
            ////this.printPreviewControl1.Columns = 1;

            //panel2.Visible = true;
            //int y = 10;
            //for (int i = 0; i < 7; i++)
            //{
            //    prtprw = new PrintPreviewControl();
            //    prtprw.Document = printDocument2;
            //    prtprw.StartPage = i;
            //    prtprw.Left = 10;
            //    prtprw.Height = 600;
            //    prtprw.Width = panel2.Width - 40;
            //    prtprw.Top = y;
            //    panel2.Controls.Add(prtprw);
            //    y = y + (prtprw.Height + 10);

            //pdf.Preview(this.prtprw);
            //}



            //Preview the pdf file
            //pdf.Preview(this.printPreviewControl1); 
        }
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //if (pageNum == 0)
            //{
            //    pdf.LoadFromFile(@"c:\scanner\MARIA ELENA GOMEZ GAMBOA  KIA 2020.pdf");
            //    pdf.Preview(this.prtprw);

            //    e.HasMorePages = true;
            //    pageNum = 1;

            //}
            //else if (pageNum == 1)
            //{
            //    pdf.Preview(this.prtprw);

            //    e.HasMorePages = true;
            //    pageNum = 2;
            //}
            //else if (pageNum == 2)
            //{
            //    pdf.Preview(this.prtprw);

            //    e.HasMorePages = false;
            //    pageNum = 3;
            //}
            //else if (pageNum == 3)
            //{
            //    pdf.Preview(this.prtprw);

            //    e.HasMorePages = false;
            //    pageNum = 4;
            //}
            //else if (pageNum == 4)
            //{
            //    pdf.Preview(this.prtprw);

            //    e.HasMorePages = false;
            //    pageNum = 5;
            //}
            //else if (pageNum == 5)
            //{
            //    pdf.Preview(this.prtprw);

            //    e.HasMorePages = false;
            //    pageNum = 6;
            //}
            //else if (pageNum == 6)
            //{
            //    pdf.Preview(this.prtprw);

            //    e.HasMorePages = false;
            //    pageNum = 0;
            //}
        }
        #endregion


    }

    public class Scanner
    {
        private readonly DeviceInfo _deviceInfo;
        public Scanner(DeviceInfo deviceInfo)
        {
            this._deviceInfo = deviceInfo;
        }
        public ImageFile Scan()
        {
            var device = this._deviceInfo.Connect();
            var item = device.Items[1];
            var imageFile = (ImageFile)item.Transfer("{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}");
            return imageFile;
        }
        public override string ToString()
        {
            return this._deviceInfo.Properties["Name"].get_Value().ToString();
        }
    }
}
