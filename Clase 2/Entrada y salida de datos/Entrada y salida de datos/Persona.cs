using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_y_salida_de_datos
{
    class Persona
    {
        private string nombre;
        private string apellido;

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
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }
}
