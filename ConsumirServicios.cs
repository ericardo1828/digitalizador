using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitalizador
{
    public partial class ConsumirServicios : Form
    {
        public ConsumirServicios()
        {
            InitializeComponent();
        }

        private void btnConsumirServicio_Click(object sender, EventArgs e)
        {
            GetItems();
        }


        private void GetItems()
        {
            var url = $"https://services-dev.iepcjalisco.org.mx:8443/api/v1/casilla/tlaquepaque";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            // Do something with responseBody
                            //Console.WriteLine(responseBody);

                            //List<Casilla> CasillasList = JsonConvert.DeserializeObject<List<Casilla>>(responseBody);

                            string jsonString = @"[
                                                    {
                                                    'Calle': 'CALLE PEDRO CIPRÉS',
                                                    'NumExt': ' NÚMERO 4690',
                                                    'NumInt': '',
                                                    'Colonia': ' COLONIA MIRAVALLE',
                                                    'CP': ' CÓDIGO POSTAL 45590',
                                                    'Referencia': 'DOMICILIO PARTICULAR',
                                                    'Seccion': '2571',
                                                    'Tipo': 'Básica',
                                                    'Clasificacion': 'Domicilio Particular',
                                                    'NumeroCasilla': '2571B',
                                                    'Nomenclatura': '2571B',
                                                    'Municipio': 'SAN PEDRO TLAQUEPAQUE',
                                                    'Distrito': '13'
                                                    },
                                                    {
                                                                                'Calle': 'CALLE PEDRO CIPRÉS',
                                                    'NumExt': ' NÚMERO 4690',
                                                    'NumInt': '',
                                                    'Colonia': ' COLONIA MIRAVALLE',
                                                    'CP': ' CÓDIGO POSTAL 45590',
                                                    'Referencia': 'DOMICILIO PARTICULAR',
                                                    'Seccion': '2571',
                                                    'Tipo': 'Contigua',
                                                    'Clasificacion': 'Domicilio Particular',
                                                    'NumeroCasilla': '2571C1',
                                                    'Nomenclatura': '2571C01',
                                                    'Municipio': 'SAN PEDRO TLAQUEPAQUE',
                                                    'Distrito': '13'
                                                    }
                                                ]";

                            var CasillasList = JsonConvert.DeserializeObject<List<Casilla>>(jsonString);

                            DataTable odt = CasillasList.ToDataTable<Casilla>();

                            if(odt != null && odt.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = odt;
                                dataGridView1.Refresh();

                            }
                            

                            //DataTable odt = ToDataTable(CasillasList);

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
        }


        //public static class claseGenerica
        //{
            //public static DataTable ToDataTable<T>(this IList<T> data)
            //{
            //    PropertyDescriptorCollection props =
            //    TypeDescriptor.GetProperties(typeof(T));
            //    DataTable table = new DataTable();
            //    for (int i = 0; i < props.Count; i++)
            //    {
            //        PropertyDescriptor prop = props[i];
            //        table.Columns.Add(prop.Name, prop.PropertyType);
            //    }
            //    object[] values = new object[props.Count];
            //    foreach (T item in data)
            //    {
            //        for (int i = 0; i < values.Length; i++)
            //        {
            //            values[i] = props[i].GetValue(item);
            //        }
            //        table.Rows.Add(values);
            //    }
            //    return table;
            //}
        //}

        

        public class Casilla
        {
            public string Calle { get; set; }
            public string NumExt { get; set; }
            public string NumInt { get; set; }
            public string Colonia { get; set; }
            public string CP { get; set; }
            public string Referencia { get; set; }
            public int Seccion { get; set; }
            public string Tipo { get; set; }
            public string Clasificacion { get; set; }
            public string NumeroCasilla { get; set; }
            public string Nomenclatura { get; set; }
            public string Municipio { get; set; }
            public int Distrito { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
