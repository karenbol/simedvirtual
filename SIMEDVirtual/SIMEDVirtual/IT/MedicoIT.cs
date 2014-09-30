using SIMEDVirtual.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.IT
{
    class MedicoIT
    {
        public static Boolean InsertaMedico(string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, string direccion, int codigo, string universidad, string especialidad, string correo,
            int telefono1, int telefono2)
        {
            return MedicoDa.InsertaMedico(nombre, apellido1, apellido2, cedula, fecha, direccion, codigo,
                universidad, especialidad, correo, telefono1, telefono2);
        }
        public static List<MedicoEntity> selectMedico()
        {
            return MedicoDa.selectMedico();
        }

        public static Boolean UpdateMedico(string nombre, string apellido1, string apellido2, string cedula,
          DateTime fecha, string direccion, int codigo, string universidad, string especialidad, string correo,
            int telefono1, int telefono2)
        {
            return MedicoDa.UpdateMedico(nombre, apellido1, apellido2, cedula, fecha, direccion, codigo, universidad
                , especialidad, correo, telefono1, telefono2);
        }

        public static List<MedicoEntity> selectMedico2(string cedula)
        {
            return MedicoDa.selectMedico2(cedula);
        }

        public static Boolean deleteMedico(string cedula)
        {
            return MedicoDa.deleteMedico(cedula);
        }

        public static Boolean deleteUsuario(string cedula)
        {
            return MedicoDa.deleteUsuario(cedula);
        }

        public static String getApellidoMedico(string cedula)
        {
            return MedicoDa.getApellidoMedico(cedula);
        }

    }
}
