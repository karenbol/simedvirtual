using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.IT
{
    class anamnesisIT
    {
        public static Boolean InsertaAnamnesis(string cedula, char tabaquismo, char ingesta_medicamentos, char alcoholismo,
            char rehabilitacion, char diabetes, char hipertension, char dolor_cabeza, char epilepsia,
            char vertigo, char depresion, char falta_aire, char ojos_oidos, char dolor_pecho, char enf_nerviosas,
            char alergias, string alergia_tratamiento, string diabetes_trat, string hipertension_trat, char asma,
            string asma_trat, char tiroides, string tiroides_trat, string hipertension_heredo, string diabetes_heredo,
            string cancer_heredo, string tiroides_heredo, string asma_heredo, string otros_heredo, string observaciones)
        {
            return anamnesisDa.InsertaAnamnesis(cedula, tabaquismo, ingesta_medicamentos, alcoholismo, rehabilitacion,
                diabetes, hipertension, dolor_cabeza, epilepsia, vertigo, depresion, falta_aire, ojos_oidos, dolor_pecho,
                enf_nerviosas, alergias, alergia_tratamiento, diabetes_trat, hipertension_trat, asma, asma_trat, tiroides,
                tiroides_trat, hipertension_heredo, diabetes_heredo, cancer_heredo, tiroides_heredo,
                asma_heredo, otros_heredo, observaciones);
        }

        //me trae la anamnesis dependiendo de la cedula del cliente
        public static List<anamnesis> selectAnamnesisPorCedula(string cedula)
        {
            return anamnesisDa.selectAnamnesisPorCedula(cedula);
        }

    }
}
