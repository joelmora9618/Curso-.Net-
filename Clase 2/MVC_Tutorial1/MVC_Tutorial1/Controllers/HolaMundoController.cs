using MVC_Tutorial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial1.Controllers
{
    public class HolaMundoController : Controller
    {
        // GET: HolaMundo
        public ActionResult Index()
        {
            ViewBag.Nombre = "Juan";
            return View();
        }

        public ActionResult EjemploParams(string nombre, int edad = 40)
        {
            ViewBag.Nombre = "Ejemplo de parametro: " +
                "\nNombre: " + nombre + " Edad: " + edad;
            return View("Index");
        }

        [HttpPost]
        public ActionResult EjemploParamsForm(string nombre, int edad = 40)
        {
            ViewBag.Nombre = "Ejemplo de parametro: " +
                "\nNombre: " + nombre + " Edad: " + edad;
            return View("Index");
        }

        [HttpPost]
        public ActionResult EjemploParamsCollectionForm(FormCollection formCollection)
        {
            ViewBag.Nombre = "Ejemplo de parametro: " +
                "\nNombre: " + formCollection["nombre"] + " Edad: " + formCollection["edad"];
            return View("Index");
        }

        [HttpGet]
        public ActionResult EjemploParamsViewModel()
        {
            PersonaViewModel persona = new PersonaViewModel();
            return View("FormPersona", persona);
        }

        [HttpPost]
        public ActionResult EjemploParamsViewModel(PersonaViewModel persona)
        {
            ViewBag.Nombre = "Ejemplo de parametro: " +
                "\nNombre: " + persona.Nombre + " Edad: " + persona.Edad;
            return View("FormPersona", persona);
        }

       

    }
}