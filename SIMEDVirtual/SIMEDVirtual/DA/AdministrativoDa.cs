using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class AdministrativoDa
    {
        public static Boolean InsertaAdm(string nombre, string apellido1, string apellido2, int cedula,
            string direccion, Char sexo, string puesto, DateTime fecha)
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
                        "insert into administrativos values (@nombre,@ape1,@ape2,@cedula,@direccion,@sexo,@puesto,@fecha)";
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@ape1", apellido1);
                    command.Parameters.AddWithValue("@ape2", apellido2);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@puesto", puesto);
                    command.Parameters.AddWithValue("@fecha", fecha);

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
