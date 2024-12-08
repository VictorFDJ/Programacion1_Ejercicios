using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CP_Usuario
    {
        public List<Usuario> Listar() { 
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) {
                try {
                    string query = "select * from usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            lista.Add(new Usuario()
                            {
                                UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                                Nombre = dr["Nombre"].ToString(),
                                Email = dr["Email"].ToString(),
                                Contraseña = dr["Contraseña"].ToString(),
                                TipoUsuario = dr["TipoUsuario"].ToString(),



                            });


                        }
                    }
                }
                catch (Exception ex) { 
                    lista = new List<Usuario>();
                
                }
                return lista;

            }
        
        
        }

    }
}
