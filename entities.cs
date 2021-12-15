using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalizador
{
    public class entities
    {
    }

    public class clogin
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class cfileBase64
    {
        public string filename { get; set; }
        public string folder { get; set; }
        public string file { get; set; }
    }

    public class cCasilla
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

    public class cPerfiles
    {
        public string pkUserPerfil { get; set; }
        public string fkUser { get; set; }
        public string fkRole { get; set; }

    }

    public class cArchivoRC
    {
        public string folio { get; set; }
        public string candidato { get; set; }
        public string doc_title { get; set; }
        public string doc_id { get; set; }
    }
}
