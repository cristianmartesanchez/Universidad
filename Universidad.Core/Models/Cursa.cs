using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Models
{
    public class Cursa
    {
        public int Id { get; set; }
        public int AsignaturaId { get; set; }
        public int AlumnoId { get; set; }
        public int Calificacion { get; set; }

        public Asignatura Asignatura { get; set; }
        public Alumno Alumno { get; set; }
    }
}
