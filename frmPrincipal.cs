using Digitalizador.Persistence;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Digitalizador
{
    public partial class frmPrincipal : Form
    {

        string objAppConfigValue_entorno = "";
        //Constructor
        public frmPrincipal()
        {
            InitializeComponent();

            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            objAppConfigValue_entorno = GetSetting("entorno");

            
        }

        //public void DimensionInicial()
        //{
        //    double height = SystemParameters.FullPrimaryScreenHeight;
        //    double width = SystemParameters.FullPrimaryScreenWidth;
        //    double resolution = height * width;     
        //}

        public void cargarMenu()
        {
            DataTable odt = new DataTable();
            rest res = new rest();
            convert conv = new convert();

            /////////////////////////////////////////////////////
            string e, p = "";
            e = LoginInfo.Email.ToString().Trim() == "" ? "" : LoginInfo.Email.ToString().Trim();
            p = LoginInfo.Pass.ToString().Trim() == "" ? "" : LoginInfo.Pass.ToString().Trim();

            var lo = new clogin
            {
                email = e,
                password = p
            };

            string json = JsonConvert.SerializeObject(lo);
            string stringToken = rest.PostItem(json);




        }

        #region eventos de controles de formulario
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnMaximizar.Hide();

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

            query = "select valor from ConfClaveValor where clave = 'entorno'";
            DataTable odtConf4 = dbsqlite.dbContext_RetSqlDataTable(query);
            string entorno = odtConf4.Rows.Count > 0 ? odtConf4.Rows[0]["valor"].ToString().Trim() : "";

            //-----------------------------------------------------------------

            lblVersion.Text = "digi 1.1";
            lblEntorno.Text = entorno;  //objAppConfigValue_entorno;
            lblTitulo.Text = nombreAplicacion; 
            //GetSetting("nombreAplicacion") != "" ? GetSetting("nombreAplicacion").ToString().Trim() : lblTitulo.Text;

            //string ruta = System.Environment.CurrentDirectory.ToString().Trim();
            //string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            //path = path.Replace(@"\bin\Debug", @"\images\refresh_icon.png");
            //string imageLogo = path;

            string ruta = System.Environment.CurrentDirectory.ToString().Trim();
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Replace(@"\bin\Debug", @"\images\refresh_icon.png");
            string imageLogo = path;
            picLogo.ImageLocation = rutaLogo != "" ? rutaLogo : imageLogo; //GetSetting("rutaLogo").ToString().Trim() != "" ? GetSetting("rutaLogo").ToString().Trim() : imageLogo;

            string a = path;

            //picLogo.ImageLocation = GetSetting("rutaLogo").ToString().Trim() != "" ? GetSetting("rutaLogo").ToString().Trim() : imageLogo;

            //switch (GetSetting("tema").ToString().Trim())
            switch(tema)
            {
                case "SIGE":
                    panelTitulo.BackColor = ColorTranslator.FromHtml("#8031A7");
                    panelFooter.BackColor = ColorTranslator.FromHtml("#8031A7");
                    break;
                case "BLUE":
                    panelTitulo.BackColor = ColorTranslator.FromHtml("#0096D6");
                    panelFooter.BackColor = ColorTranslator.FromHtml("#0096D6");
                    break;
                case "DARK":
                    panelTitulo.BackColor = ColorTranslator.FromHtml("#5A5A5A");
                    panelFooter.BackColor = ColorTranslator.FromHtml("#5A5A5A");
                    break;

            }

            //cargarMenu();


        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {


            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new System.Drawing.Size(sw, sh);
            this.Location = new System.Drawing.Point(lx, ly);
        }
        private void btnPanelDeControl_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmConfiguracion>();
        }
        private void btnRC_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmRegistroCandidatos>();
        }
        private void btnActas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmActas>();
        }
        // bool vai = false;
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //vai = true;
        }
        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            //if (vai == true)
            //{
            //    this.Location = Cursor.Position;
            //}

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            //vai = false;
        }
        #endregion

        #region metodos propios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        #endregion

        #region metodos para controlar el comportamiento del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new System.Drawing.Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        #endregion

        #region metodos del app config
        private static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        #endregion


    }
}
