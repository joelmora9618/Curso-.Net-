using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace apiNet.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [OutputCache(Duration =20)]
        public ActionResult EjemploCache()
        {
            String respuesta = String.Format("Hora cacheada!!!{0}",
            DateTime.Now);
            return Content(respuesta);
        }
    }
}