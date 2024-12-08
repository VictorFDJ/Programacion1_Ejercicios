using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pJGestionEventos.Datos
{
    public class D_Eventos
    {
        public DataTable Lista_Eventos()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_LISTAR_EVENTOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
              
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
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();


                }
            }

        }


    }
}
