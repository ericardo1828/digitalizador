using System;
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
            txtUsuario.GotFocus += new EventHandler(this.TextGotFocus);
            txtUsuario.LostFocus += new EventHandler(this.TextLostFocus);
            txtContrasena.GotFocus += new EventHandler(this.TextGotFocusContrasena);
            txtContrasena.LostFocus += new EventHandler(this.TextLostFocusContrasena);

            lblTitulo.Text = GetSetting("nombreAplicacion") != "" ? GetSetting("nombreAplicacion").ToString().Trim() : lblTitulo.Text;
            string ruta = System.Environment.CurrentDirectory.ToString().Trim();
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            //path = path.Replace(@"\bin\Debug", @"\images\logos.png");
            string imageLogo = path;
            pictureBox1.ImageLocation = GetSetting("rutaLogo").ToString().Trim() != "" ? GetSetting("rutaLogo").ToString().Trim() : imageLogo;

            switch (GetSetting("tema").ToString().Trim())
            {
                case "SIGE":
                    panel1.BackColor = ColorTranslator.FromHtml("#8031A7");
                    break;
                case "BLUE":
                    panel1.BackColor = ColorTranslator.FromHtml("#0096D6");
                    break;
                case "DARK":
                    panel1.BackColor = ColorTranslator.FromHtml("#5A5A5A");
                    break;

            }
        }
        private void cmbEntornos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string entornoSeleccionado = cmbEntornos.SelectedItem.ToString().Trim();

            // actualizar valor del key entorno
            SetSetting("entorno", entornoSeleccionado);
        }
        private void bntIngresar_Click(object sender, EventArgs e)
        {
            if (cmbEntornos.SelectedItem != null && cmbEntornos.SelectedItem.ToString().Trim() != "")
            {
                string entornoSeleccionado = cmbEntornos.SelectedItem.ToString().Trim();

                //// actualizar valor del key entorno
                //SetSetting("entorno", entornoSeleccionado);

                // validar acceso al sistema
                validarAcceso();
            }
            else
            {
                MessageBox.Show("Selecciona un entorno valido", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

        #region metodos de acciones propias o conexion hacia base de datos
        public void validarAcceso()
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM dbo.users WHERE [email] = '" + txtUsuario.Text.ToString().Trim() + "'";

            if (GetSetting("entorno").ToString().Trim() == "")
            {
                SetSetting("entorno", "pruebas");
            }

            DataTable odt = con.RetSqlDataTable(GetSetting("entorno").ToString().Trim(), sql);
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
    }
}
