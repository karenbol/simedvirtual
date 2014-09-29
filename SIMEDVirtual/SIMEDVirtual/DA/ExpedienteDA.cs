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
        public static Boolean InsertaExpediente(
            string pulso, string presion_arterial, char soplos, char dolor_precordia, char edemas, char arritmias, char disnea,
        string observaciones_sc, string talla, string peso, string observaciones_sm, string brazo_derecho, string brazo_izquierdo,
        string pierna_derecha, string pierna_izquierda, char bicipal_derecho, char bicipal_izquierdo, char patelar_derecho,
         char patelar_izquierdo, char alquileano_derecho, char alquileano_izquierdo, char flexion, char extensiones,
         char rotacion, char inclinacion_lateral, string observaciones_cc, string malformaciones, char observaciones_dl,
         string observaciones_dl_txt, char petequias, char equimosis, char sangrado, string observaciones_sh, string examen_neurologico,
         string orl, string abdomen, char auscultacion, string observaciones_sr, char convulciones, char espasmos, char temblores,
         char movimientos_anormales, string otros_sn, string observaciones_sn, string otros_examen2, DateTime fecha,
         string diagnostico, string terapeutica, string observaciones_generales, string cedula, string cedula_medico)
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
                        "insert into expediente(pulso,presion_arterial,soplos,dolor_precordial,edemas,arritmias,disnea,observaciones_sc,"
                    + "talla,peso,observaciones_sm,brazo_derecho,brazo_izquierdo,pierna_derecha,pierna_izquierda,bicipal_derecho," +
                    "bicipal_izquierdo,patelar_derecho,patelar_izquierdo,alquileano_derecho,alquileano_izquierdo,flexion,extensiones," +
                    "rotacion,inclinacion_lateral,observaciones_cc,malformaciones,observaciones_dl,observaciones_dl_txt,"
                    + "petequias,equimosis,sangrado,observaciones_sh,examen_neurologico,orl,abdomen,auscultacion,observaciones_sr," +
                    "convulciones,espasmos,temblores,movimientos_anormales,otros_sn,observaciones_sn,otros_examen2,fecha," +
                    "diagnostico,terapeutica,observaciones_generales,cedula,cedula_medico) "+
                    "values(@pulso,@presion_arterial,@soplos,@dolor_precordial,@edemas,@arritmias,@disnea,@observaciones_sc,"+
                    "@talla,@peso,@observaciones_sm,@brazo_derecho,@brazo_izquierdo,@pierna_derecha,@pierna_izquierda,"+
                    "@bicipal_derecho,@bicipal_izquierdo,@patelar_derecho,@patelar_izquierdo,@alquileano_derecho,"
                    + "@alquileano_izquierdo,@flexion,@extensiones,@rotacion,@inclinacion_lateral,@observaciones_cc,"+
                    "@malformaciones,@observaciones_dl,@observaciones_dl_txt,@petequias,@equimosis,@sangrado,"+
                    "@observaciones_sh,@examen_neurologico,@orl,@abdomen,@auscultacion,@observaciones_sr,@convulciones,"+
                    "@espasmos,@temblores,@movimientos_anormales,@otros_sn,@observaciones_sn,@otros_examen2,"+
                    "@fecha,@diagnostico,@terapeutica,@observaciones_generales,@cedula,@cedula_medico)";

                    command.Parameters.AddWithValue("@pulso", pulso);
                    command.Parameters.AddWithValue("@presion_arterial", presion_arterial);
                    command.Parameters.AddWithValue("@soplos", soplos);
                    command.Parameters.AddWithValue("@dolor_precordial", dolor_precordia);
                    command.Parameters.AddWithValue("@edemas", edemas);
                    command.Parameters.AddWithValue("@arritmias", arritmias);
                    command.Parameters.AddWithValue("@disnea", disnea);
                    command.Parameters.AddWithValue("@observaciones_sc", observaciones_sc);
                    command.Parameters.AddWithValue("@talla", talla);
                    command.Parameters.AddWithValue("@peso", peso);
                    command.Parameters.AddWithValue("@observaciones_sm", observaciones_sm);
                    command.Parameters.AddWithValue("@brazo_derecho", brazo_derecho);
                    command.Parameters.AddWithValue("@brazo_izquierdo", brazo_izquierdo);
                    command.Parameters.AddWithValue("@pierna_derecha", pierna_derecha);
                    command.Parameters.AddWithValue("@pierna_izquierda", pierna_izquierda);
                    command.Parameters.AddWithValue("@bicipal_derecho", bicipal_derecho);
                    command.Parameters.AddWithValue("@bicipal_izquierdo", bicipal_izquierdo);
                    command.Parameters.AddWithValue("@patelar_derecho", patelar_derecho);
                    command.Parameters.AddWithValue("@patelar_izquierdo", patelar_izquierdo);
                    command.Parameters.AddWithValue("@alquileano_derecho", alquileano_derecho);
                    command.Parameters.AddWithValue("@alquileano_izquierdo", alquileano_izquierdo);
                    command.Parameters.AddWithValue("@flexion", flexion);
                    command.Parameters.AddWithValue("@extensiones", extensiones);
                    command.Parameters.AddWithValue("@rotacion", rotacion);
                    command.Parameters.AddWithValue("@inclinacion_lateral", inclinacion_lateral);
                    command.Parameters.AddWithValue("@observaciones_cc", observaciones_cc);
                    command.Parameters.AddWithValue("@malformaciones", malformaciones);
                    command.Parameters.AddWithValue("@observaciones_dl", observaciones_dl);
                    command.Parameters.AddWithValue("@observaciones_dl_txt", observaciones_dl_txt);
                    command.Parameters.AddWithValue("@petequias", petequias);
                    command.Parameters.AddWithValue("@equimosis", petequias);
                    command.Parameters.AddWithValue("@sangrado", petequias);
                    command.Parameters.AddWithValue("@observaciones_sh", petequias);
                    command.Parameters.AddWithValue("@examen_neurologico", petequias);
                    command.Parameters.AddWithValue("@orl", petequias);
                    command.Parameters.AddWithValue("@abdomen", petequias);
                    command.Parameters.AddWithValue("@auscultacion", petequias);
                    command.Parameters.AddWithValue("@observaciones_sr", petequias);
                    command.Parameters.AddWithValue("@convulciones", petequias);
                    command.Parameters.AddWithValue("@espasmos", petequias);
                    command.Parameters.AddWithValue("@temblores", petequias);
                    command.Parameters.AddWithValue("@movimientos_anormales", petequias);
                    command.Parameters.AddWithValue("@otros_sn", petequias);
                    command.Parameters.AddWithValue("@observaciones_sn", petequias);
                    command.Parameters.AddWithValue("@otros_examen2", petequias);

                    command.Parameters.AddWithValue("@fecha", petequias);
                    command.Parameters.AddWithValue("@diagnostico", petequias);
                    command.Parameters.AddWithValue("@terapeutica", petequias);
                    command.Parameters.AddWithValue("@observaciones_generales", petequias);
                    command.Parameters.AddWithValue("@cedula", petequias);
                    command.Parameters.AddWithValue("@cedula_medico", petequias);


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

        //metodo get all de reconsultas
        public static List<ExpedienteEntity> selectExpediente(string cedula_cliente)
        {
            //creacion de lista tipo medico entity
            List<ExpedienteEntity> list = new List<ExpedienteEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from expediente where cedula = @cedula", conn);

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
