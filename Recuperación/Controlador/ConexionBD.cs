using System.Data;
using Npgsql;

namespace Preparcial.Controlador
{
    public static class ConexionBD
    {
        // Cadena de conexion
        //CORRECCIÓN: Se modificaron los datos para acceder a la base de datos
        private static string cadenaC = "Server=127.0.0.1;" +
                                        "Port=5432;" +
                                        "UserId=postgres;" +
                                        "Password=gohan;" +
                                        "Database=Preparcial;";

        // Ejecutar consulta (Comando SELECT)
        public static DataTable EjecutarConsulta(string consulta)
        {
            var conn = new NpgsqlConnection(cadenaC);
            var ds = new DataSet();

            conn.Open();
            var da = new NpgsqlDataAdapter(consulta, conn);
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        // Ejecutar comando (UPDATE, INSERT, DELETE, ETC)
        public static void EjecutarComando(string comando)
        {
            var conn = new NpgsqlConnection(cadenaC);

            conn.Open();
            var comm = new NpgsqlCommand(comando, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}