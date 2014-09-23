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
            char hipertension, char dolor_cabeza, char epilepsia,
            char vertigo, char depresion, char falta_aire, char ojos_oidos, char dolor_pecho, char enf_nerviosas,
            char alergias, string alergia_tratamiento, string diabetes_trat, string hipertension_trat, char asma,
            string asma_trat, char tiroides, string tiroides_trat, string hipertension_heredo, string diabetes_heredo,
            string cancer_heredo, string tiroides_heredo, string asma_heredo, string otros_heredo, string edad,
            string empresa, string observaciones)
        {
            return ClienteDA.InsertaCliente(nombre, apellido1, apellido2, cedula, fecha, sexo,
                estado_civil, grupo_sanguineo, profesion, telefono_fijo, movil, correo, direccion,
                tabaquismo, ingesta_medicamentos, alcoholismo, rehabilitacion, diabetes,hipertension, dolor_cabeza,
                epilepsia,vertigo,depresion,falta_aire,ojos_oidos,dolor_pecho,enf_nerviosas,alergias,alergia_tratamiento,
                diabetes_trat,hipertension_trat,asma,asma_trat,tiroides,tiroides_trat,hipertension_heredo,diabetes_heredo,
                cancer_heredo,tiroides_heredo,asma_heredo,otros_heredo,edad,empresa,observaciones);
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
