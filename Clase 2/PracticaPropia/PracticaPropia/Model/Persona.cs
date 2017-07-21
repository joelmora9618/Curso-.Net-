using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropia.Model
{
    public abstract class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;
        private char sexo;

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

    }
}
