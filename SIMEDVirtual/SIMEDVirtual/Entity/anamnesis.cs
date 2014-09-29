using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.Entity
{
    class anamnesis
    {
        public string cedula { get; set; }

        public char tabaquismo { get; set; }
        public char ingesta_medicamentos { get; set; }
        public char alcoholismo { get; set; }
        public char rehabilitacion { get; set; }
        public char dolor_Cabeza { get; set; }
        public char epilepsia { get; set; }
        public char vertigo { get; set; }
        public char depre { get; set; }
        public char falta_aire { get; set; }
        public char enf_ojos_oidos { get; set; }
        public char dolor_pecho { get; set; }
        public char enf_nerviosas { get; set; }
        public char alergias { get; set; }
        public string alergias_tratamiento { get; set; }
        public char diabetes { get; set; }
        public string diabetes_trat { get; set; }
        public char hipertension { get; set; }
        public string hipertension_trat { get; set; }
        public char asma { get; set; }
        public string asma_tratamiento { get; set; }
        public char tiroides { get; set; }
        public string tiroides_tratamiento { get; set; }

        public string hipertension_heredo { get; set; }
        public string diabetes_heredo { get; set; }
        public string cancer_heredo { get; set; }
        public string tiroides_heredo { get; set; }
        public string asma_heredo { get; set; }
        public string otros_heredo { get; set; }

        public string observaciones { get; set; }
    }
}
