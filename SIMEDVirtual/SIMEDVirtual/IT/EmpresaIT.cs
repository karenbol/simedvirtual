﻿using SIMEDVirtual.DA;
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

        public static EmpresaEntity getEmpresaByID(String cedula)
        {
            return Empresa.getEmpresaByID(cedula);
        }

        public static List<EmpresaEntity> getTelefono(String cedula_juridica)
        {
            return Empresa.getTelefono(cedula_juridica);
        }

        public static Boolean deleteTelefono(String cedula_juridica, int telefono)
        {
            return Empresa.deleteTelefono(cedula_juridica, telefono);
        }

        public static Boolean updateTelefono(String cedula_juridica, int telefono, string encargado)
        {
            return Empresa.updateTelefono(cedula_juridica, telefono, encargado);
        }

        public static Boolean updateEmpresa(String cedula_juridica, string nombre, string direccion, string descripcion)
        {
            return Empresa.updateEmpresa(cedula_juridica, nombre, direccion, descripcion);
        }

        public static Boolean deleteEmpresa(String cedula_juridica)
        {
            return Empresa.deleteEmpresa(cedula_juridica);
        }

        public static List<EmpresaEntity> getEmpresasMenos()
        {
            return Empresa.getEmpresasMenos();
        }

        public static EmpresaEntity getEmpresaByCedula(String cedula)
        {
            return Empresa.getEmpresaByCedula(cedula);
        }

    }
}
