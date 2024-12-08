using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEventos
{
    public class ServicioEvento
    {
        public void AgregarEvento(string nombre, DateTime fecha, string ubicacion, string organizador)
        {
            using (SqlConnection conexion = ConexiónBaseDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO Eventos (NombreEvento, FechaEvento, Ubicacion, Organizador) VALUES (@nombre, @fecha, @ubicacion, @organizador)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@ubicacion", ubicacion);
                    comando.Parameters.AddWithValue("@organizador", organizador);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarEvento(int idEvento)
        {
            using (SqlConnection conexion = ConexiónBaseDatos.ObtenerConexion())
            {
                string consulta = "DELETE FROM Eventos WHERE IDEvento = @id";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idEvento);
                    comando.ExecuteNonQuery();
                }
            }
        }

        
        public void ActualizarEvento(int idEvento, string nombre, DateTime fecha, string ubicacion, string organizador)
        {
            using (SqlConnection conexion = ConexiónBaseDatos.ObtenerConexion())
            {
                string consulta = "UPDATE Eventos SET NombreEvento = @nombre, FechaEvento = @fecha, Ubicacion = @ubicacion, Organizador = @organizador WHERE IDEvento = @id";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idEvento);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@ubicacion", ubicacion);
                    comando.Parameters.AddWithValue("@organizador", organizador);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}