using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Universidad.Models;

namespace Universidad.Controllers
{
    public class MaestriaController : Controller
    {
        private GestorMaestria gestor;
        public MaestriaController()
        {
            gestor = GestorMaestria.GetInstance;
        }
        public ActionResult Mostrar()
        {

            return View(gestor.ObtenerMaestrias());
        }

        // GET: Maestrias/Create
        public ActionResult Agregar()
        {
            return View();
        }
        // POST: Maestrias/Create
        [HttpPost]
        public ActionResult Agregar(Maestria Maestria)
        {
            try
            {
                gestor.AgregarMaestria(Maestria);
                IList<Maestria> Maestrias = gestor.ObtenerMaestrias();
                return RedirectToAction(nameof(Mostrar), Maestrias);
            }
            catch
            {
                return View();
            }
        }
        // GET: Maestrias/Delete/5
        public ActionResult Delete(int id)
        {
            Maestria Maestria = gestor.ObtenerMaestria(id);
            return View(Maestria);
        }

        // POST: Maestrias/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, string vacio = null)
        {
            try
            {
                gestor.EliminarMaestria(id);
                return RedirectToAction(nameof(Mostrar));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            Maestria Maestria = gestor.ObtenerMaestria(id);
            return View(Maestria);
        }

        // POST: Maestrias/Delete/5
        [HttpPost]
        public ActionResult Edit(int id, Maestria Maestria)
        {
            try
            {
                gestor.EditarMaestria(id, Maestria);
                return RedirectToAction(nameof(Mostrar), gestor.ObtenerMaestrias());
            }
            catch
            {
                return View(Maestria);
            }
        }

    }

}