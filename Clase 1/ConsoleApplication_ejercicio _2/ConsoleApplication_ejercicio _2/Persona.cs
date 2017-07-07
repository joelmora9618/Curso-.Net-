using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2
{
    public class Persona
    {
        private String nombre;
        private String apellido;
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void Saludar()
        {
            Console.WriteLine("Hola a todos......");
        }

        public virtual string RecuperarDatosPersonales()
        {
            string datos = "Nombre: " + Nombre + "\n" +
                "Apellido: " + Apellido + "\n" +
                "Edad: " + Edad;
            return datos;
        }


    }
}
