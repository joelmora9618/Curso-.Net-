using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLServer
{
    class GestorDePersona
    {
        string conectionString = "Server=WKS831L;Database=curso.NET;Trusted_Connection=True;";

        public int Post(Persona p)
        {
            SqlConnection conection = null;
            SqlTransaction trans = null;
            int rowCount = 0;
            try
            {
                conection = ConectionManager.OpenConection();
                trans = conection.BeginTransaction();
                 string sql = "INSERT INTO PERSONA (DNI,NOMBRE,APELLIDO,EDAD,SEXO) VALUES(@DNI,@NOMBRE,@APELLIDO,@EDAD,@SEXO)";
                 SqlCommand command = new SqlCommand(sql, conection,trans);
                 command.Parameters.AddWithValue("@DNI", p.Dni);
                 command.Parameters.AddWithValue("@NOMBRE", p.Nombre);
                 command.Parameters.AddWithValue("@APELLIDO", p.Apellido);
                 command.Parameters.AddWithValue("@EDAD", p.Edad);
                 command.Parameters.AddWithValue("@SEXO", p.Sexo);

                 rowCount = command.ExecuteNonQuery();
                 trans.Commit();
 
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message " + e.Message + "\n" + e.StackTrace);
                if (trans != null)
                {
                    trans.Rollback();
                }
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return rowCount;
        }
        public void Put(int dni,Persona p)
        {

        }

        public Persona Get(int dni)
        {
            SqlConnection conection = null;
          
            SqlDataReader dr = null;
            DataTable datosPersonales = new DataTable();
            Persona persona = new Persona();

            try
            {
                conection = ConectionManager.OpenConection();            
                string sqlGet = "SELECT * FROM PERSONA WHERE DNI = " + dni;
                SqlCommand commandConsulta = new SqlCommand(sqlGet, conection);
                dr = commandConsulta.ExecuteReader();

                datosPersonales.Load(dr);
                // dr.Close();
              
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message " + e.Message + "\n" + e.StackTrace);
             
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (conection != null)
                {
                    conection.Close();
                }
            }

            foreach (DataRow row in datosPersonales.Rows)
            {
                persona.Dni = (int)row["DNI"];
                persona.Nombre = (string)row["NOMBRE"];
                persona.Apellido = (string)row["APELLIDO"];
                persona.Edad = (int)row["EDAD"];
                persona.Sexo = (string)row["SEXO"];
               
            }

            return persona;
        }

        public List<Persona> Get()
        {
            SqlConnection conection = null;
            SqlTransaction trans = null;
            SqlDataReader dr = null;
            DataTable datosPersonales = new DataTable();
            List<Persona> listaPersona = new List<Persona>();

            try
            {
                conection = ConectionManager.OpenConection();
                trans = conection.BeginTransaction();

                string sqlGet = "SELECT * FROM PERSONA";
                SqlCommand commandConsulta = new SqlCommand(sqlGet, conection, trans);
                dr = commandConsulta.ExecuteReader();

                datosPersonales.Load(dr);
                // dr.Close();
                trans.Commit();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message " + e.Message + "\n" + e.StackTrace);
                if (trans != null)
                {
                    trans.Rollback();
                }
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (conection != null)
                {
                    conection.Close();
                }
            }

            foreach (DataRow row in datosPersonales.Rows)
            {
                Persona persona = new Persona();
                persona.Dni = (int)row["DNI"];
                persona.Nombre = (string)row["NOMBRE"];
                persona.Apellido = (string)row["APELLIDO"];
                persona.Edad = (int)row["EDAD"];
                persona.Sexo = (string)row["SEXO"];
                listaPersona.Add(persona);
            }

            return listaPersona;
        }

        public int delete(int dni)
        {
            return 0;
        }
    }
}
