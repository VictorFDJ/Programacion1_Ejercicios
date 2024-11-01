using SistemaDeRegistroDePacientes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de pacientes\n");

        List<Paciente> Enfermos = new List<Paciente>();
        bool continuar = true;

        while (continuar)
        {
            try
            {
                Console.WriteLine("Elegir la opcion que quieres hacer\n");
                Console.WriteLine("" +
                    " 1- Agregar nuevo Paciente\n" +
                    " 2- Ver pacientes\n" +
                    " 3- Eliminar Paciente\n" +
                    " 4- Edictar pacientes\n" +
                    " 5- Salir ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    //agregar paciente
                    case 1:
                        Paciente nuevoPaciente = new Paciente();
                        nuevoPaciente.AgregarDatosPaciente();
                        Enfermos.Add(nuevoPaciente);
                        Console.WriteLine("Paciente agregado.\n");

                        Console.WriteLine("Quieres añadirle una descricion al paciente?  " +
                            "1 es Si" +
                            "2 es No ");
                        string desc = Console.ReadLine();
                        if (desc == "1")
                        {
                            Console.WriteLine("Añadiendo descripcion");
                           string resumenPaciente = Console.ReadLine();
                            nuevoPaciente.SetdescPaciente(resumenPaciente);
                            Console.WriteLine("Descripcion del paciente agregada");
                        }
                        else { Console.WriteLine("No hay nada que comentar");
                            nuevoPaciente.SetdescPaciente("No hay descripcion para este paciente");
                        }
                        break;
                    //Ver pacientes guardados
                    case 2:
                        Console.WriteLine("Pacientes guardados:");
                        foreach (var paciente in Enfermos)
                        {
                            paciente.MostrarInformacion();
                        }
                        break;


                    //Eliminar Paciente
                    case 3:
                        Console.WriteLine(" Ingrese el id del paciente a eliminar ");
                        int eliminar = int.Parse(Console.ReadLine());
                        Paciente eliminarPaciente = Enfermos.Find(pacientee => pacientee.Id == eliminar);

                        if (eliminarPaciente != null)
                        {
                            Console.WriteLine("Esta es el paciente correcto?");
                            eliminarPaciente.MostrarInformacion();
                        }
                        else { Console.WriteLine("Paciente no encontrado "); }

                        if (eliminarPaciente != null) { Console.WriteLine("1 es Si: 2: es No");
                            string pacienteCorrecto = Console.ReadLine();
                            if (pacienteCorrecto == "1")
                            {
                                Enfermos.Remove(eliminarPaciente);
                                Console.WriteLine("Paciente eliminado");
                            }
                        }
                        else { Console.WriteLine("Eliminacion cancelada"); }
                          break;
    

                    //Edicar paciente
                    case 4:
                        Console.WriteLine("Ingrese el id del paciente a editar");
                        int editar = int.Parse(Console.ReadLine());
                        Paciente editarPaciente = Enfermos.Find(Enfermos => Enfermos.Id == editar);
                        if (editarPaciente != null)
                        {
                            Console.WriteLine("Informacion del paciente");
                            editarPaciente.MostrarInformacion();
                            Console.WriteLine("Que quieres editar?" +
                            "1- Nombre\n " +
                            "2- Telefono\n " +
                            "3- Edad\n ");
                             
                        }
                        else { Console.WriteLine("Paciente no encontrado"); }
                        if (editarPaciente != null) { 
                            int select = int.Parse(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    Console.WriteLine("Nuevo nombre");
                                    string nombreNuevo = Console.ReadLine();
                                    editarPaciente.setNombre(nombreNuevo);
                                    break;

                                case 2:
                                    Console.WriteLine("Nuevo Telefono");
                                    string nuevoTel = Console.ReadLine();
                                    editarPaciente.setTel(nuevoTel);
                                    break;

                                case 3:
                                    Console.WriteLine("Nueva Edad");
                                    int edad = int.Parse(Console.ReadLine());
                                    editarPaciente.setEdad(edad);
                                    break;
                            }     
                        }
                        
                        

                    break;


                    case 5:
                        continuar = false;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intenta nuevamente.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}