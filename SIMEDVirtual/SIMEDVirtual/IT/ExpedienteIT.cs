using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.IT
{
    class ExpedienteIT
    {
        public static Boolean InsertaExpediente(string cedulaPaciente, DateTime fechaConsulta, string terapeutica, string observaciones)
        {
            return ExpedienteDA.InsertaExpediente(cedulaPaciente, fechaConsulta, terapeutica, observaciones);
        }

        public static List<ExpedienteEntity> selectExpediente(string cedula_cliente)
        {
            return ExpedienteDA.selectExpediente(cedula_cliente);
        }
    }
}
