using ConsoleApplication_ejercicio__2.TipoDeCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2.General
{
    public class Banco
    {
        public void ExtraerDeCuenta(CuentaBancaria cuenta, float monto)
        {
            cuenta.ExtraerEfectivo(monto);
        }
    }
}
