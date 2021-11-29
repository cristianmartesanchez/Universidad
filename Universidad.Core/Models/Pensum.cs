using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Models
{
    public class Pensum
    {
        public int Id { get; set; }
        public int CarreraId { get; set; }
        public int UniversidadId { get; set; }
        public int AsignaturaId { get; set; }
    }
}
