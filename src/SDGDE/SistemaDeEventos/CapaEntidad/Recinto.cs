using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Recinto
    {
        public int RecintoID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public int Capacidad { get; set; }
        public string Estado { get; set; } = "Disponible"; // Valores: 'Disponible', 'No Disponible'
        public string? Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
