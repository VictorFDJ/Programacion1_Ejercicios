using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int PermisoID { get; set; }
        public required ROLES oROl { get; set; }
        public required string FechaCreacion { get; set; }

        public required string NombrePermiso  {get; set;}
    }
}
