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
        public string cedula { get; set; }
        public DateTime fecha { get; set; }
        public Char sexo { get; set; }
        public string estado_civil { get; set; }
        public string grupo_sanguineo { get; set; }
        public string profesion { get; set; }
        public int telefono_fijo { get; set; }
        public int telefono_movil { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }

        public string edad { get; set; }
        public string empresa { get; set; }

        public byte[] fotoBinaria { get; set; }
    }
}
