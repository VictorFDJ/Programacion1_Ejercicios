using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Contactes
{
    internal class Agenda
    {
        private List<Contacto> contactos;
        private int nextId;

        public Agenda()
        {
            contactos = new List<Contacto>();
            nextId = 1;
        }

        public void AgregarContacto(string nombre, string telefono, string email, string direccion)
        {
            var contacto = new Contacto(nextId, nombre, telefono, email, direccion);
            contactos.Add(contacto);
            nextId++;
        }

        public void VerContactos()
        {
            Console.WriteLine("Id\tNombre\tTeléfono\tEmail\tDirección");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var contacto in contactos)
            {
                Console.WriteLine(contacto.ToString());
            }
        }

        public Contacto BuscarContacto(int id)
        {
            return contactos.Find(c => c.Id == id);
        }

        public void ModificarContacto(int id, string nuevoNombre, string nuevoTelefono, string nuevoEmail, string nuevaDireccion)
        {
            var contacto = BuscarContacto(id);
            if (contacto != null)
            {
                contacto.Nombre = nuevoNombre;
                contacto.Telefono = nuevoTelefono;
                contacto.Email = nuevoEmail;
                contacto.Direccion = nuevaDireccion;
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }

        public void EliminarContacto(int id)
        {
            var contacto = BuscarContacto(id);
            if (contacto != null)
            {
                contactos.Remove(contacto);
            }
            else
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }
}
