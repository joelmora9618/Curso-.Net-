using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class EjemploError
    {
        public void EstoTieneError()
        {
            try
            {
                int numero = int.Parse("mandarina...");

            }
            catch(Exception e)
            {
                Console.WriteLine("esto tiene un error" + e.Message + "\n"+ e.StackTrace);
                throw;
            }
           
        }
      
    }
}
