using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Digitalizador
{
    public partial class Hilos : Form
    {
        public Hilos()
        {
            InitializeComponent();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            etHora.Text = DateTime.Now.ToLongTimeString();
        }


        private Thread hiloSecundario;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            numCargaCPU.Enabled = false;

            progressBar1.Value = 0;



            //crear delegado que hace referencia al metodo que tiene que ejecutar el hilo.
            ThreadStart delegadoPS = new ThreadStart(tareaSecundaria);
            //crear hilo
            hiloSecundario = new Thread(delegadoPS);
            //ejecutar Hilo
            hiloSecundario.Start();

        }

        private delegate void SetValueDelegate(int paramValue);
        private void SetValue_progressBar1(int hecho)
        {
            if (progressBar1.InvokeRequired)
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_progressBar1);
                progressBar1.Invoke(delegado, new object[] { hecho });
            }
            else
            {
                progressBar1.Value = hecho;
            }
            
        }

        //private delegate void SetEnabledDelegate(bool paramValue);
        //private void SetEnabled_btnCalcular(bool bnd)
        //{
        //    if (btnCalcular.InvokeRequired)
        //    {
        //        SetEnabledDelegate delegado = new SetEnabledDelegate(SetEnabled_btnCalcular);
        //        btnCalcular.Invoke(delegado, new object[] { bnd });
        //    }
        //    else
        //    {
        //        btnCalcular.Enabled = bnd;
        //    }
        //}
        //private void SetEnabled_numCargaCPU(bool bnd)
        //{
        //    if (numCargaCPU.InvokeRequired)
        //    {
        //        SetEnabledDelegate delegado = new SetEnabledDelegate(SetEnabled_numCargaCPU);
        //        numCargaCPU.Invoke(delegado, new object[] { bnd });
        //    }
        //    else
        //    {
        //        numCargaCPU.Enabled = bnd;
        //    }
        //}

        private void SetEnabled_btnCalcular()
        {
            btnCalcular.Enabled = true;
        }
        private void SetEnabled_numCargaCPU()
        {
            numCargaCPU.Enabled = true;
        }


        public void tareaSecundaria()
        {

            int hecho = 0;
            int tpHecho = 0;

            MethodInvoker delegado;

            while(hecho < numCargaCPU.Value)
            {
                hecho += 1;
                tpHecho = (int)(hecho / numCargaCPU.Value * 100);
                if (tpHecho > progressBar1.Value)
                {
                    //progressBar1.Value = tpHecho;
                    SetValue_progressBar1(tpHecho);
                }
            }


            //btnCalcular.Enabled = true;
            //SetEnabled_btnCalcular(true);

            delegado = new MethodInvoker(SetEnabled_btnCalcular);
            btnCalcular.Invoke(delegado);


            //numCargaCPU.Enabled = true;
            //SetEnabled_numCargaCPU(true);

            delegado = new MethodInvoker(SetEnabled_numCargaCPU);
            numCargaCPU.Invoke(delegado);

        }
    }
}
