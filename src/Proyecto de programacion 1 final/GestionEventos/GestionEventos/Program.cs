using System;
namespace GestionEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicioEvento servicioEvento = new ServicioEvento();
            ServicioSolicitudUsuario servicioSolicitud = new ServicioSolicitudUsuario();

            while (true)
            {
                Console.WriteLine("\n=== Sistema de Gestión de Eventos ===");
                Console.WriteLine("1. Agregar Evento");
                Console.WriteLine("2. Eliminar Evento");
                Console.WriteLine("3. Actualizar Evento");
                Console.WriteLine("4. Solicitar Evento");
                Console.WriteLine("5. Listar Solicitudes");
                Console.WriteLine("6. Aceptar/Rechazar Solicitud");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingresa el nombre del evento: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingresa la fecha del evento (yyyy-mm-dd): ");
                        DateTime fecha = DateTime.Parse(Console.ReadLine());
                        Console.Write("Ingresa la ubicación del evento: ");
                        string ubicacion = Console.ReadLine();
                        Console.Write("Ingresa el organizador del evento: ");
                        string organizador = Console.ReadLine();
                        servicioEvento.AgregarEvento(nombre, fecha, ubicacion, organizador);
                        Console.WriteLine("¡Evento agregado con éxito!");
                        break;

                    case "2":
                        Console.Write("Ingresa el ID del evento a eliminar: ");
                        int idEventoEliminar = int.Parse(Console.ReadLine());
                        servicioEvento.EliminarEvento(idEventoEliminar);
                        Console.WriteLine("¡Evento eliminado con éxito!");
                        break;

                    case "3":
                        Console.Write("Ingresa el ID del evento a actualizar: ");
                        int idEventoActualizar = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa el nuevo nombre del evento: ");
                        string nuevoNombre = Console.ReadLine();
                        Console.Write("Ingresa la nueva fecha del evento (yyyy-mm-dd): ");
                        DateTime nuevaFecha = DateTime.Parse(Console.ReadLine());
                        Console.Write("Ingresa la nueva ubicación del evento: ");
                        string nuevaUbicacion = Console.ReadLine();
                        Console.Write("Ingresa el nuevo organizador del evento: ");
                        string nuevoOrganizador = Console.ReadLine();
                        servicioEvento.ActualizarEvento(idEventoActualizar, nuevoNombre, nuevaFecha, nuevaUbicacion, nuevoOrganizador);
                        Console.WriteLine("¡Evento actualizado con éxito!");
                        break;

                    case "4":
                        Console.Write("Ingresa tu nombre: ");
                        string nombreUsuario = Console.ReadLine();
                        Console.Write("Ingresa el nombre del evento que deseas solicitar: ");
                        string nombreEvento = Console.ReadLine();
                        Console.Write("Ingresa la fecha del evento (yyyy-mm-dd): ");
                        DateTime fechaEvento = DateTime.Parse(Console.ReadLine());
                        servicioSolicitud.AgregarSolicitud(nombreUsuario, nombreEvento, fechaEvento);
                        Console.WriteLine("¡Solicitud enviada con éxito!");
                        break;

                    case "5":
                        Console.WriteLine("\n=== Lista de Solicitudes ===");
                        servicioSolicitud.ListarSolicitudes();
                        break;

                    case "6":
                        Console.Write("Ingresa el ID de la solicitud a aceptar o rechazar: ");
                        int idSolicitud = int.Parse(Console.ReadLine());
                        Console.WriteLine("1. Aceptar Solicitud");
                        Console.WriteLine("2. Rechazar Solicitud");
                        string decision = Console.ReadLine();

                        string estado = decision == "1" ? "Aceptada" : "Rechazada";
                        servicioSolicitud.ActualizarEstadoSolicitud(idSolicitud, estado);
                        Console.WriteLine($"¡Solicitud {estado} con éxito!");
                        break;

                    case "0":
                        Console.WriteLine("Saliendo...");
                        return;

                    default:
                        Console.WriteLine("Opción inválida. Intenta nuevamente.");
                        break;
                }
            }
        }
    }
}

