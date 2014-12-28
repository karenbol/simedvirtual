using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIMEDVirtual.IT
{
    class UsuarioIT
    {
        public static Boolean Ingreso(string nombreUsuario, string contrasena)
        {
            return UsuarioDa.Ingreso(nombreUsuario, contrasena);
        }

        public static String TipoUsuario(string nombreUsuario)
        {
            return UsuarioDa.TipoUsuario(nombreUsuario);
        }

        public static Boolean InsertaUsuario(string pass, string usuario, int tipo)
        {
            return UsuarioDa.InsertaUsuario(pass, usuario, tipo);
        }
        //retorna el nombre y apellido del medico segun la cedula
        public static  List<PersonaEntity> getNombreApeDr(string cedula)
        {
            return UsuarioDa.getNombreApeDr(cedula);
        }
        //elimina el usuario
        public static Boolean deleteUsuario(string cedula)
        {
            return UsuarioDa.deleteUsuario(cedula);
        }

        public static Boolean CambiarPass(string cedula, string pass)
        {
            return UsuarioDa.CambiarPass(cedula, pass);
        }
    }
}
