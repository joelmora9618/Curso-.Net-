using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2.Tarjeta
{
    class TarjetaDeCredito
    {
        private string nombre;
        private double precioVenta;

        public double PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string RecuperarNombre()
        {
            return nombre;
        }

        public double RecuperarPrecio()
        {
            return precioVenta;
        }
        public void Vender()
        {
            Console.WriteLine("Vendiendo la tarjeta de credito.....");
        }

    }
}
