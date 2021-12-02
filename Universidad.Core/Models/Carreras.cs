using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Models
{
    public class Carreras
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int TotalCredito { get; set; }
        public int Duracion { get; set; }
        //public int UniversidadId { get; set; }

        //public Universidad Universidad { get; set; }

    }
}
