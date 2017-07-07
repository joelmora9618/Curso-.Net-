using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2.TipoDeCuenta
{
    class CuentaCorriente:CuentaBancaria
    {
        private double limiteExtra;

        public double LimiteExtra
        {
            get { return limiteExtra; }
            set { limiteExtra = value; }
        }
        /// <summary>
        /// No usar
        /// </summary>
        //public CuentaCorriente()
        //{

        //}

        /// <summary>
        /// Crea una cuenta bancaria con un limite inicial de 100
        /// </summary>
        /// <param name="nuevoNumero">Numero de cuenta</param>
        /// <param name="nuevoSaldo">Saldo inicial</param>
        

        public CuentaCorriente(int nuevoNumero, double nuevoSaldo) : base(nuevoNumero,nuevoSaldo)
        {
            //base.Numero = nuevoNumero;
            //base.Saldo = nuevoSaldo;
            this.limiteExtra = 100;
        } 

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public override void ExtraerEfectivo(float extraccion)
        {
            if (base.Saldo >= extraccion)
            {
                base.Saldo = -extraccion;
                Console.WriteLine("Monto extraido" + extraccion);
            }
            else
            {
                Console.WriteLine("Deposito insuficiente");
            }

        }

        public void DepositarEfectivo(float deposito)
        {
            try
            {
                base.Saldo = +deposito;
                Console.WriteLine("Efectivo depositado en caja: " + deposito);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override string ToString()
        {
            return "Cuenta Corriente"+ base.Numero+
                "Saldo"+ base.Saldo;
        }


    }
}
