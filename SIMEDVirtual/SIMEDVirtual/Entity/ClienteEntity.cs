using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.Entity
{
    class ClienteEntity
    {
        public string nombre { get; set; }
        public string ape1 { get; set; }
        public string ape2 { get; set; }
        public int cedula { get; set; }
        public DateTime fecha { get; set; }
        public Char sexo { get; set; }
        public string direccion { get; set; }
        public string ocupacion { get; set; }
        public string correo { get; set; }
    }
}
