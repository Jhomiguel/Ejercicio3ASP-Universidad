using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Universidad.Models;

namespace Universidad.Controllers
{
    public class UniversidaController : Controller
    {
        private GestorUniversidad gestor;
        public UniversidaController()
        {
            gestor = GestorUniversidad.GetInstance;
        }
        public ActionResult Mostrar()
        {

            return View(gestor.ObtenerUniversidades());
        }

        // GET: Universidads/Create
        public ActionResult Agregar()
        {
            return View();
        }
        // POST: Universidads/Create
        [HttpPost]
        public ActionResult Agregar(Models.Universidad Universidad)
        {
            try
            {
                if (gestor.ExisteID(Universidad.Id_Universidad))
                    return View();
                else
                {
                    gestor.AgregarUniversidad(Universidad);
                    IList<Models.Universidad> Universidads = gestor.ObtenerUniversidades();
                    return RedirectToAction(nameof(Mostrar), Universidads);
                }
            }
            catch
            {
                return View();
            }
        }
        // GET: Universidads/Delete/5
        public ActionResult Delete(int id)
        {
            Models.Universidad Universidad = gestor.ObtenerUniversidad(id);
            return View(Universidad);
        }

        // POST: Universidads/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, string vacio = null)
        {
            try
            {
                gestor.EliminarUniversidad(id);
                return RedirectToAction(nameof(Mostrar));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
           Models.Universidad Universidad = gestor.ObtenerUniversidad(id);
            return View(Universidad);
        }

        // POST: Universidads/Delete/5
        [HttpPost]
        public ActionResult Edit(int id,Models.Universidad Universidad)
        {
            try
            {
                if (gestor.ExisteID(Universidad.Id_Universidad))
                    return View();
                else
                {
                    gestor.EditarUniversidad(id, Universidad);
                    return RedirectToAction(nameof(Mostrar), gestor.ObtenerUniversidades());
                }
            }
            catch
            {
                return View(Universidad);
            }
        }

    }

}