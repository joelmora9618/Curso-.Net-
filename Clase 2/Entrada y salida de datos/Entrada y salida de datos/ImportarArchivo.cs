using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entrada_y_salida_de_datos
{
    public class ImportarArchivo
    {

        public void Importar(StreamReader sr)
        {         
            try
            {              
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = sr.ReadLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
      
    }
}
