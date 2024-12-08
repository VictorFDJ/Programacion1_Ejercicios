using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; } 
        public string TipoUsuario { get; set; }  // Valores: 'Admin', 'Cliente'
        public  ROLES oRol { get; set; }
        public string FechaCreacion { get; set; }
    }
}
