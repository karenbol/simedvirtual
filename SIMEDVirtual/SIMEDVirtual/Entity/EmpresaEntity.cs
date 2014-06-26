using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.Entity
{
    class EmpresaEntity
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int cedula { get; set; }
        public string direccion { get; set; }
        public DateTime fecha { get; set; }
        public string encargado { get; set; }
    }
}
