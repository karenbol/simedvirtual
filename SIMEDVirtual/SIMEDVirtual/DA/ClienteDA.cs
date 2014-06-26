using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SIMEDVirtual.DA
{
    class ClienteDA
    {
        public static List<int> IdEmpresa(int idEmpresa)
        {
            List<int> result = new List<int>();
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select id_cliente from plan_empresarial where id_empresa='" + idEmpresa + "'", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    List<int> ids = new List<int>();
                    ids.Add(Convert.ToInt32(dr[0].ToString()));
                    //result.
                }
            }
            return result;
        }


    }
}
