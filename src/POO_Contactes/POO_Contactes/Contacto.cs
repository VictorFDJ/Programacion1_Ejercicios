using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Contactes
{
    internal class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public Contacto(int id, string nombre, string telefono, string email, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Teléfono: {Telefono}, Email: {Email}, Dirección: {Direccion}";
        }
    }
}
