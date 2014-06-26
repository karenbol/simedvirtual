using SIMEDVirtual.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIMEDVirtual.IT
{
    class UsuarioIT
    {
        public static Boolean Ingreso(int nombreUsuario, string contrasena)
        {
            return UsuarioDa.Ingreso(nombreUsuario, contrasena);
        }

        public static Char TipoUsuario(int nombreUsuario)
        {
            return UsuarioDa.TipoUsuario(nombreUsuario);
        }

        public static Boolean InsertaUsuario(string pass, int usuario, Char tipo)
        {
            return UsuarioDa.InsertaUsuario(pass, usuario, tipo);
        }
    }
}
