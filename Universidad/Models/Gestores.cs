using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Models
{
    public class GestorAlumno
    {
        private static GestorAlumno instance = new GestorAlumno();

        private List<Alumno> GAlumno = new List<Alumno>()
        {
            new Alumno() {Boleta=1,Nombre="Juan",CURP="asd",FechaNac= DateTime.Parse("12,12,2000")},
            new Alumno() {Boleta=2,Nombre="Juan",CURP="asd",FechaNac= DateTime.Parse("12,12,2000")},
            new Alumno() {Boleta=3,Nombre="Juan",CURP="asd",FechaNac= DateTime.Parse("12,12,2000")},
            new Alumno() {Boleta=4,Nombre="Juan",CURP="asd",FechaNac= DateTime.Parse("12,12,2000")},
        };
        public static GestorAlumno GetInstance => instance;
        private GestorAlumno() { }

        public void AgregarAlumno(Alumno Alumno)
        {
            GAlumno.Add(Alumno);
        }

        public void EliminarAlumno(int Boleta)
        {
            foreach (Alumno Alumno in GAlumno)
            {
                if (Alumno.Boleta == Boleta)
                {
                    GAlumno.Remove(Alumno);
                    break;
                }
            }
        }
        public Alumno ObtenerAlumno(int Boleta)
        {
            foreach (Alumno Alumno in GAlumno)
            {
                if (Alumno.Boleta == Boleta)
                {
                    return Alumno;
                }
            }
            return null;
        }
        public List<Alumno> EditarAlumno(int Id, Alumno Alumno)
        {
            var id = GAlumno.FindIndex(c => c.Boleta == Id);
            GAlumno[id] = Alumno;
            return GAlumno;
        }
        public List<Alumno> ObtenerAlumnos()
        {
            return GAlumno;
        }
        public bool ExisteID(int id)
        {
            foreach(var item in GAlumno)
              if (item.Boleta == id) return true;
          
            return false;
                
            
        }

    }
    public class GestorDocente
    {
        private static GestorDocente instance = new GestorDocente();

        private List<Docente> GDocente = new List<Docente>()
        { new Docente() {Id_Empleado=1, Nombre="Carlos",Telefono="809-233-2123" } };
        public static GestorDocente GetInstance => instance;
        private GestorDocente() { }

        public bool ExisteID(int id)
        {
            foreach (var item in GDocente)
                if (item.Id_Empleado == id) return true;

            return false;


        }
        public void AgregarDocente(Docente docente)
        {
            GDocente.Add(docente);
        }

        public void EliminarDocente(int Id)
        {
            foreach (Docente docente in GDocente)
            {
                if (docente.Id_Empleado == Id)
                {
                    GDocente.Remove(docente);
                    break;
                }
            }
        }
        public Docente ObtenerDocente(int Id)
        {
            foreach (Docente docente in GDocente)
            {
                if (docente.Id_Empleado == Id)
                {
                    return docente;
                }
            }
            return null;
        }
        public List<Docente> EditarDocente(int Id, Docente docente)
        {
            var id = GDocente.FindIndex(c => c.Id_Empleado == Id);
            GDocente[id] = docente;
            return GDocente;
        }
        public List<Docente> ObtenerDocentes()
        {
            return GDocente;
        }
    }
    public class GestorMaestria
    {
        private static GestorMaestria instance = new GestorMaestria();
        private List<Maestria> GMaestria = new List<Maestria>() { new Maestria() {ID_Maestria=1,Duracion="2 horas", Nombre="Matematicas" } };
        public static GestorMaestria GetInstance => instance;
        private GestorMaestria() { }
        public bool ExisteID(int id)
        {
            foreach (var item in GMaestria)
                if (item.ID_Maestria == id) return true;

            return false;


        }
        public void AgregarMaestria(Maestria Maestria)
        {
            GMaestria.Add(Maestria);
        }

        public void EliminarMaestria(int Id)
        {
            foreach (Maestria Maestria in GMaestria)
            {
                if (Maestria.ID_Maestria == Id)
                {
                    GMaestria.Remove(Maestria);
                    break;
                }
            }
        }
        public Maestria ObtenerMaestria(int Id)
        {
            foreach (Maestria Maestria in GMaestria)
            {
                if (Maestria.ID_Maestria == Id)
                {
                    return Maestria;
                }
            }
            return null;
        }
        public List<Maestria> EditarMaestria(int Id, Maestria Maestria)
        {
            var id = GMaestria.FindIndex(c => c.ID_Maestria == Id);
            GMaestria[id] = Maestria;
            return GMaestria;
        }
        public List<Maestria> ObtenerMaestrias()
        {
            return GMaestria;
        }
    }
    public class GestorUniversidad
    {
        private static GestorUniversidad instance = new GestorUniversidad();
        private List<Universidad> GUniversidad = new List<Universidad>() { new Universidad() { Id_Universidad=1,Nombre="UASD"} };
        public static GestorUniversidad GetInstance => instance;
        private GestorUniversidad() { }

        public bool ExisteID(int id)
        {
            foreach (var item in GUniversidad)
                if (item.Id_Universidad== id) return true;

            return false;


        }
        public void AgregarUniversidad(Universidad Universidad)
        {
            GUniversidad.Add(Universidad);
        }

        public void EliminarUniversidad(int Id)
        {
            foreach (Universidad Universidad in GUniversidad)
            {
                if (Universidad.Id_Universidad== Id)
                {
                    GUniversidad.Remove(Universidad);
                    break;
                }
            }
        }
        public Universidad ObtenerUniversidad(int Id)
        {
            foreach (Universidad Universidad in GUniversidad)
            {
                if (Universidad.Id_Universidad == Id)
                {
                    return Universidad;
                }
            }
            return null;
        }
        public List<Universidad> EditarUniversidad(int Id, Universidad Universidad)
        {
            var id = GUniversidad.FindIndex(c => c.Id_Universidad == Id);
            GUniversidad[id] = Universidad;
            return GUniversidad;
        }
        public List<Universidad> ObtenerUniversidades()
        {
            return GUniversidad;
        }

    }
}
    

