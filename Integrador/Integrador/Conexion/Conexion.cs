using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;

namespace Integrador.Conexion
{
    public class Conexion
    {
       
            private static string conexion = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
            private static SqlConnection cn;

            protected static SqlConnection abrirConexion()
            {
                cn = new SqlConnection(conexion);
                cn.Open();
                return cn;
            }

            protected static void cerrarConexion()
            {
                cn.Close();
                cn.Dispose();
            }
        
    }
}