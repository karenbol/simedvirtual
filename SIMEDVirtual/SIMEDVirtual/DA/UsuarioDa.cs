using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;
using System.Windows.Forms;
using SIMEDVirtual.Entity;

namespace SIMEDVirtual.DA
{
    public class UsuarioDa
    {

        public static List<UsuarioEntity> LeerUsuarios()
        {
            List<UsuarioEntity> usuarios = new List<UsuarioEntity>();
            using (NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("select nombre_usuario, contrasena from usuario", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    UsuarioEntity user = new UsuarioEntity();
                    user.nombre_usuario = Convert.ToInt32(dr[0]);
                    user.password = dr[1].ToString();
                    usuarios.Add(user);

                }
            }
            return usuarios;
        }


        public static Boolean Ingreso(int nombreUsuario, string contrasena)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                //seleccionamos la contrasena y el tipo de usuario segun el nombre de usuario ingresado
                NpgsqlCommand cmd = new NpgsqlCommand("select contrasena, tipo from usuario where nombre_usuario=" + nombreUsuario,
    conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //si la contrasena es correcta retorna true
                    if (dr[0].ToString() == contrasena)
                    {
                        return true;
                    }
                    else
                    //si la contrasena es incorrecta retorna false
                    {
                        return false;
                    }
                }
                //si no retorna nada, retorna false
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// retorna el tipo de usuario
        /// </summary>
        /// <param name="nombreUsuario">enviamos el nombre de usuario para saber el tipo</param>
        /// <returns>retorna el tipo m: medico a: administrador</returns>
        public static Char TipoUsuario(int nombreUsuario)
        {
            Char tipo = ' ';
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select tipo from usuario where nombre_usuario=" + nombreUsuario,
    conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tipo = Convert.ToChar(dr[0].ToString().Trim());
                    return tipo;
                }
                else
                {
                    return tipo;
                }
            }
        }


        //metodo que inserta usuarios
        public static Boolean InsertaUsuario(string pass, int usuario, Char tipo)
        {
            int x;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    command.CommandText =
                        "insert into usuario (contrasena,nombre_usuario,tipo) values (@pass,@usuario,@tipo)";
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    x = command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                conn.Close();

                if (x != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }












    }
}
