using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_y_salida_de_datos
{
    class ExportarArchivo
    {
       
        public void Exportar(StreamWriter sw, List<Persona>personas)
        {
            try
            {
                foreach (Persona p in personas)
                {
                    sw.Write( p.Nombre + " " + p.Apellido+"\n");
                    sw.Flush();
                }
                          
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

        }



   
    }
}
