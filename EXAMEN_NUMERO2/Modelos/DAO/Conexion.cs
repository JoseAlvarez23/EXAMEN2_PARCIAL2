using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EXAMEN_NUMERO2.Modelos.DAO
{
    public class Conexion
    {

        protected SqlConnection ConexionExamen = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);
    }
}
