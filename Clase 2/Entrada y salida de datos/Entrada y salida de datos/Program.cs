using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entrada_y_salida_de_datos
{
    class Program
    {
        static string path = "C:\\Users\\jmora\\testNet.csv";
        static void Main(string[] args)
        {
            ExportarArchivo exportarArchivo = new ExportarArchivo();
            ImportarArchivo importarArchivo = new ImportarArchivo();
            /*
            List<string> nombres = new List<string>();
            nombres.Add("Pedro");
            nombres.Add("Juan");
            nombres.Add("Alberto");

            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            */
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Jorge", "Rodriguez"));
            personas.Add(new Persona("Nicolas", "Perez"));

            foreach (Persona p in personas)
            {
                Console.WriteLine("Nombre: " + p.Nombre + "\nApellido: " + p.Apellido);
            }

            StreamWriter sw = null;
            StreamReader sr = null;

            try
            {
                sw = new StreamWriter(path);
                exportarArchivo.Exportar(sw, personas);
                Console.WriteLine("\nArchivo escritos en la ruta " + path);

                Console.WriteLine("\nArchivo leido");
                sr = new StreamReader(path);
                importarArchivo.Importar(sr);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
       
           
            Console.ReadLine();

        }
    }
}
