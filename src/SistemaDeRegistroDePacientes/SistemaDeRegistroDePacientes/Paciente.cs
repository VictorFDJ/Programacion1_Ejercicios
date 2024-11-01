using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRegistroDePacientes
{

    
    internal class Paciente
    {
        private static int contadorId = 1; 
        private int id;                    
        private string nombre;
        private string telefono;
        private int edad;
        private string descripcion;

        public int Id => id;

        
        public Paciente()
        {
            this.id = contadorId++;
        }

        public void setNombre(string nombre) { 
            this.nombre = nombre;       
        }
        public void setTel(string telefono) { 
            this.telefono = telefono;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;   
                  
        }
        public void SetdescPaciente(string desc) { 
            this.descripcion = desc;
        
        }

        public void AgregarDatosPaciente()
        {
            Console.WriteLine("Agrega el nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Agrega el teléfono:");
            telefono = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Ingresa la edad:");
                string validarEdad = Console.ReadLine();

                if (int.TryParse(validarEdad, out int edad))
                {
                    this.edad = edad;
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingresa solo números.");
                }
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {id}, Nombre: {nombre}, Teléfono: {telefono}, Edad: {edad},  Descricion del paciente: {descripcion}");
        }
    }

}
