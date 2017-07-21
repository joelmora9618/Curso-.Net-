using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLServer
{
    class Program
    {
        static void Main(string[] args)
        {

            GestorDePersona dbManager = new GestorDePersona();

            string value;
            int opcion = 0;
        
            char continuar = 's';
            Int64 dniAux = 0;

            while (continuar == 's')
            {
                Console.WriteLine("1 ingresar persona");
                Console.WriteLine("2 borrar persona");
                Console.WriteLine("3 modificar persona");
                Console.WriteLine("4 mostrar personas");
                Console.WriteLine("5 Salir");

                Console.WriteLine("\nque opcion desea realizar: ");
                value = Console.ReadLine();
                opcion = Convert.ToInt32(value);

                switch (opcion)
                {
                    case 1:
                        Persona p = new Persona();
                        Console.WriteLine("Ingrese su DNI: ");
                        string dni = Console.ReadLine();
                        p.Dni = Convert.ToInt32(dni);
                        Console.WriteLine("Ingrese su Nombre: ");
                        p.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su Apellido: ");
                        p.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese su Edad");
                        string edad = Console.ReadLine();
                        p.Edad = Convert.ToInt32(edad);
                        Console.WriteLine("Ingrese Sexo");
                        p.Sexo = Console.ReadLine();

                        int count = dbManager.Post(p);

                        Console.WriteLine("\n" + count + " usuario/s ingresado con exito!");
                        break;

                    case 2:

                        break;

                    case 3:
                     
                        break;
                    case 4:
                        //GET
                        List<Persona>listaPersonas = dbManager.Get();
                        Console.WriteLine("\nDNI\t\tNOMBRE\t\tAPELLIDO\tEDAD\tSEXO");
                        foreach(Persona p1 in listaPersonas)
                        {
                            Console.WriteLine(p1.Dni+"\t"+ p1.Nombre+"\t\t"+ p1.Apellido+"\t"+ p1.Edad+"\t"+ p1.Sexo);                     
                        }

                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("\nGracias vuelva prontos!");
                        Console.ReadKey();
                        continuar = 'n';
                        break;
                    default:
                        Console.WriteLine("\nError, opcion invalida!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }

            /*
            Persona p1 = new Persona();
            p1.Dni = 32715645;
            p1.Nombre = "Damian";
            p1.Apellido = "Rafael";
            p1.Edad = 34;
            p1.Sexo = "m";

            int count = dbManager.Post(p1);
            Console.WriteLine("se ah insertado " + count + " usuario/s con exito");
            

            //GET
            Persona p = dbManager.Get(39715645);

          
                Console.WriteLine(p.Dni);
                Console.WriteLine(p.Nombre);
                Console.WriteLine(p.Apellido);
                Console.WriteLine(p.Edad);
                Console.WriteLine(p.Sexo);
            

            Console.ReadLine();

            
            string conectionString = "Server=WKS831L;Database=curso.NET;Trusted_Connection=True;";
            SqlConnection conection = null;
            SqlTransaction trans = null;
            SqlDataReader dr = null;
            DataTable datosPersonales = new DataTable();

            try
            {
                conection = new SqlConnection(conectionString);
                conection.Open();
                trans = conection.BeginTransaction();
                string sql = "INSERT INTO PERSONA (DNI,NOMBRE,APELLIDO,EDAD,SEXO) VALUES(@DNI,@NOMBRE,@APELLIDO,@EDAD,@SEXO)";
                SqlCommand command = new SqlCommand(sql, conection,trans);
                command.Parameters.AddWithValue("@DNI", "38723934");
                command.Parameters.AddWithValue("@NOMBRE", "FERNANDO");
                command.Parameters.AddWithValue("@APELLIDO", "ROMERO");
                command.Parameters.AddWithValue("@EDAD", "30");
                command.Parameters.AddWithValue("@SEXO", "M");

                int rowCount = command.ExecuteNonQuery();


                //SELECT
                string sqlGet = "SELECT * FROM PERSONA WHERE DNI = 39715645;";
                SqlCommand commandConsulta = new SqlCommand(sqlGet, conection,trans);
                dr = commandConsulta.ExecuteReader();

                datosPersonales.Load(dr);
               // dr.Close();
                trans.Commit();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message " + e.Message + "\n" + e.StackTrace);
                if(trans!=null)
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
                if (conection!= null)
                {
                    conection.Close();
                }
            }
          
            
            foreach(DataRow row in datosPersonales.Rows)
            {
              
                    Console.WriteLine(row["DNI"]);

               
                    Console.WriteLine(row["NOMBRE"]);

              
                    Console.WriteLine(row["APELLIDO"]);

               
                    Console.WriteLine(row["EDAD"]);

              //  if (!dr.IsDBNull(dr.GetOrdinal("SEXO")))
                    Console.WriteLine(row["SEXO"]);
            }
            */

        }
    }
}
