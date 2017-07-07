using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2
{
    class RRHH
    {
        public void MostrarDatosPersonales(Persona persona)
        {
            Console.WriteLine("Mostrar datos personales");
            Console.WriteLine(persona.GetType().Name);
            Console.WriteLine(persona.RecuperarDatosPersonales());
        }
    }
}
