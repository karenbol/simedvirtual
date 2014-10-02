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
                    "diagnostico,terapeutica,observaciones_generales,cedula,cedula_medico) " +
                    "values(@pulso,@presion_arterial,@soplos,@dolor_precordial,@edemas,@arritmias,@disnea,@observaciones_sc," +
                    "@talla,@peso,@observaciones_sm,@brazo_derecho,@brazo_izquierdo,@pierna_derecha,@pierna_izquierda," +
                    "@bicipal_derecho,@bicipal_izquierdo,@patelar_derecho,@patelar_izquierdo,@alquileano_derecho,"
                    + "@alquileano_izquierdo,@flexion,@extensiones,@rotacion,@inclinacion_lateral,@observaciones_cc," +
                    "@malformaciones,@observaciones_dl,@observaciones_dl_txt,@petequias,@equimosis,@sangrado," +
                    "@observaciones_sh,@examen_neurologico,@orl,@abdomen,@auscultacion,@observaciones_sr,@convulciones," +
                    "@espasmos,@temblores,@movimientos_anormales,@otros_sn,@observaciones_sn,@otros_examen2," +
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
                    command.Parameters.AddWithValue("@equimosis", equimosis);
                    command.Parameters.AddWithValue("@sangrado", sangrado);
                    command.Parameters.AddWithValue("@observaciones_sh", observaciones_sh);
                    command.Parameters.AddWithValue("@examen_neurologico", examen_neurologico);
                    command.Parameters.AddWithValue("@orl", orl);
                    command.Parameters.AddWithValue("@abdomen", abdomen);
                    command.Parameters.AddWithValue("@auscultacion", auscultacion);
                    command.Parameters.AddWithValue("@observaciones_sr", observaciones_sr);
                    command.Parameters.AddWithValue("@convulciones", convulciones);
                    command.Parameters.AddWithValue("@espasmos", espasmos);
                    command.Parameters.AddWithValue("@temblores", temblores);
                    command.Parameters.AddWithValue("@movimientos_anormales", movimientos_anormales);
                    command.Parameters.AddWithValue("@otros_sn", otros_sn);
                    command.Parameters.AddWithValue("@observaciones_sn", observaciones_sn);
                    command.Parameters.AddWithValue("@otros_examen2", otros_examen2);

                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@diagnostico", diagnostico);
                    command.Parameters.AddWithValue("@terapeutica", terapeutica);
                    command.Parameters.AddWithValue("@observaciones_generales", observaciones_generales);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@cedula_medico", cedula_medico);

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

        //metodo get de reconsultas segun la cedula del paciente
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

                    expediente.cedula = Convert.ToString(dr["cedula"]);
                    expediente.fecha = Convert.ToDateTime(dr["fecha"]);
                    expediente.cedula_medico = Convert.ToString(dr["cedula_medico"]);
                    expediente.diagnostico = Convert.ToString(dr["diagnostico"]);
                    expediente.terapeutica = Convert.ToString(dr["terapeutica"]);
                    expediente.observaciones_generales = Convert.ToString(dr["observaciones_generales"]);

                    list.Add(expediente);
                }
            }
            return list;
        }


        //metodo get de expediete segun la cedula del paciente
        public static List<ExpedienteEntity> selectExpedienteAll(string cedula_cliente)
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

                    expediente.pulso = Convert.ToString(dr["pulso"]);
                    expediente.presion_arterial = Convert.ToString(dr["presion_arterial"]);
                    expediente.soplos = Convert.ToChar(dr["soplos"]);
                    expediente.dolor_precordial = Convert.ToChar(dr["dolor_precordial"]);
                    expediente.edemas = Convert.ToChar(dr["edemas"]);
                    expediente.arritmias = Convert.ToChar(dr["arritmias"]);
                    expediente.disnea = Convert.ToChar(dr["disnea"]);
                    expediente.observaciones_sc = Convert.ToString(dr["observaciones_sc"]);
                    expediente.talla = Convert.ToString(dr["talla"]);
                    expediente.peso = Convert.ToString(dr["peso"]);
                    expediente.observaciones_sm = Convert.ToString(dr["observaciones_sm"]);
                    expediente.brazo_derecho = Convert.ToString(dr["brazo_derecho"]);
                    expediente.brazo_izquierdo = Convert.ToString(dr["brazo_izquierdo"]);
                    expediente.pierna_derecha = Convert.ToString(dr["pierna_derecha"]);
                    expediente.pierna_izquierda = Convert.ToString(dr["pierna_izquierda"]);

                    expediente.bicipal_derecho = Convert.ToChar(dr["bicipal_derecho"]);
                    expediente.bicipal_izquierdo = Convert.ToChar(dr["bicipal_izquierdo"]);
                    expediente.patelar_derecho = Convert.ToChar(dr["patelar_derecho"]);
                    expediente.patelar_izquierdo = Convert.ToChar(dr["patelar_izquierdo"]);
                    expediente.alquileano_derecho = Convert.ToChar(dr["alquileano_derecho"]);
                    expediente.alquileano_izquierdo = Convert.ToChar(dr["alquileano_izquierdo"]);

                    expediente.flexion = Convert.ToChar(dr["flexion"]);
                    expediente.extensiones = Convert.ToChar(dr["extensiones"]);
                    expediente.rotacion = Convert.ToChar(dr["rotacion"]);
                    expediente.inclinacion_lateral = Convert.ToChar(dr["inclinacion_lateral"]);

                    expediente.observaciones_cc = Convert.ToString(dr["observaciones_cc"]);
                    expediente.malformaciones = Convert.ToString(dr["malformaciones"]);

                    expediente.observaciones_dl = Convert.ToChar(dr["observaciones_dl"]);
                    expediente.observaciones_dl_txt = Convert.ToString(dr["observaciones_dl_txt"]);
                    expediente.petequias = Convert.ToChar(dr["petequias"]);
                    expediente.equimosis = Convert.ToChar(dr["equimosis"]);
                    expediente.sangrado = Convert.ToChar(dr["sangrado"]);

                    expediente.observaciones_sh = Convert.ToString(dr["observaciones_sh"]);
                    expediente.examen_neurologico = Convert.ToString(dr["examen_neurologico"]);
                    expediente.orl = Convert.ToString(dr["orl"]);
                    expediente.abdomen = Convert.ToString(dr["abdomen"]);

                    expediente.auscultacion = Convert.ToChar(dr["auscultacion"]);
                    expediente.observaciones_sr = Convert.ToString(dr["observaciones_sr"]);
                    expediente.convulciones = Convert.ToChar(dr["convulciones"]);
                    expediente.espasmos = Convert.ToChar(dr["espasmos"]);
                    expediente.temblores = Convert.ToChar(dr["temblores"]);
                    expediente.movimientos_anormales = Convert.ToChar(dr["movimientos_anormales"]);

                    expediente.otros_sn = Convert.ToString(dr["otros_sn"]);
                    expediente.observaciones_sn = Convert.ToString(dr["observaciones_sn"]);
                    expediente.otros_examen2 = Convert.ToString(dr["otros_examen2"]);

                    expediente.fecha = Convert.ToDateTime(dr["fecha"]);
                    expediente.diagnostico = Convert.ToString(dr["diagnostico"]);
                    expediente.terapeutica = Convert.ToString(dr["terapeutica"]);
                    expediente.observaciones_generales = Convert.ToString(dr["observaciones_generales"]);
                    expediente.cedula = Convert.ToString(dr["cedula"]);
                    expediente.cedula_medico = Convert.ToString(dr["cedula_medico"]);

                    list.Add(expediente);
                }
            }
            return list;
        }
    }
}
//expediente.pulso = Convert.ToString(dr["pulso"]);
//expediente.presion_arterial = Convert.ToString(dr["presion_arterial"]);
//expediente.soplos = Convert.ToChar(dr["soplos"]);
//expediente.dolor_precordial = Convert.ToChar(dr["dolor_precordial"]);
//expediente.edemas = Convert.ToChar(dr["edemas"]);
//expediente.arritmias = Convert.ToChar(dr["arritmias"]);
//expediente.disnea = Convert.ToChar(dr["disnea"]);
//expediente.observaciones_sc = Convert.ToString(dr["observaciones_sc"]);
//expediente.talla = Convert.ToString(dr["talla"]);
//expediente.peso = Convert.ToString(dr["peso"]);
//expediente.observaciones_sm = Convert.ToString(dr["observaciones_sm"]);
//expediente.brazo_derecho = Convert.ToString(dr["brazo_derecho"]);
//expediente.brazo_izquierdo = Convert.ToString(dr["brazo_izquierdo"]);
//expediente.pierna_derecha = Convert.ToString(dr["pierna_derecha"]);
//expediente.pierna_izquierda = Convert.ToString(dr["pierna_izquierda"]);

