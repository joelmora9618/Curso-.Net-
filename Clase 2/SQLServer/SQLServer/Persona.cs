using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{
    class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;
        private string sexo;

        public string Sexo
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
