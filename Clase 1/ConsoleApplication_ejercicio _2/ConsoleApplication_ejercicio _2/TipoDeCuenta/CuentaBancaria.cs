using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2.TipoDeCuenta
{
    public abstract class CuentaBancaria
    {
        private int numero;
        private double saldo;

        public CuentaBancaria(int numero, double saldo)
        {
            this.numero = numero;
            this.saldo = saldo;
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public abstract void ExtraerEfectivo(float extraccion);
        
    }
}
