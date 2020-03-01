using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Universidad.Models;

namespace Universidad.Controllers
{
    public class DocenteController : Controller
    {
        private GestorDocente gestor;
        public DocenteController()
        {
            gestor = GestorDocente.GetInstance;
        }
        public ActionResult Mostrar()
        {

            return View(gestor.ObtenerDocentes());
        }

        // GET: Docentes/Create
        public ActionResult Agregar()
        {
            return View();
        }
        // POST: Docentes/Create
        [HttpPost]
        public ActionResult Agregar(Docente docente)
        {
            try
            {
                if (gestor.ExisteID(docente.Id_Empleado))
                    return View();
                else
                {
                    gestor.AgregarDocente(docente);
                    IList<Docente> docentes = gestor.ObtenerDocentes();
                    return RedirectToAction(nameof(Mostrar), docentes);
                }
            }
            catch
            {
                return View();
            }
        }
        // GET: Docentes/Delete/5
        public ActionResult Delete(int id)
        {
            Docente Docente = gestor.ObtenerDocente(id);
            return View(Docente);
        }

        // POST: Docentes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, string vacio = null)
        {
            try
            {

                gestor.EliminarDocente(id);
                return RedirectToAction(nameof(Mostrar));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            Docente Docente = gestor.ObtenerDocente(id);
            return View(Docente);
        }
        // POST: Docentes/Delete/5
        [HttpPost]
        public ActionResult Edit(int id, Docente Docente)
        {
            try
            {
                if (gestor.ExisteID(Docente.Id_Empleado))
                    return View();
                else
                {
                    gestor.EditarDocente(id, Docente);
                    return RedirectToAction(nameof(Mostrar), gestor.ObtenerDocentes());
                }
            }
            catch
            {
                return View(Docente);
            }
        }

    }
}