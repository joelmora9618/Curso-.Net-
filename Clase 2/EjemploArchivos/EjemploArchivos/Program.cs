using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                GestorDeArchivos gestor = new GestorDeArchivos();
                gestor.GuardarTextoEnArchivo("c:\\User\\Jmora\\PruebaArchivo.txt", "Hola");
                Console.WriteLine("Listo");

                Console.ReadLine();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine(e.InnerException.Message);
                    Console.WriteLine(e.InnerException.StackTrace);
                }
               
            }
            Console.ReadLine();
        }
    }
}
