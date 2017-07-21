using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLServer
{
    class ConectionManager
    {
        static string conectionString = "Server=WKS831L;Database=curso.NET;Trusted_Connection=True;";

        public static SqlConnection OpenConection()
        {
            SqlConnection conection = new SqlConnection(conectionString);
            conection.Open();
            return conection;
        }

        public static SqlConnection CloseConection()
        {
            SqlConnection conection = new SqlConnection(conectionString);
            conection.Close();
            return conection;
        }
    }
}
