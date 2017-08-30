using MVC_ABM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using MVC_ABM.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MVC_ABM.Controllers
{
    public class ClientesController : Controller
    {
        GestorCliente gestor = new GestorCliente();

        // GET: Clientes
        public ActionResult Index()
        {
           
            var clientesViewModel = gestor.Get();

            return View(clientesViewModel);
        }

        public ActionResult BuscadorAutoComplete(string term)
        {
            List<ItemAutocomplete> item = new List<ItemAutocomplete>();
            List<ClienteViewModel> clientesViewModel = gestor.Buscador(term);

            foreach(ClienteViewModel cliente in clientesViewModel)
            {
                item.Add(new ItemAutocomplete
                {
                    Id = cliente.Id,
                    Value = cliente.SaldoInicial.ToString(),
                    Label = cliente.Nombre + " " + cliente.Apellido

                });
            }

            var jsonSerializerSetting = new JsonSerializerSettings
                { ContractResolver = new CamelCasePropertyNamesContractResolver() };

                var json = JsonConvert.SerializeObject(item, Formatting.Indented,
                    jsonSerializerSetting);


                return Content(json, "application/json");
                        
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            ClienteViewModel cliente = gestor.Get(id);
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            ClienteViewModel cliente = new ClienteViewModel();
            return View(cliente);
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                gestor.Post(cliente);
                return RedirectToAction("Index");
            }else
            {
                return View(cliente);
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            ClienteViewModel cliente = gestor.Get(id);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClienteViewModel cliente)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
