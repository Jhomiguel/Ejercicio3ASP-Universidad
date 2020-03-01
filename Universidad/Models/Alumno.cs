using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Models
{
    public class Alumno
    {
        public int Boleta { get; set; }
        public string Nombre { get; set; }
        public string CURP { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }
    }
}
