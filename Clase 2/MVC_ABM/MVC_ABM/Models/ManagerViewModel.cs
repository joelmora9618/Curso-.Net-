using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace MVC_ABM.Models
{
    public class ManagerViewModel
    {
        //static string conectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
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