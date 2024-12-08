using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEventos
{
    public class ServicioSolicitudUsuario
    {
        // Método para agregar una solicitud
        public void AgregarSolicitud(string nombreUsuario, string nombreEvento, DateTime fechaEvento)
        {
            using (SqlConnection conexion = ConexiónBaseDatos.ObtenerConexion())
            {
                string consulta = "INSERT INTO SolicitudesUsuarios (NombreUsuario, NombreEvento, FechaEvento, Estado) VALUES (@nombreUsuario, @nombreEvento, @fechaEvento, 'Pendiente')";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@nombreEvento", nombreEvento);
                    comando.Parameters.AddWithValue("@fechaEvento", fechaEvento);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Método para listar las solicitudes
        public void ListarSolicitudes()
        {
            using (SqlConnection conexion = ConexiónBaseDatos.ObtenerConexion())
            {
                string consulta = "SELECT * FROM SolicitudesUsuarios";  // Cambiado aquí
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Console.WriteLine($"ID: {lector["IDSolicitud"]}, Usuario: {lector["NombreUsuario"]}, Evento: {lector["NombreEvento"]}, Fecha: {lector["FechaEvento"]}, Estado: {lector["Estado"]}");
                        }
                    }
                }
            }
        }

        // Método para actualizar el estado de una solicitud
        public void ActualizarEstadoSolicitud(int idSolicitud, string nuevoEstado)
        {
            using (SqlConnection conexion = ConexiónBaseDatos.ObtenerConexion())
            {
                string consulta = "UPDATE SolicitudesUsuarios SET Estado = @nuevoEstado WHERE IDSolicitud = @idSolicitud";  // Cambiado aquí
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                    comando.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}

