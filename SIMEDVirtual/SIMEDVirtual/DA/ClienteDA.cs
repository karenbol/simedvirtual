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
            int telefono_fijo, int movil, string correo, string direccion,
            char tabaquismo, char ingesta_medicamentos, char alcoholismo, char rehabilitacion, char diabetes,
            char hipertension, char dolor_cabeza, char epilepsia,
            char vertigo, char depresion, char falta_aire, char ojos_oidos, char dolor_pecho, char enf_nerviosas,
            char alergias, string alergia_tratamiento, string diabetes_trat, string hipertension_trat, char asma,
            string asma_trat, char tiroides, string tiroides_trat, string hipertension_heredo, string diabetes_heredo,
            string cancer_heredo, string tiroides_heredo, string asma_heredo, string otros_heredo, string edad, string empresa, string observaciones)
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
                    "estado_civil,grupo_sanguineo,profesion,telefono_fijo,telefono_movil,email,direccion," +
                    "tabaquismo,ingesta_med,alcoholismo,rehabilitacion,diabetes,hipertension," +
                    "dolor_cabeza,epilepsia,vertigo,depresion,falta_aire,enf_ojos_oidos,dolor_pecho,enf_nerviosas," +
                    "alergias,alergia_tratamiento,diabetes_trat,hipertension_trat,asma,asma_trat,tiroides,tiroides_trat," +
                    "hipertension_heredo,diabetes_heredo,cancer_heredo,tiroides_heredo,asma_heredo,otros_heredo,edad,empresa,observaciones) " +
                    "values (@nombre,@ape1,@ape2,@cedula,@fecha,@sexo,@estado,@grupo,@profesion,@telefono,@movil,@email,@direccion," +
                    "@tabaquismo,@ingesta_med,@alcoholismo,@rehabilitacion,@diabetes,@hipertension,@dolor_cabeza," +
                    "@epilepsia,@vertigo,@depresion,@falta_aire,@ojos_oidos,@dolor_pecho,@enf_nerviosas," +
                    "@alergias,@alergia_tratamiento,@diabetes_trat,@hipertension_trat,@asma,@asma_trat,@tiroides,@tiroides_trat," +
                    "@hipertension_heredo,@diabetes_heredo,@cancer_heredo,@tiroides_heredo,@asma_heredo,@otros_heredo,@edad,@empresa,@observaciones)";


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
                    command.Parameters.AddWithValue("@tabaquismo", tabaquismo);
                    command.Parameters.AddWithValue("@ingesta_med", ingesta_medicamentos);
                    command.Parameters.AddWithValue("@alcoholismo", alcoholismo);
                    command.Parameters.AddWithValue("@rehabilitacion", rehabilitacion);
                    command.Parameters.AddWithValue("@diabetes", diabetes);
                    command.Parameters.AddWithValue("@hipertension", hipertension);
                    command.Parameters.AddWithValue("@dolor_cabeza", dolor_cabeza);
                    command.Parameters.AddWithValue("@epilepsia", epilepsia);
                    command.Parameters.AddWithValue("@vertigo", vertigo);
                    command.Parameters.AddWithValue("@depresion", depresion);
                    command.Parameters.AddWithValue("@falta_aire", falta_aire);
                    command.Parameters.AddWithValue("@ojos_oidos", ojos_oidos);
                    command.Parameters.AddWithValue("@dolor_pecho", dolor_pecho);
                    command.Parameters.AddWithValue("@enf_nerviosas", enf_nerviosas);
                    command.Parameters.AddWithValue("@alergias", alergias);
                    command.Parameters.AddWithValue("@alergia_tratamiento", alergia_tratamiento);
                    command.Parameters.AddWithValue("@diabetes_trat", diabetes_trat);
                    command.Parameters.AddWithValue("@hipertension_trat", hipertension_trat);
                    command.Parameters.AddWithValue("@asma", asma);
                    command.Parameters.AddWithValue("@asma_trat", asma_trat);
                    command.Parameters.AddWithValue("@tiroides", tiroides);
                    command.Parameters.AddWithValue("@tiroides_trat", tiroides_trat);
                    command.Parameters.AddWithValue("@hipertension_heredo", hipertension_heredo);
                    command.Parameters.AddWithValue("@diabetes_heredo", diabetes_heredo);
                    command.Parameters.AddWithValue("@cancer_heredo", cancer_heredo);
                    command.Parameters.AddWithValue("@tiroides_heredo", tiroides_heredo);
                    command.Parameters.AddWithValue("@asma_heredo", asma_heredo);
                    command.Parameters.AddWithValue("@otros_heredo", otros_heredo);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@empresa", empresa);
                    command.Parameters.AddWithValue("@observaciones", observaciones);

                    x = command.ExecuteNonQuery();
                }

                catch (Exception exp)
                {
                    g = exp.ToString();
                    Console.Write(g);
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
            }
            return list;
        }

        //me trae todo del cliente segun la cedula
        public static List<ClienteEntity> selectClienteAnamnesis(string cedula)
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

                    //anamnesis
                    cliente.tabaquismo = Convert.ToChar(dr["tabaquismo"]);
                    cliente.ingesta_medicamentos = Convert.ToChar(dr["ingesta_med"]);
                    cliente.alcoholismo = Convert.ToChar(dr["alcoholismo"]);
                    cliente.rehabilitacion = Convert.ToChar(dr["rehabilitacion"]);
                    cliente.diabetes = Convert.ToChar(dr["diabetes"]);
                    cliente.hipertension = Convert.ToChar(dr["hipertension"]);
                    cliente.dolor_Cabeza = Convert.ToChar(dr["dolor_cabeza"]);
                    cliente.epilepsia = Convert.ToChar(dr["epilepsia"]);
                    cliente.vertigo = Convert.ToChar(dr["vertigo"]);
                    cliente.depre = Convert.ToChar(dr["depresion"]);
                    cliente.falta_aire = Convert.ToChar(dr["falta_aire"]);
                    cliente.enf_ojos_oidos = Convert.ToChar(dr["enf_ojos_oidos"]);
                    cliente.dolor_pecho = Convert.ToChar(dr["dolor_pecho"]);
                    cliente.enf_nerviosas = Convert.ToChar(dr["enf_nerviosas"]);
                    cliente.alergias = Convert.ToChar(dr["alergias"]);
                    cliente.alergias_tratamiento = Convert.ToString(dr["alergia_tratamiento"]);
                    cliente.diabetes_trat = Convert.ToString(dr["diabetes_trat"]);
                    cliente.hipertension_trat = Convert.ToString(dr["hipertension_trat"]);
                    cliente.asma = Convert.ToChar(dr["asma"]);
                    cliente.asma_tratamiento = Convert.ToString(dr["asma_trat"]);
                    cliente.tiroides = Convert.ToChar(dr["tiroides"]);
                    cliente.tiroides_tratamiento = Convert.ToString(dr["tiroides_trat"]);

                    cliente.hipertension_heredo = Convert.ToString(dr["hipertension_heredo"]);
                    cliente.diabetes_heredo = Convert.ToString(dr["diabetes_heredo"]);
                    cliente.cancer_heredo = Convert.ToString(dr["cancer_heredo"]);
                    cliente.tiroides_heredo = Convert.ToString(dr["tiroides_heredo"]);
                    cliente.asma_heredo = Convert.ToString(dr["asma_heredo"]);
                    cliente.otros_heredo = Convert.ToString(dr["otros_heredo"]);
                    cliente.edad = Convert.ToString(dr["edad"]);
                    cliente.empresa = Convert.ToString(dr["empresa"]);

                    cliente.observaciones = Convert.ToString(dr["observaciones"]);
                                      
                    list.Add(cliente);
                }
            }
            return list;
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
