using pJGestionEventos.Etidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pJGestionEventos.Datos
{
    public class D_Visitantes
    {
        public DataTable Lista_Visitantes(string cBuscar) {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_LISTAR_VISITANTES", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cBuscar", SqlDbType.VarChar).Value = cBuscar;
                SqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                return tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;

            }
            finally { 
                if(SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();


                }
            }
        
        }
        public string Guardar_Visitantes(V_Visitante Visitante) {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_GUARDAR_VISITANTES", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = Visitante.nombre_visitante;
                comando.Parameters.Add("@cDireccion", SqlDbType.VarChar).Value = Visitante.direccion_visi;
                comando.Parameters.Add("@dFecha", SqlDbType.Date).Value = Visitante.fecha_nacimiento;
                comando.Parameters.Add("@cTelefono", SqlDbType.VarChar).Value = Visitante.telefono;
                comando.Parameters.Add("@iID_Evento", SqlDbType.Int).Value = Visitante.id_evento;

                SqlCon.Open();

                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no se pudieron registrar";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;

            }
            finally {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            
            
            }
            return respuesta;
        }
        public string Actualizar_Visitantes(V_Visitante Visitante)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_VISITANTES", SqlCon);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@iID_Visitante",SqlDbType.Int).Value=Visitante.ID_visitante;
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = Visitante.nombre_visitante;
                comando.Parameters.Add("@cDireccion", SqlDbType.VarChar).Value = Visitante.direccion_visi;
                comando.Parameters.Add("@dFecha", SqlDbType.Date).Value = Visitante.fecha_nacimiento;
                comando.Parameters.Add("@cTelefono", SqlDbType.VarChar).Value = Visitante.telefono;
                comando.Parameters.Add("@iID_Evento", SqlDbType.Int).Value = Visitante.id_evento;

                SqlCon.Open();

                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no se pudieron registrar";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;

            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();


            }
            return respuesta;
        }
        public string Desativar_Visitantes(int iCodigoVisitante)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_DESATIVAR_VISITANTES", SqlCon);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@iID_Visitante", SqlDbType.Int).Value = iCodigoVisitante;
               

                SqlCon.Open();

                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no se pudieron registrar";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;

            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();


            }
            return respuesta;

        }

    }
}
