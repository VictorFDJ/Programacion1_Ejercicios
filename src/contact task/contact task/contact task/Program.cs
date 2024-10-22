using System.Diagnostics;
using static System.Console;
Console.WriteLine("Bienvenido a mi lista de Contactes");


//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();


while (runing)
{
    try
    {
        Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   6. Eliminar Contacto    6. Salir");
        Console.WriteLine("Digite el número de la opción deseada");

        int typeOption = Convert.ToInt32(Console.ReadLine());

        switch (typeOption)
        {

            case 1:
                {


                    AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                    WriteLine("");

                }
                break;
            case 2:
                {
                    Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                    Console.WriteLine($"____________________________________________________________________________________________________________________________");
                    foreach (var id in ids)
                    {
                        var isBestFriend = bestFriends[id];



                        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                        Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
                    }
                    WriteLine("");
                }
                break;
            case 3: //search
                {
                    Console.WriteLine("Buscador de contactos (ingrese el ID del contacto):");
                    int buscador = Convert.ToInt32(Console.ReadLine());

                    if (names.ContainsKey(buscador))
                    {
                        string nombreContacto = names[buscador];
                        string apellidoContacto = lastnames[buscador];
                        string direccionContacto = addresses[buscador];
                        string telefonoContacto = telephones[buscador];
                        string emailContacto = emails[buscador];
                        int edadContacto = ages[buscador];
                        bool esMejorAmigo = bestFriends[buscador];

                        string esMejorAmigoStr = esMejorAmigo ? "Si" : "No";

                        Console.WriteLine($"Nombre: {nombreContacto}, Apellido: {apellidoContacto}, Dirección: {direccionContacto}, Teléfono: {telefonoContacto}, Email: {emailContacto}, Edad: {edadContacto}, Es Mejor Amigo: {esMejorAmigoStr}");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún contacto con ese ID.");
                    }
                    WriteLine("");

                }
                break;
            case 4: //modify
                {
                    Console.WriteLine("Modificador de contactos (ingrese el ID del contacto a modificar):");
                    int modificador = Convert.ToInt32(Console.ReadLine());

                    if (names.ContainsKey(modificador))
                    {
                        Console.WriteLine("Estos son los datos actuales del contacto");

                        Console.WriteLine($"Nombre: {names[modificador]}");
                        Console.WriteLine($"Apellido: {lastnames[modificador]}");
                        Console.WriteLine($"Dirección: {addresses[modificador]}");
                        Console.WriteLine($"Teléfono: {telephones[modificador]}");
                        Console.WriteLine($"Email: {emails[modificador]}");
                        Console.WriteLine($"Edad: {ages[modificador]}");
                        Console.WriteLine($"Es Mejor Amigo: {(bestFriends[modificador] ? "Si" : "No")}");


                        Console.WriteLine("¿Qué desea modificar? (1. Nombre, 2. Apellido, 3. Dirección, 4. Teléfono, 5. Email, 6. Edad, 7. Es Mejor Amigo, 8. Cambiar todo)");
                        int opcionModificar = Convert.ToInt32(Console.ReadLine());

                        switch (opcionModificar)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Ingrese el nuevo nombre:");
                                    names[modificador] = Console.ReadLine();
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Ingrese el nuevo apellido:");
                                    lastnames[modificador] = Console.ReadLine();
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Ingrese la nueva dirección:");
                                    addresses[modificador] = Console.ReadLine();
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Ingrese el nuevo teléfono:");
                                    telephones[modificador] = Console.ReadLine();
                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("Ingrese el nuevo email:");
                                    emails[modificador] = Console.ReadLine();
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("Ingrese la nueva edad:");
                                    ages[modificador] = Convert.ToInt32(Console.ReadLine());
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("Especifique si es mejor amigo (1. Si, 2. No):");
                                    bestFriends[modificador] = Convert.ToInt32(Console.ReadLine()) == 1;
                                }
                                break;
                            default:
                                Console.WriteLine("Opción no válida.");
                                break;
                            case 8:
                                {
                                    Console.WriteLine("Ingrese el nuevo nombre:");
                                    names[modificador] = Console.ReadLine();

                                    Console.WriteLine("Ingrese el nuevo apellido:");
                                    lastnames[modificador] = Console.ReadLine();

                                    Console.WriteLine("Ingrese la nueva dirección:");
                                    addresses[modificador] = Console.ReadLine();

                                    Console.WriteLine("Ingrese el nuevo teléfono:");
                                    telephones[modificador] = Console.ReadLine();

                                    Console.WriteLine("Ingrese el nuevo email:");
                                    emails[modificador] = Console.ReadLine();

                                    Console.WriteLine("Ingrese la nueva edad:");
                                    ages[modificador] = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Especifique si es mejor amigo (1. Si, 2. No):");
                                    bestFriends[modificador] = Convert.ToInt32(Console.ReadLine()) == 1;
                                }
                                break;
                        }

                        Console.WriteLine("Contacto modificado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún contacto con ese ID.");
                        Console.WriteLine("Piensa Mark Piernsa");

                    }
                    WriteLine("");

                }
                break;
            case 5: //delete
                {
                    Console.WriteLine("Eliminador de contactos (ingrese el ID del contacto a eliminar):");
                    int eliminador = Convert.ToInt32(Console.ReadLine());

                    if (names.ContainsKey(eliminador))
                    {
                        Console.WriteLine($"Datos del contacto a eliminar:");
                        Console.WriteLine($"Nombre: {names[eliminador]}, Apellido: {lastnames[eliminador]}, Teléfono: {telephones[eliminador]}");

                        Console.WriteLine("¿Está seguro que desea eliminar este contacto? (1. Si, 2. No)");
                        int confirmacion = Convert.ToInt32(Console.ReadLine());

                        if (confirmacion == 1)
                        {
                            ids.Remove(eliminador);
                            names.Remove(eliminador);
                            lastnames.Remove(eliminador);
                            addresses.Remove(eliminador);
                            telephones.Remove(eliminador);
                            emails.Remove(eliminador);
                            ages.Remove(eliminador);
                            bestFriends.Remove(eliminador);

                            Console.WriteLine("Contacto eliminado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Eliminación cancelada.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún contacto con ese ID.");
                        Console.WriteLine("Piensa Mark");
                    }
                    WriteLine("");
                }
                break;
            case 6:
                runing = false;
                break;
            default:
                Console.WriteLine("Tu eres o te haces el idiota?");
                break;

        }
    }
    catch (Exception e) {
        Console.WriteLine(e.Message);
        Console.WriteLine("Ha ocurrido un error intenta de nuevo\n");
    
    }
}


static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre de la persona");
    string name = Console.ReadLine();
    Console.WriteLine("Digite el apellido de la persona");
    string lastname = Console.ReadLine();
    Console.WriteLine("Digite la dirección");
    string address = Console.ReadLine();
    Console.WriteLine("Digite el telefono de la persona");
    string phone = Console.ReadLine();
    Console.WriteLine("Digite el email de la persona");
    string email = Console.ReadLine();
    Console.WriteLine("Digite la edad de la persona en números");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");

    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    var id = ids.Count + 1;
    ids.Add(id);
    names.Add(id, name);
    lastnames.Add(id, lastname);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);
}
