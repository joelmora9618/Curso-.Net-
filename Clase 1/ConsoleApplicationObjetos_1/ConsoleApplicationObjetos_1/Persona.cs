using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationObjetos_1
{
    class Persona
    {
        private String nombre;
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void Saludar()
        {
            Console.WriteLine("Hola Mundo" + Nombre);
        }

        public void Saludar2(string textoInicial)
        {
           
        }

        public String GenerarDatosPersonales()
        {
            string texto = "Nombre: " + Nombre + "\n" + "Edad: " + Edad;
            return texto;
        }

    }
}
