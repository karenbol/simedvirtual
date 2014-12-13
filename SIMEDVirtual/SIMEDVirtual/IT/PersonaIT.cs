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
            int telefono_fijo, int movil, string correo, int empresa, byte[] fotoBinaria, bool medico, DateTime fecha_creacion)
        {
            return PersonaDA.InsertaCliente(nombre, apellido1, apellido2, cedula, fecha, direccion, edad, sexo,
                estado_civil, grupo_sanguineo, profesion, telefono_fijo, movil, correo, empresa, fotoBinaria, medico, fecha_creacion);
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
            int telefono_fijo, int movil, string correo, int empresa, byte[] fotoBinaria, bool medico)
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
           DateTime fecha, string direccion, string edad, char sexo, int telefono1, int telefono2, string correo,
             byte[] foto, int codigo, string universidad, int especialidad, bool medico)
        {
            return PersonaDA.InsertaMedico(nombre, apellido1, apellido2, cedula, fecha, direccion, edad, sexo,
                 telefono1, telefono2, correo, foto, codigo, universidad, especialidad, medico);
        }
        public static List<PersonaEntity> selectMedico()
        {
            return PersonaDA.selectMedico();
        }

        public static Boolean UpdateMedico(string nombre, string apellido1, string apellido2, string cedula,
           DateTime fecha, string direccion, string edad, char sexo, int telefono1, int telefono2, string correo,
            byte[] foto, int codigo, string universidad, int especialidad)
        {
            return PersonaDA.UpdateMedico(nombre, apellido1, apellido2, cedula, fecha, direccion, edad, sexo, telefono1, telefono2, correo,
                foto, codigo, universidad, especialidad);
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

        public static List<PersonaEntity> selectMedicoLess()
        {
            return PersonaDA.selectMedicoLess();
        }

        public static List<PersonaEntity> selectClienteByBusqueda(string columna, string pista)
        {
            return PersonaDA.selectClienteByBusqueda(columna, pista);
        }

        public static List<PersonaEntity> selectClienteByIdEmpresa(int id_empresa)
        {
            return PersonaDA.selectClienteByIdEmpresa(id_empresa);
        }

        public static List<PersonaEntity> selectClientePorFecha(string fecha)
        {
            return PersonaDA.selectClientePorFecha(fecha);
        }

        //inserta una persona administrativa
        public static Boolean InsertaAdministrativo(
            string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, string direccion, string edad, char sexo, string profesion,
            int telefono_fijo, int movil, string correo, bool medico, DateTime fecha_creacion)
        {
            return PersonaDA.InsertaAdministrativo(nombre, apellido1, apellido2, cedula, fecha, direccion, edad, sexo,
                profesion, telefono_fijo, movil, correo, medico, fecha_creacion);
        }

        public static Boolean UpdateAdministrativo(string nombre, string apellido1, string apellido2, string cedula,
          DateTime fecha, string direccion, string edad, char sexo, string profesion,
          int telefono_fijo, int movil, string correo)
        {
            return UpdateAdministrativo(nombre, apellido1, apellido2, cedula, fecha,
                direccion, edad, sexo, profesion, telefono_fijo, movil, correo);
        }

        public static List<PersonaEntity> selectAdministrativo()
        {
            return PersonaDA.selectAdministrativo();
        }
    }
}
