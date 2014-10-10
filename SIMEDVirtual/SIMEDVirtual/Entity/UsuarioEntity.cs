using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEDVirtual.Entity
{
    public class UsuarioEntity
    {
        public int nombre_usuario { get; set; }
        public string password { get; set; }
        public string tipo_usuario { get; set; }
    }
}
