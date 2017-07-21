using Sofrecom.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Calculadora calculadora = new Calculadora();
            Console.WriteLine("inicio del programa");
            try
            {
                Console.WriteLine("inicio del try");
                EjemploError ejemploError = new EjemploError();
                ejemploError.EstoTieneError();
                Console.WriteLine("fin del try");
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("error de tipo null");
            }
            catch(FormatException e)
            {
                Console.WriteLine("hay un error de formato");
            }
            catch(Exception e)
            {
                Console.WriteLine("hay un error");
            }
            finally
            {
                Console.WriteLine("finally!!!");
            }

            Console.WriteLine("fin del programa");
            Console.ReadLine();
        }
    }
}
