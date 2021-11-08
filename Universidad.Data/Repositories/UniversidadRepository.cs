using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Data;
using Universidad.Data.Repositories;

namespace Universidad.Core.Repositories
{

    public interface IUniversidadRepository : IRepository<Core.Models.Universidad>
    {

    }

    public class UniversidadRepository : Repository<Models.Universidad>, IUniversidadRepository
    {
        private readonly DataContext _context;
        public UniversidadRepository(DataContext context): base(context)
        {
            _context = context;
        }
    }
}
