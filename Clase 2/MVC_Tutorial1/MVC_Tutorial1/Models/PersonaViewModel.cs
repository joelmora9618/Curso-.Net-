using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Tutorial1.Models
{
    public class PersonaViewModel
    {
        private int id;
        private string nombre;
        private int edad;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }
    }
}