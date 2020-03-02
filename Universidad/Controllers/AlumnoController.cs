using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Universidad.Models;

namespace Universidad.Controllers
{
    public class AlumnoController : Controller
    {
        private GestorAlumno gestor;
        public AlumnoController()
        {
            gestor = GestorAlumno.GetInstance;
        }
        public ActionResult Mostrar()
        {

            return View(gestor.ObtenerAlumnos());
        }

        // GET: Alumnos/Create
        public ActionResult Agregar()
        {
            return View();
        }
        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Agregar(Alumno Alumno)
        {
            try
            {
                GestorMaestria maestria = GestorMaestria.GetInstance;
                List <Maestria> master = maestria.ObtenerMaestrias();
                if (!gestor.ExisteID(Alumno.Boleta) && gestor.ExisteMaestria(master.FindIndex(c => c.ID_Maestria== Alumno.Id_Maestria)))
                {
                    gestor.AgregarAlumno(Alumno);
                    IList<Alumno> Alumnos = gestor.ObtenerAlumnos();
                    return RedirectToAction(nameof(Mostrar), Alumnos);
                }
                else return View();
              
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {

            Alumno Alumno = gestor.ObtenerAlumno(id);
            return View(Alumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Edit(int id, Alumno Alumno)
        {
            try
            {
                    gestor.EditarAlumno(id, Alumno);
                    return RedirectToAction(nameof(Mostrar), gestor.ObtenerAlumnos());
               
            }
            catch
            {
                return View(Alumno);
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            Alumno Alumno = gestor.ObtenerAlumno(id);
            return View(Alumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, string vacio = null)
        {
            try
            {
                gestor.EliminarAlumno(id);
                return RedirectToAction(nameof(Mostrar));
            }
            catch
            {
                return View();
            }
        }

    }
}