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

namespace Digitalizador
{
    public partial class crud_pdf : Form
    {

        

        public crud_pdf()
        {
            InitializeComponent();
        }

        private void btnLeerPDF_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            //path = path + @"\pdfsqr1.pdf";
            path = @"c:\pdfsqr\pdfsqr1.pdf";
            string salida = ReadPdfFile(path);


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
                { ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy(); 
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
