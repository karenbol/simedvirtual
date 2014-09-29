using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.IT
{
    class ClienteIT
    {
        public static Boolean InsertaCliente(string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, char sexo, string estado_civil, string grupo_sanguineo, string profesion,
            int telefono_fijo, int movil, string correo, string direccion, string edad, string empresa)
        {
            return ClienteDA.InsertaCliente(nombre, apellido1, apellido2, cedula, fecha, sexo,
                estado_civil, grupo_sanguineo, profesion, telefono_fijo, movil, correo, direccion,
               edad, empresa);
        }

        //obtenemos todos los clientes en la tabla
        public static List<ClienteEntity> selectCliente()
        {
            return ClienteDA.selectCliente();
        }

        //obtenemos todo del cliente segun la cedula
        public static List<ClienteEntity> selectClientePorCedula(string cedula)
        {
            return ClienteDA.selectClientePorCedula(cedula);
        }
    }
}
