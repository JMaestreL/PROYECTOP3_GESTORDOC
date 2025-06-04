using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexion
    {
        public static string ObtenerCadenaConexion()
        {
            return "User Id=DigiGestor;Password=1234;Data Source=localhost:1521/XEPDB1;";
        }
    }
}
