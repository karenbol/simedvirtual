using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.Entity
{
    class ExpedienteEntity
    {
        public string pulso { get; set; }
        public string presion_arterial { get; set; }
        public char soplos { get; set; }
        public char dolor_precordial { get; set; }
        public char edemas { get; set; }
        public char arritmias { get; set; }
        public char disnea { get; set; }
        public string observaciones_sc { get; set; }
        public string talla { get; set; }
        public string peso { get; set; }
        public string observaciones_sm { get; set; }
        public string brazo_derecho { get; set; }
        public string brazo_izquierdo { get; set; }
        public string pierna_derecha { get; set; }
        public string pierna_izquierda { get; set; }
        public char bicipal_derecho { get; set; }
        public char bicipal_izquierdo { get; set; }
        public char patelar_derecho { get; set; }
        public char patelar_izquierdo { get; set; }
        public char alquileano_derecho { get; set; }
        public char alquileano_izquierdo { get; set; }
        public char flexion { get; set; }
        public char extensiones { get; set; }
        public char rotacion { get; set; }
        public char inclinacion_lateral { get; set; }

        public string observaciones_cc { get; set; }
        public string malformaciones { get; set; }
        public char observaciones_dl { get; set; }
        public string observaciones_dl_txt { get; set; }
        public char petequias { get; set; }
        public char equimosis { get; set; }
        public char sangrado { get; set; }
        public string observaciones_sh { get; set; }
        public string examen_neurologico { get; set; }
        public string orl { get; set; }
        public string abdomen { get; set; }
        public char auscultacion { get; set; }
        public string observaciones_sr { get; set; }
        public char convulciones { get; set; }
        public char espasmos { get; set; }
        public char temblores { get; set; }
        public char movimientos_anormales { get; set; }
        public string otros_sn { get; set; }
        public string observaciones_sn { get; set; }
        public string otros_examen2 { get; set; }

        public DateTime fecha { get; set; }
        public string diagnostico { get; set; }
        public string terapeutica { get; set; }

        public string observaciones_generales { get; set; }
        public string cedula { get; set; }
        public string cedula_medico { get; set; }
    }
}
