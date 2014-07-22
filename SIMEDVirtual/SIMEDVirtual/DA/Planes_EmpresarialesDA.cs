using Npgsql;
using SIMEDVirtual.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class Planes_EmpresarialesDA
    {
        //public static List<ClienteEntity> ClientesXEmpresa()
        //{
        //    List<ClienteEntity> usuarios = new List<ClienteEntity>();

        //    using (NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
        //    {
        //        conn.Open();

        //        NpgsqlCommand cmd = new NpgsqlCommand
        //            ("select * from clientes where clientes.cedula=plan_empresarial.id_cliente;", conn);
        //        NpgsqlDataReader dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            ClienteEntity cliente = new ClienteEntity();
        //            cliente.nombre = dr[0].ToString();
        //            cliente.ape1 = dr[1].ToString();
        //            cliente.ape2 = dr[2].ToString();
        //            cliente.cedula = Convert.ToInt32(dr[3].ToString());
        //            cliente.fecha = Convert.ToDateTime(dr[4].ToString());
        //            cliente.sexo = Convert.ToChar(dr[5].ToString());
        //            cliente.estado_civil = dr[6].ToString();
        //            cliente.grupo_sanguineo = dr[7].ToString();
        //            cliente.profesion = dr[8].ToString();
        //            cliente.telefono_fijo = Convert.ToInt32(dr[9].ToString());
        //            cliente.telefono_movil = Convert.ToInt32(dr[10].ToString());
        //            cliente.email = dr[11].ToString();
        //            cliente.direccion = dr[12].ToString();
        //            usuarios.Add(cliente);
        //        }
        //    }
        //    return usuarios;
        //}
    }
}
