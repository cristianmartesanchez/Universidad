using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Models
{
    public class AulaAsignatura
    {
        public int Id { get; set; }
        public int AulaId { get; set; }
        public int AsignaturaId { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int Dia { get; set; }

        public Aula Aula { get; set; }
        public Asignatura Asignatura { get; set; }
    }
}
