using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplicationEjemploArchivos
{
    class GestorDeArchivos
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(GestorDeArchivos));

        public void GuardarTextoEnArchivo(string path, string contenido)
        {
            log.Debug("Tratando de guardar el archivo en " + path);
            StreamWriter writer = null;
            if (File.Exists(path))
            {

                try
                {
                    writer = new StreamWriter(path);
                    writer.WriteLine(contenido);
                }
                catch (Exception error)
                {
                    throw new GestorDeArchivosException("Hay un error al guardar el archivo", error);
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }

            }
            else
            {
                throw new GestorDeArchivosException("Todo ok pero no hay archivo en el path: "
                    + path);
 
            } 

        }
    }
}
