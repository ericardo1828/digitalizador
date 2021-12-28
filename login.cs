using Digitalizador.Persistence;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;


namespace Digitalizador
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        #region eventos de controles del formulario
        private void login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "digitalizador@iepcjalisco.org.mx";
            txtContrasena.Text = "123456";

            txtUsuario.GotFocus += new EventHandler(this.TextGotFocus);
            txtUsuario.LostFocus += new EventHandler(this.TextLostFocus);
            txtContrasena.GotFocus += new EventHandler(this.TextGotFocusContrasena);
            txtContrasena.LostFocus += new EventHandler(this.TextLostFocusContrasena);


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

            //--------------------------------------------------------------

            lblTitulo.Text = nombreAplicacion; //GetSetting("nombreAplicacion") != "" ? GetSetting("nombreAplicacion").ToString().Trim() : lblTitulo.Text;
            string ruta = System.Environment.CurrentDirectory.ToString().Trim();
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            //path = path.Replace(@"\bin\Debug", @"\images\logos.png");
            path = path.Replace(@"\bin\Debug", @"\images\refresh_icon.png");
            string imageLogo = path;
            pictureBox1.ImageLocation = rutaLogo != "" ? rutaLogo : imageLogo; //GetSetting("rutaLogo").ToString().Trim() != "" ? GetSetting("rutaLogo").ToString().Trim() : imageLogo;

            string a = path;
            //switch (GetSetting("tema").ToString().Trim())
            switch (tema)
            {
                case "SIGE":
                    panel1.BackColor = ColorTranslator.FromHtml("#8031A7");
                    linkLabel1.BackColor = ColorTranslator.FromHtml("#8031A7");
                    linkLabel3.BackColor = ColorTranslator.FromHtml("#8031A7");

                    a = a.Replace(@"\images\refresh_icon.png", @"\images\imgIngresar_sige.png");
                    bntIngresar.ImageLocation = a;
                    bntIngresar.Refresh();

                    break;
                case "BLUE":
                    panel1.BackColor = ColorTranslator.FromHtml("#0096D6");
                    linkLabel1.BackColor = ColorTranslator.FromHtml("#0096D6");
                    linkLabel3.BackColor = ColorTranslator.FromHtml("#0096D6");

                    a = a.Replace(@"\images\refresh_icon.png", @"\images\imgIngresar_blue.png");
                    bntIngresar.ImageLocation = a;
                    bntIngresar.Refresh();

                    break;
                case "DARK":
                    panel1.BackColor = ColorTranslator.FromHtml("#5A5A5A");
                    linkLabel1.BackColor = ColorTranslator.FromHtml("#5A5A5A");
                    linkLabel3.BackColor = ColorTranslator.FromHtml("#5A5A5A");

                    a = a.Replace(@"\images\refresh_icon.png", @"\images\imgIngresar_dark.png");
                    bntIngresar.ImageLocation = a;
                    bntIngresar.Refresh();

                    break;

            }
        }
        private void cmbEntornos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";

            string entornoSeleccionado = cmbEntornos.SelectedItem.ToString().Trim().ToLower();

            //// actualizar valor del key entorno
            //SetSetting("entorno", entornoSeleccionado);

            DBContext dbsqlite = new DBContext();
            query = "update ConfClaveValor set valor = '" + entornoSeleccionado + "' where clave = 'entorno'";
            dbsqlite.dbContext_RetSqlDataTable(query);


        }

        private void bntIngresar_Click(object sender, EventArgs e)
        {
            string query = "";

            DBContext dbsqlite = new DBContext();
            query = "select valor from ConfClaveValor where clave = 'entorno'";
            DataTable odtEntorno = dbsqlite.dbContext_RetSqlDataTable(query);

            if (odtEntorno != null && odtEntorno.Rows.Count > 0)
            {
                getLogin(txtUsuario.Text.ToString().Trim(),txtContrasena.Text.ToString().Trim());
            }
            //else if (cmbEntornos.SelectedItem != null && cmbEntornos.SelectedItem.ToString().Trim() != "")
            //{
            //    string entornoSeleccionado = cmbEntornos.SelectedItem.ToString().Trim();

            //    //// actualizar valor del key entorno
            //    //SetSetting("entorno", entornoSeleccionado);

            //    // validar acceso al sistema
            //    validarAcceso(2);
            //}
            else
            {
                MessageBox.Show("Selecciona un entorno valido", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void bntIngresar_Click_2(object sender, EventArgs e)
        {
            string query = "";

            DBContext dbsqlite = new DBContext();
            query = "select valor from ConfClaveValor where clave = 'entorno'";
            DataTable odtEntorno = dbsqlite.dbContext_RetSqlDataTable(query);
            
            if(odtEntorno != null && odtEntorno.Rows.Count > 0)
            {
                validarAcceso(1);

            }
            else if (cmbEntornos.SelectedItem != null && cmbEntornos.SelectedItem.ToString().Trim() != "")
            {
                string entornoSeleccionado = cmbEntornos.SelectedItem.ToString().Trim();

                //// actualizar valor del key entorno
                //SetSetting("entorno", entornoSeleccionado);

                // validar acceso al sistema
                validarAcceso(2);
            }
            else
            {
                MessageBox.Show("Selecciona un entorno valido", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

        #region metodos de acciones propias o conexion hacia base de datos
        private void getLogin(string email, string pass)
        {
            rest res = new rest();
            convert conv = new convert();

            /////////////////////////////////////////////////////
            string e, p = "";
            e = email == "" ? "" : email;
            p = pass == "" ? "" : pass;

            var lo = new clogin
            {
                email = e,
                password = p
            };

            //var lo = new clogin
            //{
            //    email = "ericardo.munoz@iepcjalisco.org.mx",
            //    password = "cantinflas20"
            //};

            string json = JsonConvert.SerializeObject(lo);
            string stringToken = rest.PostItem(json);

            bool bndUserPassCorrect = (stringToken == "error" ? false : true);

            if(stringToken.Contains("\"response\":false"))
            {
                Dictionary<string, string> dictObjResponse = ((JToken)(JObject.Parse(stringToken))).ToObject<Dictionary<string, string>>();
                if (dictObjResponse != null)
                {
                    foreach (var dic_obj in dictObjResponse)
                    {
                        if (dic_obj.Key.Contains("response"))
                        {
                            if (dic_obj.Value.ToString().Trim() == "False")
                            {
                                JObject SearchNodeResponse = JObject.Parse(stringToken);
                                string message = conv.ParseNode(SearchNodeResponse, "message");

                                bndUserPassCorrect = false;

                                MessageBox.Show(message, "Precaucion!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            

            ////////
            if (bndUserPassCorrect)
            {
                JObject SearchNode = JObject.Parse(stringToken);
                string token = conv.ParseNode(SearchNode, "token");

                string mensaje = conv.ParseNode(SearchNode, "message");
                string status = conv.ParseNode(SearchNode, "status");

                int bndAcceso = 0;

                if (status == "200")
                {
                    JEnumerable<JToken> results = SearchNode["perfiles"].Children();

                    foreach (JToken result in results)
                    {
                        // Agregar a un diccionario los nodos de json object
                        Dictionary<string, string> dictObj = result.ToObject<Dictionary<string, string>>();

                        foreach (var dic_obj in dictObj)
                        {
                            if (dic_obj.Key.Contains("fkRole"))
                            {
                                if (dic_obj.Value.ToString().Trim() == "65")
                                {
                                    bndAcceso++;

                                }
                            }
                        }
                    }
                }

                if (bndAcceso > 0)
                {
                    LoginInfo.Email = txtUsuario.Text.ToString().Trim();
                    LoginInfo.Pass = txtContrasena.Text.ToString().Trim();

                    this.Hide();
                    frmPrincipal frm = new frmPrincipal();
                    
                    //double height = System.Windows.SystemParameters.FullPrimaryScreenHeight;
                    //double width = System.Windows.SystemParameters.FullPrimaryScreenWidth;
                    //double resolution = height * width;

                    //// Size the form to be 300 pixels in height and width.
                    //frm.Size = new Size((int)width, (int)height);

                    // Display the form in the center of the screen.
                    frm.StartPosition = FormStartPosition.CenterScreen;

                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales Invalidas o sin acceso al Digitalizador");
                }

            }
        }


        public void validarAcceso(int opc)
        {
            if(opc == 1)
            {
                string query = "";

                DBContext dbsqlite = new DBContext();
                query = "select valor from ConfClaveValor where clave = 'entorno'";
                DataTable odtEntorno = dbsqlite.dbContext_RetSqlDataTable(query);

                Conexion con = new Conexion();
                string sql = "SELECT * FROM dbo.users WHERE [email] = '" + txtUsuario.Text.ToString().Trim() + "'";


                DataTable odt = new DataTable();
                if (odtEntorno != null && odtEntorno.Rows.Count > 0)
                {
                    odt = con.RetSqlDataTable(odtEntorno.Rows[0]["valor"].ToString().Trim(), sql);
                }


                //if (GetSetting("entorno").ToString().Trim() == "")
                //{
                //    SetSetting("entorno", "pruebas");
                //}

                    
                //DataTable odt = con.RetSqlDataTable("Pruebas", sql);


                if (odt != null && odt.Rows.Count > 0)
                {
                    //string entorno = ConfigurationManager.AppSettings["entorno"];

                    this.Hide();
                    frmPrincipal frm = new frmPrincipal();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales Invalidas");
                }


            }
            else
            {


            }
            
        }
        #endregion

        #region metodos para controlar el comportamiento de formulario
        public void TextGotFocus(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }
        public void TextLostFocus(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }
        public void TextGotFocusContrasena(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.White;
            }
        }
        public void TextLostFocusContrasena(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.LightGray;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        
        //bool vai = false;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //vai = true;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            //if (vai == true)
            //{
            //    this.Location = Cursor.Position;
            //}
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            //vai = false;
        }
        #endregion

        #region Metodos hacia el app config
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

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                bntIngresar_Click(null, null);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                bntIngresar_Click(null, null);
            }
        }

        private void cmbEntornos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                bntIngresar_Click(null, null);
            }
        }
    }
}
