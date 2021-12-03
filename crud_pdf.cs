using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


            //convertPagePdfToImage();

            //ConvertPDFTOneImage();

            LoadImage("",1);

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

        public string ReadPdfFile(string fileName)
        {
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



                    //Escanear codigos qr en la hoja actual
                    cadenaQR = ReadQRCode(fileName);



                }
                pdfReader.Close();


            }
            return text.ToString();
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

        public void LoadImage(string InputPDFFile, int PageNumber)
        {
            InputPDFFile = @"C:\pdfsqr\qrs_pdf_1.pdf";
            string outPdfFolder = @"C:\pdfsqr\";
            PageNumber = 1;

            string appPath = Application.StartupPath;
            string dbPath = @"\";
            string fullpath = System.IO.Path.Combine(appPath, dbPath);


            string outImageName = System.IO.Path.GetFileNameWithoutExtension(InputPDFFile);
            outImageName = outImageName + "_" + PageNumber.ToString() + "_.png";


            GhostscriptPngDevice dev = new GhostscriptPngDevice(GhostscriptPngDeviceType.Png256);
            dev.GraphicsAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
            dev.TextAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
            dev.ResolutionXY = new GhostscriptImageDeviceResolution(290, 290);
            dev.InputFiles.Add(InputPDFFile);
            dev.Pdf.FirstPage = PageNumber;
            dev.Pdf.LastPage = PageNumber;
            dev.CustomSwitches.Add("-dDOINTERPOLATE");
            dev.OutputPath = outPdfFolder + outImageName;
            dev.Process();

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

    }
}
