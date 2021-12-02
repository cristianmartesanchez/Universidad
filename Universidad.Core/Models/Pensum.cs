using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Models
{
    public class Pensum
    {
        [Key]
        public int Id { get; set; }
        public int CarreraId { get; set; }
        public int UniversidadId { get; set; }
        public string Descripcion { get; set; }
        public int PreCarreraId { get; set; }
        public int TotalCreditos { get; set; }
        public bool Status { get; set; } = false;
        public Carreras Carrera { get; set; }
        public Universidad Universidad { get; set; }
    }
}
