//using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Digitalizador.Persistence
{
    public class DBContext
    {
        private const string DBName = "database.db";
        //private const string SQLScript = @"..\..\dbs\database.sql";
        //private static bool IsDbRecentlyCreated = false;


        public static SQLiteConnection GetInstance()
        {
            var db = new SQLiteConnection(
                string.Format("Data Source={0};Version=3;", DBName)
            );

            db.Open();

            return db;
        }


        // Metodos para CRUD en la db de sqlite
        public DataTable dbContext_RetSqlDataTable(string query)
        {
            using (var ctx = GetInstance())
            {
                //var query = "INSERT INTO Users (name, lastname, birthday) VALUES (?, ?, ?)";
                DataTable dtResultado = new DataTable();
                try {
                    using (var command = new SQLiteCommand(query, ctx))
                    {
                        command.ExecuteNonQuery();

                        SQLiteDataAdapter sda = new SQLiteDataAdapter(command);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        dtResultado = ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
                        command.Connection.Close();
                        ctx.Dispose();
                    }
                }
                catch (Exception e)
                { throw e; }
                return dtResultado;
            }
        }

        public DataTable dbContext_RetSqlDataTableSP(string strPrmProc, string[] strPrmNombre, string[] strPrmValor)
        {
            using (var ctx = GetInstance())
            {
                //var query = "INSERT INTO Users (name, lastname, birthday) VALUES (?, ?, ?)";
                DataTable dtResultado = new DataTable();
                try
                {
                    using (var command = new SQLiteCommand(strPrmProc, ctx))
                    {

                        command.CommandTimeout = 0;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = strPrmProc;

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

                            command.Parameters.Add(new SqlParameter(nombreParametro, valorParametro));
                        }
                        command.Connection = ctx;
                        command.Connection.Open();


                        SqlDataAdapter daCatalogo = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        daCatalogo.Fill(ds);
                        dtResultado = ds != null && ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
                        command.Connection.Close();
                        ctx.Dispose();
                    }
                }
                catch (Exception e)
                { throw e; }
                return dtResultado;


            }
        }


        public DataTable RetSqlDataTable(string dataBase, string consulta)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection())
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
        //public DataTable RetSqlDataTableSP(string dataBase, string strPrmProc, string[] strPrmNombre, string[] strPrmValor)
        //{
        //    DataTable dtResultado = new DataTable();
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(SettingsDataBase(dataBase)))
        //        {

        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandTimeout = 0;
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = strPrmProc;

        //            int iIdx = 0;
        //            int iLen;
        //            iLen = strPrmNombre.Length;
        //            string nombreParametro;
        //            string valorParametro;

        //            //Agrega cada parametro dependiendo la lista de arreglos
        //            for (iIdx = 0; iIdx < iLen; iIdx++)
        //            {
        //                nombreParametro = strPrmNombre[iIdx];
        //                valorParametro = strPrmValor[iIdx];

        //                cmd.Parameters.Add(new SqlParameter(nombreParametro, valorParametro));
        //            }
        //            cmd.Connection = con;
        //            cmd.Connection.Open();

        //            SqlDataAdapter daCatalogo = new SqlDataAdapter(cmd);
        //            DataSet ds = new DataSet();
        //            daCatalogo.Fill(ds);
        //            dtResultado = ds != null && ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
        //            cmd.Connection.Close();
        //            con.Dispose();
        //        }
        //    }
        //    catch (Exception e)
        //    { throw e; }
        //    return dtResultado;
        //}

    }
}
