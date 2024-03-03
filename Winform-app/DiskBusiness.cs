using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Winform_app
{
    class DiskBusiness
    {
        public List<Disk> toList() // method that reads from the database
        {
            List<Disk> list = new List<Disk>();
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
                

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text; // reads database
                cmd.CommandText = "select Titulo, FechaLanzamiento, CantidadCanciones from DISCOS";
                cmd.Connection = connection; 

                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Disk aux = new Disk();
                    aux.Title = (string)reader["Titulo"];
                    aux.ReleaseDate = (DateTime)reader["FechaLanzamiento"];
                    aux.SongsNumber = (int)reader["CantidadCanciones"];

                    list.Add(aux);
                }

                connection.Close();
                return list;    
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
