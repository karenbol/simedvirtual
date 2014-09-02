using Npgsql;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class Empresa
    {
        //metodo que carga el nombre en el combo
        public static List<EmpresaEntity> getAllEmpresas()
        {
            List<EmpresaEntity> empresas = new List<EmpresaEntity>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from empresa order by nombe",
    conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EmpresaEntity entidad = new EmpresaEntity();

                    entidad.nombre = dr[1].ToString();
                    entidad.cedula = Convert.ToInt32(dr[2]);
                    entidad.direccion = dr[3].ToString();
                    entidad.fecha = Convert.ToDateTime(dr[4]);
                    entidad.encargado = dr[5].ToString();

                    empresas.Add(entidad);
                }
            }
            return empresas;
        }

        //selecciona el id de la empresa
        public static int IdEmpresa(String empresa)
        {
            int id = 0;
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select id from empresa where nombe='"+empresa+"'", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id =Convert.ToInt32(dr[0].ToString());
                }
            }
            return id;
        }

    }
}
