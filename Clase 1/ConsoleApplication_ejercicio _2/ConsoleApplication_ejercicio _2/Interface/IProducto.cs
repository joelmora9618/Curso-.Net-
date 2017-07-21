using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2.Interface
{
    public interface IProducto
    {
        string RecuperarNombre();

        double RecuperarPrecio();

        void Vender();

    }
}
