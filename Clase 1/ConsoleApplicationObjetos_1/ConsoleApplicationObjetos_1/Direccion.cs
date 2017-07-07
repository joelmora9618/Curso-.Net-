using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationObjetos_1
{
    class Direccion : Persona
    {
        private String direccion;
            
        public String MyProperty
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
