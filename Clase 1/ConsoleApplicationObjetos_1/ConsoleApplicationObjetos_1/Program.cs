using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationObjetos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Jorge";
            persona1.Edad = 20;

            Console.WriteLine(persona1.GenerarDatosPersonales());
            Console.ReadLine();
        }
    }
}
