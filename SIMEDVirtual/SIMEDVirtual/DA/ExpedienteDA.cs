using Npgsql;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class ExpedienteDA
    {
        //inserta datos en la tabla expediente
        public static Boolean InsertaExpediente(string cedulaPaciente, DateTime fechaConsulta, string terapeutica, string observaciones)
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
                        "insert into expediente(cedula_paciente,fecha_consulta,terapeutica,observaciones) values(@cedula,@fecha,@terapeutica,@observaciones)";

                    command.Parameters.AddWithValue("@cedula", cedulaPaciente);
                    command.Parameters.AddWithValue("@fecha", fechaConsulta);
                    command.Parameters.AddWithValue("@terapeutica", terapeutica);
                    command.Parameters.AddWithValue("@observaciones", observaciones);

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

        //comentarios ade prueba bitbucked
        //////al precer no funciona

        //metodo get all de reconsultas
        public static List<ExpedienteEntity> selectExpediente(string cedula_cliente)
        {
            //creacion de lista tipo medico entity
            List<ExpedienteEntity> list = new List<ExpedienteEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from expediente where cedula_paciente = @cedula", conn);

                cmd.Parameters.AddWithValue("@cedula", cedula_cliente);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ExpedienteEntity expediente = new ExpedienteEntity();
                    expediente.fecha_consulta = Convert.ToDateTime(dr["fecha_consulta"]);
                    expediente.terapeutica = Convert.ToString(dr["terapeutica"]);
                    expediente.observaciones = Convert.ToString(dr["observaciones"]);
                    list.Add(expediente);
                }
            }
            return list;
        }



    }
}
