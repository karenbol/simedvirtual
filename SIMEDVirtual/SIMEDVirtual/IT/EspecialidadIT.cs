using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.IT
{
    class EspecialidadIT
    {
        public static List<EspecialidadEntity> getAllEspecialidades()
        {
            return EspecialidadDA.getAllEspecialidades();
        }
    }
}
