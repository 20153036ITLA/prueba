using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMOPC.Models
{
    public class MOPCData
    {

        public int Id { get; set; }

        public string Cedula { get; set; }

        public int? RNC { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Provincia { get; set; }
        public string Municipio { get; set; }

        public string RazonSocial { get; set; }

        public string Posicion { get; set; }

        public string Comentario { get; set; }

    }
}
