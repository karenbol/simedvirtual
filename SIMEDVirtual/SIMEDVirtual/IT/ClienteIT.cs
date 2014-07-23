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
            int telefono_fijo, int movil, string correo, string direccion,
            char tabaquismo, char ingesta_medicamentos, char alcoholismo, char rehabilitacion, char diabetes,
            string trat_diabetes, char hipertension, string trat_hipertension, char dolor_cabeza, char epilepsia,
            char vertigo, char depresion, char falta_aire, char ojos_oidos, string observaciones)
        {
            return ClienteDA.InsertaCliente(nombre, apellido1, apellido2, cedula, fecha, sexo,
                estado_civil, grupo_sanguineo, profesion, telefono_fijo, movil, correo, direccion,
                tabaquismo, ingesta_medicamentos, alcoholismo, rehabilitacion, diabetes, trat_diabetes, hipertension, trat_hipertension,
                dolor_cabeza, epilepsia, vertigo, depresion, falta_aire, ojos_oidos, observaciones);
        }

        //obtenemos todos los clientes en la tabla
        public static List<ClienteEntity> selectCliente()
        {
            return ClienteDA.selectCliente();
        }

        //obtenemos todo del cliente segun la cedula
        public static List<ClienteEntity> selectClienteAnamnesis(string cedula)
        {
            return ClienteDA.selectClienteAnamnesis(cedula);
        }
    }
}
