using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Models;

namespace Datos.Admin
{
    public static class AdmPublisher
    {
        public static List<Publisher> Listar()
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers";
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Publisher> lista = new List<Publisher>();
            while (reader.Read())
            {
                lista.Add(
                    new Publisher()
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString()
                    });
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return lista;
        }
    }
}
