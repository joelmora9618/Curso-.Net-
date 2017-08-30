using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_ABM.ViewModel
{
    public class ClienteViewModel
    {
        private long id;
        private string nombre;
        private string apellido;
        private int saldoInicial;

        public long Id
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

        [Required(ErrorMessage = "El Nombre es rquerido")]
        [Display(Name = "Primer nombre")]
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

        [Required(ErrorMessage = "El Apellido es rquerido")]
        [Display(Name = "Primer apellido")]
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

        public int SaldoInicial
        {
            get
            {
                return saldoInicial;
            }

            set
            {
                saldoInicial = value;
            }
        }
    }
}