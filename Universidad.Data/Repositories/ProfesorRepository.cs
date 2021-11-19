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

    public interface IProfesorRepository : IRepository<Profesor>
    {

    }

    public class ProfesorRepository : Repository<Profesor>, IProfesorRepository
    {
        private readonly DataContext _context;
        public ProfesorRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
