using Npgsql;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class ClienteDA
    {
        //inserta datos en la tabla clientes
        public static Boolean InsertaCliente(
            string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, char sexo, string estado_civil, string grupo_sanguineo, string profesion,
            int telefono_fijo, int movil, string correo, string direccion, string edad, string empresa, byte[]fotoBinaria)
        {
            int x = 0;
            string g = "";
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    command.CommandText =
                        "insert into clientes(nombre,apellido1,apellido2,cedula,fecha_nacimiento,sexo," +
                    "estado_civil,grupo_sanguineo,profesion,telefono_fijo,telefono_movil,email,direccion,edad,empresa,foto) " +
                    "values (@nombre,@ape1,@ape2,@cedula,@fecha,@sexo,@estado,@grupo,@profesion,@telefono,@movil,@email,@direccion," +
                    "@edad,@empresa,@foto)";

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@ape1", apellido1);
                    command.Parameters.AddWithValue("@ape2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@estado", estado_civil);
                    command.Parameters.AddWithValue("@grupo", grupo_sanguineo);
                    command.Parameters.AddWithValue("@profesion", profesion);
                    command.Parameters.AddWithValue("@telefono", telefono_fijo);
                    command.Parameters.AddWithValue("@movil", movil);
                    command.Parameters.AddWithValue("@email", correo);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@empresa", empresa);
                    command.Parameters.AddWithValue("@foto", fotoBinaria);

                    x = command.ExecuteNonQuery();
                }

                catch (Exception exp)
                {
                    g = exp.ToString();
                    return false;
                    //Console.Write(g);
                    //throw;
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

        //metodo get all de clientes
        public static List<ClienteEntity> selectCliente()
        {
            //creacion de lista tipo medico entity
            List<ClienteEntity> list = new List<ClienteEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from clientes", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClienteEntity cliente = new ClienteEntity();

                    cliente.nombre = Convert.ToString(dr["nombre"]);
                    cliente.ape1 = Convert.ToString(dr["apellido1"]);
                    cliente.ape2 = Convert.ToString(dr["apellido2"]);
                    cliente.cedula = Convert.ToString(dr["cedula"]);
                    cliente.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    cliente.sexo = Convert.ToChar(dr["sexo"]);
                    cliente.estado_civil = Convert.ToString(dr["estado_civil"]);
                    cliente.grupo_sanguineo = Convert.ToString(dr["grupo_sanguineo"]);
                    cliente.profesion = Convert.ToString(dr["profesion"]);
                    cliente.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    cliente.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    cliente.email = Convert.ToString(dr["email"]);
                    cliente.direccion = Convert.ToString(dr["direccion"]);

                    list.Add(cliente);
                }
                conn.Close();
            }
            return list;
        }

        //me trae todo del cliente segun la cedula
        public static List<ClienteEntity> selectClientePorCedula(string cedula)
        {
            //creacion de lista tipo medico entity
            List<ClienteEntity> list = new List<ClienteEntity>();

            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from clientes where cedula= @cedula", conn);
                cmd.Parameters.AddWithValue("@cedula", cedula);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClienteEntity cliente = new ClienteEntity();

                    cliente.nombre = Convert.ToString(dr["nombre"]);
                    cliente.ape1 = Convert.ToString(dr["apellido1"]);
                    cliente.ape2 = Convert.ToString(dr["apellido2"]);
                    cliente.cedula = Convert.ToString(dr["cedula"]);
                    cliente.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    cliente.sexo = Convert.ToChar(dr["sexo"]);
                    cliente.estado_civil = Convert.ToString(dr["estado_civil"]);
                    cliente.grupo_sanguineo = Convert.ToString(dr["grupo_sanguineo"]);
                    cliente.profesion = Convert.ToString(dr["profesion"]);
                    cliente.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    cliente.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    cliente.email = Convert.ToString(dr["email"]);
                    cliente.direccion = Convert.ToString(dr["direccion"]);

                    cliente.edad = Convert.ToString(dr["edad"]);
                    cliente.empresa = Convert.ToString(dr["empresa"]);

                    list.Add(cliente);
                }
                conn.Close();
            }
            return list;
        }


        public static Boolean UpdateCliente(string nombre, string apellido1, string apellido2, string cedula, DateTime fecha,
            string edad, char sexo, string direccion, string estado, string grupo, string empresa, string profesion,
           int telefono1, int telefono2, string email)
        {
            int x = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    string cadena = "update clientes set nombre=@nombre, apellido1=@apellido1,apellido2=@apellido2," +
                    "fecha_nacimiento=@fecha_nacimiento,sexo=@sexo,estado_civil=@estado_civil, grupo_sanguineo=@grupo_sanguineo," +
                    "profesion=@profesion,telefono_fijo=@telefono_fijo,telefono_movil=@telefono_movil, email=@email," +
                    "direccion=@direccion, edad=@edad, empresa=@empresa where cedula=@cedula";

                    command.CommandText = cadena;

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido1", apellido1);
                    command.Parameters.AddWithValue("@apellido2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@estado_civil", estado);
                    command.Parameters.AddWithValue("@grupo_sanguineo", grupo);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@empresa", empresa);
                    command.Parameters.AddWithValue("@profesion", profesion);
                    command.Parameters.AddWithValue("@telefono_fijo", telefono1);
                    command.Parameters.AddWithValue("@telefono_movil", telefono2);
                    command.Parameters.AddWithValue("@email", email);

                    x = command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                    return false;
                }

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






















        /* public static List<int> IdEmpresa(int idEmpresa)
         {
             List<int> result = new List<int>();
             NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
             {
                 conn.Open();
                 NpgsqlCommand cmd = new NpgsqlCommand("select id_cliente from plan_empresarial where id_empresa='" + idEmpresa + "'", conn);
                 NpgsqlDataReader dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     List<int> ids = new List<int>();
                     ids.Add(Convert.ToInt32(dr[0].ToString()));
                     //result.
                 }
             }
             return result;
         }*/
    }
}
