using ConsoleApplication_ejercicio__2.General;
using ConsoleApplication_ejercicio__2.TipoDeCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ejercicio__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string value;
            char continuar = 's';

            Persona p1 = new Persona();
            p1.Nombre = "Joel";
            p1.Apellido = "Mora";
            p1.Edad = 20;
            p1.Saludar();
            string datosPersonales = p1.RecuperarDatosPersonales();
            Console.WriteLine(datosPersonales);
            Console.WriteLine("***********************************");

            Empleado e1 = new Empleado();
            e1.Nombre = "Walter";
            e1.Apellido = "Martinez";
            e1.Sueldo = 40000;
            e1.Edad = 20;
            e1.Saludar();
            e1.Trabajar();
            Console.WriteLine(e1.RecuperarDatosPersonales());

            Banco banco = new Banco();
            Object cc1 = new CuentaCorriente(1234, 1000);
            Console.WriteLine(cc1);
            Console.WriteLine(cc1.ToString());

                /*
            CajaDeAhorro ca1 = new CajaDeAhorro();
            ca1.Saldo = 500;
            ca1.Numero = 123123;

            banco.ExtraerDeCuenta(ca1, 3000);
            banco.ExtraerDeCuenta(ca1, 100);

            banco.ExtraerDeCuenta(cc1, 400);

            
            RRHH rrhh = new RRHH();
            rrhh.MostrarDatosPersonales(p1);
            rrhh.MostrarDatosPersonales(e1);
            
            do
            {



                Console.WriteLine("\n1 CAJA DE AHORRO\n" +
                                  "2 CUENTA CORRIENTE\n" +
                                  "3 SALIR\n\n" +
                                  "A que cuenta desea acceder?");

                value = Console.ReadLine();
                opcion = Convert.ToInt32(value);

                switch (opcion)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:

                        break;
                }

            } while (continuar == 's');
            */
        }
    }
}
