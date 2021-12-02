using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Models
{
    public class PensumDetalle
    {
        public int Id { get; set; }
        public int PensumId { get; set;}
        public int AsignaturaId { get; set; }
        public int PreRequisitosId { get; set; }
        public int Creditos { get; set; }      
        public Pensum Pensum { get; set; }
        public Asignatura Asignatura { get; set; }

    }
}
