using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Models
{
    public class Cursa
    {
        [Key]
        public int Id { get; set; }
        public int SeccionId { get; set; }
        public int AlumnoId { get; set; }
        public decimal PrimerParcial { get; set; }
        public decimal SegundoParcial { get; set; }
        public decimal Practicas { get; set; }
        public decimal ExamenFinal { get; set; }

        public Seccion Seccion { get; set; }
        public Alumno Alumno { get; set; }
    }
}
