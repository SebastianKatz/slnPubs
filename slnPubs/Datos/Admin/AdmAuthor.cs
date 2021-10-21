using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Models;

namespace Datos.Admin
{
    public static class AdmAuthor
    {
        public static List<Author> Listar(){
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors";
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            List<Author> lista = new List<Author>();
            while (reader.Read())
            {
                lista.Add(
                    new Author()
                    {
                        Au_id = reader["au_id"].ToString(),
                        Au_lname = reader["Au_lname"].ToString(),
                        Au_fname = reader["Au_fname"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Zip = reader["Zip"].ToString(),
                        Contract = (bool)reader["Contract"],
                    });
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return lista;
        }
    }
}
