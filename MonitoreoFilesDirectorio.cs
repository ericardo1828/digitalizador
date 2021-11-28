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
    public partial class MonitoreoFilesDirectorio : Form
    {
        public MonitoreoFilesDirectorio()
        {
            InitializeComponent();
        }

        //public ListViewItem ObtenerFilesDirectorio()
        //{
        //    ListViewItem lista = new ListViewItem();

        //    string[] files = Directory.GetFiles(@"C:\files\", "*.txt");

        //    foreach (var file in files)
        //    {
        //        listView1.Items.Add(Environment.NewLine);
        //        listView1.Items.Add(file);
        //    }

        //    return lista;
        //}

        //public void limpiarListView()
        //{
        //    listView1.Clear();
        //    listView1.Refresh();
        //}

        public void LlenarTextBox()
        {
            textBox1.Clear();
            textBox1.Refresh();

            string[] files = Directory.GetFiles(@"C:\files\", "*.txt");

            foreach (var file in files)
            {
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(file);
            }
            //textBox1.Refresh();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //limpiarListView();

            //listView1.Items.Add(ObtenerFilesDirectorio());
            //listView1.Refresh();

            LlenarTextBox();
        }
    }
}
