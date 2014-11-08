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

                NpgsqlCommand cmd = new NpgsqlCommand("select cedula, contrasena from usuario", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    UsuarioEntity user = new UsuarioEntity();
                    user.nombre_usuario = Convert.ToInt32(dr[0]);
                    user.password = dr[1].ToString();
                    usuarios.Add(user);
                }
                conn.Close();
            }
            return usuarios;
        }

        //verifica si esta registrado en la bd
        public static Boolean Ingreso(string nombreUsuario, string contrasena)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                //seleccionamos la contrasena y el tipo de usuario segun el nombre de usuario ingresado
                //la cedula es el nombre de usuario
                command.CommandText = "select contrasena, tipo_usuario from usuario where cedula=@cedula";

                command.Parameters.AddWithValue("@cedula", nombreUsuario);
                NpgsqlDataReader dr = command.ExecuteReader();


                if (dr.Read())
                {
                    //si la contrasena es correcta retorna true
                    if (dr[0].ToString() == contrasena)
                    {
                        conn.Close();
                        return true;
                    }
                    else
                    //si la contrasena es incorrecta retorna false
                    {
                        conn.Close();
                        return false;
                    }
                }
                //si no retorna nada, retorna false
                else
                {
                    conn.Close();
                    return false;
                }
            }
        }

        /// <summary>
        /// retorna el tipo de usuario
        /// </summary>
        /// <param name="nombreUsuario">enviamos el nombre de usuario para saber el tipo</param>
        /// <returns>retorna el tipo m: medico a: administrador</returns>
        public static String TipoUsuario(string nombreUsuario)
        {
            String tipo = "";
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();

                command.CommandText = "select tipo_usuario from usuario where cedula=@cedula";

                command.Parameters.AddWithValue("@cedula", nombreUsuario);

                NpgsqlDataReader dr = command.ExecuteReader();

                if (dr.Read())
                {
                    tipo = dr[0].ToString().Trim();
                    conn.Close();
                    return tipo;
                }
                else
                {
                    conn.Close();
                    return tipo;
                }
            }
        }


        //metodo que inserta usuarios, tipo es int xq es el id de la table role
        public static Boolean InsertaUsuario(string pass, string usuario, int tipo)
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
                        "insert into usuario values (default,@usuario,@pass,@tipo)";

                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    x = command.ExecuteNonQuery();
                }
                catch
                {
                    return false;
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

        //me trae el nombre y apellido del medico segun la la cedula
        public static List<PersonaEntity> getNombreApeDr(string cedula)
        {
            List<PersonaEntity> persona = new List<PersonaEntity>();
            using (NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("select nombre,apellido1 from persona where cedula=@cedula", conn);
                cmd.Parameters.AddWithValue("@cedula", cedula);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    PersonaEntity doctor = new PersonaEntity();
                    doctor.nombre = Convert.ToString(dr["nombre"]);
                    doctor.ape1 = Convert.ToString(dr["apellido1"]);
                    persona.Add(doctor);
                }
                conn.Close();
            }
            return persona;
        }

        //elimina el usuario
        public static Boolean deleteUsuario(string cedula)
        {
            int x = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    string cadena = "delete from usuario where cedula=@cedula";
                    command.CommandText = cadena;

                    command.Parameters.AddWithValue("@cedula", cedula);
                    x = command.ExecuteNonQuery();
                }
                catch
                {
                    return false;
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
