using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitalizador
{
    public class Conexion
    {

        public string SettingsDataBase(string dataBase)
        {
            string conDatabase = "";      //variable para almacenar el string de conexión a la base de datos
            try
            {
                conDatabase = ConfigurationManager.ConnectionStrings[dataBase].ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conDatabase;
        }

        public int RetSqlInt(string dataBase, string consulta)
        {
            int iResultado = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(SettingsDataBase(dataBase)))
                {
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.CommandTimeout = 0;
                    cmd.Connection = con;
                    cmd.Connection.Open();
                    iResultado = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    con.Dispose();
                }
            }
            catch (Exception e)
            { throw e; }
            return iResultado;
        }
        public DataTable RetSqlDataTable(string dataBase, string consulta)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(SettingsDataBase(dataBase)))
                {
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.CommandTimeout = 0;
                    cmd.Connection = con;
                    cmd.Connection.Open();

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dtResultado = ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
                    cmd.Connection.Close();
                    con.Dispose();
                }
            }
            catch (Exception e)
            { throw e; }
            return dtResultado;
        }


        //Regresa una tabla dependiendo del parametro Consulta= Procedimiento a ejecutar, Conexion=cadenade conexion de SQL, 
        //arreglo de parametros que necesita el Procedimiento Nombre y valor
        public DataTable RetSqlDataTableSP(string dataBase, string strPrmProc, string[] strPrmNombre, string[] strPrmValor)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(SettingsDataBase(dataBase)))
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = strPrmProc;

                    int iIdx = 0;
                    int iLen;
                    iLen = strPrmNombre.Length;
                    string nombreParametro;
                    string valorParametro;

                    //Agrega cada parametro dependiendo la lista de arreglos
                    for (iIdx = 0; iIdx < iLen; iIdx++)
                    {
                        nombreParametro = strPrmNombre[iIdx];
                        valorParametro = strPrmValor[iIdx];

                        cmd.Parameters.Add(new SqlParameter(nombreParametro, valorParametro));
                    }
                    cmd.Connection = con;
                    cmd.Connection.Open();

                    SqlDataAdapter daCatalogo = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    daCatalogo.Fill(ds);
                    dtResultado = ds != null && ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
                    cmd.Connection.Close();
                    con.Dispose();
                }
            }
            catch (Exception e)
            { throw e; }
            return dtResultado;
        }



        SqlConnection con;

        //procedimiento que abre la conexion sqlsever
        public DataTable conectar(string entorno,string query)
        {
            DataTable odt = new DataTable();
            try
            {
                //mi conexion:
                //SqlConnection con = new SqlConnection("server=RUDOLF\\SQLEXPRESS2012;database=sys_fact_2018_liceo_castro_madriz_1;Trusted_Connection=True;");
                //SqlConnection 
                
                con = new SqlConnection(ConfigurationManager.ConnectionStrings[entorno].ConnectionString);

                con.Open();
                odt = consultaQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return odt;
        }

        public DataTable consultaQuery(string cadenaQuery)
        {
            SqlCommand cmd = new SqlCommand(cadenaQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            if (dr.Read())
            {
                //Console.WriteLine(Convert.ToString(dr["nombrecampo"]));
                dt.Load(dr);
            }

            return dt;
        }

        //procedimiento que cierra la conexion sqlserver
        public void desconectar()
        {
            con.Close();
        }

        //funcion que devuelve la conexion sqlserver
        public SqlConnection conex()
        {
            SqlConnection conexi = con;
            return conexi;
        }

    }



}

