using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.IT
{
    class EmpresaIT
    {
        public static List<EmpresaEntity> getAllEmpresas()
        {
            return Empresa.getAllEmpresas();
        }

        public static int IdEmpresa(String empresa)
        {
            return Empresa.IdEmpresa(empresa);
        }
    }
}
