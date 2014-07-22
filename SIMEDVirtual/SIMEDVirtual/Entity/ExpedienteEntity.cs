using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.Entity
{
    class ExpedienteEntity
    {
        public string cedula_paciente { get; set; }
        public DateTime fecha_consulta { get; set; }
        public string terapeutica { get; set; }
        public string observaciones { get; set; }
    }
}
