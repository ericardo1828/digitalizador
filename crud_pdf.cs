using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using BarcodeLib.BarcodeReader;
using ImageMagick;
using System.Collections;
using Ghostscript.NET;

using Syncfusion.Pdf.Parsing;
using Syncfusion.Windows.Forms.PdfViewer;
using System.Drawing;
using System.Drawing.Imaging;

namespace Digitalizador
{
    public partial class crud_pdf : Form
    {
        //private const string _RootDirectory = @"..\..\Samples\Magick.NET\";
        private const string _FilesDirectory = @"Files\";


        public crud_pdf()
        {
            InitializeComponent();
        }

        private void btnLeerPDF_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            //path = path + @"\pdfsqr1.pdf";

            //path = @"c:\pdfsqr\pdfsqr1.pdf";
            //string salida = ReadPdfFile(path);


            //string path2 = @"c:\pdfsqr\qrs_pdf.pdf";
            //SplitePDF(path2);

            //ConvertPdfPageToPng(@"C:\pdfsqr\qrs_pdf_1.pdf", 1, @"C:\pdfsqr\png\");


            //chido
            //ReadPdfFile(@"C:\pdfsqr\IEPC-SIRC-00235_23.pdf", @"C:\pdfsqr\png\");

           
        }

        private void btnLeerImagen_Click(object sender, EventArgs e)
        {
            ReadImagenFile(@"C:\actas\Captura1.png");
        }

        public void convert_pdf_to_jpg(string filepath, string outputFolder)
        {
            //string InputPDFFile = @"C:\pdfsqr\qrs_pdf_1.pdf";
            //string OutPdfFolder = @"C:\pdfsqr\jpg\";

            //Initialize the PdfViewer Control
            PdfViewerControl pdfViewer = new PdfViewerControl();

            //Load the input PDF file
            //PdfLoadedDocument loadedDocument = new PdfLoadedDocument("../../Data/Barcode.pdf");
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(filepath);

            pdfViewer.Load(loadedDocument);

            //Export the particular PDF page as image at the page index of 0
            Bitmap image = pdfViewer.ExportAsImage(0);

            // Save the image.
            image.Save(outputFolder + @"Sample3.png", ImageFormat.Png);
        }

        public void convert()
        {
            //// Create a PDF converter instance by loading a local file 
            //PdfImageConverter pdfConverter = new PdfImageConverter("sample.pdf");

            //// Set the dpi, the output image will be rendered in such resolution
            //pdfConverter.DPI = 96;

            //// the output image will be rendered to grayscale image or not
            //pdfConverter.GrayscaleOutput = false;

            //for (int i = 0; i < pdfConverter.PageCount; i++)
            //{
            //    // Convert each pdf page to jpeg image with original page size
            //    //Image pageImage = pdfConverter.PageToImage(i);
            //    // Convert pdf to jpg in customized image size
            //    Image pageImage = pdfConverter.PageToImage(i, 500, 800);

            //    // Save converted image to jpeg format
            //    pageImage.Save("Page " + i + ".jpg", ImageFormat.Jpeg);
            //}
        }

        //public string ReadPdfFile(object Filename)
        //{
        //    PdfReader reader2 = new PdfReader((string)Filename);
        //    string strText = string.Empty;

        //    for (int page = 1; page <= reader2.NumberOfPages; page++)
        //    {
        //        ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy();
        //        PdfReader reader = new PdfReader((string)Filename);
        //        String s = PdfTextExtractor.GetTextFromPage(reader, page, its);

        //        s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
        //        strText = strText + s;
        //        reader.Close();
        //    }
        //    return strText;
        //}

