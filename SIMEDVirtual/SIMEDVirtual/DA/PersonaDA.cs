using Npgsql;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class PersonaDA
    {
        //inserta datos en la tabla persona
        public static Boolean InsertaCliente(
            string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, string direccion, string edad, char sexo, string estado_civil, string grupo_sanguineo, string profesion,
            int telefono_fijo, int movil, string correo, int empresa, byte[] fotoBinaria, bool medico, DateTime fecha_creacion)
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
                        "insert into persona(nombre,apellido1,apellido2,cedula,fecha_nacimiento,direccion,edad,sexo," +
                    "estado_civil,grupo_sanguineo,profesion,telefono_fijo,telefono_movil,email,empresa,foto, medico,fecha_creacion) " +
                    "values (@nombre,@ape1,@ape2,@cedula,@fecha,@direccion,@edad,@sexo,@estado,@grupo,@profesion,@telefono,@movil,@email," +
                    "@empresa,@foto,@medico,@fecha_creacion)";

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@ape1", apellido1);
                    command.Parameters.AddWithValue("@ape2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@estado", estado_civil);
                    command.Parameters.AddWithValue("@grupo", grupo_sanguineo);
                    command.Parameters.AddWithValue("@profesion", profesion);
                    command.Parameters.AddWithValue("@telefono", telefono_fijo);
                    command.Parameters.AddWithValue("@movil", movil);
                    command.Parameters.AddWithValue("@email", correo);

                    command.Parameters.AddWithValue("@empresa", empresa);
                    command.Parameters.AddWithValue("@foto", fotoBinaria);
                    command.Parameters.AddWithValue("@medico", medico);
                    command.Parameters.AddWithValue("@fecha_creacion", fecha_creacion);

                    x = command.ExecuteNonQuery();
                }

                catch (Exception exp)
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

        //inserta datos en la tabla persona
        public static Boolean InsertaAdministrativo(
            string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, string direccion, string edad, char sexo, string profesion,
            int telefono_fijo, int movil, string correo, bool medico, DateTime fecha_creacion)
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
                        "insert into persona(nombre,apellido1,apellido2,cedula,fecha_nacimiento,direccion,edad,sexo," +
                    "profesion,telefono_fijo,telefono_movil,email,medico,fecha_creacion) " +
                    "values (@nombre,@ape1,@ape2,@cedula,@fecha,@direccion,@edad,@sexo,@profesion,@telefono,@movil,@email," +
                    "@medico,@fecha_creacion)";

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@ape1", apellido1);
                    command.Parameters.AddWithValue("@ape2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@profesion", profesion);
                    command.Parameters.AddWithValue("@telefono", telefono_fijo);
                    command.Parameters.AddWithValue("@movil", movil);
                    command.Parameters.AddWithValue("@email", correo);

                    command.Parameters.AddWithValue("@medico", medico);
                    command.Parameters.AddWithValue("@fecha_creacion", fecha_creacion);

                    x = command.ExecuteNonQuery();
                }

                catch (Exception exp)
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

        //metodo get all de clientes
        public static List<PersonaEntity> selectCliente()
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from persona where medico=false and cedula!='1' order by apellido1", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaEntity cliente = new PersonaEntity();

                    cliente.nombre = Convert.ToString(dr["nombre"]);
                    cliente.ape1 = Convert.ToString(dr["apellido1"]);
                    cliente.ape2 = Convert.ToString(dr["apellido2"]);
                    cliente.cedula = Convert.ToString(dr["cedula"]);
                    cliente.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    cliente.direccion = Convert.ToString(dr["direccion"]);
                    cliente.edad = Convert.ToString(dr["edad"]);
                    cliente.sexo = Convert.ToChar(dr["sexo"]);
                    cliente.estado_civil = Convert.ToString(dr["estado_civil"]);
                    cliente.grupo_sanguineo = Convert.ToString(dr["grupo_sanguineo"]);
                    cliente.profesion = Convert.ToString(dr["profesion"]);
                    cliente.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    cliente.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    cliente.email = Convert.ToString(dr["email"]);
                    cliente.empresa = Convert.ToInt32(dr["empresa"]);

                    list.Add(cliente);
                }
                conn.Close();
            }
            return list;
        }


        //select cliente by busqueda
        public static List<PersonaEntity> selectClienteByBusqueda(string columna, string pista)
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM persona WHERE (" + columna + " LIKE LOWER('" + pista + "%') or "
                    + columna + " LIKE UPPER('" + pista + "%') or " + columna + " LIKE('" + pista + "')) and medico =false", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaEntity cliente = new PersonaEntity();

                    cliente.nombre = Convert.ToString(dr["nombre"]);
                    cliente.ape1 = Convert.ToString(dr["apellido1"]);
                    cliente.ape2 = Convert.ToString(dr["apellido2"]);
                    cliente.cedula = Convert.ToString(dr["cedula"]);
                    cliente.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    cliente.direccion = Convert.ToString(dr["direccion"]);
                    cliente.edad = Convert.ToString(dr["edad"]);
                    cliente.sexo = Convert.ToChar(dr["sexo"]);
                    cliente.estado_civil = Convert.ToString(dr["estado_civil"]);
                    cliente.grupo_sanguineo = Convert.ToString(dr["grupo_sanguineo"]);
                    cliente.profesion = Convert.ToString(dr["profesion"]);
                    cliente.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    cliente.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    cliente.email = Convert.ToString(dr["email"]);
                    cliente.empresa = Convert.ToInt32(dr["empresa"]);

                    list.Add(cliente);
                }
                conn.Close();
            }
            return list;
        }

        //select cliente by id empresa
        public static List<PersonaEntity> selectClienteByIdEmpresa(int id_empresa)
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from persona where CAST(empresa AS VARCHAR(100)) LIKE ('" + id_empresa + "%')", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaEntity cliente = new PersonaEntity();

                    cliente.nombre = Convert.ToString(dr["nombre"]);
                    cliente.ape1 = Convert.ToString(dr["apellido1"]);
                    cliente.ape2 = Convert.ToString(dr["apellido2"]);
                    cliente.cedula = Convert.ToString(dr["cedula"]);
                    cliente.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    cliente.direccion = Convert.ToString(dr["direccion"]);
                    cliente.edad = Convert.ToString(dr["edad"]);
                    cliente.sexo = Convert.ToChar(dr["sexo"]);
                    cliente.estado_civil = Convert.ToString(dr["estado_civil"]);
                    cliente.grupo_sanguineo = Convert.ToString(dr["grupo_sanguineo"]);
                    cliente.profesion = Convert.ToString(dr["profesion"]);
                    cliente.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    cliente.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    cliente.email = Convert.ToString(dr["email"]);
                    cliente.empresa = Convert.ToInt32(dr["empresa"]);

                    list.Add(cliente);
                }
                conn.Close();
            }
            return list;
        }


        //selecciona los pacientes segun el medico
        public static List<PersonaEntity> selectClienteByIdMedico(string id_medico)
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM (SELECT cedula FROM expediente where cedula_medico='"+id_medico+"') AS a,persona b WHERE b.cedula = a.cedula;", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaEntity cliente = new PersonaEntity();

                    cliente.nombre = Convert.ToString(dr["nombre"]);
                    cliente.ape1 = Convert.ToString(dr["apellido1"]);
                    cliente.ape2 = Convert.ToString(dr["apellido2"]);
                    cliente.cedula = Convert.ToString(dr["cedula"]);
                    cliente.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    cliente.direccion = Convert.ToString(dr["direccion"]);
                    cliente.edad = Convert.ToString(dr["edad"]);
                    cliente.sexo = Convert.ToChar(dr["sexo"]);
                    cliente.estado_civil = Convert.ToString(dr["estado_civil"]);
                    cliente.grupo_sanguineo = Convert.ToString(dr["grupo_sanguineo"]);
                    cliente.profesion = Convert.ToString(dr["profesion"]);
                    cliente.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    cliente.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    cliente.email = Convert.ToString(dr["email"]);
                    cliente.empresa = Convert.ToInt32(dr["empresa"]);

                    list.Add(cliente);
                }
                conn.Close();
            }
            return list;
        }


        //me trae todo del cliente segun la cedula
        public static List<PersonaEntity> selectClientePorCedula(string cedula)
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();

            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from persona where cedula= @cedula", conn);
                cmd.Parameters.AddWithValue("@cedula", cedula);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaEntity cliente = new PersonaEntity();

                    cliente.nombre = Convert.ToString(dr["nombre"]);
                    cliente.ape1 = Convert.ToString(dr["apellido1"]);
                    cliente.ape2 = Convert.ToString(dr["apellido2"]);
                    cliente.cedula = Convert.ToString(dr["cedula"]);
                    cliente.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    cliente.direccion = Convert.ToString(dr["direccion"]);
                    cliente.edad = Convert.ToString(dr["edad"]);
                    cliente.sexo = Convert.ToChar(dr["sexo"]);
                    cliente.estado_civil = Convert.ToString(dr["estado_civil"]);
                    cliente.grupo_sanguineo = Convert.ToString(dr["grupo_sanguineo"]);
                    cliente.profesion = Convert.ToString(dr["profesion"]);
                    cliente.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    cliente.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    cliente.email = Convert.ToString(dr["email"]);
                    cliente.empresa = Convert.ToInt32(dr["empresa"]);

                    list.Add(cliente);
                }
                conn.Close();
            }
            return list;
        }

        //me trae todo del cliente segun la cedula
        public static List<PersonaEntity> selectClientePorFecha(string fecha)
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();

            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from persona where fecha_creacion= @fecha and medico=false order by apellido1", conn);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaEntity cliente = new PersonaEntity();

                    cliente.nombre = Convert.ToString(dr["nombre"]);
                    cliente.ape1 = Convert.ToString(dr["apellido1"]);
                    cliente.ape2 = Convert.ToString(dr["apellido2"]);
                    cliente.cedula = Convert.ToString(dr["cedula"]);
                    cliente.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    cliente.direccion = Convert.ToString(dr["direccion"]);
                    cliente.edad = Convert.ToString(dr["edad"]);
                    cliente.sexo = Convert.ToChar(dr["sexo"]);
                    cliente.estado_civil = Convert.ToString(dr["estado_civil"]);
                    cliente.grupo_sanguineo = Convert.ToString(dr["grupo_sanguineo"]);
                    cliente.profesion = Convert.ToString(dr["profesion"]);
                    cliente.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    cliente.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    cliente.email = Convert.ToString(dr["email"]);
                    cliente.empresa = Convert.ToInt32(dr["empresa"]);

                    list.Add(cliente);
                }
                conn.Close();
            }
            return list;
        }



        public static Boolean UpdateCliente(string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, string direccion, string edad, char sexo, string estado_civil, string grupo_sanguineo, string profesion,
            int telefono_fijo, int movil, string correo, int empresa, byte[] fotoBinaria, bool medico)
        {
            int x = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    string cadena = "update persona set nombre=@nombre, apellido1=@apellido1,apellido2=@apellido2," +
                    "fecha_nacimiento=@fecha_nacimiento,direccion=@direccion,edad=@edad,sexo=@sexo,estado_civil=@estado_civil, grupo_sanguineo=@grupo_sanguineo," +
                    "profesion=@profesion,telefono_fijo=@telefono_fijo,telefono_movil=@telefono_movil, email=@email," +
                    "empresa=@empresa, foto=@foto where cedula=@cedula";

                    command.CommandText = cadena;

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido1", apellido1);
                    command.Parameters.AddWithValue("@apellido2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@estado_civil", estado_civil);
                    command.Parameters.AddWithValue("@grupo_sanguineo", grupo_sanguineo);
                    command.Parameters.AddWithValue("@profesion", profesion);
                    command.Parameters.AddWithValue("@telefono_fijo", telefono_fijo);
                    command.Parameters.AddWithValue("@telefono_movil", movil);
                    command.Parameters.AddWithValue("@email", correo);
                    command.Parameters.AddWithValue("@empresa", empresa);
                    command.Parameters.AddWithValue("@foto", fotoBinaria);

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

        public static Boolean UpdateAdministrativo(string nombre, string apellido1, string apellido2, string cedula,
           DateTime fecha, string direccion, string edad, char sexo, string profesion,
           int telefono_fijo, int movil, string correo)
        {
            int x = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    string cadena = "update persona set nombre=@nombre, apellido1=@apellido1,apellido2=@apellido2," +
                    "fecha_nacimiento=@fecha_nacimiento,direccion=@direccion,edad=@edad,sexo=@sexo," +
                    "profesion=@profesion,telefono_fijo=@telefono_fijo,telefono_movil=@telefono_movil, email=@email," +
                    "fecha_update=@fecha_update where cedula=@cedula";

                    command.CommandText = cadena;

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido1", apellido1);
                    command.Parameters.AddWithValue("@apellido2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha_nacimiento", fecha);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@profesion", profesion);
                    command.Parameters.AddWithValue("@telefono_fijo", telefono_fijo);
                    command.Parameters.AddWithValue("@telefono_movil", movil);
                    command.Parameters.AddWithValue("@email", correo);
                    command.Parameters.AddWithValue("@fecha_update", DateTime.Now);

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

        //me muestra la imagen del cliente en la BD
        public static Image GetImagePacient(string cedula)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                try
                {
                    using (NpgsqlCommand pgCommand = new NpgsqlCommand("SELECT foto FROM persona WHERE cedula=@id;", conn))
                    {
                        pgCommand.Parameters.AddWithValue("@id", cedula);
                        try
                        {
                            conn.Open();
                            Byte[] productImageByte = (Byte[])pgCommand.ExecuteScalar();
                            if (productImageByte != null)
                            {
                                using (Stream productImageStream = new System.IO.MemoryStream(productImageByte))
                                {
                                    return Image.FromStream(productImageStream);
                                }
                            }
                        }
                        catch (Exception x)
                        {
                            return null;
                        }
                    }
                }
                catch
                {
                    return null;
                }
                conn.Close();
            }
            return null;
        }

        //////////////////////////////////////////////////////////////////////////////
        public static Boolean InsertaMedico(string nombre, string apellido1, string apellido2, string cedula,
           DateTime fecha, string direccion, string edad, char sexo, int telefono1, int telefono2, string correo,
             byte[] foto, int codigo, string universidad, int especialidad, bool medico)
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
                        "insert into persona(nombre,apellido1,apellido2,cedula,fecha_nacimiento,direccion,edad,sexo," +
                    "telefono_fijo,telefono_movil,email,foto,codigo,universidad,especialidad,medico)" +
                        "values (@nombre,@ape1,@ape2,@cedula,@fecha,@direccion,@edad,@sexo,@telefono_fijo,@telefono_movil,@correo,@foto,@codigo,@universidad,@especialidad,@medico)";

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@ape1", apellido1);
                    command.Parameters.AddWithValue("@ape2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@telefono_fijo", telefono1);
                    command.Parameters.AddWithValue("@telefono_movil", telefono2);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@foto", foto);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@universidad", universidad);
                    command.Parameters.AddWithValue("@especialidad", especialidad);
                    command.Parameters.AddWithValue("@medico", medico);

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

        //metodo que edita la informacion


        public static Boolean UpdateMedico(string nombre, string apellido1, string apellido2, string cedula,
           DateTime fecha, string direccion, string edad, char sexo, int telefono1, int telefono2, string correo, byte[] foto,
            int codigo, string universidad, int especialidad)
        {
            int x = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    string cadena = "update persona set nombre=@nombre, apellido1=@ape1,apellido2=@ape2," +
                    "fecha_nacimiento= @fecha,direccion=@direccion,edad=@edad, sexo=@sexo,codigo=@codigo,universidad=@universidad, especialidad=@especialidad,email=@correo, " +
                    "telefono_fijo=@telefono_fijo, telefono_movil=@telefono_movil, foto=@foto where cedula=@cedula";
                    command.CommandText = cadena;

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@ape1", apellido1);
                    command.Parameters.AddWithValue("@ape2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@universidad", universidad);
                    command.Parameters.AddWithValue("@especialidad", especialidad);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@telefono_fijo", telefono1);
                    command.Parameters.AddWithValue("@telefono_movil", telefono2);
                    command.Parameters.AddWithValue("@foto", foto);

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

        //metodo que elimina la informacion
        public static Boolean deletePersona(string cedula)
        {
            int x = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                conn.Open();
                try
                {
                    string cadena = "delete from persona where cedula=@cedula";
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
                }            }
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
        //metodo get all de medicos
        public static List<PersonaEntity> selectMedico()
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from persona where medico=true order by apellido1", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaEntity doctor = new PersonaEntity();
                    doctor.nombre = Convert.ToString(dr["nombre"]);
                    doctor.ape1 = Convert.ToString(dr["apellido1"]);
                    doctor.ape2 = Convert.ToString(dr["apellido2"]);
                    doctor.cedula = Convert.ToString(dr["cedula"]);
                    doctor.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    doctor.direccion = Convert.ToString(dr["direccion"]);
                    doctor.edad = Convert.ToString(dr["edad"]);
                    doctor.sexo = Convert.ToChar(dr["sexo"]);
                    doctor.codigo = Convert.ToInt32(dr["codigo"]);
                    doctor.universidad = Convert.ToString(dr["universidad"]);
                    doctor.especialidad = Convert.ToString(dr["especialidad"]);
                    doctor.email = Convert.ToString(dr["email"]);
                    doctor.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    doctor.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    //falta la foto
                    list.Add(doctor);
                }
                conn.Close();
            }
            return list;
        }



        //metodo get all de medicos - Dr Admin
        public static List<PersonaEntity> selectMedicoLess()
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from persona where medico=true and cedula!='k' order by apellido1", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaEntity doctor = new PersonaEntity();
                    doctor.nombre = Convert.ToString(dr["nombre"]);
                    doctor.ape1 = Convert.ToString(dr["apellido1"]);
                    doctor.ape2 = Convert.ToString(dr["apellido2"]);
                    doctor.cedula = Convert.ToString(dr["cedula"]);
                    doctor.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    doctor.direccion = Convert.ToString(dr["direccion"]);
                    doctor.edad = Convert.ToString(dr["edad"]);
                    doctor.sexo = Convert.ToChar(dr["sexo"]);
                    doctor.codigo = Convert.ToInt32(dr["codigo"]);
                    doctor.universidad = Convert.ToString(dr["universidad"]);
                    doctor.especialidad = Convert.ToString(dr["especialidad"]);
                    doctor.email = Convert.ToString(dr["email"]);
                    doctor.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    doctor.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    //falta la foto
                    list.Add(doctor);
                }
                conn.Close();
            }
            return list;
        }

        //metodo get all de medicos
        public static List<PersonaEntity> selectMedico2(string cedula)
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from persona where cedula=@cedula", conn);
                cmd.Parameters.AddWithValue("@cedula", cedula);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaEntity doctor = new PersonaEntity();
                    doctor.nombre = Convert.ToString(dr["nombre"]);
                    doctor.ape1 = Convert.ToString(dr["apellido1"]);
                    doctor.ape2 = Convert.ToString(dr["apellido2"]);
                    doctor.cedula = Convert.ToString(dr["cedula"]);
                    doctor.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    doctor.direccion = Convert.ToString(dr["direccion"]);
                    doctor.edad = Convert.ToString(dr["edad"]);
                    doctor.sexo = Convert.ToChar(dr["sexo"]);
                    doctor.codigo = Convert.ToInt32(dr["codigo"]);
                    doctor.universidad = Convert.ToString(dr["universidad"]);
                    doctor.especialidad = Convert.ToString(dr["especialidad"]);
                    doctor.email = Convert.ToString(dr["email"]);
                    doctor.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    doctor.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);

                    list.Add(doctor);
                }
                conn.Close();
            }
            return list;
        }

        //metodo get all de medicos
        public static List<PersonaEntity> selectAdministrativo()
        {
            //creacion de lista tipo medico entity
            List<PersonaEntity> list = new List<PersonaEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT persona.*,usuario.tipo_usuario, usuario.cedula " +
                    "FROM persona,usuario WHERE persona.cedula=usuario.cedula and usuario.tipo_usuario=1 order by apellido1", conn);

                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PersonaEntity doctor = new PersonaEntity();
                    doctor.nombre = Convert.ToString(dr["nombre"]);
                    doctor.ape1 = Convert.ToString(dr["apellido1"]);
                    doctor.ape2 = Convert.ToString(dr["apellido2"]);
                    doctor.cedula = Convert.ToString(dr["cedula"]);
                    doctor.fecha = Convert.ToDateTime(dr["fecha_nacimiento"]);
                    doctor.direccion = Convert.ToString(dr["direccion"]);
                    doctor.edad = Convert.ToString(dr["edad"]);
                    doctor.sexo = Convert.ToChar(dr["sexo"]);
                    doctor.profesion = Convert.ToString(dr["profesion"]);
                    doctor.telefono_fijo = Convert.ToInt32(dr["telefono_fijo"]);
                    doctor.telefono_movil = Convert.ToInt32(dr["telefono_movil"]);
                    doctor.email = Convert.ToString(dr["email"]);

                    list.Add(doctor);
                }
                conn.Close();
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
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT apellido1 FROM persona WHERE cedula = @cedula", conn);
                //cmd.CommandTimeout = 20;

                cmd.Parameters.AddWithValue("@cedula", cedula);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    apellido = Convert.ToString(dr["apellido1"]);
                }
                conn.Close();
            }
            return apellido;
        }


        //me muestra la imagen del cliente en la BD
        public static Image GetImageMedico(string cedula)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                try
                {
                    using (NpgsqlCommand pgCommand = new NpgsqlCommand("SELECT foto FROM persona WHERE cedula=@id;", conn))
                    {
                        pgCommand.Parameters.AddWithValue("@id", cedula);
                        try
                        {
                            conn.Open();
                            var x = pgCommand.ExecuteScalar();

                            if (pgCommand.ExecuteScalar() != null)
                            {
                                Byte[] productImageByte = (Byte[])pgCommand.ExecuteScalar();
                                if (productImageByte != null)
                                {
                                    using (Stream productImageStream = new System.IO.MemoryStream(productImageByte))
                                    {
                                        return Image.FromStream(productImageStream);
                                    }
                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                        catch (Exception x)
                        {
                            return null;
                        }
                    }
                }
                catch
                {
                    return null;
                }
                conn.Close();
            }
            return null;
        }

    }

}
