using Npgsql;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class EspecialidadDA
    {
        // retorna todas las especialidades para mostrarlas en un combo box
        public static List<EspecialidadEntity> getAllEspecialidades()
        {
            List<EspecialidadEntity> especialidad = new List<EspecialidadEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from especialidad order by nombre_especialidad",
    conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EspecialidadEntity esp = new EspecialidadEntity();
                    esp.id = Convert.ToInt32(dr[0]);
                    esp.nombre = Convert.ToString(dr[1]);
                    especialidad.Add(esp);
                }
                conn.Close();
            }
            return especialidad;
        }
    }
}