        public void ReadPdfFile(string fileName, string outputFolder)
        {
            string cadenaObtenida = "";
            StringBuilder text = new StringBuilder();
            if (File.Exists(fileName))
            {
                string[] cadenaQR;

                PdfReader pdfReader = new PdfReader(fileName);
                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);
                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                    text.Append(currentText);

                    //crear una imagen jpg por cada hoja
                    string pageInPng = ConvertPdfPageToPng(fileName, page, outputFolder);

                    //Escanear codigos qr en la hoja actual
                    string[] arr;
                    arr = ReadQRCode(pageInPng);
                    
                    for (int x = 0; x < arr.Length; x++)
                    {
                        cadenaObtenida = cadenaObtenida + arr[x].ToString().Trim();
                    }
                    textBox1.Text = cadenaObtenida;

                }
                pdfReader.Close();

            }
            //return text.ToString();
        }

        public void ReadImagenFile(string fileName)
        {
            //string cadenaObtenida = "";
            //StringBuilder text = new StringBuilder();
            //if (File.Exists(fileName))
            //{
            //    string[] arr;
            //    arr = ReadBarCode(fileName);
            //    for (int x = 0; x < arr.Length; x++)
            //    {
            //        cadenaObtenida = cadenaObtenida + arr[x].ToString().Trim();
            //    }
            //    textBox1.Text = cadenaObtenida;
            //}

            ubicarCodigoBarras(fileName);

        }

        void SplitePDF(string filepath)
        {
            iTextSharp.text.pdf.PdfReader reader = null;
            int currentPage = 1;
            int pageCount = 0;
            //string filepath_New = filepath + "\\PDFDestination\\";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            //byte[] arrayofPassword = encoding.GetBytes(ExistingFilePassword);
            reader = new iTextSharp.text.pdf.PdfReader(filepath);
            reader.RemoveUnusedObjects();
            pageCount = reader.NumberOfPages;
            string ext = System.IO.Path.GetExtension(filepath);
            for (int i = 1; i <= pageCount; i++)
            {
                iTextSharp.text.pdf.PdfReader reader1 = new iTextSharp.text.pdf.PdfReader(filepath);
                string outfile = filepath.Replace((System.IO.Path.GetFileName(filepath)), (System.IO.Path.GetFileName(filepath).Replace(".pdf", "") + "_" + i.ToString()) + ext);
                reader1.RemoveUnusedObjects();
                iTextSharp.text.Document doc = new iTextSharp.text.Document(reader.GetPageSizeWithRotation(currentPage));
                iTextSharp.text.pdf.PdfCopy pdfCpy = new iTextSharp.text.pdf.PdfCopy(doc, new System.IO.FileStream(outfile, System.IO.FileMode.Create));
                doc.Open();
                for (int j = 1; j <= 1; j++)
                {
                    iTextSharp.text.pdf.PdfImportedPage page = pdfCpy.GetImportedPage(reader1, currentPage);
                    //pdfCpy.SetFullCompression();
                    pdfCpy.AddPage(page);
                    currentPage += 1;
                }
                doc.Close();
                pdfCpy.Close();
                reader1.Close();
                reader.Close();

            }
        }

        //public void RenderPDFAsImages(string Inputfile, string OutputFolder)
        //{
        //    string fileName = System.IO.Path.GetFileNameWithoutExtension(Inputfile);

        //    using (PDFiumSharp.PdfDocument doc = new PDFiumSharp.PdfDocument(Inputfile))
        //    {
        //        for (int i = 0; i < doc.Pages.Count; i++)
        //        {
        //            var page = doc.Pages[i];
        //            using (var bitmap = new System.Drawing.Bitmap((int)page.Width, (int)page.Height))
        //            {
        //                var grahpics = Graphics.FromImage(bitmap);
        //                grahpics.Clear(Color.White);
        //                page.Render(bitmap);
        //                var targetFile = Path.Combine(OutputFolder, fileName + "_" + i + ".png");
        //                bitmap.Save(targetFile);
        //            }
        //        }
        //    }
        //}


        public string ConvertPdfPageToPng(string InputPDFFile, int PageNumber, string OutputFolder)
        {
            //InputPDFFile = @"C:\pdfsqr\qrs_pdf_1.pdf";
            //string outPdfFolder = @"C:\pdfsqr\";
            //PageNumber = 1;

            string appPath = Application.StartupPath;
            string dbPath = @"\";
            string fullpath = System.IO.Path.Combine(appPath, dbPath);

            string outImageName = System.IO.Path.GetFileNameWithoutExtension(InputPDFFile);
            outImageName = outImageName + "_" + PageNumber.ToString() + ".png";

            GhostscriptPngDevice dev = new GhostscriptPngDevice(GhostscriptPngDeviceType.Png256);
            dev.GraphicsAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
            dev.TextAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
            dev.ResolutionXY = new GhostscriptImageDeviceResolution(290, 290);
            dev.InputFiles.Add(InputPDFFile);
            dev.Pdf.FirstPage = PageNumber;
            dev.Pdf.LastPage = PageNumber;
            dev.CustomSwitches.Add("-dDOINTERPOLATE");
            dev.OutputPath = OutputFolder + outImageName;
            dev.Process();

            return dev.OutputPath.ToString().Trim();

        }

        public void convertPagePdfToImage()
        {
            //string inputPdf = @"C:\my docs\input.pdf";
            //string outputPng = @"C:\my docs\output.png";

            string inputPdf = @"C:\pdfsqr\qrs_pdf_1.pdf";
            string outputPng = @"C:\pdfsqr\qrs_pdf_1.png";
            if (File.Exists(inputPdf))
            {
                using (MagickImageCollection images = new MagickImageCollection())
                {
                    IEnumerable lista = images.ToList();

                    foreach (var o in lista)
                    {
                        textBox1.Text += o.ToString().Trim();
                    }

                    images.Read(inputPdf);
                    using (IMagickImage vertical = images.AppendVertically())
                    {
                        vertical.Format = MagickFormat.Png;
                        vertical.Density = new Density(300);
                        vertical.Write(outputPng);
                    }
                }
            }

        }

        public static void ConvertPDFTOneImage()
        {
            string inputPdf =  Environment.CurrentDirectory.Replace(@"\bin\Debug",@"\") + _FilesDirectory + "Snakeware.pdf";
            string outputPng = _FilesDirectory;

            if (File.Exists(inputPdf))
            {
                var settings = new MagickReadSettings();
                // Settings the density to 300 dpi will create an image with a better quality
                settings.Density = new Density(300);

                using (var images = new MagickImageCollection())
                {
                    // Add all the pages of the pdf file to the collection
                    images.Read(inputPdf);

                    // Create new image that appends all the pages horizontally
                    using (var horizontal = images.AppendHorizontally())
                    {
                        // Save result as a png
                        horizontal.Write(outputPng + "Snakeware.horizontal.png");
                    }

                    // Create new image that appends all the pages vertically
                    using (var vertical = images.AppendVertically())
                    {
                        // Save result as a png
                        vertical.Write(outputPng + "Snakeware.vertical.png");
                        vertical.Write(outputPng + "Snakeware.vertical.png");
                    }
                }
            }
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
            Bitmap source = new Bitmap(@"C:\Users\programador\Downloads\codigos\scan_qr.jpg");
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
                            CroppedImage.Save(@"C:\Users\programador\Downloads\codigos\qrs\qr_" + a.ToString().Trim() + "_" + b.ToString().Trim() + ".jpg");

                            // Lee la imagen actual para ver si puede leer un codigo qr
                            string[] arr;
                            arr = ReadQRCode(@"C:\Users\programador\Downloads\codigos\qrs\qr_" + a.ToString().Trim() + "_" + b.ToString().Trim() + ".jpg");

                            for (int z = 0; z < arr.Length; z++)
                            {
                                cadenaObtenida = cadenaObtenida + arr[z].ToString().Trim();
                            }
                            if (arr != null && arr.Length != 0)
                            {
                                textBox1.Text += cadenaObtenida;

                                break;
                            }
                        }
                    }
                }
            }
        }

        public void ubicarCodigoBarras(string filepath)
        {
            // Crear bitmap la imagen seleccionada
            Bitmap source = new Bitmap(filepath);
            string cadenaObtenida = "";

            for (int x = 1; x <= 5; x++)
            {
                if (cadenaObtenida == "")
                {
                    for (int y = 1; y <= 16; y++)
                    {
                        if (cadenaObtenida == "")
                        {
                            //int a = 00, b = 55;
                            //int a = 150, b = 150;
                            int a = 30, b = 20;
                            a = a * x;
                            b = b * y;

                            // Crear seccion a recortar
                            //Rectangle section = new Rectangle(new Point(a, b), new Size(650, 200));
                            //Rectangle section = new Rectangle(new Point(a, b), new Size(2000, 500));
                            Rectangle section = new Rectangle(new Point(a, b), new Size(300, 100));

                            // Recortar seccion de la imagen
                            Bitmap CroppedImage = CropImage(source, section);

                            //// Guardar la Imagen de QR
                            //CroppedImage.Save(@"C:\Users\programador\Downloads\barras\barra_" + a.ToString().Trim() + "_" + b.ToString().Trim() + ".jpg");
                            string tempFolder = Environment.CurrentDirectory.Replace(@"\bin\Debug",@"\temp\");
                            string imgFile = tempFolder + a.ToString().Trim() + "_" + b.ToString().Trim() + ".png";
                            CroppedImage.Save(imgFile);

                            // Lee la imagen actual para ver si puede leer un codigo qr
                            string[] arr;
                            //arr = ReadBarCode(@"C:\Users\programador\Downloads\barras\barra_" + a.ToString().Trim() + "_" + b.ToString().Trim() + ".jpg");
                            arr = ReadBarCode(imgFile);

                            for (int z = 0; z < arr.Length; z++)
                            {
                                cadenaObtenida = cadenaObtenida + arr[z].ToString().Trim();
                            }
                            if (arr != null && arr.Length != 0)
                            {
                                textBox1.Text += cadenaObtenida;

                                break;
                            }
                        }
                    }
                }
            }
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

       
    }
}
