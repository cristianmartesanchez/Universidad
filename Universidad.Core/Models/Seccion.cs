using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Models
{
    public class Seccion
    {
        public int Id { get; set; }
        public int AsignaturaId { get; set; }
        public int Numero { get; set; }
        public int ProfesorId { get; set; }
        public int AulaId { get; set; }
        public int Año { get; set; }
        public int Cuantrimestre { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public TimeSpan TotalHoras { get; set; }

        public Profesor Profesor { get; set; }
        public Asignatura Asignatura { get; set; }
        public Aula Aula { get; set; }
        
    }
}
