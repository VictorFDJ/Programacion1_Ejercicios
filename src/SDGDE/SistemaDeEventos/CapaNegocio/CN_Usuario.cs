using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CP_Usuario objcd_usuario = new CP_Usuario();


        public List<Usuario> Listar() { 
           return objcd_usuario.Listar();
        
        }
    }
}
