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

    public interface IAsignaturaRepository : IRepository<Asignatura>
    {

    }

    public class AsignaturaRepository : Repository<Asignatura>, IAsignaturaRepository
    {
        private readonly DataContext _context;
        public AsignaturaRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
