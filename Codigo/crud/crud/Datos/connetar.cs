using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace crud.Datos
{
     internal static class connetar 

    {
        public static SqlConnection conx = new SqlConnection(@"Data Source=DESKTOP-OSK8CQO\SQLEXPRESS;Initial Catalog=userdb;Integrated Security=True");

        public static void abrir() { 
        if (conx.State==ConnectionState.Closed)
            {
                conx.Open();
            }
            
        
        }
        public static void cerrar()
        {
            if (conx.State == ConnectionState.Open)
            {
                conx.Close();
            }
        }

    }
}
