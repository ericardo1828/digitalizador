using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.Management;
using System.Configuration;
using System.IO;
using Digitalizador.Persistence;

namespace Digitalizador
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        #region EVENTOS DEL CONTROLES
        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            LlenarScannerDisponibles();
            LlenarComboTiposDocumentos();
            LlenarGridRutasGuardadas();
            LlenarDatosApariencia();
            LlenarDatosTimers();
            LlenarDatosServicios();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query = "";

            string scannerSeleccionado = lstEscaner.SelectedItem.ToString().Trim();

            //// actualizar valor del key entorno
            //SetSetting("scannerDefault", scannerSeleccionado);

            DBContext dbsqlite = new DBContext();
            query = "update ConfClaveValor set valor = '" + scannerSeleccionado + "' where clave = 'scannerDefault'";
            dbsqlite.dbContext_RetSqlDataTable(query);

            string objAppConfigValue_scannerDefault = "";
            //objAppConfigValue_scannerDefault = GetSetting("scannerDefault");

            query = "select valor from ConfClaveValor where clave = 'scannerDefault')";
            //DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query) == null ? dbsqlite.dbContext_RetSqlDataTable(query) : new DataTable();
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            objAppConfigValue_scannerDefault = odtConf.Rows.Count > 0 ? odtConf.Rows[0]["valor"].ToString().Trim() : "";
        }
        private void btnAgregarDir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();

                //obtener datos desde SQLite
                DBContext dbsqlite = new DBContext();
                string query = "select valor from ConfClaveValor where clave = 'entorno'";
                //DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query) == null || dbsqlite.dbContext_RetSqlDataTable(query).Rows.Count  == 0 ? dbsqlite.dbContext_RetSqlDataTable(query) : new DataTable();
                DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
                string entorno = odtConf.Rows.Count > 0 ? odtConf.Rows[0]["valor"].ToString().Trim() : "";


                if (cmbTipoDocumento.SelectedValue != null)
                {
                    //insetar la ruta
                    string tipoDoc = cmbTipoDocumento.SelectedValue.ToString().Trim();
                    string ruta = txtRuta.Text.ToString().Trim();
                    query = "insert into RutasArchDig (fkDocumento,rutaDir,created_at,updated_at,deleted_at) values ('" + tipoDoc + "','" + ruta + "',null,null,null ) ";
                    dbsqlite.dbContext_RetSqlDataTable(query);

                    //con.RetSqlDataTable(entorno, query);

                }
                //else if(cmbTipoDocumento.Text.ToString().Trim() != "" && cmbTipoDocumento.SelectedValue == null)
                //{
                //    //insetar la ruta
                //    string tipoDoc = cmbTipoDocumento.Text.ToString().Trim();
                //    string ruta = txtRuta.Text.ToString().Trim();
                //    query = "insert into RutasArchDig (fkDocumento,rutaDir,created_at,updated_at,deleted_at) values ('" + tipoDoc + "','" + ruta + "',null,null,null ) ";
                //    dbsqlite.dbContext_RetSqlDataTable(query);

                //    //con.RetSqlDataTable(entorno, query);
                //}

                gridRutasDir.DataSource = ObtenerRutasDir();
                gridRutasDir.Refresh();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region METODOS PROPIOS
        public List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("DeviceID"),
                (string)device.GetPropertyValue("PNPDeviceID"),
                (string)device.GetPropertyValue("Description")
                ));
            }

            collection.Dispose();
            return devices;
        }

        public DataTable ObtenerTiposDocumentos()
        {
            try
            {
                string query = "";
                string entorno = "";

                //obtener datos desde SQLite
                DBContext dbsqlite = new DBContext();
                query = "select valor from ConfClaveValor where clave = 'entorno'";
                //DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query) == null || dbsqlite.dbContext_RetSqlDataTable(query).Rows.Count  == 0 ? dbsqlite.dbContext_RetSqlDataTable(query) : new DataTable();
                DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
                entorno = odtConf.Rows.Count > 0 ? odtConf.Rows[0]["valor"].ToString().Trim() : "";

                //Obtener los tipos de documentos
                Conexion con = new Conexion();
                query = "select * from Common.CS_Documentos";
                DataTable odt = con.RetSqlDataTable(entorno, query);

                return odt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }
        public DataTable ObtenerRutasDir()
        {
            try
            {
                string query = "";

                //obtener datos desde SQLite
                DBContext dbsqlite = new DBContext();
                string entorno = "";
                query = "select valor from ConfClaveValor where clave = 'entorno'";
                //DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query) == null ? dbsqlite.dbContext_RetSqlDataTable(query) : new DataTable();
                DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
                entorno = odtConf.Rows.Count > 0 ? odtConf.Rows[0]["valor"].ToString().Trim() : "";

                //Obtener los tipos de documentos
                Conexion con = new Conexion();
                query = "select distinct cd.pkDocumento, cd.documento, rad.rutaDir from RutasArchDig rad left join Documentos cd on rad.fkDocumento = cd.pkDocumento";
                //DataTable odt = dbsqlite.dbContext_RetSqlDataTable(query) == null ? dbsqlite.dbContext_RetSqlDataTable(query) : new DataTable();
                DataTable odt = dbsqlite.dbContext_RetSqlDataTable(query);

                return odt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return new DataTable(); 
            }

        }


        public void LlenarComboTiposDocumentos()
        {
            cmbTipoDocumento.DataSource = ObtenerTiposDocumentos();
            cmbTipoDocumento.DisplayMember = "documento";
            cmbTipoDocumento.ValueMember = "pkDocumento";
            cmbTipoDocumento.Refresh();
        }

        public void LlenarScannerDisponibles()
        {
            lstEscaner.Items.Clear();
            try
            {
                var deviceManager = new DeviceManager();
                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        continue;
                    }
                    lstEscaner.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void LlenarGridRutasGuardadas()
        {
            gridRutasDir.DataSource = ObtenerRutasDir();
            gridRutasDir.Refresh();
        }

        public void LlenarDatosApariencia()
        {
            //txtNombreAplicacion.Text = GetSetting("nombreAplicacion").ToString().Trim();
            //cmbTemas.SelectedItem = GetSetting("tema").ToString().Trim();
            //txtRutaLogo.Text = GetSetting("rutaLogo").ToString().Trim();

            
            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'nombreAplicacion'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            string nombreAplicacion = odtConf.Rows.Count > 0 ? odtConf.Rows[0]["valor"].ToString().Trim() : "";

            query = "select valor from ConfClaveValor where clave = 'rutaLogo'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            string rutaLogo = odtConf2.Rows.Count > 0 ? odtConf2.Rows[0]["valor"].ToString().Trim() : "";

            query = "select valor from ConfClaveValor where clave = 'tema'";
            DataTable odtConf3 = dbsqlite.dbContext_RetSqlDataTable(query);
            string tema = odtConf3.Rows.Count > 0 ? odtConf3.Rows[0]["valor"].ToString().Trim() : "";

            txtNombreAplicacion.Text = nombreAplicacion;
            cmbTemas.SelectedItem = tema;
            txtRutaLogo.Text = rutaLogo;

        }

        public void LlenarDatosTimers()
        {
            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'timerMonitoreoRC'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerMonitoreoRC_valor = odtConf.Rows.Count > 0 ? Extensions.ToBoolean( odtConf.Rows[0]["valor"].ToString().Trim()) : false;

            query = "select valor from ConfClaveValor where clave = 'timerEnvioRC'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerEnvioRC_valor = odtConf2.Rows.Count > 0 ? Extensions.ToBoolean(odtConf2.Rows[0]["valor"].ToString().Trim()) : false;

            query = "select valor from ConfClaveValor where clave = 'timerMonitoreoActas'";
            DataTable odtConf3 = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerMonitoreoActas_valor = odtConf3.Rows.Count > 0 ? Extensions.ToBoolean(odtConf3.Rows[0]["valor"].ToString().Trim()) : false;

            query = "select valor from ConfClaveValor where clave = 'timerEnvioActas'";
            DataTable odtConf4 = dbsqlite.dbContext_RetSqlDataTable(query);
            bool timerEnvioActas_valor = odtConf4.Rows.Count > 0 ? Extensions.ToBoolean(odtConf4.Rows[0]["valor"].ToString().Trim()) : false;

            chkMonitoreoRC.Checked = timerMonitoreoRC_valor;
            chkEnvioRC.Checked = timerEnvioRC_valor;
            chkMonitoreoActas.Checked = timerMonitoreoActas_valor;
            chkEnvioActasPrep.Checked = timerEnvioActas_valor;

        }

        public void LlenarDatosServicios()
        {
            //obtener datos desde SQLite
            DBContext dbsqlite = new DBContext();
            string query = "";

            query = "select valor from ConfClaveValor where clave = 'serivicioPruebasRC'";
            DataTable odtConf = dbsqlite.dbContext_RetSqlDataTable(query);
            string serivicioPruebasRC_valor = odtConf.Rows.Count > 0 ? odtConf.Rows[0]["valor"].ToString().Trim() : "";

            query = "select valor from ConfClaveValor where clave = 'servicioProdRC'";
            DataTable odtConf2 = dbsqlite.dbContext_RetSqlDataTable(query);
            string servicioProdRC_valor = odtConf2.Rows.Count > 0 ? odtConf2.Rows[0]["valor"].ToString().Trim() : "";

            query = "select valor from ConfClaveValor where clave = 'servicioPruebasActasPrep'";
            DataTable odtConf3 = dbsqlite.dbContext_RetSqlDataTable(query);
            string servicioPruebasActasPrep_valor = odtConf3.Rows.Count > 0 ? odtConf3.Rows[0]["valor"].ToString().Trim() : "";

            query = "select valor from ConfClaveValor where clave = 'servicioProdActasPrep'";
            DataTable odtConf4 = dbsqlite.dbContext_RetSqlDataTable(query);
            string servicioProdActasPrep_valor = odtConf4.Rows.Count > 0 ? odtConf4.Rows[0]["valor"].ToString().Trim() : "";

            txtServicioPruebasRC.Text = serivicioPruebasRC_valor;
            txtServicioProdRC.Text = servicioProdRC_valor;
            txtServicioPruebasActasPrep.Text = servicioPruebasActasPrep_valor;
            txtServicioProdActasPrep.Text = servicioProdActasPrep_valor;

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



        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRuta.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
        //private void btnSubirImagen_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        //    string dirApp = Directory.GetCurrentDirectory();

        //    string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);


        //    saveFileDialog1.InitialDirectory = @"C:\";
        //    saveFileDialog1.Title = "Save png Files";
        //    saveFileDialog1.CheckFileExists = true;
        //    saveFileDialog1.CheckPathExists = true;
        //    saveFileDialog1.DefaultExt = "png";
        //    saveFileDialog1.Filter = "Image files (*.png)|*.png|All files (*.*)|*.*";
        //    saveFileDialog1.FilterIndex = 2;
        //    saveFileDialog1.RestoreDirectory = true;
        //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        txtSubirImagen.Text = saveFileDialog1.FileName;
        //    }
        //}
        private void btnLogo_Click(object sender, EventArgs e)
        {
            string dirApp = Directory.GetCurrentDirectory();

            var fileContent = string.Empty;
            var filePath = string.Empty;
            string dest = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    string source = filePath;
                    dest = dirApp.Replace(@"\bin\Debug",@"\images\logos\") + Path.GetFileName(source);
                    if (!File.Exists(dest))
                    {
                        File.Copy(source, dest);
                    }
                    
                }
            }
            txtRutaLogo.Text = dest;
            SetSetting("rutaLogo", dest);


            //var fileContent = string.Empty;
            //var filePath = string.Empty;

            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.InitialDirectory = "c:\\";
            //    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //    openFileDialog.FilterIndex = 2;
            //    openFileDialog.RestoreDirectory = true;

            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        //Get the path of specified file
            //        filePath = openFileDialog.FileName;

            //        //Read the contents of the file into a stream
            //        var fileStream = openFileDialog.OpenFile();

            //        using (StreamReader reader = new StreamReader(fileStream))
            //        {
            //            fileContent = reader.ReadToEnd();
            //        }
            //    }
            //}
            //txtRutaLogo.Text = filePath;
        }

        private void btnGuardarApariencia_Click(object sender, EventArgs e)
        {
            //SetSetting("nombreAplicacion", txtNombreAplicacion.Text.ToString().Trim());
            //SetSetting("rutaLogo", txtRutaLogo.Text.ToString().Trim());
            //SetSetting("tema", cmbTemas.SelectedItem.ToString().Trim());

            string tema = cmbTemas.Text == "" ? "" : cmbTemas.SelectedItem.ToString().Trim();

            DBContext dbsqlite = new DBContext();
            string query = "";
            query = "update ConfClaveValor set valor = '" + txtNombreAplicacion.Text.ToString().Trim() + "' where clave = 'nombreAplicacion'";
            dbsqlite.dbContext_RetSqlDataTable(query);
            query = "update ConfClaveValor set valor = '" + txtRutaLogo.Text.ToString().Trim() + "' where clave = 'rutaLogo'";
            dbsqlite.dbContext_RetSqlDataTable(query);
            query = "update ConfClaveValor set valor = '" + tema + "' where clave = 'tema'";
            dbsqlite.dbContext_RetSqlDataTable(query);

        }

       

        private void picRefresh_Click(object sender, EventArgs e)
        {
            LlenarScannerDisponibles();
            LlenarComboTiposDocumentos();
            LlenarGridRutasGuardadas();
        }

       

        private void btnPropiedadesFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;

            fontDlg.MaxSize = 40;
            fontDlg.MinSize = 8;

            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                txtMensaje.Font = fontDlg.Font;
                txtMensaje.BackColor = Color.White;
                txtMensaje.ForeColor = fontDlg.Color;
            }
        }

        private void chkAgregarFecha_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk1 = (CheckBox)sender;
            
            if(chk1.Checked)
            {
                txtMensaje.Text = txtMensaje.Text 
                                + "\n" 
                                + System.DateTime.Now.Year.ToString().Trim() + "-"
                                + System.DateTime.Now.Month.ToString().Trim() + "-"
                                + System.DateTime.Now.Day.ToString().Trim()
                                + " "
                                + System.DateTime.Now.Hour.ToString().Trim() + ":"
                                + System.DateTime.Now.Minute.ToString().Trim() + ":"
                                + System.DateTime.Now.Second.ToString().Trim();
            }
            else
            {
                txtMensaje.Text = "";
            }
                  
            
        }

        private void btnGuardarConfigXY_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarTabTimers_Click(object sender, EventArgs e)
        {
            DBContext dbsqlite = new DBContext();
            string query = "";
            query = "update ConfClaveValor set valor = '" + chkMonitoreoRC.Checked.ToString().Trim() + "' where clave = 'timerMonitoreoRC'";
            dbsqlite.dbContext_RetSqlDataTable(query);
            query = "update ConfClaveValor set valor = '" + chkEnvioRC.Checked.ToString().Trim() + "' where clave = 'timerEnvioRC'";
            dbsqlite.dbContext_RetSqlDataTable(query);

            query = "update ConfClaveValor set valor = '" + chkMonitoreoActas.Checked.ToString().Trim() + "' where clave = 'timerMonitoreoActas'";
            dbsqlite.dbContext_RetSqlDataTable(query);
            query = "update ConfClaveValor set valor = '" + chkEnvioActasPrep.Checked.ToString().Trim() + "' where clave = 'timerEnvioActas'";
            dbsqlite.dbContext_RetSqlDataTable(query);
        }

        private void btnGuardarTabServicios_Click(object sender, EventArgs e)
        {
            DBContext dbsqlite = new DBContext();
            string query = "";
            query = "update ConfClaveValor set valor = '" + txtServicioPruebasRC.Text.ToString().Trim() + "' where clave = 'serivicioPruebasRC'";
            dbsqlite.dbContext_RetSqlDataTable(query);
            query = "update ConfClaveValor set valor = '" + txtServicioProdRC.Text.ToString().Trim() + "' where clave = 'servicioProdRC'";
            dbsqlite.dbContext_RetSqlDataTable(query);

            query = "update ConfClaveValor set valor = '" + txtServicioPruebasActasPrep.Text.ToString().Trim() + "' where clave = 'servicioPruebasActasPrep'";
            dbsqlite.dbContext_RetSqlDataTable(query);
            query = "update ConfClaveValor set valor = '" + txtServicioProdActasPrep.Text.ToString().Trim() + "' where clave = 'servicioProdActasPrep'";
            dbsqlite.dbContext_RetSqlDataTable(query);

        }
    }

    public class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
        {
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
    }

    public static class Extensions
    {
        public static Boolean ToBoolean(this string str)
        {
            try
            {
                return Convert.ToBoolean(str);
            }
            catch { }
            try
            {
                return Convert.ToBoolean(Convert.ToInt32(str));
            }
            catch { }
            return false;
        }
    }

}
