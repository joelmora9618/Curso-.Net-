using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiNet.viewModel
{
    public class Cliente
    {
        private int id;
        private String nombre;
        private String apellido;

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

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }
    }
}