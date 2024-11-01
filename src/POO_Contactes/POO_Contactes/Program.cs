using POO_Contactes;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Mi Agenda Perrón");
        Console.WriteLine("Bienvenido a tu lista de contactos");

        Agenda agenda = new Agenda();
        bool running = true;

        while (running)
        {
            Console.Write("1. Agregar Contacto      ");
            Console.Write("2. Ver Contactos     ");
            Console.Write("3. Buscar Contacto      ");
            Console.Write("4. Modificar Contacto        ");
            Console.Write("5. Eliminar Contacto     ");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AgregarContacto(agenda);
                        break;
                    case 2:
                        agenda.VerContactos();
                        break;
                    case 3:
                        BuscarContacto(agenda);
                        break;
                    case 4:
                        ModificarContacto(agenda);
                        break;
                    case 5:
                        EliminarContacto(agenda);
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida, por favor ingresa un número.");
            }
        }
    }

    static void AgregarContacto(Agenda agenda)
    {
        Console.WriteLine("Vamos a agregar ese contacto que te trae loco.");
        Console.Write("Digite el Nombre: ");
        var nombre = Console.ReadLine();
        Console.Write("Digite el Teléfono: ");
        var telefono = Console.ReadLine();
        Console.Write("Digite el Email: ");
        var email = Console.ReadLine();
        Console.Write("Digite la dirección: ");
        var direccion = Console.ReadLine();

        agenda.AgregarContacto(nombre, telefono, email, direccion);
        Console.WriteLine("Contacto agregado con éxito.");
    }

    static void BuscarContacto(Agenda agenda)
    {
        Console.Write("Digite el Id del Contacto para Buscar: ");
        int id = Convert.ToInt32(Console.ReadLine());
        var contacto = agenda.BuscarContacto(id);
        if (contacto != null)
        {
            Console.WriteLine(contacto.ToString());
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }

    static void ModificarContacto(Agenda agenda)
    {
        Console.Write("Digite el Id del Contacto para Modificar: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite el Nuevo Nombre: ");
        var nuevoNombre = Console.ReadLine();
        Console.Write("Digite el Nuevo Teléfono: ");
        var nuevoTelefono = Console.ReadLine();
        Console.Write("Digite el Nuevo Email: ");
        var nuevoEmail = Console.ReadLine();
        Console.Write("Digite la Nueva Dirección: ");
        var nuevaDireccion = Console.ReadLine();

        agenda.ModificarContacto(id, nuevoNombre, nuevoTelefono, nuevoEmail, nuevaDireccion);
        Console.WriteLine("Contacto modificado con éxito.");
    }

    static void EliminarContacto(Agenda agenda)
    {
        Console.Write("Digite el Id del Contacto para Eliminar: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Seguro que desea eliminar? 1. Si, 2. No");
        int opcion = Convert.ToInt32(Console.ReadLine());
        if (opcion == 1)
        {
            agenda.EliminarContacto(id);
            Console.WriteLine("Contacto eliminado con éxito.");
        }
    }
}
