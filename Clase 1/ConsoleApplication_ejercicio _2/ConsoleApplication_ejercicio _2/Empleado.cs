using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2
{
    public class Empleado: Persona
    {
        private double sueldo;


        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public void Trabajar()
        {
            Console.WriteLine("Soy " + base.Nombre + 
            " y estoy trabajando......");
        }

        public override string RecuperarDatosPersonales()
        {
            return base.RecuperarDatosPersonales() +
                " Sueldo: " + Sueldo;
        }
    }
}
