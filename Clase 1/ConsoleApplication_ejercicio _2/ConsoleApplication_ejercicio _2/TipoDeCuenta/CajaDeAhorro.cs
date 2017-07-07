using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2.TipoDeCuenta
{
    public class CajaDeAhorro:CuentaBancaria
    {
        public static int LIMITE = 10000;

        

        public override void ExtraerEfectivo(float extraccion)
        {
            if (Saldo >= extraccion)
            {
                Saldo = -extraccion;
                Console.WriteLine("Monto extraido" + extraccion);
            }
            else
            {
                Console.WriteLine("Deposito insuficiente");
            }
        }
    

    }
}
