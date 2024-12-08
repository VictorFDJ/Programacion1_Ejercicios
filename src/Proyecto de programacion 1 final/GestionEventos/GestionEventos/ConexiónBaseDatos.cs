using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEventos
{
    public class ConexiónBaseDatos
    {
        private const string CadenaConexion = "Server=VICTOR\\SQLEXPRESS;Database=GestionEventos;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
