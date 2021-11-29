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
        public TimeSpan TotalHoras { get; set; }
        
    }
}
