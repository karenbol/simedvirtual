using Npgsql;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class anamnesisDa
    {
        //inserta datos en la tabla clientes
        public static Boolean InsertaAnamnesis(
            string cedula, char tabaquismo, char ingesta_medicamentos, char alcoholismo, char rehabilitacion, char diabetes,
            char hipertension, char dolor_cabeza, char epilepsia,
            char vertigo, char depresion, char falta_aire, char ojos_oidos, char dolor_pecho, char enf_nerviosas,
            char alergias, string alergia_tratamiento, string diabetes_trat, string hipertension_trat, char asma,
            string asma_trat, char tiroides, string tiroides_trat, string hipertension_heredo, string diabetes_heredo,
            string cancer_heredo, string tiroides_heredo, string asma_heredo, string otros_heredo, string observaciones)
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
                        "insert into anamnesis(cedula,tabaquismo,ingesta_med,alcoholismo,rehabilitacion,diabetes,hipertension," +
                    "dolor_cabeza,epilepsia,vertigo,depresion,falta_aire,enf_ojos_oidos,dolor_pecho,enf_nerviosas," +
                    "alergias,alergia_tratamiento,diabetes_trat,hipertension_trat,asma,asma_trat,tiroides,tiroides_trat," +
                    "hipertension_heredo,diabetes_heredo,cancer_heredo,tiroides_heredo,asma_heredo,otros_heredo,observaciones) " +
                    "values (@cedula,@tabaquismo,@ingesta_med,@alcoholismo,@rehabilitacion,@diabetes,@hipertension,@dolor_cabeza," +
                    "@epilepsia,@vertigo,@depresion,@falta_aire,@ojos_oidos,@dolor_pecho,@enf_nerviosas," +
                    "@alergias,@alergia_tratamiento,@diabetes_trat,@hipertension_trat,@asma,@asma_trat,@tiroides,@tiroides_trat," +
                    "@hipertension_heredo,@diabetes_heredo,@cancer_heredo,@tiroides_heredo,@asma_heredo,@otros_heredo,@observaciones)";


                    command.Parameters.AddWithValue("@cedula", cedula);
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
        
        //me trae la anamnesis segun la cedula del cliente
        //me trae la ultima anamnesis creada
        public static List<anamnesis> selectAnamnesisPorCedula(string cedula)
        {
            //creacion de lista tipo medico entity
            List<anamnesis> list = new List<anamnesis>();

            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from anamnesis where cedula= @cedula order by id desc", conn);
                cmd.Parameters.AddWithValue("@cedula", cedula);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    anamnesis anamnesis = new anamnesis();

                    anamnesis.tabaquismo = Convert.ToChar(dr["tabaquismo"]);
                    anamnesis.ingesta_medicamentos = Convert.ToChar(dr["ingesta_med"]);
                    anamnesis.alcoholismo = Convert.ToChar(dr["alcoholismo"]);
                    anamnesis.rehabilitacion = Convert.ToChar(dr["rehabilitacion"]);
                    anamnesis.diabetes = Convert.ToChar(dr["diabetes"]);
                    anamnesis.hipertension = Convert.ToChar(dr["hipertension"]);
                    anamnesis.dolor_Cabeza = Convert.ToChar(dr["dolor_cabeza"]);
                    anamnesis.epilepsia = Convert.ToChar(dr["epilepsia"]);
                    anamnesis.vertigo = Convert.ToChar(dr["vertigo"]);
                    anamnesis.depre = Convert.ToChar(dr["depresion"]);
                    anamnesis.falta_aire = Convert.ToChar(dr["falta_aire"]);
                    anamnesis.enf_ojos_oidos = Convert.ToChar(dr["enf_ojos_oidos"]);
                    anamnesis.dolor_pecho = Convert.ToChar(dr["dolor_pecho"]);
                    anamnesis.enf_nerviosas = Convert.ToChar(dr["enf_nerviosas"]);
                    anamnesis.alergias = Convert.ToChar(dr["alergias"]);
                    anamnesis.alergias_tratamiento = Convert.ToString(dr["alergia_tratamiento"]);
                    anamnesis.diabetes_trat = Convert.ToString(dr["diabetes_trat"]);
                    anamnesis.hipertension_trat = Convert.ToString(dr["hipertension_trat"]);
                    anamnesis.asma = Convert.ToChar(dr["asma"]);
                    anamnesis.asma_tratamiento = Convert.ToString(dr["asma_trat"]);
                    anamnesis.tiroides = Convert.ToChar(dr["tiroides"]);
                    anamnesis.tiroides_tratamiento = Convert.ToString(dr["tiroides_trat"]);
                    anamnesis.hipertension_heredo = Convert.ToString(dr["hipertension_heredo"]);
                    anamnesis.diabetes_heredo = Convert.ToString(dr["diabetes_heredo"]);
                    anamnesis.cancer_heredo = Convert.ToString(dr["cancer_heredo"]);
                    anamnesis.tiroides_heredo = Convert.ToString(dr["tiroides_heredo"]);
                    anamnesis.asma_heredo = Convert.ToString(dr["asma_heredo"]);
                    anamnesis.otros_heredo = Convert.ToString(dr["otros_heredo"]);
                    anamnesis.observaciones = Convert.ToString(dr["observaciones"]);
                                      

                    list.Add(anamnesis);
                }
            }
            return list;
        }

    }
}
