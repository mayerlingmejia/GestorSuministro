using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestorSuministro.BLL.Referencias;

namespace ProyectoSistema.GestorSuministro.Areas.Referencias.Controllers
{
    public class DepartamentoController : Controller
    {
        //
        // GET: /Referencias/Departamento/

        public ActionResult Index()
        {
            List<CDepartamento> List = new List<CDepartamento>();
            List.Add(new CDepartamento() { IdDepartamento = 1, Descripcion = "Desarrollo TI", Abrev = "Des", Estado=true, Usuario = "admin", Fecha= DateTime.Now });
            List.Add(new CDepartamento() { IdDepartamento = 2, Descripcion = "Control de Calidad", Abrev = "QA",Estado=true, Usuario = "admin", Fecha= DateTime.Now  });
            List.Add(new CDepartamento() { IdDepartamento = 3, Descripcion = "Recursos Humanos", Abrev = "RRHH", Estado = false, Usuario = "admin", Fecha = DateTime.Now });
            return View(List);
        }

        //
        // GET: /Referencias/Departamento/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Referencias/Departamento/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Referencias/Departamento/Create

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
        // GET: /Referencias/Departamento/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Referencias/Departamento/Edit/5

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
        // GET: /Referencias/Departamento/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Referencias/Departamento/Delete/5

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
