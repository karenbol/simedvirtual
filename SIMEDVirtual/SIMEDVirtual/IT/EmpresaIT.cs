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
        public static Boolean InsertaEmpresa(
            string nombre, string cedula_juridica, string direccion, string descripcion)
        {
            return Empresa.InsertaEmpresa(nombre, cedula_juridica, direccion, descripcion);
        }


         //inserta datos en la tabla persona
        public static Boolean InsertaEmpresaTelefono(string cedula_juridica,
            int telefono, string encargado)
        {
            return Empresa.InsertaEmpresaTelefono(cedula_juridica, telefono, encargado);
        }




        public static List<EmpresaEntity> getAllEmpresas()
        {
            return Empresa.getAllEmpresas();
        }

        public static int IdEmpresa(String empresa)
        {
            return Empresa.IdEmpresa(empresa);
        }

        public static List<EmpresaEntity> getTelefono(String cedula_juridica)
        {
            return Empresa.getTelefono(cedula_juridica);
        }


    }
}
