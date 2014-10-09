using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    public class MedicoEntity
    {
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string cedula { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string direccion { get; set; }
        public int codigo { get; set; }
        public string universidad { get; set; }
        public string especialidad { get; set; }
        public string correo { get; set; }
        public int telefono1 { get; set; }
        public int telefono2 { get; set; }

        public byte[] foto { get; set; }
    }
}
