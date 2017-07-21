using ConsoleApplication_ejercicio__2.TipoDeCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication_ejercicio__2.Interface;

namespace ConsoleApplication_ejercicio__2.General
{
    public class Banco
    {
        private List<CuentaBancaria> cuentas = new List<CuentaBancaria>();

        public void AgregarCuentas(CuentaBancaria cuenta)
        {
            cuentas.Add(cuenta);
        }

        public List<CuentaBancaria> RecuperarCuentas()
        {
            return cuentas;
        }

        public void ExtraerDeCuenta(CuentaBancaria cuenta, float monto)
        {
            cuenta.ExtraerEfectivo(monto);
        }



        public void VenderProducto(IProducto producto)
        {
            Console.WriteLine("Producto" + producto.RecuperarNombre());
            Console.WriteLine("Precio" + producto.RecuperarPrecio());
            producto.Vender();
        }
    }
}
