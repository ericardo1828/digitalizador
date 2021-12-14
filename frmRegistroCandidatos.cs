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

            timerMonitoreoRC.Enabled = chkMonitorearAuto.Checked;
            visorPDF.Visible = false;
        }

        private void btnEnviarArchivoManual_Click(object sender, EventArgs e)
        {

        }

        private void timerMonitoreoRC_Tick(object sender, EventArgs e)
        {
            if (chkMonitorearAuto.Checked)
            {
                LlenarGridMonitoreoArchivos();
            }
            
        }

        private void timerEnvioRC_Tick(object sender, EventArgs e)
        {

        }

        public void LlenarGridMonitoreoArchivos()
        {
            odtFilesMonitoreados.Rows.Clear();
            

            string[] files = Directory.GetFiles(@"C:\files\", "*.pdf");

            
            foreach(string file in files)
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
