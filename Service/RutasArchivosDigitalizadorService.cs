using Digitalizador.Entity;
using Digitalizador.Persistence;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalizador.Service
{
    public class RutasArchivosDigitalizadorService
    {
        public static IEnumerable<RutasArchivosDigitalizador> GetAll()
        {
            var result = new List<RutasArchivosDigitalizador>();

            using (var ctx = DBContext.GetInstance())
            {
                var query = "SELECT * FROM Common.CT_RutasArchivosDigitalizador";

                using (var command = new SqliteCommand(query, ctx))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new RutasArchivosDigitalizador
                            {
                                pkRutaArchivo = Convert.ToInt32(reader["pkRutaArchivo"].ToString()),
                                fkDocumento = Convert.ToInt32(reader["fkDocumento"].ToString()),
                                rutaDir = reader["rutaDir"].ToString(),
                                created_at = Convert.ToDateTime(reader["created_at"]),
                                updated_at = Convert.ToDateTime(reader["updated_at"]),
                                deleted_at = Convert.ToDateTime(reader["deleted_at"]),
                            });
                        }
                    }
                }
            }

            return result;
        }

        //public void Insertar(string query, string params)
        //{
        //    using (var ctx = DBContext.GetInstance())
        //    {
        //        //var query = "INSERT INTO Common.CT_RutasArchivosDigitalizador (fkDocumento, rutaDir, created_at, updated_at, deleted_at ) VALUES (?, ?, ?, ?, ?)";
                

        //        using (var command = new SqliteCommand(query, ctx))
        //        {
        //            command.Parameters.Add(new SqliteParameter("fkDocumento",   )));
        //            command.Parameters.Add(new SqliteParameter("rutaDir", )));
        //            command.Parameters.Add(new SqliteParameter("created_at", DateTime.Now.ToString()));
        //            command.Parameters.Add(new SqliteParameter("created_at", "null"));
        //            command.Parameters.Add(new SqliteParameter("created_at", "null"));

        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}

    }
}
