using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PruebaConexion
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaconexion = "Data Source=SQL5053.site4now.net;Initial Catalog=db_a766c1_alexanderidio;User ID=db_a766c1_alexanderidio_admin;Password=alexanderisaac1";
            SqlConnection Miconexion = new SqlConnection(cadenaconexion);
            Miconexion.Open();
            SqlCommand Comando = new SqlCommand("InsertarCategoria", Miconexion);
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Add("@id", SqlDbType.Int).Value = 17;
            Comando.Parameters.Add("@nombreCa", SqlDbType.VarChar).Value = "CategoriaD";
            Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = "DescripcionD";
            Comando.ExecuteNonQuery();
            Miconexion.Close();
            Console.WriteLine("Se Inserto una Fila Nueva ");
            Console.ReadKey();

        }
    }
}
