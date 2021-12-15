﻿using Digitalizador.Persistence;
using Newtonsoft.Json;
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
using Ghostscript.NET;
using Newtonsoft.Json.Linq;

namespace Digitalizador
{
    public partial class frmRegistroCandidatos : Form
    {

        DataTable odtFilesMonitoreados = new DataTable();

        public frmRegistroCandidatos()
        {
            InitializeComponent();
        }

        private void frmRegistroCandidatos_Load(object sender, EventArgs e)
        {
            odtFilesMonitoreados.Columns.Add("file");
            visorPDF.Visible = false;

            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'timerMonitoreoRC'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerMonitoreoRC_valor = odtConf.Rows.Count > 0 ? Extensions.ToBoolean(odtConf.Rows[0]["valor"].ToString().Trim()) : false;

            query = "select valor from ConfClaveValor where clave = 'timerEnvioRC'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerEnvioRC_valor = odtConf2.Rows.Count > 0 ? Extensions.ToBoolean(odtConf2.Rows[0]["valor"].ToString().Trim()) : false;

            timerMonitoreoRC.Enabled = timerMonitoreoRC_valor;
            timerEnvioRC.Enabled = timerEnvioRC_valor;
        }

        private void btnEnviarArchivoManual_Click(object sender, EventArgs e)
        {
            //enviar un arreglo de string con los paths completos a este metodo EnviarArchivosRC
            string[] arrArchivos = ObtenerArchivosRCSeleccionados();
            EnviarArchivosRC(arrArchivos);
        }

        private void timerChecaTimers_Tick(object sender, EventArgs e)
        {
            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'timerMonitoreoRC'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerMonitoreoRC_valor = odtConf.Rows.Count > 0 ? Extensions.ToBoolean(odtConf.Rows[0]["valor"].ToString().Trim()) : false;

            query = "select valor from ConfClaveValor where clave = 'timerEnvioRC'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerEnvioRC_valor = odtConf2.Rows.Count > 0 ? Extensions.ToBoolean(odtConf2.Rows[0]["valor"].ToString().Trim()) : false;

            timerMonitoreoRC.Enabled = timerMonitoreoRC_valor;
            timerEnvioRC.Enabled = timerEnvioRC_valor;
        }

        private void timerMonitoreoRC_Tick(object sender, EventArgs e)
        {
            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'timerMonitoreoRC'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerMonitoreoRC_valor = odtConf.Rows.Count > 0 ? Extensions.ToBoolean(odtConf.Rows[0]["valor"].ToString().Trim()) : false;


            if (timerMonitoreoRC_valor)
            {
                if (chkMonitorearAuto.Checked)
                {
                    LlenarGridMonitoreoArchivos();
                }
            }
        }

        private void timerEnvioRC_Tick(object sender, EventArgs e)
        {
            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'timerEnvioRC'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerEnvioRC_valor = odtConf2.Rows.Count > 0 ? Extensions.ToBoolean(odtConf2.Rows[0]["valor"].ToString().Trim()) : false;

            if (timerEnvioRC_valor)
            {
                if (chkEnviarAuto.Checked)
                {
                    try
                    {
                        string[] arrArchivos = ObtenerArchivosRCSeleccionados();
                        EnviarArchivosRC(arrArchivos);
                    }
                    catch (Exception ex)
                    {
                        string[] arrArchivos = ObtenerArchivosRCSeleccionados();
                        EnviarArchivosRC(arrArchivos);
                    }
                }
            }
        }

        public string[] ObtenerArchivosRCSeleccionados()
        {
            int cant = gridMonitoreoArchivos.SelectedCells.Count;
            string[] arrArchivos = new string[cant];

            if (gridMonitoreoArchivos.SelectedCells.Count > 0)
            {
                for (int x = 0; x < cant; x++)
                {
                    int i = gridMonitoreoArchivos.SelectedCells[0].RowIndex;
                    string dirArchivo = gridMonitoreoArchivos.Rows[i].Cells[0].Value.ToString().Trim();

                    arrArchivos[x] = dirArchivo;
                }
            }
            return arrArchivos;
        }

