using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ModelSistemaGestionClienteContainer())
            {/*Alta

                Localidad localidad = new Localidad();
                localidad.Nombre = "Monte Grande";

                context.Localidades.Add(localidad);
                context.SaveChanges();
                */

                //Ejemplo consulta lamda
                List<Persona> persona1 = context.Personas
                    .Where(x => x.Nombre == "Joel")
                    .ToList();

                //Ejemplo consulta Linq
                List<Persona> persona2 = (from x in context.Personas
                                         where x.Nombre == "Joel"
                                         select x).ToList();

                //Ejemplo consulta Sql

                List<Persona> persona3 = context.Personas.
                    SqlQuery("select Personas * from Personas " +
                    " where Persona.Nombre = 'Joel'").ToList();

                //Ejemplo consulta conexion directa a la base de datos
                string nombre = context.Database
                    .SqlQuery<string>("select Nombre from Personas where Id = 1")
                    .FirstOrDefault();

                foreach(Persona p in persona1)
                {
                    Console.WriteLine(p.Nombre+"\n");
                }

                //Localidad localidad = context.Localidades.Where(x => x.Id == 1).FirstOrDefault();

                /*
                Localidad localidad = new Localidad();
                localidad.Nombre = "Lomas de Zamora";
                context.Localidades.Add(localidad);

                Persona persona = new Persona();
                persona.Nombre = "Joel";
                context.Personas.Add(persona);

                Direccion direccion = new Direccion();
                direccion.Calle = "Bilack 123";
                context.Direcciones.Add(direccion);

                Telefono telefono = new Telefono();
                telefono.Numero = "31231";
                context.Telefonos.Add(telefono);

                //Relaciones
                persona.Direccion = direccion;
                persona.Telefonos.Add(telefono);
                persona.Localidades.Add(localidad);
                direccion.Persona = persona;
                telefono.Persona = persona;
                localidad.Personas.Add(persona);

                context.SaveChanges();*/
                /*
                 * Obtener
                Localidad localidad = context.Localidades.Find(1);
                Console.WriteLine(localidad.Nombre);
                context.SaveChanges();*/
            }
            Console.ReadLine();
        }
    }
}
