using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Dtos
{
    public class AsignaturaDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int ProfesorId { get; set; }
        public int TipoId { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }

        public List<ProfesorDto> Profesors { get; set; }

    }
}
