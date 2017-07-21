using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EjemploArchivos
{
    class GestorDeArchivos
    {
        public void GuardarTextoEnArchivo(string path, string contenido)
        {
            StreamWriter writer = null;
            if(File.Exists(path))
            {
                try
                {
                    writer = new StreamWriter(path);
                    writer.WriteLine(contenido);

                }
                catch (Exception e)
                {
                    throw new GestorDeArchivosException("Hay un error al guardar el archivo", e);
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }

            }else
            {
                throw new GestorDeArchivosException("no existe un archivo en la ruta " + path);
            }


        }
    }
}
