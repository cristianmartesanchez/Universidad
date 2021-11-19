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

    public interface IAulaRepository : IRepository<Aula>
    {

    }

    public class AulaRepository : Repository<Aula>, IAulaRepository
    {
        private readonly DataContext _context;
        public AulaRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
