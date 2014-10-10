using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.IT
{
    class PersonaIT
    {
        public static Boolean InsertaCliente(
            string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, string direccion, string edad, char sexo, string estado_civil, string grupo_sanguineo, string profesion,
            int telefono_fijo, int movil, string correo, string empresa, byte[] fotoBinaria, bool medico)
        {
            return PersonaDA.InsertaCliente(nombre, apellido1, apellido2, cedula, fecha, direccion, edad, sexo,
                estado_civil, grupo_sanguineo, profesion, telefono_fijo, movil, correo, empresa, fotoBinaria, medico);
        }

        //obtenemos todos los clientes en la tabla
        public static List<PersonaEntity> selectCliente()
        {
            return PersonaDA.selectCliente();
        }

        //obtenemos todo del cliente segun la cedula
        public static List<PersonaEntity> selectClientePorCedula(string cedula)
        {
            return PersonaDA.selectClientePorCedula(cedula);
        }


        public static Boolean UpdateCliente(string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, string direccion, string edad, char sexo, string estado_civil, string grupo_sanguineo, string profesion,
            int telefono_fijo, int movil, string correo, string empresa, byte[] fotoBinaria, bool medico)
        {
            return PersonaDA.UpdateCliente(nombre, apellido1, apellido2, cedula, fecha, direccion, edad, sexo, estado_civil,
                grupo_sanguineo, profesion, telefono_fijo, movil, correo, empresa, fotoBinaria, medico);
        }

        public static Image GetImagePacient(string cedula)
        {
            return PersonaDA.GetImagePacient(cedula);
        }
        //////////////////////////////////////////

        public static Boolean InsertaMedico(string nombre, string apellido1, string apellido2, string cedula,
           DateTime fecha, string direccion, string edad, char sexo, int codigo, int telefono1, int telefono2,
            string universidad, string especialidad, string correo, byte[] foto, bool medico)
        {
            return PersonaDA.InsertaMedico(nombre, apellido1, apellido2, cedula, fecha, direccion, edad, sexo, codigo,
                telefono1, telefono2, universidad, especialidad, correo, foto, medico);
        }
        public static List<PersonaEntity> selectMedico()
        {
            return PersonaDA.selectMedico();
        }

        public static Boolean UpdateMedico(string nombre, string apellido1, string apellido2, string cedula,
           DateTime fecha, string direccion, string edad, char sexo, int codigo, int telefono1, int telefono2,
            string universidad, string especialidad, string correo, byte[] foto)
        {
            return PersonaDA.UpdateMedico(nombre, apellido1, apellido2, cedula, fecha, direccion, edad, sexo, codigo,
               telefono1, telefono2, universidad, especialidad, correo, foto);
        }

        public static List<PersonaEntity> selectMedico2(string cedula)
        {
            return PersonaDA.selectMedico2(cedula);
        }

        public static Boolean deleteMedico(string cedula)
        {
            return PersonaDA.deleteMedico(cedula);
        }

        public static Boolean deleteUsuario(string cedula)
        {
            return PersonaDA.deleteUsuario(cedula);
        }

        public static String getApellidoMedico(string cedula)
        {
            return PersonaDA.getApellidoMedico(cedula);
        }

        public static Image GetImageMedico(string cedula)
        {
            return PersonaDA.GetImageMedico(cedula);
        }
    }
}
