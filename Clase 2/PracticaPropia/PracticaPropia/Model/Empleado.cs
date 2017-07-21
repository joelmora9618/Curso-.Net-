using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPropia.Model
{
    public class Empleado:Persona
    {
        private int legajo;
        private string sector;
        private string oficina;
        private int salario;

        public Empleado()
        {

        }

        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Oficina
        {
            get { return oficina; }
            set { oficina = value; }
        }

        public string Sector
        {
            get { return sector; }
            set { sector = value; }
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

    }
}
