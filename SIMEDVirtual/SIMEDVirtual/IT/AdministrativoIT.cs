using SIMEDVirtual.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.IT
{
    class AdministrativoIT
    {
        public static Boolean InsertaAdm(string nombre, string apellido1, string apellido2, int cedula,
            string direccion, Char sexo, string puesto, DateTime fecha)
        {
            return AdministrativoDa.InsertaAdm(nombre, apellido1, apellido2, cedula, direccion, sexo, puesto, fecha);
        }
    }
}