//expediente.bicipal_derecho = Convert.ToChar(dr["bicipal_derecho"]);
//expediente.bicipal_izquierdo = Convert.ToChar(dr["bicipal_izquierdo"]);
//expediente.patelar_derecho = Convert.ToChar(dr["patelar_derecho"]);
//expediente.patelar_izquierdo = Convert.ToChar(dr["patelar_izquierdo"]);
//expediente.alquileano_derecho = Convert.ToChar(dr["alquileano_derecho"]);
//expediente.alquileano_izquierdo = Convert.ToChar(dr["alquileano_izquierdo"]);

//expediente.flexion = Convert.ToChar(dr["flexion"]);
//expediente.extensiones = Convert.ToChar(dr["extensiones"]);
//expediente.rotacion = Convert.ToChar(dr["rotacion"]);
//expediente.inclinacion_lateral = Convert.ToChar(dr["inclinacion_lateral"]);

//expediente.observaciones_cc = Convert.ToString(dr["observaciones_cc"]);
//expediente.malformaciones = Convert.ToString(dr["malformaciones"]);

//expediente.observaciones_dl = Convert.ToChar(dr["observaciones_dl"]);
//expediente.observaciones_dl_txt = Convert.ToString(dr["observaciones_dl_txt"]);
//expediente.petequias = Convert.ToChar(dr["petequias"]);
//expediente.equimosis = Convert.ToChar(dr["equimosis"]);
//expediente.sangrado = Convert.ToChar(dr["sangrado"]);

//expediente.observaciones_sh = Convert.ToString(dr["observaciones_sh"]);
//expediente.examen_neurologico = Convert.ToString(dr["examen_neurologico"]);
//expediente.orl = Convert.ToString(dr["orl"]);
//expediente.abdomen = Convert.ToString(dr["abdomen"]);

//expediente.auscultacion = Convert.ToChar(dr["auscultacion"]);
//expediente.observaciones_sr = Convert.ToString(dr["observaciones_sr"]);
//expediente.convulciones = Convert.ToChar(dr["convulciones"]);
//expediente.espasmos = Convert.ToChar(dr["espasmos"]);
//expediente.temblores = Convert.ToChar(dr["temblores"]);
//expediente.movimientos_anormales = Convert.ToChar(dr["movimientos_anormales"]);

//expediente.otros_sn = Convert.ToString(dr["otros_sn"]);
//expediente.observaciones_sn = Convert.ToString(dr["observaciones_sn"]);
//expediente.otros_examen2 = Convert.ToString(dr["otros_examen2"]);