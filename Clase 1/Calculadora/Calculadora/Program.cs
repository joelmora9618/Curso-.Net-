using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Operaciones operacion1 = new Operaciones();
            operacion1.ValorX = 1;
            operacion1.ValorY = 2;

            Console.WriteLine("valorX: {0} valorY: {1}", operacion1.ValorX, operacion1.ValorY);
            Console.WriteLine("Suma: " + operacion1.Sumar());
            Console.WriteLine("\nResta: " + operacion1.Restar());
            Console.ReadLine();
            */

            char continuar = 's';
            string value;
            int opcion = 0;

            do
            {

                Console.WriteLine("1 ingresar valor de X\n");
                Console.WriteLine("2 ingresar valor de Y\n");
                Console.WriteLine("3 Sumar\n");
                Console.WriteLine("4 Restar\n\n");

                Console.WriteLine("Que operacion desea realizar*");
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
                    case 4:
                        break;
                    case 5:
                        break;
                }

            } while (continuar == 's');
           

        }
    }
}
