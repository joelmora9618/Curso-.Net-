using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEjemploArchivos
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            try
            {
                log.Info("Inicio del programa");

                GestorDeArchivos gestorDeArchivos = new GestorDeArchivos();
                gestorDeArchivos.GuardarTextoEnArchivo("X:\\Users\\Claudio\\texto.txt", "Hola");
                Console.WriteLine("Listo...");
            }
            catch (Exception error)
            {
                log.Error("Error general", error);

            }
            
            Console.ReadLine();
        }
    }
}
