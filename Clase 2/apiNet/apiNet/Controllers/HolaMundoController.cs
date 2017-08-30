using apiNet.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiNet.Controllers
{
    public class HolaMundoController : ApiController
    {
        // GET: api/HolaMundo
        public IEnumerable<Cliente> Get()
        {
            return new Cliente[] {
                new Cliente()
                {
                     Id = 1,
                     Nombre = "Joel",
                     Apellido = "Mora"
                },
                new Cliente()
                {
                    Id = 2,
                    Nombre = "Marcos",
                    Apellido = "Reinoso"
                }
               
            };
        }

        // GET: api/HolaMundo/5
        public Cliente Get(int id)
        {
            return new Cliente()
            {
                Id = 2,
                Nombre = "Marcos",
                Apellido = "Reinoso"
            };
        }

        // POST: api/HolaMundo
        public void Post([FromBody]Cliente value)
        {

        }

        // PUT: api/HolaMundo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HolaMundo/5
        public void Delete(int id)
        {
        }
    }
}
