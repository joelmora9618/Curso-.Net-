using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax2.Controllers
{
    public class EjemploAjaxController : Controller
    {
        // GET: EjemploAjax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RecuperarPartialView()
        {
            ViewBag.Texto = "1234";
            return PartialView("RecuperarPartialView");
        }

        public JsonResult RecuperarJSON()
        {
            return Json
                (new {
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Edad = 20
                },
                JsonRequestBehavior.AllowGet);
        }
    }
}