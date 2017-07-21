using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArchivos
{
    class GestorDeArchivosException: Exception
    {
        private ILog log;
        
        public GestorDeArchivosException()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = LogManager.GetLogger(this.GetType()); //aquí procedemos a inicializar el objeto log.
        }
    

        public GestorDeArchivosException(string msg) :
          base(msg)
        {

        }

        public GestorDeArchivosException(string msg,Exception innerException):
            base(msg, innerException)
        {
            
        }
    }
}
