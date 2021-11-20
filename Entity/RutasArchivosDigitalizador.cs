using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalizador.Entity
{
    public class RutasArchivosDigitalizador
    {
        public int pkRutaArchivo { get; set; }
        public int fkDocumento { get; set; }
        public string rutaDir { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }


    }
}
