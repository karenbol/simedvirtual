using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class MedicoDa
    {
        public static Boolean InsertaMedico(string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, string direccion, int codigo, string universidad, string especialidad, string correo,
            int telefono1, int telefono2)
        {
            int x = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    command.CommandText =
                        "insert into medicos(nombre,apellido1,apellido2,cedula,fecha_nacimiento,direccion,codigo,universidad,especialidad,correo,telefono1,telefono2) values (@nombre,@ape1,@ape2,@cedula,@fecha,@direccion,@codigo,@universidad,@especialidad,@correo,@telefono1,@telefono2)";

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@ape1", apellido1);
                    command.Parameters.AddWithValue("@ape2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@universidad", universidad);
                    command.Parameters.AddWithValue("@especialidad", especialidad);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@telefono1", telefono1);
                    command.Parameters.AddWithValue("@telefono2", telefono2);

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
        //metodo que edita la informacion
        public static Boolean UpdateMedico(string nombre, string apellido1, string apellido2, string cedula,
           DateTime fecha, string direccion, int codigo, string universidad, string especialidad, string correo,
            int telefono1, int telefono2)
        {
            int x = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    string cadena = "update medicos set nombre=@nombre, apellido1=@ape1,apellido2=@ape2," +
                    "fecha_nacimiento= @fecha,direccion=@direccion,codigo=@codigo,universidad=@universidad, especialidad=@especialidad,correo=@correo, telefono1=@telefono1, telefono2=@telefono2 where cedula=@cedula";
                    command.CommandText = cadena;

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@ape1", apellido1);
                    command.Parameters.AddWithValue("@ape2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@universidad", universidad);
                    command.Parameters.AddWithValue("@especialidad", especialidad);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@telefono1", telefono1);
                    command.Parameters.AddWithValue("@telefono2", telefono2);

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

        //metodo que elimina la informacion
        public static Boolean deleteMedico(string cedula)
        {
            int x = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    string cadena = "delete from medicos where cedula=@cedula";
                    command.CommandText = cadena;

                    command.Parameters.AddWithValue("@cedula", cedula);
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

        //metodo que elimina el usuario
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
                    string cadena = "delete from usuario where nombre_usuario=@cedula";
                    command.CommandText = cadena;

                    command.Parameters.AddWithValue("@cedula", cedula);
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
        //metodo get all de medicos
        public static List<MedicoEntity> selectMedico()
        {
            //creacion de lista tipo medico entity
            List<MedicoEntity> list = new List<MedicoEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from medicos", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    MedicoEntity doctor = new MedicoEntity();
                    doctor.nombre = Convert.ToString(dr["nombre"]);
                    doctor.apellido1 = Convert.ToString(dr["apellido1"]);
                    doctor.apellido2 = Convert.ToString(dr["apellido2"]);
                    doctor.cedula = Convert.ToString(dr["cedula"]);
                    doctor.fecha_nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    doctor.direccion = Convert.ToString(dr["direccion"]);
                    doctor.codigo = Convert.ToInt32(dr["codigo"]);
                    doctor.universidad = Convert.ToString(dr["universidad"]);
                    doctor.especialidad = Convert.ToString(dr["especialidad"]);
                    doctor.correo = Convert.ToString(dr["correo"]);
                    list.Add(doctor);
                }
            }
            return list;
        }

        //metodo get all de medicos
        public static List<MedicoEntity> selectMedico2(string cedula)
        {
            //creacion de lista tipo medico entity
            List<MedicoEntity> list = new List<MedicoEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from medicos where cedula=@cedula", conn);
                cmd.Parameters.AddWithValue("@cedula", cedula);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    MedicoEntity doctor = new MedicoEntity();
                    doctor.nombre = Convert.ToString(dr["nombre"]);
                    doctor.apellido1 = Convert.ToString(dr["apellido1"]);
                    doctor.apellido2 = Convert.ToString(dr["apellido2"]);
                    doctor.cedula = Convert.ToString(dr["cedula"]);
                    doctor.fecha_nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    doctor.direccion = Convert.ToString(dr["direccion"]);
                    doctor.codigo = Convert.ToInt32(dr["codigo"]);
                    doctor.universidad = Convert.ToString(dr["universidad"]);
                    doctor.especialidad = Convert.ToString(dr["especialidad"]);
                    doctor.correo = Convert.ToString(dr["correo"]);
                    doctor.telefono1 = Convert.ToInt32(dr["telefono1"]);
                    doctor.telefono2 = Convert.ToInt32(dr["telefono2"]);

                    list.Add(doctor);
                }
            }
            return list;
        }


        //metodo join que me devuelve apellido segun cedula del medico
        public static String getApellidoMedico(string cedula)
        {
            string apellido = "";
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT apellido1 FROM medicos WHERE cedula = @cedula", conn);
                //cmd.CommandTimeout = 20;

                cmd.Parameters.AddWithValue("@cedula", cedula);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    apellido = Convert.ToString(dr["apellido1"]);
                }
                conn.Close();
            }
            return apellido;
        }
    }
}
