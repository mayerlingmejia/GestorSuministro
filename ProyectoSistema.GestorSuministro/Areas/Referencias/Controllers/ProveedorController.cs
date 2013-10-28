using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestorSuministro.BLL.Referencias;

namespace ProyectoSistema.GestorSuministro.Areas.Referencias.Controllers
{
    public class ProveedorController : Controller
    {
        //
        // GET: /Referencias/Proveedor/

        public ActionResult Index()
        {
            List<CProveedor> lista = new List<CProveedor>();
            lista.Add(new CProveedor()
            {
                IdProveedor = 1,
                Nombre = "Proveedor 1",
                Direccion = "Los Faraones",
                Telefono = "8095905555",
                Celular = "8097884567",
                Email = "proveedor1@hotmail.com",
                Estado = true,
                Garantia = "garantia 1",
                TiempoEntrega = "2 dias",
                Usuario = "admin",
                Fecha = DateTime.Now
            });
            lista.Add(new CProveedor()
            {
                IdProveedor = 2,
                Nombre = "Proveedor 2",
                Direccion = "Los Prados",
                Telefono = "8095905908",
                Celular = "8097904567",
                Email = "proveedor2@hotmail.com",
                Estado = true,
                Garantia = "garantia 2",
                TiempoEntrega = "5 dias",
                Usuario = "admin",
                Fecha = DateTime.Now
            });
            return View(lista);
        }

        //
        // GET: /Referencias/Proveedor/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Referencias/Proveedor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Referencias/Proveedor/Create

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
        
        //
        // GET: /Referencias/Proveedor/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Referencias/Proveedor/Edit/5

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

        //
        // GET: /Referencias/Proveedor/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Referencias/Proveedor/Delete/5

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