        public string EnviarArchivosRC(string[] arrArchivos)
        {
            convert conv = new convert();
            string bndEnvioCorrecto = "";

            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'serivicioPruebasRC'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            string serivicioPruebasRC = odtConf.Rows.Count > 0 ? odtConf.Rows[0]["valor"].ToString().Trim() : "";

            string url = serivicioPruebasRC;

            foreach (string file in arrArchivos)
            {
                //Leer codigo QR del archivo PDF
                string currentDirectory = Environment.CurrentDirectory.ToString().Trim();
                string contenidoQR = ReadPdfFile(file, currentDirectory);
                contenidoQR = contenidoQR.Replace("6\"f", "{\"f");
                contenidoQR = contenidoQR.Replace("7\"f", "{\"f");

                /////////////////////////////////////////////////
                JObject SearchNode = JObject.Parse(contenidoQR);

                // Obtener la propiedades result en una lista 
                IList<JToken> results = SearchNode.Children().ToList();

                // Serializa resultados JSON a un objeto .NET
                IList<cArchivoRC> searchResults = new List<cArchivoRC>();

                string folio2 = results[0].First.ToString().Trim();
                string candidato = results[1].First.ToString().Trim();
                string doc_title = results[2].First.ToString().Trim();
                string doc_id = results[3].First.ToString().Trim();

                //foreach (JToken result in results)
                //{
                //cArchivoRC searchResult = JsonConvert.DeserializeObject<cArchivoRC>(result.ToString());
                //searchResults.Add(searchResult);



                //string folio = result.First.ToString();

                //string candidato = searchResult.candidato.ToString().Trim();
                //string doc_title = searchResult.doc_title.ToString().Trim();
                //string doc_id = searchResult.doc_id.ToString().Trim();

                // enviar un archivo en base 64
                var file64 = new cfileBase64
                    {
                        //filename = "codigoQR4.pdf",
                        //folder = "urnas",
                        //file = conv.convertFileToBase64(file)

                        filename = folio2 + ".pdf",
                        folder = "urnas",
                        file = conv.convertFileToBase64(file)
                    };
                    string jsonFile = JsonConvert.SerializeObject(file64);

                    //bndEnvioCorrecto = rest.PostItemFile64(jsonFile, url);
                //}
            }



            return bndEnvioCorrecto;
        }

        public string ReadPdfFile(string fileName, string outputFolder)
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
                }
                pdfReader.Close();
            }
            return cadenaObtenida;
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

        public void LlenarGridMonitoreoArchivos()
        {
            odtFilesMonitoreados.Rows.Clear();

            string[] files = Directory.GetFiles(@"C:\files\", "*.pdf");

            foreach (string file in files)
            {
                odtFilesMonitoreados.Rows.Add(file);
            }

            //gridMonitoreoArchivos.AutoGenerateColumns = false;
            gridMonitoreoArchivos.DataSource = odtFilesMonitoreados;
            gridMonitoreoArchivos.Refresh();

        }

        private void gridMonitoreoArchivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridMonitoreoArchivos.SelectedCells.Count > 0)
            {
                int i = gridMonitoreoArchivos.SelectedCells[0].RowIndex;
                string dirArchivo = gridMonitoreoArchivos.Rows[i].Cells[0].Value.ToString().Trim();

                visorPDF.Visible = true;
                visorPDF.src = dirArchivo;
            }
        }



        //private void gridMonitoreoArchivos_SelectionChanged(object sender, EventArgs e)
        //{
        //if (gridMonitoreoArchivos.SelectedRows.Count > 0)
        //{
        //int id = Convert.ToInt32(gridMonitoreoArchivos.SelectedRows[0].Cells["ColummID"].Value.ToString());
        //string dirArchivo = gridMonitoreoArchivos.SelectedRows[0].Cells["file"].Value.ToString();

        //string dirArchivo = gridMonitoreoArchivos.SelectedRows[0].Cells["file"].Value.ToString();

        //visorPDF.Visible = true;
        //visorPDF.src = dirArchivo;
        //}

        //}


    }
}