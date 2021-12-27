using BarcodeLib.BarcodeReader;
using Digitalizador.Persistence;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace Digitalizador
{
    public partial class frmActas : Form
    {
        DataTable odtFilesMonitoreados = new DataTable();
        DataTable odtFilesEnviados = new DataTable();

        int zoom = 0;

        public frmActas()
        {
            InitializeComponent();
        }



        private void frmActas_Load(object sender, EventArgs e)
        {
            odtFilesMonitoreados.Columns.Add("file");
            odtFilesEnviados.Columns.Add("file");

            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'timerMonitoreoActas'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerMonitoreoActas_valor = odtConf.Rows.Count > 0 ? Extensions.ToBoolean(odtConf.Rows[0]["valor"].ToString().Trim()) : false;

            query = "select valor from ConfClaveValor where clave = 'timerEnvioActas'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerEnvioActas_valor = odtConf2.Rows.Count > 0 ? Extensions.ToBoolean(odtConf2.Rows[0]["valor"].ToString().Trim()) : false;

            timerMonitoreoActas.Enabled = timerMonitoreoActas_valor;
            timerEnvioActas.Enabled = timerEnvioActas_valor;
        }

        private void picActa_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            picActa.Width = picActa.Image.Width;
            picActa.Height = picActa.Image.Height;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            zoom++;
            picActa.Width += zoom;
            picActa.Height += zoom;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            zoom--;
            picActa.Width -= zoom;
            picActa.Height -= zoom;
        }

        private void btnEnviarManualmente_Click(object sender, EventArgs e)
        {
            //enviar un arreglo de string con los paths completos a este metodo EnviarArchivosRC
            string[] arrArchivos = ObtenerArchivosActasSeleccionados();
            EnviarArchivosActas(arrArchivos);
        }

        private void timerMonitoreoActas_Tick(object sender, EventArgs e)
        {
            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'timerMonitoreoActas'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerMonitoreoActas_valor = odtConf.Rows.Count > 0 ? Extensions.ToBoolean(odtConf.Rows[0]["valor"].ToString().Trim()) : false;


            if (timerMonitoreoActas_valor)
            {
                if (chkMonitoreoActas.Checked)
                {
                    LlenarGridMonitoreoArchivos();
                    LlenarGridEnvioArchivos();
                }
            }
        }

        private void timerEnvioActas_Tick(object sender, EventArgs e)
        {
            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'timerEnvioActas'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerEnvioActas_valor = odtConf2.Rows.Count > 0 ? Extensions.ToBoolean(odtConf2.Rows[0]["valor"].ToString().Trim()) : false;

            if (timerEnvioActas_valor)
            {
                if (chkEnvioActas.Checked)
                {
                    try
                    {
                        string[] arrArchivos = ObtenerArchivosActasTodos();
                        EnviarArchivosActas(arrArchivos);
                    }
                    catch (Exception ex)
                    {
                        string[] arrArchivos = ObtenerArchivosActasTodos();
                        EnviarArchivosActas(arrArchivos);
                    }
                }
            }
        }

        private void timerChecaTimers_Tick(object sender, EventArgs e)
        {
            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'timerMonitoreoActas'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerMonitoreoActas_valor = odtConf.Rows.Count > 0 ? Extensions.ToBoolean(odtConf.Rows[0]["valor"].ToString().Trim()) : false;

            query = "select valor from ConfClaveValor where clave = 'timerEnvioActas'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerEnvioActas_valor = odtConf2.Rows.Count > 0 ? Extensions.ToBoolean(odtConf2.Rows[0]["valor"].ToString().Trim()) : false;

            timerMonitoreoActas.Enabled = timerMonitoreoActas_valor;
            timerEnvioActas.Enabled = timerEnvioActas_valor;
        }

        private void gridMonitoreoArchivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridMonitoreoArchivos.SelectedCells.Count > 0)
                {
                    int i = gridMonitoreoArchivos.SelectedCells[0].RowIndex;
                    string dirArchivo = gridMonitoreoArchivos.Rows[i].Cells[0].Value.ToString().Trim();

                    picActa.Visible = true;
                    picActa.ImageLocation = dirArchivo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Trim(), "Exception grid monitoreo");
            }
        }

        private void gridEnvioArchivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridEnvioArchivos.SelectedCells.Count > 0)
                {
                    string currentDirectory = Environment.CurrentDirectory.ToString().Trim();
                    string pathFolderApp = currentDirectory.Replace(@"\bin\Debug", "");

                    int i = gridEnvioArchivos.SelectedCells[0].RowIndex;
                    string dirArchivo = pathFolderApp + gridEnvioArchivos.Rows[i].Cells[0].Value.ToString().Trim();

                    picActa.Visible = true;
                    picActa.ImageLocation = dirArchivo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Trim(), "Exception grid envio");
            }
        }


        /*//////////////////////////////////////////////////////////////////////////////*/

        public string[] ObtenerArchivosActasTodos()
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

        public string[] ObtenerArchivosActasSeleccionados()
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

        public string EnviarArchivosActas(string[] arrArchivos)
        {
            convert conv = new convert();
            string bndEnvioCorrecto = "";

            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'serivicioPruebasActas'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            string serivicioPruebasActas = odtConf.Rows.Count > 0 ? odtConf.Rows[0]["valor"].ToString().Trim() : "";

            string url = serivicioPruebasActas;

            foreach (string file in arrArchivos)
            {
                //Leer codigo barras del archivo jpg o png
                string currentDirectory = Environment.CurrentDirectory.ToString().Trim();

                string pathFolderTemp = currentDirectory.Replace(@"\bin\Debug", @"\temp\");
                string outputFolderCompressed = currentDirectory.Replace(@"\bin\Debug", @"\compressed\");

                string contenidoCodigoBarras = ReadImageFile(file, pathFolderTemp);

                // enviar un archivo en base 64
                var file64 = new cfileBase64
                {
                    filename = "acta_" + contenidoCodigoBarras + ".jpg",
                    folder = "urnas",
                    file = conv.convertFileToBase64(file)
                };

                string jsonFile = JsonConvert.SerializeObject(file64);

                //bndEnvioCorrecto = rest.PostItemFile64(jsonFile, url);

                bndEnvioCorrecto = ""; // TEMPORAL PARA EMULAR QUE YA ENVIO ALGO EL SERVICO IMAGENES

                if (bndEnvioCorrecto != "error")
                {
                    string pathFolderEnviados = currentDirectory.Replace(@"\bin\Debug", @"\enviados\");

                    //eliminar el archivo de enviados si ya existe.
                    if (System.IO.File.Exists(pathFolderEnviados + "acta_" + contenidoCodigoBarras + ".jpg"))
                    {
                        System.IO.File.Delete(pathFolderEnviados + "acta_" + contenidoCodigoBarras + ".jpg");
                    }

                    //mover el archivo de carpeta para que ya no lo envie de nuevo
                    File.Move(file, pathFolderEnviados + "acta_" + contenidoCodigoBarras + ".jpg");
                }


            }
            return bndEnvioCorrecto;
        }

        public string ReadImageFile(string fileName, string outputFolder)
        {
            string cadenaObtenida = "";
            StringBuilder text = new StringBuilder();
            if (File.Exists(fileName))
            {
                //Escanear codigos qr en la hoja actual
                string[] arr;
                arr = ReadBarCode(fileName);
                cadenaObtenida = "";
                for (int x = 0; x < arr.Length; x++)
                {
                    cadenaObtenida = cadenaObtenida + arr[x].ToString().Trim();
                }
            }
            return cadenaObtenida;
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

        public void LlenarGridMonitoreoArchivos()
        {
            odtFilesMonitoreados.Rows.Clear();

            List<string> FileList = new List<string>();
            DirectoryInfo folderMonitored = new DirectoryInfo(@"C:\\files_actas");

            IEnumerable<FileInfo> fileList = folderMonitored.GetFiles("*.*");

            //Create the query
            IEnumerable<FileInfo> fileQuery = from file in fileList
                                              where (file.Extension.ToLower() == ".jpg" || file.Extension.ToLower() == ".png")
                                              orderby file.LastWriteTime
                                              select file;

            foreach (System.IO.FileInfo fi in fileQuery)
            {
                fi.Attributes = FileAttributes.Normal;
                FileList.Add(fi.FullName);
            }

            string[] files = FileList.ToArray();

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

            string[] files = Directory.GetFiles(pathFolderEnviados, "*.jpg");

            foreach (string file in files)
            {
                odtFilesEnviados.Rows.Add(file.Replace(pathFolderEnviados, @"\enviados\"));
            }

            //gridMonitoreoArchivos.AutoGenerateColumns = false;
            gridEnvioArchivos.DataSource = odtFilesEnviados;
            gridEnvioArchivos.Refresh();

        }

    }
}
