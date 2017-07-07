using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {
        private float valorx;
        private float valorY;

        public float ValorY
        {
            get { return valorY; }
            set { valorY = value; }
        }


        public float ValorX
        {
            get { return valorx; }
            set { valorx = value; }
        }

        public float Sumar()
        {
            return ValorX + ValorY;
        }

        public float Restar()
        {
            return ValorX - valorY;
        }

    }
}
