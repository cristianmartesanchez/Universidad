using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Core.Models;
using Universidad.Data;
using Universidad.Data.Repositories;

namespace Universidad.Core.Repositories
{

    public interface IAlumnoRepository : IRepository<Alumno>
    {

    }

    public class AlumnoRepository : Repository<Alumno>, IAlumnoRepository
    {
        private readonly DataContext _context;
        public AlumnoRepository(DataContext context): base(context)
        {
            _context = context;
        }
    }
}
