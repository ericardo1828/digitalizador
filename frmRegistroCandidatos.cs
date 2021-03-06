using Digitalizador.Persistence;
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
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System.Net.Http;
using System.Net;

namespace Digitalizador
{
    public partial class frmRegistroCandidatos : Form
    {

        DataTable odtFilesMonitoreados = new DataTable();
        DataTable odtFilesEnviados = new DataTable();

        public frmRegistroCandidatos()
        {
            InitializeComponent();
        }

        private void frmRegistroCandidatos_Load(object sender, EventArgs e)
        {
            odtFilesMonitoreados.Columns.Add("file");
            odtFilesEnviados.Columns.Add("file");
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
                    LlenarGridEnvioArchivos();
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
                        string[] arrArchivos = ObtenerArchivosRCTodos();
                        if(arrArchivos.Length > 0) 
                        {
                            EnviarArchivosRC_2(arrArchivos);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        string[] arrArchivos = ObtenerArchivosRCTodos();
                        if (arrArchivos.Length > 0)
                        {
                            EnviarArchivosRC_2(arrArchivos);
                        }
                    }
                }
            }
        }

        public string[] ObtenerArchivosRCTodos()
        {
            int cant = gridMonitoreoArchivos.Rows.Count;
            string[] arrArchivos = new string[cant];

            for (int x = 0; x < cant; x++)
            {
                string dirArchivo = gridMonitoreoArchivos.Rows[x].Cells["file"].Value.ToString().Trim();
                arrArchivos[x] = dirArchivo;
            }
            
            return arrArchivos;
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

                string pathFolderTemp = currentDirectory.Replace(@"\bin\Debug", @"\temp\");
                string outputFolderCompressed = currentDirectory.Replace(@"\bin\Debug", @"\compressed\");

                //string fileCompressed = CompressPdf(file, outputFolderCompressed);

                string contenidoQR = ReadPdfFile(file, pathFolderTemp); // ULTIMO CAMBIO
                //contenidoQR = contenidoQR.Replace("6\"f", "{\"f");
                //contenidoQR = contenidoQR.Replace("7\"f", "{\"f");

                validaciones val = new validaciones();
                if (validaciones.IsValidJson(contenidoQR))
                {
                    /////////////////////////////////////////////////
                    JObject SearchNode = JObject.Parse(contenidoQR);

                    // Obtener la propiedades result en una lista 
                    IList<JToken> results = SearchNode.Children().ToList();

                    // Serializa resultados JSON a un objeto .NET
                    IList<cArchivoRC> searchResults = new List<cArchivoRC>();

                    string folio = results[0].First.ToString().Trim();
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

                        filename = folio + "_"+ doc_id + ".pdf",
                        folder = "urnas",
                        file = conv.convertFileToBase64(file)
                    };
                    
                    string jsonFile = JsonConvert.SerializeObject(file64);

                    bndEnvioCorrecto = rest.PostItemFile64(jsonFile, url);

                    //bndEnvioCorrecto = ""; // TEMPORAL PARA EMULAR QUE YA ENVIO ALGO EL SERVICO IMAGENES

                    if (bndEnvioCorrecto != "error")
                    {
                        string pathFolderEnviados = currentDirectory.Replace(@"\bin\Debug",@"\enviados\");

                        //eliminar el archivo de enviados si ya existe.
                        if (System.IO.File.Exists(pathFolderEnviados + folio + "_" + doc_id + ".pdf"))
                        { 
                            System.IO.File.Delete(pathFolderEnviados + folio + "_" + doc_id + ".pdf"); 
                        }

                        //mover el archivo de carpeta para que ya no lo envie de nuevo
                        File.Move(file, pathFolderEnviados + folio + "_" + doc_id + ".pdf");
                    }
                    //}
                }
            }
            return bndEnvioCorrecto;
        }

        public string EnviarArchivosRC_2(string[] arrArchivos)
        {
            convert conv = new convert();
            string bndEnvioCorrecto = "";

            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'serivicioPruebasRC'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            string serivicioPruebasRC = odtConf.Rows.Count > 0 ? odtConf.Rows[0]["valor"].ToString().Trim() : "";

            query = "select valor from ConfClaveValor where clave = 'servicioPruebasLogin'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            string serivicioPruebasLogin = odtConf2.Rows.Count > 0 ? odtConf2.Rows[0]["valor"].ToString().Trim() : "";

            //mandar llamar endpoint de login
            var login = new clogin
            {

                email = "digitalizador@iepcjalisco.org.mx",
                password = "123456"
            };

            string jsonLogin = JsonConvert.SerializeObject(login);
            string respuesta = rest.PostItem(jsonLogin);
            
            dynamic json = JValue.Parse(respuesta);
            string token = json.token;


            foreach (string file in arrArchivos)
            {
                //Leer codigo QR del archivo PDF
                string currentDirectory = Environment.CurrentDirectory.ToString().Trim();

                string pathFolderTemp = currentDirectory.Replace(@"\bin\Debug", @"\temp\");
                string outputFolderCompressed = currentDirectory.Replace(@"\bin\Debug", @"\compressed\");

                //string fileCompressed = CompressPdf(file, outputFolderCompressed);

                string contenidoQR = ReadPdfFile(file, pathFolderTemp); // ULTIMO CAMBIO
                //contenidoQR = contenidoQR.Replace("6\"f", "{\"f");
                //contenidoQR = contenidoQR.Replace("7\"f", "{\"f");

                validaciones val = new validaciones();
                if (validaciones.IsValidJson(contenidoQR))
                {
                    /////////////////////////////////////////////////
                    JObject SearchNode = JObject.Parse(contenidoQR);

                    // Obtener la propiedades result en una lista 
                    IList<JToken> results = SearchNode.Children().ToList();

                    // Serializa resultados JSON a un objeto .NET
                    IList<cArchivoRC> searchResults = new List<cArchivoRC>();

                    string folio = results[0].First.ToString().Trim();
                    string candidato = results[1].First.ToString().Trim();
                    string doc_title = results[2].First.ToString().Trim();
                    string doc_id = results[3].First.ToString().Trim();

                    string filename = folio + "_" + doc_id + ".pdf";

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
                        filename = folio + "_" + doc_id + ".pdf",
                        folder = "urnas",
                        file = conv.convertFileToBase64(file)
                    };

                    string jsonFile = JsonConvert.SerializeObject(file64);

                    //bndEnvioCorrecto = rest.PostItemFile64(jsonFile, url);
                    //bndEnvioCorrecto = ""; // TEMPORAL PARA EMULAR QUE YA ENVIO ALGO EL SERVICO IMAGENES


                    byte[] buffer;
                    buffer = convertFileToBytes(file);
                    Task<System.IO.Stream> stream =
                    Upload(serivicioPruebasRC, folio, doc_title, doc_id, filename, buffer, token);

                    if (bndEnvioCorrecto != "error")
                    {
                        string pathFolderEnviados = currentDirectory.Replace(@"\bin\Debug", @"\enviados\");

                        //eliminar el archivo de enviados si ya existe.
                        if (System.IO.File.Exists(pathFolderEnviados + folio + "_" + doc_id + ".pdf"))
                        {
                            System.IO.File.Delete(pathFolderEnviados + folio + "_" + doc_id + ".pdf");
                        }

                        //mover el archivo de carpeta para que ya no lo envie de nuevo
                        File.Move(file, pathFolderEnviados + folio + "_" + doc_id + ".pdf");
                    }
                    //}
                }
            }
            return bndEnvioCorrecto;
        }

        public byte[] convertFileToBytes(string filepath)
        {
            byte[] buffer;
            using (Stream stream = new System.IO.FileStream(filepath, FileMode.Open))
            {
                buffer = new byte[stream.Length - 1];
                stream.Read(buffer, 0, buffer.Length);
            }

            return buffer;
        }

        private async Task<System.IO.Stream> Upload(string actionUrl, string paramFolio, string paramDocTitle, string paramDocId, string paramFilePath,  byte[] paramFileBytes, string paramToken)
        {
            //HttpContent stringContent = new StringContent(paramString);
            //HttpContent fileStreamContent = new StreamContent(paramFileStream);

            HttpContent stringContentFolio = new StringContent(paramFolio);
            HttpContent stringContentDocTitle = new StringContent(paramDocTitle);
            HttpContent stringContentDocId = new StringContent(paramDocId);
            HttpContent stringContentFilePath = new StringContent(paramFilePath);
            HttpContent bytesContent = new ByteArrayContent(paramFileBytes);
            HttpContent stringContentToken = new StringContent("Bearer " + paramToken);


            // Create the request and set parameters
            string boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(actionUrl);
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";
            request.KeepAlive = true;
            request.Credentials = System.Net.CredentialCache.DefaultCredentials;



            // ------------------------------------------------------------
            var webClient = new WebClient();
            string boundary2 = "------------------------" + DateTime.Now.Ticks.ToString("x");
            webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + boundary2);
            var fileData = webClient.Encoding.GetString(paramFileBytes);
            var package = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"file\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", boundary2, paramFilePath, "multipart/form-data", fileData);
            var nfile = webClient.Encoding.GetBytes(package);
            byte[] resp = webClient.UploadData(actionUrl, "POST", nfile);
            // ------------------------------------------------------------



            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                //formData.Add(stringContent, "param1", "param1");
                //formData.Add(fileStreamContent, "file1", "file1");

                formData.Add(stringContentFolio, "folio", "folio");
                formData.Add(stringContentDocTitle, "doc_title", "doc_title");
                formData.Add(stringContentDocId, "doc_id", "doc_id");
                formData.Add(bytesContent, "file", paramFilePath );
                formData.Headers.Add( "Authorization", paramToken);
                
                var response = await client.PostAsync(actionUrl, formData);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                return await response.Content.ReadAsStreamAsync();
            }
        }

        public static string CompressPdf(string inputFilePath,string outputFolder)
        {
            using (var stream = new MemoryStream(File.ReadAllBytes(inputFilePath)) { Position = 0 })
            using (var source = PdfSharp.Pdf.IO.PdfReader.Open(stream, PdfDocumentOpenMode.Import))
            using (var document = new PdfSharp.Pdf.PdfDocument())
            {
                var options = document.Options;
                options.FlateEncodeMode = PdfFlateEncodeMode.BestCompression;
                options.UseFlateDecoderForJpegImages = PdfUseFlateDecoderForJpegImages.Automatic;
                options.CompressContentStreams = true;
                options.NoCompression = false;
                
                foreach (var page in source.Pages)
                {
                    document.AddPage(page);
                }

                document.Save(outputFolder + @"\" + System.IO.Path.GetFileName(inputFilePath));
            }
            return outputFolder + @"\" + System.IO.Path.GetFileName(inputFilePath);
        }

        public string ReadPdfFile(string fileName, string outputFolder)
        {
            string cadenaObtenida = "";
            StringBuilder text = new StringBuilder();
            if (File.Exists(fileName))
            {
                string[] cadenaQR;

                iTextSharp.text.pdf.PdfReader pdfReader = new iTextSharp.text.pdf.PdfReader(fileName);
                //for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                for (int page = 1; page <= 1; page++)
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

        public void LlenarGridEnvioArchivos()
        {
            odtFilesEnviados.Rows.Clear();
            string currentDirectory = Environment.CurrentDirectory.ToString().Trim();
            string pathFolderEnviados = currentDirectory.Replace(@"\bin\Debug", @"\enviados\");

            string[] files = Directory.GetFiles(pathFolderEnviados, "*.pdf");

            foreach (string file in files)
            {
                odtFilesEnviados.Rows.Add(file.Replace(pathFolderEnviados, @"\enviados\"));
            }

            //gridMonitoreoArchivos.AutoGenerateColumns = false;
            gridEnvioArchivos.DataSource = odtFilesEnviados;
            gridEnvioArchivos.Refresh();

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

        private void gridEnvioArchivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridEnvioArchivos.SelectedCells.Count > 0)
            {
                string currentDirectory = Environment.CurrentDirectory.ToString().Trim();
                string pathFolderApp = currentDirectory.Replace(@"\bin\Debug","");

                int i = gridEnvioArchivos.SelectedCells[0].RowIndex;
                string dirArchivo = pathFolderApp + gridEnvioArchivos.Rows[i].Cells[0].Value.ToString().Trim();

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

        //public void CompressPdf_2(string inputFilePath, string outputFolder)
        //{

        //    //iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 50, 50, 25, 25);
        //    //PdfWriter writer = PdfWriter.GetInstance(doc, myStream);

        //    //writer.SetFullCompression();

        //    //doc.Open();

        //    //Image frontCover = iTextSharp.text.Image.GetInstance(@"C:\MyImage.png");

        //    ////Scale down from a 96 dpi image to standard itextsharp 72 dpi
        //    //frontCover.ScalePercent(75f);

        //    //frontCover.SetAbsolutePosition(0, 0);

        //    //doc.Add(frontCover);

        //    //doc.Close();

        //    /*-------------------------------------------------------------------------*/

        //    //using (var stream = new MemoryStream(File.ReadAllBytes(inputFilePath)) { Position = 0 })
        //    //using (var document = new iTextSharp.text.pdf.PdfDocument())
        //    //{
        //    //    PdfWriter writer = PdfWriter.GetInstance(document, stream);
        //    //    PdfContentByte contentPlacer;
        //    //    writer.SetFullCompression(); //
        //    //    writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_5);
        //    //    writer.CompressionLevel = PdfStream.BEST_COMPRESSION;


        //    //}

        //    /*-------------------------------------------------------------------------*/
        //}


    }
}
