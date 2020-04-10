using ClienteDotNet.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ClienteDotNet.Controllers
{
    public class PedidosController : Controller
    {
        HttpClient client = new HttpClient();
        public PedidosController()
        {
            client.BaseAddress = new Uri("http://189.113.4.250:888/api");
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(
            //    "application/json"));
            var byteArray = Encoding.ASCII.GetBytes("administrator:vtaTPR@2019**");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(byteArray));

        }

        // GET: Pedidos
        public ActionResult Index()
        {
            List<Pedido> pedidosCliente = new List<Pedido>();
            HttpResponseMessage response = client.GetAsync(
                "/millenium!status_pedidov/pedido_venda/listarstatuspv_pf?cpf=954.278.481-34&$format=json").Result;
            if (response.IsSuccessStatusCode)
            {
                pedidosCliente = response.Content.ReadAsAsync<List<Pedido>>().Result;
            }
            return View(pedidosCliente);
        }

        // GET: Pedidos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pedidos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pedidos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedidos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pedidos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Pedidos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pedidos/Delete/5
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
