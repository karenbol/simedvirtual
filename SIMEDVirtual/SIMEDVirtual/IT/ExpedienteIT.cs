using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.IT
{
    class ExpedienteIT
    {
        public static Boolean InsertaExpediente(string pulso, string presion_arterial, char soplos, char dolor_precordia, char edemas, char arritmias, char disnea,
        string observaciones_sc, string talla, string peso, string observaciones_sm, string brazo_derecho, string brazo_izquierdo,
        string pierna_derecha, string pierna_izquierda, char bicipal_derecho, char bicipal_izquierdo, char patelar_derecho,
         char patelar_izquierdo, char alquileano_derecho, char alquileano_izquierdo, char flexion, char extensiones,
         char rotacion, char inclinacion_lateral, string observaciones_cc, string malformaciones, char observaciones_dl,
         string observaciones_dl_txt, char petequias, char equimosis, char sangrado, string observaciones_sh, string examen_neurologico,
         string orl, string abdomen, char auscultacion, string observaciones_sr, char convulciones, char espasmos, char temblores,
         char movimientos_anormales, string otros_sn, string observaciones_sn, string otros_examen2, DateTime fecha,
         string diagnostico, string terapeutica, string observaciones_generales, string cedula, string cedula_medico)
        {
            return ExpedienteDA.InsertaExpediente(pulso, presion_arterial, soplos, dolor_precordia, edemas, arritmias, disnea,
                observaciones_sc, talla, peso, observaciones_sm, brazo_derecho, brazo_izquierdo, pierna_derecha, pierna_izquierda,
                bicipal_derecho, bicipal_izquierdo, patelar_derecho, patelar_izquierdo, alquileano_derecho, alquileano_izquierdo,
                flexion, extensiones, rotacion, inclinacion_lateral, observaciones_cc, malformaciones, observaciones_dl,
                observaciones_dl_txt, petequias, equimosis, sangrado, observaciones_sh, examen_neurologico, orl, abdomen, auscultacion,
                observaciones_sr, convulciones, espasmos, temblores, movimientos_anormales, otros_sn, observaciones_sn, otros_examen2,
                fecha, diagnostico, terapeutica, observaciones_generales, cedula, cedula_medico);
        }

        public static List<ExpedienteEntity> selectExpediente(string cedula_cliente)
        {
            return ExpedienteDA.selectExpediente(cedula_cliente);
        }

        public static List<ExpedienteEntity> selectExpedienteAll (string cedula_cliente)
        {
            return ExpedienteDA.selectExpedienteAll(cedula_cliente);
        }

        public static List<ExpedienteEntity> selectExpedienteById(string cedula_cliente, int id)
        {
            return ExpedienteDA.selectExpedienteById(cedula_cliente, id);
        }
    }
}
